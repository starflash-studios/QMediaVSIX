namespace QDebug.Listeners;

public class ConsoleListener : IDebugListener {
	/// <inheritdoc />
	public void WriteLine( string? Message = null ) => SysCon.WriteLine(Message);

	/// <inheritdoc />
	public void WriteLine( string? Message, string Category ) => SysCon.WriteLine($"[{Category}]{Message}");

	/// <inheritdoc />
	public void WriteLine( string Format, params object?[]? Args ) => SysCon.WriteLine(Format, Args);

	/// <inheritdoc />
	public void Write( string? Message = null ) => SysCon.Write(Message);

	/// <inheritdoc />
	public void Write( string? Message, string Category ) => SysCon.Write($"[{Category}]{Message}");

	/// <inheritdoc />
	public void Clear() => SysCon.Clear();
}