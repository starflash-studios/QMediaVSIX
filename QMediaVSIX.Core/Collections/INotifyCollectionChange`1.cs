namespace QMediaVSIX.Core.Collections;

public interface INotifyCollectionChange<T> : INotifyCollectionChange, INotifyCollectionChanging<T>, INotifyCollectionChanged<T> { }