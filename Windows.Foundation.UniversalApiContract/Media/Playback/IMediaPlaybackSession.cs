// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlaybackSession))]
  [Guid(3274401853, 1031, 16826, 137, 70, 139, 52, 90, 90, 84, 53)]
  internal interface IMediaPlaybackSession
  {
    event TypedEventHandler<MediaPlaybackSession, object> PlaybackStateChanged;

    event TypedEventHandler<MediaPlaybackSession, object> PlaybackRateChanged;

    event TypedEventHandler<MediaPlaybackSession, object> SeekCompleted;

    event TypedEventHandler<MediaPlaybackSession, object> BufferingStarted;

    event TypedEventHandler<MediaPlaybackSession, object> BufferingEnded;

    event TypedEventHandler<MediaPlaybackSession, object> BufferingProgressChanged;

    event TypedEventHandler<MediaPlaybackSession, object> DownloadProgressChanged;

    event TypedEventHandler<MediaPlaybackSession, object> NaturalDurationChanged;

    event TypedEventHandler<MediaPlaybackSession, object> PositionChanged;

    event TypedEventHandler<MediaPlaybackSession, object> NaturalVideoSizeChanged;

    MediaPlayer MediaPlayer { get; }

    TimeSpan NaturalDuration { get; }

    TimeSpan Position { get; set; }

    MediaPlaybackState PlaybackState { get; }

    bool CanSeek { get; }

    bool CanPause { get; }

    bool IsProtected { get; }

    double PlaybackRate { get; set; }

    double BufferingProgress { get; }

    double DownloadProgress { get; }

    uint NaturalVideoHeight { get; }

    uint NaturalVideoWidth { get; }

    Rect NormalizedSourceRect { get; set; }

    StereoscopicVideoPackingMode StereoscopicVideoPackingMode { get; set; }
  }
}
