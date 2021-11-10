using System.Diagnostics.CodeAnalysis;

namespace QMediaVSIX.Core.Collections;

public interface IIntGetSetIndexer<in T> : IIntGetIndexer<T>, IIntSetIndexer<T> where T : notnull {
	new int this[T Key] { get; set; }
}