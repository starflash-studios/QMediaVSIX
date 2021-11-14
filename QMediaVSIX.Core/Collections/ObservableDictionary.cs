#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.ComponentModel;
using System.Runtime.CompilerServices;

#endregion

namespace QMediaVSIX.Core.Collections;

public class ObservableDictionary<TKey, TValue> : List<ObservableKeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue>, IIntGetIndexer<TKey>, ICustomGetIndexer<TKey, ObservableKeyValuePair<TKey, TValue>> where TKey : notnull {

	#region Constructors

	public ObservableDictionary() { }

	public ObservableDictionary( IEnumerable<ObservableKeyValuePair<TKey, TValue>> OKVPairs ) : base(OKVPairs) {
		lock ( this ) {
			foreach ( ObservableKeyValuePair<TKey, TValue> Pair in this ) {
				//Debug.WriteLine("LinkA");
				Link(Pair);
			}
		}
	}

	public ObservableDictionary( params ObservableKeyValuePair<TKey, TValue>[] OKVPairsArr ) : this(OKVPairs: OKVPairsArr) { }

	public ObservableDictionary( IEnumerable<KeyValuePair<TKey, TValue>> KVPairs ) {
		foreach ( KeyValuePair<TKey, TValue> Pair in KVPairs ) {
			//Debug.WriteLine("LinkB");
			Add(MakeLinkedPair(Pair));
		}
	}

	public ObservableDictionary( params KeyValuePair<TKey, TValue>[] KVPairsArr ) : this(KVPairs: KVPairsArr) { }

	public ObservableDictionary( IEnumerable<(TKey K, TValue V)> TuplePairs ) {
		// ReSharper disable once LoopCanBePartlyConvertedToQuery
		foreach ( (TKey, TValue) P in TuplePairs ) {
			ObservableKeyValuePair<TKey, TValue> Pair = new ObservableKeyValuePair<TKey, TValue>(P);
			//Link(Pair);
			Add(Pair);
		}
	}

	public ObservableDictionary( params (TKey K, TValue V)[] TuplePairsArr ) : this(TuplePairs: TuplePairsArr) { }

	public ObservableDictionary( IDictionary<TKey, TValue> Dict ) : this(KVPairs: Dict) { }

	#endregion

	#region Callback Linking

	internal ObservableKeyValuePair<TKey, TValue> MakeLinkedPair( KeyValuePair<TKey, TValue> Pair ) {
		if ( Pair.Key is null ) {
			throw new KeyNullException(nameof(Pair));
		}
		ObservableKeyValuePair<TKey, TValue> Return = new ObservableKeyValuePair<TKey, TValue>(Pair);
		Link(Return);
		return Return;
	}

	internal ObservableKeyValuePair<TKey, TValue> MakeLinkedPair( (TKey Key, TValue Value) Pair ) => MakeLinkedPair(Pair.Key, Pair.Value);

	internal ObservableKeyValuePair<TKey, TValue> MakeLinkedPair( TKey Key, TValue Value ) {
		ObservableKeyValuePair<TKey, TValue> Return = new ObservableKeyValuePair<TKey, TValue>(Key, Value);
		//Debug.WriteLine("LinkD");
		Link(Return);
		return Return;
	}

	internal void Unlink( ObservableKeyValuePair<TKey, TValue> Pair ) {
		Pair.PropertyChanging -= Pair_PropertyChanging;
		Pair.PropertyChanged -= Pair_PropertyChanged;
	}

	internal void Link( ObservableKeyValuePair<TKey, TValue> Pair ) {
		//Debug.WriteLine($"Attempting linkage of {Pair.Key}.");
		//Debug.WriteLine($"Keys at this time: {string.Join(',', Keys)}.");
		if ( !ContainsKey(Pair.Key) ) {
			Pair.PropertyChanging += Pair_PropertyChanging;
			Pair.PropertyChanged += Pair_PropertyChanged;
		}// else {
			//Debug.WriteLine($"Skipping additional link for {Pair.Key}.");
		//}
	}

	internal void Pair_PropertyChanging( object? Sender, PropertyChangingEventArgs E ) {
		if ( Sender is not ObservableKeyValuePair<TKey, TValue> P ) {
			return;
		}
		switch ( E.PropertyName ) {
			case "Value":
				OnValueChanging(P.Key);
				break;
		}
	}

	internal void Pair_PropertyChanged( object? Sender, PropertyChangedEventArgs E ) {
		if ( Sender is not ObservableKeyValuePair<TKey, TValue> P ) {
			return;
		}
		switch ( E.PropertyName ) {
			case "Value":
				OnValueChanged(P.Key);
				break;
		}
	}

	#endregion

	#region Item Adding

	/// <inheritdoc />
	public void Add( KeyValuePair<TKey, TValue> Item ) {
		if ( Item.Key is null ) {
			throw new KeyNullException(nameof(Item.Key));
		}
		Add(Item.Key, Item.Value);
	}

	/// <inheritdoc />
	public void Add( TKey Key, TValue Value ) {
		if ( Key is null ) {
			throw new KeyNullException(nameof(Key));
		}
		if ( ContainsKey(Key) ) {
			throw new KeyCollisionException(Key);
		}
		ObservableKeyValuePair<TKey, TValue> LinkedOKVP = MakeLinkedPair(Key, Value);
		base.Add(LinkedOKVP);
		OnKeyAdded(LinkedOKVP.Key);
	}

	public new void Add( ObservableKeyValuePair<TKey, TValue> OKVP ) {
		//Debug.WriteLine("LinkC");
		if ( ContainsKey(OKVP.Key) ) {
			throw new KeyCollisionException(OKVP.Key);
		}
		Link(OKVP);
		base.Add(OKVP);
		OnKeyAdded(OKVP.Key);
	}

	public new void AddRange( IEnumerable<ObservableKeyValuePair<TKey, TValue>> OKVPairs ) => AddRange(OKVPairs.ToArray());

	public void AddRange( params ObservableKeyValuePair<TKey, TValue>[] OKVPairsArr ) {
		//Debug.WriteLine("LinkE");
		//OKVPairsArr.ForAll(Link);
		bool PreEmpt( ObservableKeyValuePair<TKey, TValue> OKVP ) => ContainsKey(OKVP.Key);
		void Collision( ObservableKeyValuePair<TKey, TValue> OKVP ) => throw new KeyCollisionException(OKVP.Key);
		OKVPairsArr.ForAllUnless(Link, PreEmpt, Collision);
		base.AddRange(OKVPairsArr);
	}

	public void AddRange( IEnumerable<KeyValuePair<TKey, TValue>> OKVPairs ) => AddRange(OKVPairs.ToArray());

	public void AddRange( params KeyValuePair<TKey, TValue>[] OKVPairsArr ) {
		bool PreEmpt( KeyValuePair<TKey, TValue> KVP ) => ContainsKey(KVP.Key);
		if ( OKVPairsArr.Any(PreEmpt, out KeyValuePair<TKey, TValue> Collision ) ) {
			throw new KeyCollisionException(Collision.Key);
		}
		base.AddRange(OKVPairsArr.Select(MakeLinkedPair));
	}

	public void AddRange( IEnumerable<(TKey Key, TValue Value)> TuplePairs ) => AddRange(TuplePairs.ToArray());

	public void AddRange( params (TKey Key, TValue Value)[] TuplePairsArr ) {
		bool PreEmpt( (TKey Key, TValue _) Tuple ) => ContainsKey(Tuple.Key);
		if ( TuplePairsArr.Any(PreEmpt, out (TKey Key, TValue _) Collision) ) {
			throw new KeyCollisionException(Collision.Key);
		}
		base.AddRange(TuplePairsArr.Select(MakeLinkedPair));
	}

	#endregion

	#region Item Checking / Retrieval

	/// <inheritdoc />
	public bool Contains( KeyValuePair<TKey, TValue> Item ) => Contains(Item.Key, Item.Value);

	public bool Contains( TKey Key, TValue Value ) {
		foreach ( (TKey K, TValue V) in this ) {
			if ( Key.Equals(K) && Value.SafeEquals(V) ) {
				return true;
			}
		}
		return false;
	}

	/// <inheritdoc />
	public bool ContainsKey( TKey Key ) {
		foreach ( (TKey K, _) in this ) {
			if ( Key.Equals(K) ) {
				return true;
			}
		}
		return false;
	}

	/// <summary>
	/// Determines whether the <see cref="IDictionary{TKey, TValue}"/> contains an element with the specified value.
	/// </summary>
	/// <param name="Value">The value to check for.</param>
	/// <returns><see langword="true"/> if the <see cref="IDictionary{TKey, TValue}"/> contains an element with the specified value; otherwise, <see langword="false"/>.</returns>
	public bool ContainsValue( TValue Value ) {
		foreach ( (_, TValue V) in this ) {
			if ( Value.SafeEquals(V) ) {
				return true;
			}
		}
		return false;
	}

	/// <inheritdoc />
	public bool TryGetValue( TKey Key, out TValue Value ) {
		foreach ( (TKey K, TValue V) in this ) {
			if ( Key.Equals(K) ) {
				Value = V;
				return true;
			}
		}
		Value = default!;
		return false;
	}

	public ObservableKeyValuePair<TKey, TValue> GetPair( TKey Key ) {
		foreach ( ObservableKeyValuePair<TKey, TValue> Pair in this ) {
			if ( Key.Equals(Pair.Key) ) {
				return Pair;
			}
		}
		throw new KeyNotFoundException(Key);
	}

	public int IndexOf( TKey Key ) {
		int I = 0;
		foreach ( (TKey K, _) in this ) {
			if ( Key.Equals(K) ) {
				return I;
			}
			I++;
		}
		return - 1;
	}

	public bool TryGetIndexOf( TValue Value, out int Index ) {
		foreach( (_, TValue V) in this ) {
			Index = 0;
			if ( V is { } Val && Val.Equals(Value) ) {
				return true;
			}
			Index++;
		}
		Index = - 1;
		return false;
	}

	#endregion

	#region Item Manipulation

	public void Set( TKey Key, TValue Value ) {
		ObservableKeyValuePair<TKey, TValue> Pair = GetPair(Key);
		Pair.Value = Value;
	}

	#endregion

	#region Item Removing

	/// <inheritdoc />
	public bool Remove( KeyValuePair<TKey, TValue> Item ) {
		lock ( this ) {
			if ( this.TryFind(out ObservableKeyValuePair<TKey, TValue> OKVP, out int Index, O => O.Equals(Item)) ) {
				OnKeyRemoved(OKVP.Key, OKVP.Value);
				RemoveAt(Index);
				return true;
			}
			//int I, C = Count;
			//bool Found = false;
			//for ( I = 0; I < C; I++ ) {
			//	//ObservableKeyValuePair<TKey, TValue> OKVP
			//	if ( this[I].Equals(Item) ) {
			//		Found = true;
			//		break;
			//	}
			//}
			//if ( Found ) {
			//	RemoveAt(I);
			//	return true;
			//}
		}
		return false;
	}

	/// <inheritdoc />
	public bool Remove( TKey Key ) {
		lock ( this ) {
			if ( this.TryFind(out ObservableKeyValuePair<TKey, TValue> OKVP, out int Index, O => O.Key.SafeEquals(Key)) ) {
				OnKeyRemoved(OKVP.Key, OKVP.Value);
				RemoveAt(Index);
				return true;
			}
			//int I, C = Count;
			//bool Found = false;
			//for ( I = 0; I < C; I++ ) {
			//	if ( this[I].Key!.Equals(Key) ) {
			//		Found = true;
			//		break;
			//	}
			//}
			//if ( Found ) {
			//	RemoveAt(I);
			//	return true;
			//}
		}
		return false;
	}

	#endregion

	#region Events

	public delegate void ValueChangingEventArgs( ObservableDictionary<TKey, TValue> Sender, TKey Key );

	public event ValueChangingEventArgs ValueChanging = delegate { };
	public void OnValueChanging( TKey Key ) => ValueChanging(this, Key);

	public delegate void ValueChangedEventArgs( ObservableDictionary<TKey, TValue> Sender, TKey Key );

	public event ValueChangedEventArgs ValueChanged = delegate { };
	public void OnValueChanged( TKey Key ) => ValueChanged(this, Key);

	public delegate void KeyAddedEventArgs( ObservableDictionary<TKey, TValue> Sender, TKey Key );

	public event KeyAddedEventArgs KeyAdded = delegate { };
	public void OnKeyAdded( TKey Key ) => KeyAdded(this, Key);

	public delegate void KeyRemovedEventArgs( ObservableDictionary<TKey, TValue> Sender, TKey Key, TValue Value );

	public event KeyRemovedEventArgs KeyRemoved = delegate { };
	public void OnKeyRemoved( TKey Key, TValue Value ) => KeyRemoved(this, Key, Value);

	#endregion

	#region Enumeration

	/// <inheritdoc />
	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() {
		foreach ( (TKey Key, TValue Value) in this ) {
			yield return new KeyValuePair<TKey, TValue>(Key, Value);
		}
	}

	#endregion

	#region Helpers

	internal static IEnumerable<KeyValuePair<TKey, TValue>> GetPairs( IDictionary<TKey, TValue> Dict ) => Dict;

	//internal static IEnumerable<TB> Select<TA, TB>(IEnumerable<TA> Enumerable, Func<TA, TB> Function) => Enumerable.Select(Function);

	internal static IEnumerable<TB> Select<TK, TV, TB>( List<ObservableKeyValuePair<TK, TV>> Enumerable, Func<ObservableKeyValuePair<TK, TV>, TB> Function ) where TK : notnull => Enumerable.Select(Function);

	#endregion

	#region Indexers

	/// <inheritdoc />
	public TValue this[ TKey Key ] {
		get => TryGetValue(Key, out TValue Value) ? Value : throw new KeyNotFoundException(Key);
		set => Set(Key, value);
	}

	/// <inheritdoc />
	int IIntGetIndexer<TKey>.this[ TKey Key ] {
		get {
			if ( Key is null ) {
				throw new KeyNullException(nameof(Key));
			}
			return IndexOf(Key);
		}
	}

	/// <inheritdoc />
	ObservableKeyValuePair<TKey, TValue> ICustomGetIndexer<TKey, ObservableKeyValuePair<TKey, TValue>>.this[ TKey Input ] {
		get {
			if ( Input is null ) {
				throw new KeyNullException(nameof(Input));
			}
			return GetPair(Input);
		}
	}

	#endregion

	#region Exceptions

	public class KeyNullException : Collections.KeyNullException {
		public KeyNullException( [CallerMemberName] string ParamName = null! ) : base(ParamName ?? throw new ArgumentNullException(nameof(ParamName), "Parameter name may not be null.")) { }
	}

	public class KeyCollisionException : Collections.KeyCollisionException {
		public KeyCollisionException( TKey Key ) : base(Key) { }
		public KeyCollisionException( ObservableKeyValuePair<TKey, TValue> OKVP ) : this(OKVP.Key) { }
	}

	public class KeyNotFoundException : Collections.KeyNotFoundException {
		public KeyNotFoundException( TKey Key ) : base(Key) { }
	}

	#endregion

	#region IDictionary Implementation

	/// <inheritdoc />
	public void CopyTo( KeyValuePair<TKey, TValue>[] Array, int ArrayIndex ) {
		IEnumerable<KeyValuePair<TKey, TValue>> Enum = this;
		Enum.CopyTo(Array, ArrayIndex);
	}

	/// <inheritdoc />
	public bool IsReadOnly => false;

	/// <summary>
	/// Gets an <see cref="IEnumerable{T}"/> containing the keys of the <see cref="ObservableDictionary{TKey, TValue}"/>.
	/// </summary>
	public IEnumerable<TKey> Keys => Select(this, P => P.Key);

	/// <inheritdoc />
	ICollection<TKey> IDictionary<TKey, TValue>.Keys => Select(this, P => P.Key).AsCollection();

	/// <summary>
	/// Gets an <see cref="IEnumerable{T}"/> containing the values of the <see cref="ObservableDictionary{TKey, TValue}"/>.
	/// </summary>
	public IEnumerable<TValue> Values => Select(this, P => P.Value);

	/// <inheritdoc />
	ICollection<TValue> IDictionary<TKey, TValue>.Values => Select(this, P => P.Value).AsCollection();

	#endregion

	#region Unsupported Methods

	public new void Sort() => throw new NotSupportedException("The ObservableDictionary type does not support the sorting of key values.".WithCallStack());

	#endregion
}