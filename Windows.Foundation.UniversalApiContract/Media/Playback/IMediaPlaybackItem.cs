// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(74487762, 58543, 18603, 178, 131, 105, 41, 230, 116, 236, 226)]
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  internal interface IMediaPlaybackItem : IMediaPlaybackSource
  {
    event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> AudioTracksChanged;

    event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> VideoTracksChanged;

    event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> TimedMetadataTracksChanged;

    MediaSource Source { get; }

    MediaPlaybackAudioTrackList AudioTracks { get; }

    MediaPlaybackVideoTrackList VideoTracks { get; }

    MediaPlaybackTimedMetadataTrackList TimedMetadataTracks { get; }
  }
}
