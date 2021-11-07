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
  /// <summary>The object that holds all of the playback information about a session (Play state, Controls, playback type etc.)</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(Version = 1)]
  public sealed class GlobalSystemMediaTransportControlsSessionPlaybackInfo :
    IGlobalSystemMediaTransportControlsSessionPlaybackInfo {
    /// <summary>Specifies which controls the session has enabled.</summary>
    /// <returns>A GlobalSystemMediaTransportControlsSessionPlaybackControls object.</returns>
    public extern GlobalSystemMediaTransportControlsSessionPlaybackControls Controls { [MethodImpl] get; }

    /// <summary>The current playback state of the session.</summary>
    /// <returns>The playback status.</returns>
    public extern GlobalSystemMediaTransportControlsSessionPlaybackStatus PlaybackStatus { [MethodImpl] get; }

    /// <summary>Specifies what type of content the session has.</summary>
    /// <returns>The playback type.</returns>
    public extern IReference<MediaPlaybackType> PlaybackType { [MethodImpl] get; }

    /// <summary>Specifies the repeat mode of the session.</summary>
    /// <returns>A value representing the current auto-repeat mode.</returns>
    public extern IReference<MediaPlaybackAutoRepeatMode> AutoRepeatMode { [MethodImpl] get; }

    /// <summary>The rate at which playback is happening.</summary>
    /// <returns>A value indicating the playback rate, 1 being normal playback.</returns>
    public extern IReference<double> PlaybackRate { [MethodImpl] get; }

    /// <summary>Specifies whether the session is currently playing content in a shuffled order or not.</summary>
    /// <returns>True if the session is currently shuffling; otherwise, false.</returns>
    public extern IReference<bool> IsShuffleActive { [MethodImpl] get; }
  }
}