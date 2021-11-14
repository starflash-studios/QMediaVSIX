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

public class ObservableKeyValuePair<TKey, TValue> : INotifyPropertyChange, IEquatable<ObservableKeyValuePair<TKey, TValue>>, IEquatable<KeyValuePair<TKey, TValue>>, IEquatable<(TKey Key, TValue Value)> where TKey : notnull {
	public TKey Key { get; }

	TValue _Value;
	public TValue Value {
		get => _Value;
		set => this.SetValue(ref _Value, value);
	}

	public ObservableKeyValuePair(TKey Key, TValue Value = default!) {
		this.Key = Key;
		_Value = Value;
	}

	public void Deconstruct(out TKey Key, out TValue Value ) {
		Key = this.Key;
		Value = this.Value;
	}

	// ReSharper disable twice UseDeconstructionOnParameter
	public ObservableKeyValuePair(KeyValuePair<TKey, TValue> Pair) : this(Pair.Key, Pair.Value) { }
	public ObservableKeyValuePair( (TKey Key, TValue Value) Pair ) : this(Pair.Key, Pair.Value) { }

	public override string ToString() => $"[{Key}, {Value}]";

	#region Cast Operators

	public static explicit operator ObservableKeyValuePair<TKey, TValue>( KeyValuePair<TKey, TValue> Pair ) => new ObservableKeyValuePair<TKey, TValue>(Pair);

	public static explicit operator ObservableKeyValuePair<TKey, TValue>( (TKey Key, TValue Value) Pair ) => new ObservableKeyValuePair<TKey, TValue>(Pair);

	public static explicit operator KeyValuePair<TKey, TValue>( ObservableKeyValuePair<TKey, TValue> ObvPair ) => new KeyValuePair<TKey, TValue>(ObvPair.Key, ObvPair.Value);

	public static explicit operator (TKey Key, TValue Value)( ObservableKeyValuePair<TKey, TValue> ObvPair ) => (ObvPair.Key, ObvPair.Value);

	#endregion

	#region INotifyPropertyChange Implementation

	/// <inheritdoc />
	public event PropertyChangedEventHandler? PropertyChanged = delegate { };

	public void OnPropertyChanged( object? Sender, [CallerMemberName] string? PropertyName = null ) => PropertyChanged?.Invoke(Sender, new PropertyChangedEventArgs(PropertyName));

	/// <inheritdoc />
	public event PropertyChangingEventHandler? PropertyChanging = delegate { };

	public void OnPropertyChanging( object? Sender, [CallerMemberName] string? PropertyName = null ) => PropertyChanging?.Invoke(Sender, new PropertyChangingEventArgs(PropertyName));

	#endregion

	#region IEquatable Implementation

	/// <inheritdoc />
	public bool Equals( ObservableKeyValuePair<TKey, TValue>? OtherOKVP ) =>
		OtherOKVP switch {
			null => false,
			_    => ReferenceEquals(this, OtherOKVP) || Equals(OtherOKVP.Key, OtherOKVP.Value)
		};

	/// <inheritdoc />
	public bool Equals( KeyValuePair<TKey, TValue> OtherKVP ) => Equals(OtherKVP.Key, OtherKVP.Value);

	/// <inheritdoc />
	public bool Equals( (TKey Key, TValue Value) OtherT ) => Equals(OtherT.Key, OtherT.Value);

	public bool Equals( TKey Key, TValue Value ) => EqualityComparer<TKey>.Default.Equals(this.Key, Key) && EqualityComparer<TValue>.Default.Equals(_Value, Value);

	/// <inheritdoc />
	public override bool Equals( object? Obj ) =>
		Obj switch {
			null                                      => false,
			ObservableKeyValuePair<TKey, TValue> OKVP => Equals(OKVP),
			KeyValuePair<TKey, TValue> KVP            => Equals(KVP),
			_ => ReferenceEquals(this, Obj)
			     || Obj is (TKey K, TValue V) && Equals(K, V)
		};

	/// <inheritdoc />
	public override int GetHashCode() => HashCode.Combine(_Value, Key);

	#region ==, != operators

	public static bool operator ==( ObservableKeyValuePair<TKey, TValue>? Left, ObservableKeyValuePair<TKey, TValue>? Right ) => Equals(Left, Right);

	public static bool operator !=( ObservableKeyValuePair<TKey, TValue>? Left, ObservableKeyValuePair<TKey, TValue>? Right ) => !Equals(Left, Right);

	public static bool operator ==( ObservableKeyValuePair<TKey, TValue>? Left, KeyValuePair<TKey, TValue>? Right ) => Left is null ? Right is null : Right is { } R && Left.Equals(R);

	public static bool operator !=( ObservableKeyValuePair<TKey, TValue>? Left, KeyValuePair<TKey, TValue>? Right ) => !(Left == Right);

	public static bool operator ==( KeyValuePair<TKey, TValue>? Left, ObservableKeyValuePair<TKey, TValue>? Right ) => Right is null ? Left is null : Left is { } L && Right.Equals(L);

	public static bool operator !=( KeyValuePair<TKey, TValue>? Left, ObservableKeyValuePair<TKey, TValue>? Right ) => !(Right == Left);

	public static bool operator ==( ObservableKeyValuePair<TKey, TValue>? Left, (TKey, TValue)? Right ) => Left is null ? Right is null : Right is { } R && Left.Equals(R);

	public static bool operator !=( ObservableKeyValuePair<TKey, TValue>? Left, (TKey, TValue)? Right ) => !(Left == Right);

	public static bool operator ==( (TKey, TValue)? Left, ObservableKeyValuePair<TKey, TValue>? Right ) => Right is null ? Left is null : Left is { } L && Right.Equals(L);

	public static bool operator !=( (TKey, TValue)? Left, ObservableKeyValuePair<TKey, TValue>? Right ) => !(Right == Left);

	#endregion

	#endregion
}