using System.Diagnostics.CodeAnalysis;

namespace QMediaVSIX.Core.Collections;

public interface IIntSetIndexer<in T> where T : notnull {
	int this[T Key] { set; }
}