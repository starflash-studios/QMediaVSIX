// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackSession2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(4172971129, 8136, 16535, 173, 112, 192, 250, 24, 204, 0, 80)]
  [ExclusiveTo(typeof (MediaPlaybackSession))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMediaPlaybackSession2
  {
    event TypedEventHandler<MediaPlaybackSession, object> BufferedRangesChanged;

    event TypedEventHandler<MediaPlaybackSession, object> PlayedRangesChanged;

    event TypedEventHandler<MediaPlaybackSession, object> SeekableRangesChanged;

    event TypedEventHandler<MediaPlaybackSession, object> SupportedPlaybackRatesChanged;

    MediaPlaybackSphericalVideoProjection SphericalVideoProjection { get; }

    bool IsMirroring { get; set; }

    IVectorView<MediaTimeRange> GetBufferedRanges();

    IVectorView<MediaTimeRange> GetPlayedRanges();

    IVectorView<MediaTimeRange> GetSeekableRanges();

    bool IsSupportedPlaybackRateRange(double rate1, double rate2);
  }
}
