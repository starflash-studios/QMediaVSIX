// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(1282618095, 54175, 17302, 180, 217, 4, 57, 87, 167, 201, 100)]
  [ExclusiveTo(typeof (AdaptiveMediaSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdaptiveMediaSource : IMediaSource
  {
    bool IsLive { get; }

    TimeSpan DesiredLiveOffset { get; set; }

    uint InitialBitrate { get; set; }

    uint CurrentDownloadBitrate { get; }

    uint CurrentPlaybackBitrate { get; }

    IVectorView<uint> AvailableBitrates { get; }

    IReference<uint> DesiredMinBitrate { get; set; }

    IReference<uint> DesiredMaxBitrate { get; set; }

    bool AudioOnlyPlayback { get; }

    ulong InboundBitsPerSecond { get; }

    TimeSpan InboundBitsPerSecondWindow { get; set; }

    event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadBitrateChangedEventArgs> DownloadBitrateChanged;

    event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourcePlaybackBitrateChangedEventArgs> PlaybackBitrateChanged;

    event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadRequestedEventArgs> DownloadRequested;

    event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadCompletedEventArgs> DownloadCompleted;

    event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadFailedEventArgs> DownloadFailed;
  }
}
