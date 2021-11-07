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
  /// <summary>Defines values for the types of media playback.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaPlaybackType {
    /// <summary>The media type is unknown.</summary>
    Unknown,

    /// <summary>The media type is audio music.</summary>
    Music,

    /// <summary>The media type is video.</summary>
    Video,

    /// <summary>The media type is an image.</summary>
    Image
  }
}