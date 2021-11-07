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
  /// <summary>Represents the timeline state of the session (Position, seek ranges etc.).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(Version = 1)]
  public sealed class GlobalSystemMediaTransportControlsSessionTimelineProperties :
    IGlobalSystemMediaTransportControlsSessionTimelineProperties {
    /// <summary>The starting timestamp of the current media item.</summary>
    /// <returns>A value representing the start time of the current media item.</returns>
    public extern TimeSpan StartTime { [MethodImpl] get; }

    /// <summary>The end timestamp of the current media item.</summary>
    /// <returns>A value representing the end time of the current media item.</returns>
    public extern TimeSpan EndTime { [MethodImpl] get; }

    /// <summary>The earliest timestamp at which the current media item can currently seek to.</summary>
    /// <returns>A value representing the min seek time of the current media item.</returns>
    public extern TimeSpan MinSeekTime { [MethodImpl] get; }

    /// <summary>The furthest timestamp at which the content can currently seek to.</summary>
    /// <returns>A value representing the max seek time of the current media item.</returns>
    public extern TimeSpan MaxSeekTime { [MethodImpl] get; }

    /// <summary>The playback position, current as of LastUpdatedTime.</summary>
    /// <returns>A value representing the playback position of the current media item.</returns>
    public extern TimeSpan Position { [MethodImpl] get; }

    /// <summary>The UTC time at which the timeline properties were last updated.</summary>
    /// <returns>A value representing the last time the timeline properties were updated.</returns>
    public extern DateTime LastUpdatedTime { [MethodImpl] get; }
  }
}