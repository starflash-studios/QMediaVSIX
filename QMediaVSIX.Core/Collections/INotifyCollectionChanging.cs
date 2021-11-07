namespace QMediaVSIX.Core.Collections;

public interface INotifyCollectionChanging {
	public delegate void CollectionItemChangingEventArgs( object Sender, object? Item );
	public event CollectionItemChangingEventArgs CollectionItemChanging;
}