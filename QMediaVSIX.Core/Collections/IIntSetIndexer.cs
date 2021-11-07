using System.Diagnostics.CodeAnalysis;

namespace QMediaVSIX.Core.Collections;

public interface IIntSetIndexer<in T> {
	int this[[DisallowNull] T Key] { set; }
}