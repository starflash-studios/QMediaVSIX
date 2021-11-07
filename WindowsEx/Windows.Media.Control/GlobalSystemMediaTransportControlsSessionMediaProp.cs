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
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

#endregion

namespace Windows.Media.Control {
  /// <summary>Holds information about the content that the current session has.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(Version = 1)]
  public sealed class GlobalSystemMediaTransportControlsSessionMediaProperties :
    IGlobalSystemMediaTransportControlsSessionMediaProperties {
    /// <summary>Gets the title.</summary>
    /// <returns>The title.</returns>
    public extern string Title { [MethodImpl] get; }

    /// <summary>Gets the subtitle.</summary>
    /// <returns>The subtitle of the media.</returns>
    public extern string Subtitle { [MethodImpl] get; }

    /// <summary>Gets the album's artist</summary>
    /// <returns>The name of the album artist.</returns>
    public extern string AlbumArtist { [MethodImpl] get; }

    /// <summary>Gets the Artist's name.</summary>
    /// <returns>The Artist name.</returns>
    public extern string Artist { [MethodImpl] get; }

    /// <summary>Gets the title of the album.</summary>
    /// <returns>The title of the album.</returns>
    public extern string AlbumTitle { [MethodImpl] get; }

    /// <summary>The number associated with this track</summary>
    /// <returns>The track number.</returns>
    public extern int TrackNumber { [MethodImpl] get; }

    /// <summary>Gets the list of genres.</summary>
    /// <returns>A list of all strings representing the genres.</returns>
    public extern IVectorView<string> Genres { [MethodImpl] get; }

    /// <summary>Gets the total number of tracks on the album.</summary>
    /// <returns>The total number of tracks on the album.</returns>
    public extern int AlbumTrackCount { [MethodImpl] get; }

    /// <summary>The playback type of the content</summary>
    /// <returns>The type of media.</returns>
    public extern IReference<MediaPlaybackType> PlaybackType { [MethodImpl] get; }

    /// <summary>A reference to a RandomAccessStream of the thumbnail image associated with this content.</summary>
    /// <returns>The thumbnail image.</returns>
    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; }
  }
}