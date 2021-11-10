namespace QMediaVSIX.Core.Collections;

public interface IIntGetIndexer<in T> where T : notnull {
	int this[T Key] { get; }
}