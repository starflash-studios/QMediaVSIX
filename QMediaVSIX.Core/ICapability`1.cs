//using WindowsEx;

namespace QMediaVSIX.Core; 

public interface ICapability<out T> {
	bool Available { get; }

	T Activate();
}