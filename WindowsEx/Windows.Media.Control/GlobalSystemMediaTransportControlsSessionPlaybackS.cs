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
  /// <summary>The different states of playback the session could be in.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum GlobalSystemMediaTransportControlsSessionPlaybackStatus {
    /// <summary>The media is closed.</summary>
    Closed,

    /// <summary>The media is opened.</summary>
    Opened,

    /// <summary>The media is changing.</summary>
    Changing,

    /// <summary>The media is stopped.</summary>
    Stopped,

    /// <summary>The media is playing.</summary>
    Playing,

    /// <summary>The media is paused.</summary>
    Paused
  }
}