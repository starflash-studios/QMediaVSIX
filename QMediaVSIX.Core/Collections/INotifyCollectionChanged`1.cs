namespace QMediaVSIX.Core.Collections;

public interface INotifyCollectionChanged<T> : INotifyCollectionChanged {
	#pragma warning disable CS0109 //Member does not hide an inherited member; new keyword is not required
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
	#pragma warning restore CS0109
}