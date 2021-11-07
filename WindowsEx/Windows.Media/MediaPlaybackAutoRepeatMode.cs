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

namespace Windows.Media {
  /// <summary>Specifies the auto repeat mode for media playback.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaPlaybackAutoRepeatMode {
    /// <summary>No repeating.</summary>
    None,

    /// <summary>Repeat the current track.</summary>
    Track,

    /// <summary>Repeat the current list of tracks.</summary>
    List
  }
}