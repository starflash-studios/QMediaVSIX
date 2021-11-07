//using WindowsEx;

namespace QMediaVSIX.Core; 

public class Capability<T> : ICapability<T> {

	public static readonly Capability<T> None = new Capability<T>(false, () => throw new NotImplementedException());

	public Capability( bool Available, Func<T> Activate ) {
		this.Available = Available;
		_Act = Activate;
	}

	/// <inheritdoc />
	public bool Available { get; }

	readonly Func<T> _Act;

	/// <inheritdoc />
	public T Activate() => _Act();
}