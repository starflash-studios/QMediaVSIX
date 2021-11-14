#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QMediaVSIX.Core.Collections;

public class NullSafeObservableDictionary<TKey, TValue> : ObservableDictionary<TKey, TValue?> where TKey : notnull {

	#region Constructors

	public NullSafeObservableDictionary() { }

	public NullSafeObservableDictionary( IEnumerable<ObservableKeyValuePair<TKey, TValue?>> OKVPairs ) : base(OKVPairs) { }

	public NullSafeObservableDictionary( params ObservableKeyValuePair<TKey, TValue?>[] OKVPairsArr ) : this(OKVPairs: OKVPairsArr) { }

	public NullSafeObservableDictionary( IEnumerable<KeyValuePair<TKey, TValue?>> KVPairs ) : base(KVPairs) { }

	public NullSafeObservableDictionary( params KeyValuePair<TKey, TValue?>[] KVPairsArr ) : this(KVPairs: KVPairsArr) { }

	public NullSafeObservableDictionary( IEnumerable<(TKey K, TValue? V)> TuplePairs ) : base(TuplePairs) { }

	public NullSafeObservableDictionary( params (TKey K, TValue? V)[] TuplePairsArr ) : this(TuplePairs: TuplePairsArr) { }

	public NullSafeObservableDictionary( IDictionary<TKey, TValue?> Dict ) : this(KVPairs: Dict) { }

	#endregion

	#region Events

	public new delegate void ValueChangingEventArgs( ObservableDictionary<TKey, TValue?> Sender, TKey Key );
	public new event ValueChangingEventArgs ValueChanging = delegate { };
	public new void OnValueChanging( TKey Key ) => ValueChanging(this, Key);

	public new delegate void ValueChangedEventArgs( ObservableDictionary<TKey, TValue?> Sender, TKey Key );
	public new event ValueChangedEventArgs ValueChanged = delegate { };
	public new void OnValueChanged( TKey Key ) => ValueChanged(this, Key);

	public new delegate void KeyAddedEventArgs( ObservableDictionary<TKey, TValue?> Sender, TKey Key );
	public new event KeyAddedEventArgs KeyAdded = delegate { };
	public new void OnKeyAdded( TKey Key ) => KeyAdded(this, Key);

	public new delegate void KeyRemovedEventArgs( ObservableDictionary<TKey, TValue?> Sender, TKey Key, TValue? Value );
	public new event KeyRemovedEventArgs KeyRemoved = delegate { };
	public new void OnKeyRemoved( TKey Key, TValue? Value ) => KeyRemoved(this, Key, Value);

	#endregion

}