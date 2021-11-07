using System.Diagnostics.CodeAnalysis;

namespace QMediaVSIX.Core.Collections;

public interface IIntGetIndexer<in T> {
	int this[[DisallowNull] T Key] { get; }
}