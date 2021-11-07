#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

namespace QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

/// <summary>
/// Courtesy of <see href="https://stackoverflow.com/a/31931235/11519246">Hans Passant</see>.
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
internal static class MMDeviceEnumeratorFactory {
	static readonly Guid _MMDeviceEnumerator = new Guid("BCDE0395-E52F-467C-8E3D-C4579291692E");

	public static IMMDeviceEnumerator? CreateInstance() =>
		Type.GetTypeFromCLSID(_MMDeviceEnumerator) switch {
			{ } Tp => (IMMDeviceEnumerator?)Activator.CreateInstance(Tp),
			_      => null
		};
}