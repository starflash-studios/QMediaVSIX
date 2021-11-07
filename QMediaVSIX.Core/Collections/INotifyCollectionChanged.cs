namespace QMediaVSIX.Core.Collections;

public interface INotifyCollectionChanged {
	public delegate void CollectionItemAddedEventArgs( object Sender, object? Item );
	public event CollectionItemAddedEventArgs CollectionItemAdded;

	public delegate void CollectionItemInsertedEventArgs( object Sender, object? Item, int Index );
	public event CollectionItemInsertedEventArgs CollectionItemInserted;

	public delegate void CollectionItemMovedEventArgs( object Sender, object? Item, int OldIndex, int NewIndex );
	public event CollectionItemMovedEventArgs CollectionItemMoved;

	public delegate void CollectionItemRemovedEventArgs( object Sender, object? Item );
	public event CollectionItemRemovedEventArgs CollectionItemRemoved;

	public delegate void CollectionClearedEventArgs( object Sender );
	public event CollectionClearedEventArgs CollectionCleared;

	public delegate void CollectionItemChangedEventArgs( object Sender, object? Item );
	public event CollectionItemChangedEventArgs CollectionItemChanged;
}