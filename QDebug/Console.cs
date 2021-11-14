#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System;
using System.Runtime.InteropServices;

#endregion

namespace QDebug;

#nullable enable

public static class Console {
	/// <inheritdoc cref="SysCon.Read()"/>
	public static int Read() => SysCon.Read();

	/// <inheritdoc cref="SysCon.ReadKey()"/>
	public static ConsoleKeyInfo ReadKey() => SysCon.ReadKey();

	/// <inheritdoc cref="SysCon.ReadKey(bool)"/>
	/// <param name="Intercept">Determines whether to display the pressed key in the console window. <see langword="true"/> to not display the pressed key; otherwise <see langword="false"/>.</param>
	public static ConsoleKeyInfo ReadKey(bool Intercept) => SysCon.ReadKey(Intercept);

	/// <inheritdoc cref="SysCon.ReadLine()"/>
	public static string? ReadLine() => SysCon.ReadLine();

	/// <summary>
	/// Returns <see langword="true"/> if <see cref="GetConsoleWindow()"/> does not return <see cref="IntPtr.Zero"/>.
	/// </summary>
	public static bool HasConsoleAttached => GetConsoleWindow() != IntPtr.Zero;

	[DllImport("kernel32.dll")]
	static extern IntPtr GetConsoleWindow();

	/// <inheritdoc cref="SysDbg.WriteLine(string?)"/>
	public static void WriteLine( string? Message = null ) => Debug.Listeners.ForEach(L => L.WriteLine(Message));

	/// <inheritdoc cref="SysDbg.WriteLine(object?)"/>
	public static void WriteLine( object? Object ) => WriteLine(Object?.ToString());

	/// <inheritdoc cref="SysDbg.WriteLine(string?, string)"/>
	public static void WriteLine( string? Message, string Category ) => Debug.Listeners.ForEach(L => L.WriteLine(Message, Category));

	/// <inheritdoc cref="SysDbg.WriteLine(object?, string)"/>
	public static void WriteLine( object? Object, string Category ) => WriteLine(Object?.ToString(), Category);

	/// <inheritdoc cref="SysDbg.Write(string?)"/>
	public static void Write( string? Message = null ) => Debug.Listeners.ForEach(L => L.Write(Message));

	/// <inheritdoc cref="SysDbg.Write(object?)"/>
	public static void Write( object? Object ) => Write(Object?.ToString());

	/// <inheritdoc cref="SysDbg.Write(string?, string)"/>
	public static void Write( string? Message, string Category ) => Debug.Listeners.ForEach(L => L.Write(Message, Category));

	/// <inheritdoc cref="SysDbg.Write(object?, string)"/>
	public static void Write( object? Object, string Category ) => Write(Object?.ToString(), Category);

	/// <inheritdoc cref="SysCon.Clear()"/>
	public static void Clear() => Debug.Listeners.ForEach(L => L.Clear());

	/// <inheritdoc cref="System.Diagnostics.Debugger.Break()"/>
	public static void Break() => Debug.Listeners.ForEach(L => L.Break());
}