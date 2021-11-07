// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.IGlobalSystemMediaTransportControlsSessionMediaProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Control
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1753574646, 44468, 21682, 172, 22, 5, 131, 121, 7, 172, 182)]
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSessionMediaProperties))]
  internal interface IGlobalSystemMediaTransportControlsSessionMediaProperties
  {
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
