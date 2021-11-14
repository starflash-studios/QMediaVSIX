#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

namespace QMediaVSIX.Core.Collections;

public abstract class NotifyCollectionChange<T> : NotifyCollectionChange, INotifyCollectionChange<T> {
    /// <inheritdoc />
    public new event INotifyCollectionChanging<T>.CollectionItemChangingEventArgs? CollectionItemChanging;

    public void OnCollectionItemChanging( T Item ) => CollectionItemChanging?.Invoke(this, Item);

    /// <inheritdoc />
    public new event INotifyCollectionChanged<T>.CollectionItemAddedEventArgs? CollectionItemAdded;

    public void OnCollectionItemAdded( T Item ) => CollectionItemAdded?.Invoke(this, Item);

    /// <inheritdoc />
    public new event INotifyCollectionChanged<T>.CollectionItemInsertedEventArgs? CollectionItemInserted;

    public void OnCollectionItemInserted( T Item, int Index ) => CollectionItemInserted?.Invoke(this, Item, Index);

    /// <inheritdoc />
    public new event INotifyCollectionChanged<T>.CollectionItemMovedEventArgs? CollectionItemMoved;

    public void OnCollectionItemMoved( T Item, int OldIndex, int NewIndex ) => CollectionItemMoved?.Invoke(this, Item, OldIndex, NewIndex);

    /// <inheritdoc />
    public new event INotifyCollectionChanged<T>.CollectionItemRemovedEventArgs? CollectionItemRemoved;

    public void OnCollectionItemRemoved( T Item ) => CollectionItemRemoved?.Invoke(this, Item);

    /// <inheritdoc />
    public new event INotifyCollectionChanged<T>.CollectionItemChangedEventArgs? CollectionItemChanged;

    public void OnCollectionItemChanged( T Item ) => CollectionItemChanged?.Invoke(this, Item);
}