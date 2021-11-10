using System;

namespace QDebug;

#nullable enable

public class Console {
	/// <inheritdoc cref="SysCon.Read()"/>
	public static int Read() => SysCon.Read();

	/// <inheritdoc cref="SysCon.ReadKey()"/>
	public static ConsoleKeyInfo ReadKey() => SysCon.ReadKey();

	/// <inheritdoc cref="SysCon.ReadKey(bool)"/>
	/// <param name="Intercept">Determines whether to display the pressed key in the console window. <see langword="true"/> to not display the pressed key; otherwise <see langword="false"/>.</param>
	public static ConsoleKeyInfo ReadKey(bool Intercept) => SysCon.ReadKey(Intercept);

	/// <inheritdoc cref="SysCon.ReadLine()"/>
	public static string? ReadLine() => SysCon.ReadLine();

	#region Redirected Methods

	/// <inheritdoc cref="SysCon.Clear()"/>
	public static void Clear() => Debug.Clear();

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