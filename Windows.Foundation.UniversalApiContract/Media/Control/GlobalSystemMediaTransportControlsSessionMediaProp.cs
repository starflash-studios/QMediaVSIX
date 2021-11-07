// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.GlobalSystemMediaTransportControlsSessionMediaProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Control
{
  /// <summary>Holds information about the content that the current session has.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(version = 1)]
  public sealed class GlobalSystemMediaTransportControlsSessionMediaProperties : 
    IGlobalSystemMediaTransportControlsSessionMediaProperties
  {
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
