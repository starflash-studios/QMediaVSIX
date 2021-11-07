// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Playback
{
  /// <summary>Provides information about the state of the current playback session of a MediaPlayer and provides events for responding to changes in playback session state.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaPlaybackSession : 
    IMediaPlaybackSession,
    IMediaPlaybackSession2,
    IMediaPlaybackSession3
  {
    /// <summary>Occurs when the current playback state changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> PlaybackStateChanged;

    /// <summary>Occurs when the current playback rate for the MediaPlaybackSession changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> PlaybackRateChanged;

    /// <summary>Occurs when a seek operation for the MediaPlaybackSession completes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> SeekCompleted;

    /// <summary>Occurs when buffering starts for the MediaPlaybackSession.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> BufferingStarted;

    /// <summary>Occurs when buffering ends for the MediaPlaybackSession.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> BufferingEnded;

    /// <summary>Occurs when the buffering progress for the MediaPlaybackSession changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> BufferingProgressChanged;

    /// <summary>Occurs when the download progress for a MediaPlaybackSession changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> DownloadProgressChanged;

    /// <summary>Occurs when the duration of the currently playing media item changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> NaturalDurationChanged;

    /// <summary>Occurs when the current playback position within the currently playing media changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> PositionChanged;

    /// <summary>Occurs when the size of the video in the currently playing media item changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> NaturalVideoSizeChanged;

    /// <summary>Gets the MediaPlayer associated with the MediaPlaybackSession.</summary>
    /// <returns>The MediaPlayer associated with the MediaPlaybackSession.</returns>
    public extern MediaPlayer MediaPlayer { [MethodImpl] get; }

    /// <summary>Gets a value indicating the duration of the currently playing media, when being played back at normal speed.</summary>
    /// <returns>The duration of the currently playing media.</returns>
    public extern TimeSpan NaturalDuration { [MethodImpl] get; }

    /// <summary>Gets or sets the current playback position within the currently playing media.</summary>
    /// <returns>The current playback position within the currently playing media.</returns>
    public extern TimeSpan Position { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating the current playback state of the MediaPlaybackSession, such as buffering or playing.</summary>
    /// <returns>The current playback state of the MediaPlaybackSession</returns>
    public extern MediaPlaybackState PlaybackState { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the current playback position of the media can be changed by setting the value of the MediaPlayer.Position property.</summary>
    /// <returns>True if the current playback position of the media can be changed; otherwise, false.</returns>
    public extern bool CanSeek { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether media can be paused if the MediaPlayer.Pause method is called.</summary>
    /// <returns>True if the media can be paused; otherwise, false.</returns>
    public extern bool CanPause { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the media that is currently playing in the MediaPlaybackSession is protected by digital rights management (DRM).</summary>
    /// <returns>True if the currently playing media is protected by DRM; otherwise, false.</returns>
    public extern bool IsProtected { [MethodImpl] get; }

    /// <summary>Gets or sets a value representing the current playback rate for the MediaPlaybackSession.</summary>
    /// <returns>The current playback rate for the MediaPlaybackSession.</returns>
    public extern double PlaybackRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates the current buffering progress of a MediaPlaybackSession.</summary>
    /// <returns>The current buffering progress. The value ranges from 0 to 1.0. Multiply by 100 to obtain a percentage.</returns>
    public extern double BufferingProgress { [MethodImpl] get; }

    /// <summary>Gets a value indicating the position after the current playback Position to which downloading has completed and content is buffered.</summary>
    /// <returns>A value indicating the position after the current playback Position to which downloading has completed and content is buffered. The value ranges from 0 to 1. Multiply by 100 to obtain a percentage.</returns>
    public extern double DownloadProgress { [MethodImpl] get; }

    /// <summary>Gets the height of the video in the currently playing media item.</summary>
    /// <returns>The height of the video in the currently playing media item, in pixels.</returns>
    public extern uint NaturalVideoHeight { [MethodImpl] get; }

    /// <summary>Gets the width of the video in the currently playing media item.</summary>
    /// <returns>The width of the video in the currently playing media item, in pixels.</returns>
    public extern uint NaturalVideoWidth { [MethodImpl] get; }

    /// <summary>Gets or sets a normalized rectangle within the video source which is rendered by the MediaPlayer. This enables pan and zoom within video.</summary>
    /// <returns>A normalized rectangle specifying the rectangle within the source video that is rendered by the MediaPlayer.</returns>
    public extern Rect NormalizedSourceRect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value specifying the stereoscopic video packing mode for the MediaPlaybackSession.</summary>
    /// <returns>The stereoscopic video packing mode</returns>
    public extern StereoscopicVideoPackingMode StereoscopicVideoPackingMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the set of time ranges for which data is buffered changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> BufferedRangesChanged;

    /// <summary>Occurs when the set of time ranges that have been played changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> PlayedRangesChanged;

    /// <summary>Occurs when the set of time ranges that can be seeked to changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> SeekableRangesChanged;

    /// <summary>Occurs when the set of playback rates supported by the media playback session changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackSession, object> SupportedPlaybackRatesChanged;

    /// <summary>Gets an object that manages the spherical video projection settings used by the media playback session.</summary>
    /// <returns>An object that manages the spherical video projection settings used by the media playback session.</returns>
    public extern MediaPlaybackSphericalVideoProjection SphericalVideoProjection { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether the content of the media playback session is currently being mirrored horizontally.</summary>
    /// <returns>True if the content of the media playback session is currently being mirrored horizontally; otherwise, false.</returns>
    public extern bool IsMirroring { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Retrieves a read-only list of time ranges for which data is buffered and playback can begin immediately.</summary>
    /// <returns>A read-only list of time ranges.</returns>
    [MethodImpl]
    public extern IVectorView<MediaTimeRange> GetBufferedRanges();

    /// <summary>Retrieves a read-only list of time ranges for which content has been played back.</summary>
    /// <returns>A read-only list of time ranges.</returns>
    [MethodImpl]
    public extern IVectorView<MediaTimeRange> GetPlayedRanges();

    /// <summary>Retrieves a read-only list of time ranges in which the playack position can be seeked to. For live streaming, these ranges represent the times ranges for which data is still available.</summary>
    /// <returns>A read-only list of time ranges.</returns>
    [MethodImpl]
    public extern IVectorView<MediaTimeRange> GetSeekableRanges();

    /// <summary>Gets a value indicating whether the specified range of playback rates is supported.</summary>
    /// <param name="rate1">The lower bound of the playback rate range for which support is queried.</param>
    /// <param name="rate2">The upper bound of the playback rate range for which support is queried.</param>
    /// <returns>True if the playback range is supported; otherwise, false.</returns>
    [MethodImpl]
    public extern bool IsSupportedPlaybackRateRange(double rate1, double rate2);

    /// <summary>Gets or sets a value from the MediaRotation enumeration that specifies the rotation applied to video content during playback.</summary>
    /// <returns>The rotation applied to video content during playback.</returns>
    public extern MediaRotation PlaybackRotation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that expresses the current output degradation policy state of the MediaPlaybackSession.</summary>
    /// <returns>A MediaPlaybackSessionOutputDegradationPolicyState object that expresses the current output degradation policy state.</returns>
    [MethodImpl]
    public extern MediaPlaybackSessionOutputDegradationPolicyState GetOutputDegradationPolicyState();
  }
}
