namespace QMediaVSIX.Core.Collections;

public interface ICustomGetSetIndexer<in TIn, TOut> : ICustomGetIndexer<TIn, TOut>, ICustomSetIndexer<TIn, TOut> {
	new TOut this[TIn Input] { get; set; }
}