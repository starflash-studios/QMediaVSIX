#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Windows.Foundation;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Media.Control {
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSessionPlaybackInfo))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2494871247, 59578, 20909, 135, 167, 193, 10, 222, 16, 97, 39)]
  internal interface IGlobalSystemMediaTransportControlsSessionPlaybackInfo {
    GlobalSystemMediaTransportControlsSessionPlaybackControls Controls { get; }

    GlobalSystemMediaTransportControlsSessionPlaybackStatus PlaybackStatus { get; }

    IReference<MediaPlaybackType> PlaybackType { get; }

    IReference<MediaPlaybackAutoRepeatMode> AutoRepeatMode { get; }

    IReference<double> PlaybackRate { get; }

    IReference<bool> IsShuffleActive { get; }
  }
}