namespace QDebug.Listeners;

#nullable enable

public interface IDebugListener {
	/// <summary>
	/// Writes the line to the listener trace.
	/// </summary>
	/// <param name="Message">The line to write.</param>
	void WriteLine( string? Message = null );

	/// <summary>
	/// Writes the line to the listener trace.
	/// </summary>
	/// <param name="Message">The line to write.</param>
	/// <param name="Category">The category the line relates to.</param>
	void WriteLine( string? Message, string Category );

	/// <summary>
	/// Writes a formatted message followed by a line terminator to the listener trace.
	/// </summary>
	/// <param name="Format">A composite format string that contains text intermixed with zero or more format items, which correspond to objects in the args array.</param>
	/// <param name="Args">An object array that contains zero or more objects to format.</param>
	void WriteLine( string Format, params object?[] Args );

	/// <summary>
	/// Writes the text to the listener trace.
	/// </summary>
	/// <param name="Message">The text to write.</param>
	void Write( string? Message = null );

	/// <summary>
	/// Writes the text to the listener trace.
	/// </summary>
	/// <param name="Message">The text to write.</param>
	/// <param name="Category">The category the text relates to.</param>
	void Write( string? Message, string Category );

	/// <summary>
	/// Clears the listener trace.
	/// </summary>
	void Clear();

	/// <summary>
	/// Sets the listener into a broken state.
	/// </summary>
	void Break();
}