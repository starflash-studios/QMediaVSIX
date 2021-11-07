namespace QMediaVSIX.Core.Collections;

public interface ICustomGetIndexer<in TIn, out TOut> {
	TOut this[ TIn Input] { get; }
}