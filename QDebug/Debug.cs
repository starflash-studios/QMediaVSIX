using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

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

	/// <summary>
	/// Constructs a collection of parameters for use in the <see cref="Here(object?[]?, string?, string?, int?)"/> method.
	/// </summary>
	/// <param name="Args">The collection of parameters.</param>
	/// <returns>A collection of parameters.</returns>
	public static object[] Params( params object[] Args ) => Args;

	/// <summary>
	/// Writes the current location (caller method, file path and line number) to the trace <see cref="Listeners"/> collection.
	/// </summary>
	/// <param name="CallerMemberName">The name of the caller method.</param>
	/// <param name="CallerFilePath">The file path of the caller script file at the time of compilation.</param>
	/// <param name="CallerLineNumber">The line number of the caller script file at the time of compilation.</param>
	/// <param name="Parameters">The collection of parameters to document as part of the <paramref name="CallerMemberName"/>.</param>
	public static void Here( object?[]? Parameters, [CallerMemberName] string? CallerMemberName = null, [CallerFilePath] string? CallerFilePath = null, [CallerLineNumber] int? CallerLineNumber = null ) {
		StringBuilder SB = new StringBuilder();
		SB.Append(">> ");
		bool FN = false;
		if ( CallerFilePath is not null ) {
			FN = true;
			SB.Append(CallerFilePath);
			if ( CallerLineNumber is not null ) {
				SB.Append(',');
				SB.Append(CallerLineNumber);
			}
		}
		if ( CallerMemberName is not null ) {
			if ( FN ) {
				SB.Append(' ');
			}
			SB.Append("> ");
			SB.Append(CallerMemberName);
			SB.Append('(');
			if ( Parameters is not null ) {
				foreach ( object? Param in Parameters ) {
					switch ( Param ) {
						case { } P:
							SB.Append(P.GetType().Name);
							SB.Append(' ');
							SB.Append(P);
							break;
						default:
							SB.Append("null");
							break;
					}
					SB.Append(", ");
				}
				SB.Remove(SB.Length - 1, 1);
			}
			SB.Append(')');
		}
		WriteLine(SB.ToString());
	}


	/// <summary>
	/// Writes the current location (caller method, file path and line number) to the trace <see cref="Listeners"/> collection.
	/// </summary>
	/// <param name="CallerMemberName">The name of the caller method.</param>
	/// <param name="CallerFilePath">The file path of the caller script file at the time of compilation.</param>
	/// <param name="CallerLineNumber">The line number of the caller script file at the time of compilation.</param>
	public static void Here( [CallerMemberName] string? CallerMemberName = null, [CallerFilePath] string? CallerFilePath = null, [CallerLineNumber] int? CallerLineNumber = null ) => Here(null, CallerMemberName, CallerFilePath, CallerLineNumber);

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

//public struct LogMe {
//	string? CallerMemberName, CallerFilePath;
//	int? CallerLineNumber;
//	object?[] Parameters;

//	public LogMe([CallerMemberName] string? CallerMemberName = null, [CallerFilePath] string? CallerFilePath = null, [CallerLineNumber] int? CallerLineNumber = null ) {
//		this.CallerMemberName = CallerMemberName;
//		this.CallerFilePath = CallerFilePath;
//		this.CallerLineNumber = CallerLineNumber;
//		Parameters = Array.Empty<object?>();
//	}

//	public void Params( params object?[] Parameters ) => this.Parameters = Parameters;
//}