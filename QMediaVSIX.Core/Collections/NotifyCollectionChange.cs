namespace QMediaVSIX.Core.Collections;

public abstract class NotifyCollectionChange : NotifyPropertyChange, INotifyCollectionChange {

    /// <inheritdoc />
    public event INotifyCollectionChanging.CollectionItemChangingEventArgs? CollectionItemChanging = delegate { };

    public void OnCollectionItemChanging( object Item ) => CollectionItemChanging?.Invoke(this , Item);

    /// <inheritdoc />
    public event INotifyCollectionChanged.CollectionItemAddedEventArgs? CollectionItemAdded = delegate { };

    public void OnCollectionItemAdded( object Item ) => CollectionItemAdded?.Invoke(this, Item);

    /// <inheritdoc />
    public event INotifyCollectionChanged.CollectionItemInsertedEventArgs? CollectionItemInserted = delegate { };

    public void OnCollectionItemInserted( object Item, int Index ) => CollectionItemInserted?.Invoke(this, Item, Index);

    /// <inheritdoc />
    public event INotifyCollectionChanged.CollectionItemMovedEventArgs? CollectionItemMoved = delegate { };

    public void OnCollectionItemMoved( object Item, int OldIndex, int NewIndex ) => CollectionItemMoved?.Invoke(this, Item, OldIndex, NewIndex);

    /// <inheritdoc />
    public event INotifyCollectionChanged.CollectionItemRemovedEventArgs? CollectionItemRemoved = delegate { };

    public void OnCollectionItemRemoved( object Item ) => CollectionItemRemoved?.Invoke(this, Item);

    /// <inheritdoc />
    public event INotifyCollectionChanged.CollectionClearedEventArgs? CollectionCleared = delegate { };

    public void OnCollectionItemCleared() => CollectionCleared?.Invoke(this);

    /// <inheritdoc />
    public event INotifyCollectionChanged.CollectionItemChangedEventArgs? CollectionItemChanged = delegate { };

    public void OnCollectionItemChanged( object Item ) => CollectionItemChanged?.Invoke(this, Item);
}