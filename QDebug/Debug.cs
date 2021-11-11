using System.Collections.Generic;

using QDebug.Listeners;

namespace QDebug;

#nullable enable

public static class Debug {
	/// <summary>
	/// The collection of trace listeners to output debug statements to.
	/// </summary>
	public static readonly List<IDebugListener> Listeners;


	static Debug() {
		Listeners = new List<IDebugListener>() {
			new DiagnosticsListener()
		};
		if ( Console.HasConsoleAttached ) {
			Listeners.Add(new ConsoleListener());
		}
	}
	/// <summary>
	/// Queries the collection of listeners for trace listeners of the requested type.
	/// </summary>
	/// <typeparam name="T">The type of listeners to retrieve.</typeparam>
	/// <returns>A collection of all listeners of type <typeparamref name="T"/>.</returns>
	public static IEnumerable<T> Query<T>() where T : IDebugListener {
		foreach ( IDebugListener L in Listeners ) {
			if (L is T TL ) {
				yield return TL;
			}
		}
	}

	/// <inheritdoc cref="SysDbg.WriteLine(string?)"/>
	public static void WriteLine( string? Message = null ) => Listeners.ForEach(L => L.WriteLine(Message));

	/// <inheritdoc cref="SysDbg.WriteLine(object?)"/>
	public static void WriteLine( object? Object ) => WriteLine(Message: Object?.ToString());

	/// <inheritdoc cref="SysDbg.WriteLine(string?, string)"/>
	public static void WriteLine( string? Message, string Category ) => Listeners.ForEach(L => L.WriteLine(Message, Category));

	/// <inheritdoc cref="SysDbg.WriteLine(object?, string)"/>
	public static void WriteLine( object? Object, string Category ) => WriteLine(Object?.ToString(), Category);

	/// <inheritdoc cref="SysDbg.Write(string?)"/>
	public static void Write( string? Message = null ) => Listeners.ForEach(L => L.Write(Message));

	/// <inheritdoc cref="SysDbg.Write(object?)"/>
	public static void Write( object? Object ) => Write(Message: Object?.ToString());

	/// <inheritdoc cref="SysDbg.Write(string?, string)"/>
	public static void Write( string? Message, string Category ) => Listeners.ForEach(L => L.Write(Message, Category));

	/// <inheritdoc cref="SysDbg.Write(object?, string)"/>
	public static void Write( object? Object, string Category ) => Write(Object?.ToString(), Category);

	/// <inheritdoc cref="SysCon.Clear()"/>
	public static void Clear() => Listeners.ForEach(L => L.Clear());

	/// <inheritdoc cref="System.Diagnostics.Debugger.Break()"/>
	public static void Break() => Listeners.ForEach(L => L.Break());
}