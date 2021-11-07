// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(941261771, 28671, 18843, 141, 100, 40, 133, 223, 193, 36, 158)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlayer
  {
    bool AutoPlay { get; set; }

    TimeSpan NaturalDuration { [Deprecated("Use PlaybackSession.NaturalDuration instead of NaturalDuration.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    TimeSpan Position { [Deprecated("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] set; }

    double BufferingProgress { [Deprecated("Use PlaybackSession.BufferingProgress instead of BufferingProgress.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    MediaPlayerState CurrentState { [Deprecated("Use PlaybackSession.State instead of CurrentState.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    bool CanSeek { [Deprecated("Use PlaybackSession.CanSeek instead of CanSeek.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    bool CanPause { [Deprecated("Use PlaybackSession.CanPause instead of CanPause.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    bool IsLoopingEnabled { get; set; }

    bool IsProtected { [Deprecated("Use PlaybackSession.IsProtected instead of IsProtected.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    bool IsMuted { get; set; }

    double PlaybackRate { [Deprecated("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] set; }

    double Volume { get; set; }

    PlaybackMediaMarkerSequence PlaybackMediaMarkers { [Deprecated("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")] get; }

    event TypedEventHandler<MediaPlayer, object> MediaOpened;

    event TypedEventHandler<MediaPlayer, object> MediaEnded;

    event TypedEventHandler<MediaPlayer, MediaPlayerFailedEventArgs> MediaFailed;

    event TypedEventHandler<MediaPlayer, object> CurrentStateChanged;

    event TypedEventHandler<MediaPlayer, PlaybackMediaMarkerReachedEventArgs> PlaybackMediaMarkerReached;

    event TypedEventHandler<MediaPlayer, MediaPlayerRateChangedEventArgs> MediaPlayerRateChanged;

    event TypedEventHandler<MediaPlayer, object> VolumeChanged;

    event TypedEventHandler<MediaPlayer, object> SeekCompleted;

    event TypedEventHandler<MediaPlayer, object> BufferingStarted;

    event TypedEventHandler<MediaPlayer, object> BufferingEnded;

    void Play();

    void Pause();

    [Deprecated("Use Source instead of SetUriSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    void SetUriSource(Uri value);
  }
}
