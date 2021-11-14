#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

using QDebug.Listeners;

#endregion

namespace QDebug;

#nullable enable

public static class Debug {
	/// <summary>
	/// The collection of trace listeners to output debug statements to.
	/// </summary>
	public static readonly List<IDebugListener> Listeners;

	static Debug() {
		Listeners = new List<IDebugListener> {
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
	/// Constructs a collection of parameters for use in the <see cref="Here(object?[], string?, string?, int?)"/> method.
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
	[Conditional("DEBUG")]
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
	[SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression"),
	 SuppressMessage("ReSharper", "ExplicitCallerInfoArgument"),
	 Conditional("DEBUG")]
	public static void Here( [CallerMemberName] string? CallerMemberName = null, [CallerFilePath] string? CallerFilePath = null, [CallerLineNumber] int? CallerLineNumber = null ) => Here(null, CallerMemberName, CallerFilePath, CallerLineNumber);

	#region Redirected Methods

	/// <inheritdoc cref="SysCon.Clear()"/>
	[Conditional("DEBUG")]
	public static void Clear() => Console.Clear();

	/// <inheritdoc cref="Debugger.Break()"/>
	[Conditional("DEBUG")]
	public static void Break() => Console.Break();

	/// <inheritdoc cref="SysCon.WriteLine(string?)"/>
	[Conditional("DEBUG")]
	public static void WriteLine( string? Message = null ) => Console.WriteLine(Message);

	/// <inheritdoc cref="Console.WriteLine(string?, string)"/>
	[Conditional("DEBUG")]
	public static void WriteLine( string? Message, string Category ) => Console.WriteLine(Message, Category);

	/// <inheritdoc cref="SysCon.WriteLine(object?)"/>
	[Conditional("DEBUG")]
	public static void WriteLine( object? Object ) => Console.WriteLine(Object);

	/// <inheritdoc cref="Console.WriteLine(object?, string)"/>
	[Conditional("DEBUG")]
	public static void WriteLine( object? Object, string Category ) => Console.WriteLine(Object, Category);

	/// <inheritdoc cref="SysCon.Write(string?)"/>
	[Conditional("DEBUG")]
	public static void Write( string? Message = null ) => Console.Write(Message);

	/// <inheritdoc cref="Console.Write(string?, string)"/>
	[Conditional("DEBUG")]
	public static void Write( string? Message, string Category ) => Console.Write(Message, Category);

	/// <inheritdoc cref="SysCon.Write(object?)"/>
	[Conditional("DEBUG")]
	public static void Write( object? Object ) => Console.Write(Object);

	/// <inheritdoc cref="Console.Write(object?, string)"/>
	[Conditional("DEBUG")]
	public static void Write( object? Object, string Category ) => Console.Write(Object, Category);

	#endregion
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