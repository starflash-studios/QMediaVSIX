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
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSessionPlaybackControls))]
  [Guid(1694606310, 48250, 20538, 187, 27, 104, 241, 88, 243, 251, 3)]
  internal interface IGlobalSystemMediaTransportControlsSessionPlaybackControls {
    bool IsPlayEnabled { get; }

    bool IsPauseEnabled { get; }

    bool IsStopEnabled { get; }

    bool IsRecordEnabled { get; }

    bool IsFastForwardEnabled { get; }

    bool IsRewindEnabled { get; }

    bool IsNextEnabled { get; }

    bool IsPreviousEnabled { get; }

    bool IsChannelUpEnabled { get; }

    bool IsChannelDownEnabled { get; }

    bool IsPlayPauseToggleEnabled { get; }

    bool IsShuffleEnabled { get; }

    bool IsRepeatEnabled { get; }

    bool IsPlaybackRateEnabled { get; }

    bool IsPlaybackPositionEnabled { get; }
  }
}