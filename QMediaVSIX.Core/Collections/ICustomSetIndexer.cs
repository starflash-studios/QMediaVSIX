namespace QMediaVSIX.Core.Collections;

public interface ICustomSetIndexer<in TIn, in TOut> {
	TOut this[TIn Input] { set; }
}