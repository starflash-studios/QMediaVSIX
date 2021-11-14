#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QMediaVSIX.Core;

/// <summary>
/// Implementation courtesy of <see href="https://stackoverflow.com/a/64066801/11519246">ims1234</see>.
/// </summary>
/// <remarks>
/// This code is licensed under Creative Commons Attribution-ShareAlike 4.0 Internal (CC BY-SA 4.0).
/// <br/>You are free to:
/// <list type="bullet"><item>
/// <term>Share</term>
/// <description> copy and redistribute the material in any medium or format</description>
/// </item><item>
/// <term>Adapt</term>
/// <description> remix, transform, and build upon the material for any purpose, even commercially.</description>
/// </item></list>
/// This is a human-readable summary of (and not a substitute for) the <see href="https://creativecommons.org/licenses/by-sa/4.0/legalcode">license</see>.
/// <para/>For more information, please visit: <see href="https://creativecommons.org/licenses/by-sa/4.0/"/>
/// </remarks>
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class NotNullWhenAttribute : Attribute {
	public NotNullWhenAttribute( bool ReturnValue ) => this.ReturnValue = ReturnValue;
	public bool ReturnValue { get; }
}