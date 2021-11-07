using System.Diagnostics.CodeAnalysis;

namespace QMediaVSIX.Core.Collections;

public interface IIntGetSetIndexer<in T> : IIntGetIndexer<T>, IIntSetIndexer<T> {
	new int this[[DisallowNull] T Key] { get; set; }
}