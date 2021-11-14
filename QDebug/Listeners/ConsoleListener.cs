#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QDebug.Listeners;

#nullable enable

public class ConsoleListener : IDebugListener {
	/// <inheritdoc />
	public void WriteLine( string? Message = null ) => SysCon.WriteLine(Message);

	/// <inheritdoc />
	public void WriteLine( string? Message, string Category ) => SysCon.WriteLine($"[{Category}]{Message}");

	/// <inheritdoc />
	public void WriteLine( string Format, params object?[] Args ) => SysCon.WriteLine(Format, Args);

	/// <inheritdoc />
	public void Write( string? Message = null ) => SysCon.Write(Message);

	/// <inheritdoc />
	public void Write( string? Message, string Category ) => SysCon.Write($"[{Category}]{Message}");

	/// <inheritdoc />
	public void Clear() => SysCon.Clear();

	/// <inheritdoc />
	public void Break() {
		SysCon.WriteLine("[[BREAK]]");
		SysCon.Beep();
	}
}