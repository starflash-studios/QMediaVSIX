#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

using System.Diagnostics;

namespace QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

public static class VolumeMixer_Extensions {
	///// <inheritdoc cref="VolumeMixer"/>
	//[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	//static extern IntPtr FindWindow( string StrClassName, string StrWindowName );

	///// <inheritdoc cref="VolumeMixer"/>
	//[DllImport("user32.dll", SetLastError = true)]
	//static extern uint GetWindowThreadProcessId( IntPtr HWnd, out uint ProcessId );

	internal static void SetVol(int ProcessId, float Level) => VolumeMixer.SetApplicationVolume(ProcessId, Level * 100.0f);

	/// <summary>
	/// Sets the application volume to the desired level. (<c>0.0f</c> - <c>1.0f</c>)
	/// </summary>
	/// <param name="P">The process reference.</param>
	/// <param name="Level">The desired volume level. (<c>0.0f</c> - <c>1.0f</c>)</param>
	public static void SetApplicationVolume( this Process P, float Level ) => SetVol(P.Id, Level);

	/// <inheritdoc cref="SetApplicationVolume(Process, float)"/>
	/// <param name="Session">The session to change the volume of.</param>
	/// <param name="Level"><inheritdoc cref="SetApplicationVolume(Process, float)"/></param>
	public static void SetApplicationVolume( this AudioSession Session, float Level ) => SetVol(Session.ProcessId, Level);

	internal static float? GetVol( int ProcessId ) => VolumeMixer.GetApplicationVolume(ProcessId) is { } V ? V / 100.0f : null;

	/// <summary>
	/// Retrieves the current volume of the application. (<c>0.0f</c> - <c>1.0f</c>)
	/// </summary>
	/// <param name="P">The process reference.</param>
	/// <returns>A <see cref="float"/> in the range <c>0.0f</c> - <c>1.0f</c>, or <see langword="null"/>.</returns>
	public static float? GetApplicationVolume( this Process P ) => GetVol(P.Id);

	/// <inheritdoc cref="GetApplicationVolume(Process)"/>
	public static float? GetApplicationVolume( this AudioSession Session ) => GetVol(Session.ProcessId);

	internal static void SetMute(int ProcessId, bool Mute) => VolumeMixer.SetApplicationMute(ProcessId, Mute);

	/// <summary>
	/// Mutes (or unmutes) the given application.
	/// </summary>
	/// <param name="P">The process reference.</param>
	/// <param name="Mute">If <see langword="true"/>, the application will be muted; otherwise, if <see langword="false"/>, the application will be unmuted.</param>
	public static void SetApplicationMute( this Process P, bool Mute ) => SetMute(P.Id, Mute);

	/// <inheritdoc cref="SetApplicationMute(Process, bool)"/>
	/// <param name="Session">The session to mute (or unmute).</param>
	/// <param name="Mute"><inheritdoc cref="SetApplicationMute(Process, bool)"/></param>
	public static void SetApplicationMute( this AudioSession Session, bool Mute ) => SetMute(Session.ProcessId, Mute);

	internal static bool? GetMute( int ProcessId ) => VolumeMixer.GetApplicationMute(ProcessId);

	/// <summary>
	/// Retrieves whether the application is currently muted.
	/// </summary>
	/// <param name="P">The process reference.</param>
	/// <returns>A <see cref="bool"/> indicating whether the application is currently muted, or <see langword="null"/>.</returns>
	public static bool? GetApplicationMute( this Process P ) => GetMute(P.Id);

	/// <inheritdoc cref="GetApplicationMute(Process)"/>
	public static bool? GetApplicationMute( this AudioSession Session ) => GetMute(Session.ProcessId);
}