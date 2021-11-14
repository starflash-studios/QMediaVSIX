#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QMediaVSIX.Core.Collections;

public interface INotifyCollectionChanged<T> : INotifyCollectionChanged {
	public new delegate void CollectionItemAddedEventArgs( object Sender, T? Item );
	public new event CollectionItemAddedEventArgs CollectionItemAdded;

	public new delegate void CollectionItemInsertedEventArgs( object Sender, T? Item, int Index );
	public new event CollectionItemInsertedEventArgs CollectionItemInserted;

	public new delegate void CollectionItemMovedEventArgs( object Sender, T? Item, int OldIndex, int NewIndex );
	public new event CollectionItemMovedEventArgs CollectionItemMoved;

	public new delegate void CollectionItemRemovedEventArgs( object Sender, T? Item );
	public new event CollectionItemRemovedEventArgs CollectionItemRemoved;

	public new delegate void CollectionItemChangedEventArgs( object Sender, T? Item );
	public new event CollectionItemChangedEventArgs CollectionItemChanged;
}