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

	#region Redirected Methods

	/// <inheritdoc cref="SysCon.Clear()"/>
	public static void Clear() => Debug.Clear();

	/// <inheritdoc cref="System.Diagnostics.Debugger.Break()"/>
	public static void Break() => Debug.Break();

	/// <inheritdoc cref="SysCon.WriteLine(string?)"/>
	public static void WriteLine( string? Message = null ) => Debug.WriteLine(Message);

	/// <inheritdoc cref="Debug.WriteLine(string?, string)"/>
	public static void WriteLine( string? Message, string Category ) => Debug.WriteLine(Message, Category);

	/// <inheritdoc cref="SysCon.WriteLine(object?)"/>
	public static void WriteLine( object? Object ) => Debug.WriteLine(Object);

	/// <inheritdoc cref="Debug.WriteLine(object?, string)"/>
	public static void WriteLine( object? Object, string Category ) => Debug.WriteLine(Object, Category);

	/// <inheritdoc cref="SysCon.Write(string?)"/>
	public static void Write( string? Message = null ) => Debug.Write(Message);

	/// <inheritdoc cref="Debug.Write(string?, string)"/>
	public static void Write( string? Message, string Category ) => Debug.Write(Message, Category);

	/// <inheritdoc cref="SysCon.Write(object?)"/>
	public static void Write( object? Object ) => Debug.Write(Object);

	/// <inheritdoc cref="Debug.Write(object?, string)"/>
	public static void Write( object? Object, string Category ) => Debug.Write(Object, Category);

	#endregion
}