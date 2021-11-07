#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

#endregion

namespace Windows.Media.Control {
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1753574646, 44468, 21682, 172, 22, 5, 131, 121, 7, 172, 182)]
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSessionMediaProperties))]
  internal interface IGlobalSystemMediaTransportControlsSessionMediaProperties {
    string Title { get; }

    string Subtitle { get; }

    string AlbumArtist { get; }

    string Artist { get; }

    string AlbumTitle { get; }

    int TrackNumber { get; }

    IVectorView<string> Genres { get; }

    int AlbumTrackCount { get; }

    IReference<MediaPlaybackType> PlaybackType { get; }

    IRandomAccessStreamReference Thumbnail { get; }
  }
}