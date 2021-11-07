namespace QMediaVSIX.Core;

public interface ICapability {
	bool Available { get; }

	void Activate();
}