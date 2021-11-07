#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Media.Control {
  /// <summary>An object that describes what controls a session currently has enabled.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(Version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GlobalSystemMediaTransportControlsSessionPlaybackControls :
    IGlobalSystemMediaTransportControlsSessionPlaybackControls {
    /// <summary>Whether the session currently supports the Play command.</summary>
    /// <returns>True if play is supported; otherwise, false.</returns>
    public extern bool IsPlayEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the pause command.</summary>
    /// <returns>True if pause is supported; otherwise, false.</returns>
    public extern bool IsPauseEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the stop command.</summary>
    /// <returns>True if stop is supported; otherwise, false.</returns>
    public extern bool IsStopEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the record command.</summary>
    /// <returns>True if record is supported; otherwise, false.</returns>
    public extern bool IsRecordEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the fast forward command.</summary>
    /// <returns>True if fast forward is supported; otherwise, false.</returns>
    public extern bool IsFastForwardEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the rewind command.</summary>
    /// <returns>True if rewind is supported; otherwise, false.</returns>
    public extern bool IsRewindEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the next command.</summary>
    /// <returns>True if next is supported; otherwise, false.</returns>
    public extern bool IsNextEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the previous command.</summary>
    /// <returns>True if previous is supported; otherwise, false.</returns>
    public extern bool IsPreviousEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports ChannelUp.</summary>
    /// <returns>True if channel up is supported; otherwise, false.</returns>
    public extern bool IsChannelUpEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports ChannelDown.</summary>
    /// <returns>True if channel down is supported; otherwise, false.</returns>
    public extern bool IsChannelDownEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the play pause toggle command (where play or pause is picked depending on state).</summary>
    /// <returns>True if play pause toggle is supported; otherwise, false.</returns>
    public extern bool IsPlayPauseToggleEnabled { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the session currently allows control of its shuffle state.</summary>
    /// <returns>True if shuffle control is supported; otherwise, false.</returns>
    public extern bool IsShuffleEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports control of its repeat mode.</summary>
    /// <returns>True if repeat mode is supported; otherwise, false.</returns>
    public extern bool IsRepeatEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports changing the playback rate.</summary>
    /// <returns>True if playback rate is supported; otherwise, false.</returns>
    public extern bool IsPlaybackRateEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports changing the playback position.</summary>
    /// <returns>True if playback position is supported; otherwise, false.</returns>
    public extern bool IsPlaybackPositionEnabled { [MethodImpl] get; }
  }
}