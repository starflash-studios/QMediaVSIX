namespace QMediaVSIX.Core;

public class Capability : ICapability {

	public static readonly Capability None = new Capability(false, () => throw new NotImplementedException());

	public Capability( bool Available, Action Activate ) {
		this.Available = Available;
		_Act = Activate;
	}

	/// <inheritdoc />
	public bool Available { get; }

	readonly Action _Act;

	/// <inheritdoc />
	public void Activate() => _Act();
}