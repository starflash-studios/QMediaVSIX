// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoTrack
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (VideoTrack))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2582886387, 58008, 17302, 187, 106, 165, 27, 230, 162, 162, 10)]
  internal interface IVideoTrack
  {
    event TypedEventHandler<VideoTrack, VideoTrackOpenFailedEventArgs> OpenFailed;

    VideoEncodingProperties GetEncodingProperties();

    MediaPlaybackItem PlaybackItem { get; }

    string Name { get; }

    VideoTrackSupportInfo SupportInfo { get; }
  }
}
