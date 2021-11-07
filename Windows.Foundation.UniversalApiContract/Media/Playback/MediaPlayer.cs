// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.Audio;
using Windows.Media.Casting;
using Windows.Media.Core;
using Windows.Media.Protection;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Composition;

namespace Windows.Media.Playback
{
  /// <summary>Provides access to media playback functionality such as play, pause, fast-forward, rewind, and volume.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaPlayer : 
    IMediaPlayer,
    IMediaPlayerSource,
    IMediaPlayerSource2,
    IMediaPlayer2,
    IMediaPlayerEffects,
    IClosable,
    IMediaPlayer3,
    IMediaPlayer4,
    IMediaPlayerEffects2,
    IMediaPlayer5,
    IMediaPlayer6,
    IMediaPlayer7
  {
    /// <summary>Initializes a new instance of the MediaPlayer object.</summary>
    [MethodImpl]
    public extern MediaPlayer();

    /// <summary>Gets or sets a Boolean value indicating if playback automatically starts after the media is loaded.</summary>
    /// <returns>True is playback start automatically, otherwise false.</returns>
    public extern bool AutoPlay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get the actual duration of the media without applying the PlaybackRate. </summary>
    /// <returns>The actual duration of the media without applying the PlaybackRate.</returns>
    public extern TimeSpan NaturalDuration { [Deprecated("Use PlaybackSession.NaturalDuration instead of NaturalDuration.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets the playback position within the media. </summary>
    /// <returns>The playback position within the media.</returns>
    public extern TimeSpan Position { [Deprecated("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets the amount of buffering that is completed for the media content, expressed as a percentage.</summary>
    /// <returns>The amount of buffering that is completed for the media content.</returns>
    public extern double BufferingProgress { [Deprecated("Use PlaybackSession.BufferingProgress instead of BufferingProgress.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the current state of media playback. </summary>
    /// <returns>The current state of media playback.</returns>
    public extern MediaPlayerState CurrentState { [Deprecated("Use PlaybackSession.State instead of CurrentState.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the media supports seeking to a specific position.</summary>
    /// <returns>True if the media supports seeking, otherwise false.</returns>
    public extern bool CanSeek { [Deprecated("Use PlaybackSession.CanSeek instead of CanSeek.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the media can be paused.</summary>
    /// <returns>True if the media can be paused, otherwise false.</returns>
    public extern bool CanPause { [Deprecated("Use PlaybackSession.CanPause instead of CanPause.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value indicating if the media will playback in a repeating loop.</summary>
    /// <returns>True is looping is enabled, otherwise false.</returns>
    public extern bool IsLoopingEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating if the content is protected by a digital rights management system.</summary>
    /// <returns>True if the content is protected, otherwise false.</returns>
    public extern bool IsProtected { [Deprecated("Use PlaybackSession.IsProtected instead of IsProtected.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value indicating if the audio is muted.</summary>
    /// <returns>True if the audio is muted, otherwise false.</returns>
    public extern bool IsMuted { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the playback rate, expressed as a ratio. </summary>
    /// <returns>The playback rate, expressed as a percentage.</returns>
    public extern double PlaybackRate { [Deprecated("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Get or sets the audio volume for media playback.</summary>
    /// <returns>The audio volume for media playback. The allowed range of values is 0 to 1. Values outside of this range will be clamped.</returns>
    public extern double Volume { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of timeline markers for the media. </summary>
    /// <returns>The collection of timeline markers for the media.</returns>
    public extern PlaybackMediaMarkerSequence PlaybackMediaMarkers { [Deprecated("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Occurs when the media is opened.</summary>
    public extern event TypedEventHandler<MediaPlayer, object> MediaOpened;

    /// <summary>Occurs when the media has finished playback.</summary>
    public extern event TypedEventHandler<MediaPlayer, object> MediaEnded;

    /// <summary>Occurs when an error is encountered.</summary>
    public extern event TypedEventHandler<MediaPlayer, MediaPlayerFailedEventArgs> MediaFailed;

    /// <summary>Occurs when the state of the media player has changed. </summary>
    public extern event TypedEventHandler<MediaPlayer, object> CurrentStateChanged;

    /// <summary>Occurs when a media marker has been reached during playback. </summary>
    public extern event TypedEventHandler<MediaPlayer, PlaybackMediaMarkerReachedEventArgs> PlaybackMediaMarkerReached;

    /// <summary>Occurs when the media playback rate has changed. </summary>
    public extern event TypedEventHandler<MediaPlayer, MediaPlayerRateChangedEventArgs> MediaPlayerRateChanged;

    /// <summary>Occurs when the volume of the audio has changed.</summary>
    public extern event TypedEventHandler<MediaPlayer, object> VolumeChanged;

    /// <summary>Occurs when a seek operation has finished. </summary>
    public extern event TypedEventHandler<MediaPlayer, object> SeekCompleted;

    /// <summary>Occurs when buffering has started. </summary>
    public extern event TypedEventHandler<MediaPlayer, object> BufferingStarted;

    /// <summary>Occurs when buffering has finished. </summary>
    public extern event TypedEventHandler<MediaPlayer, object> BufferingEnded;

    /// <summary>Starts media playback.</summary>
    [MethodImpl]
    public extern void Play();

    /// <summary>Pauses media playback.</summary>
    [MethodImpl]
    public extern void Pause();

    [Deprecated("Use Source instead of SetUriSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetUriSource(Uri value);

    /// <summary>Gets or sets the content protection manager for the media.</summary>
    /// <returns>The content protection manager for the media.</returns>
    public extern MediaProtectionManager ProtectionManager { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Set the media source to a file. </summary>
    /// <deprecated type="deprecate">Use Source instead of SetFileSource.  For more info, see MSDN.</deprecated>
    /// <param name="file">The media source file.</param>
    [Deprecated("Use Source instead of SetFileSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetFileSource(IStorageFile file);

    /// <summary>Sets the media source to a stream. </summary>
    /// <deprecated type="deprecate">Use Source instead of SetStreamSource.  For more info, see MSDN.</deprecated>
    /// <param name="stream">The media source stream.</param>
    [Deprecated("Use Source instead of SetStreamSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetStreamSource(IRandomAccessStream stream);

    /// <summary>Sets the media source for playback. </summary>
    /// <deprecated type="deprecate">Use Source instead of SetMediaSource.  For more info, see MSDN.</deprecated>
    /// <param name="source">The media source for playback.</param>
    [Deprecated("Use Source instead of SetMediaSource.  For more info, see MSDN.", DeprecationType.Deprecate, 131072, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetMediaSource(IMediaSource source);

    /// <summary>Sets the playback source of the media player.</summary>
    /// <returns>The playback source of the media player.</returns>
    public extern IMediaPlaybackSource Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an instance of the SystemMediaTransportControls class to enable user control of playback of the MediaPlayer and to allow the app to show information about the currently playing content in the system UI.</summary>
    /// <returns>An instance of the SystemMediaTransportControls class.</returns>
    public extern SystemMediaTransportControls SystemMediaTransportControls { [MethodImpl] get; }

    /// <summary>Gets or sets the type of audio that is currently being played.</summary>
    /// <returns>The type of audio that is currently being played.</returns>
    public extern MediaPlayerAudioCategory AudioCategory { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that describes the primary usage of the device that is being used to play back audio.</summary>
    /// <returns>The audio device type.</returns>
    public extern MediaPlayerAudioDeviceType AudioDeviceType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Adds an audio effect to the playback stream of the MediaPlayer.</summary>
    /// <param name="activatableClassId">The activatable class ID of the audio effect to add to the playback stream.</param>
    /// <param name="effectOptional">A value indicating whether the effect is optional.</param>
    /// <param name="configuration">A property set containing configuration settings for the specified audio effect.</param>
    [MethodImpl]
    public extern void AddAudioEffect(
      string activatableClassId,
      bool effectOptional,
      IPropertySet configuration);

    /// <summary>Removes all effects from the playback stream of the MediaPlayer.</summary>
    [MethodImpl]
    public extern void RemoveAllEffects();

    [MethodImpl]
    public extern void Close();

    /// <summary>Occurs when the current muted status of the MediaPlayer changes.</summary>
    public extern event TypedEventHandler<MediaPlayer, object> IsMutedChanged;

    /// <summary>Occurs when the media source for the MediaPlayer changes.</summary>
    public extern event TypedEventHandler<MediaPlayer, object> SourceChanged;

    /// <summary>Gets or sets a ratio of volume across stereo speakers.</summary>
    /// <returns>The ratio of volume across speakers in the range between -1 and 1. The default value is 0.</returns>
    public extern double AudioBalance { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that configures the MediaPlayer for real-time scenarios such as live streaming video.</summary>
    /// <returns>True if the MediaPlayer is being used for real-time media; otherwise, false.</returns>
    public extern bool RealTimePlayback { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating the current stereoscopic render mode.</summary>
    /// <returns>The current stereoscopic render mode.</returns>
    public extern StereoscopicVideoRenderMode StereoscopicVideoRenderMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the MediaBreakManager associated with the MediaPlayer, which provides information about and control over media breaks for the player.</summary>
    /// <returns>The MediaBreakManager associated with the MediaPlayer.</returns>
    public extern MediaBreakManager BreakManager { [MethodImpl] get; }

    /// <summary>Gets the MediaPlaybackCommandManager associated with the MediaPlayer, which specifies the behavior of and receives events from the System Media Transport Controls.</summary>
    /// <returns>The MediaPlaybackCommandManager associated with the MediaPlayer.</returns>
    public extern MediaPlaybackCommandManager CommandManager { [MethodImpl] get; }

    /// <summary>Gets or sets the DeviceInformation object representing audio device used by the MediaPlayer to render audio.</summary>
    /// <returns>The DeviceInformation object representing audio device used by the MediaPlayer to render audio.</returns>
    public extern DeviceInformation AudioDevice { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the MediaTimelineController associated with the MediaPlayer. Use this property to manipulate multiple **MediaPlayer** instances with a single timeline control.</summary>
    /// <returns>The MediaTimelineController associated with the MediaPlayer.</returns>
    public extern MediaTimelineController TimelineController { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the offset applied to the position of the MediaTimelineController associated with the MediaPlayer.</summary>
    /// <returns>The offset applied to the position of the MediaTimelineController associated with the MediaPlayer.</returns>
    public extern TimeSpan TimelineControllerPositionOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the MediaPlaybackSession associated with the MediaPlayer, which provides information about the state of the current playback session and provides events for responding to changes in playback session state.</summary>
    /// <returns>The MediaPlaybackSession associated with the MediaPlayer.</returns>
    public extern MediaPlaybackSession PlaybackSession { [MethodImpl] get; }

    /// <summary>Causes the MediaPlayer to move forward in the current media by one frame.</summary>
    [MethodImpl]
    public extern void StepForwardOneFrame();

    /// <summary>Causes the playback position of the MediaPlayer to move backward by .042 seconds, which corresponds to one frame at 24 fps, regardless of the actual frame rate of the content being played.</summary>
    [MethodImpl]
    public extern void StepBackwardOneFrame();

    /// <summary>Gets a CastingSource representing the MediaPlayer, which allows it's media to be cast to other devices.</summary>
    /// <returns>The casting source.</returns>
    [MethodImpl]
    public extern CastingSource GetAsCastingSource();

    /// <summary>Sets the size of the composition surface returned by GetSurface.</summary>
    /// <param name="size">An object representing the size of the composition surface.</param>
    [MethodImpl]
    public extern void SetSurfaceSize(Size size);

    /// <summary>Gets a MediaPlayerSurface object for the MediaPlayer, which allows you to render the player's contents using a Compositor without relying on the XAML framework.</summary>
    /// <param name="compositor">The Compositor with which the returned surface will be used.</param>
    /// <returns>The media player surface.</returns>
    [MethodImpl]
    public extern MediaPlayerSurface GetSurface(Compositor compositor);

    /// <summary>Applies a video effect to media playback.</summary>
    /// <param name="activatableClassId">The identifier of the effect.</param>
    /// <param name="effectOptional">Tue if the effect shouldn't block playback when the effect can't be used at run time. False if the effect should block playback when the effect can't be used at run time.</param>
    /// <param name="effectConfiguration">A property set that transmits property values to the effect specified by *effectID*.</param>
    [MethodImpl]
    public extern void AddVideoEffect(
      string activatableClassId,
      bool effectOptional,
      IPropertySet effectConfiguration);

    /// <summary>Occurs when IsVideoFrameServerEnabled is set to true and a new video frame is available for processing.</summary>
    public extern event TypedEventHandler<MediaPlayer, object> VideoFrameAvailable;

    /// <summary>Gets a value indicating whether video frame server mode is enabled for the **MediaPlayer** instance.</summary>
    /// <returns>True if video frame server mode is enabled; otherwise, false.</returns>
    public extern bool IsVideoFrameServerEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Copies the current video frame from the **MediaPlayer** to the provided **IDirect3DSurface**.</summary>
    /// <param name="destination">The **IDirect3DSurface** to which the video frame is copied.</param>
    [Overload("CopyFrameToVideoSurface")]
    [MethodImpl]
    public extern void CopyFrameToVideoSurface(IDirect3DSurface destination);

    /// <summary>Copies the current video frame from the **MediaPlayer** to the specified target rectangle within the provided **IDirect3DSurface**.</summary>
    /// <param name="destination">The **IDirect3DSurface** to which the video frame is copied.</param>
    /// <param name="targetRectangle">The target rectangle within the **IDirect3DSurface** to which the video frame is copied.</param>
    [Overload("CopyFrameToVideoSurfaceWithTargetRectangle")]
    [MethodImpl]
    public extern void CopyFrameToVideoSurface(IDirect3DSurface destination, Rect targetRectangle);

    /// <summary>Copies the video frame currently displayed by the **MediaPlayer** to the two provided **IDirect3DSurface** objects which represent the left eye and right eye content of a stereoscopic video frame.</summary>
    /// <param name="destinationLeftEye">The surface to which the left eye content is copied.</param>
    /// <param name="destinationRightEye">The surface to which the right eye content is copied.</param>
    [MethodImpl]
    public extern void CopyFrameToStereoscopicVideoSurfaces(
      IDirect3DSurface destinationLeftEye,
      IDirect3DSurface destinationRightEye);

    /// <summary>Occurs when the current subtitle content has changed while the MediaPlayer is in frame server mode.</summary>
    public extern event TypedEventHandler<MediaPlayer, object> SubtitleFrameChanged;

    /// <summary>Requests for the system to render the current subtitle text to the provided IDirect3DSurface.</summary>
    /// <param name="destination">The object that implements **IDirect3DSurface**  to which the subtitle text is rendered.</param>
    /// <returns>True if the system rendered subtitles to the surface; otherwise false.</returns>
    [Overload("RenderSubtitlesToSurface")]
    [MethodImpl]
    public extern bool RenderSubtitlesToSurface(IDirect3DSurface destination);

    /// <summary>Requests for the system to render the current subtitle text to the specified target rectangle within the provided IDirect3DSurface.</summary>
    /// <param name="destination">The object that implements **IDirect3DSurface**  to which the subtitle text is rendered.</param>
    /// <param name="targetRectangle">The rectangle within the provided surface within which the subtitles are rendered.</param>
    /// <returns>True if the system rendered subtitles to the surface; otherwise false.</returns>
    [Overload("RenderSubtitlesToSurfaceWithTargetRectangle")]
    [MethodImpl]
    public extern bool RenderSubtitlesToSurface(IDirect3DSurface destination, Rect targetRectangle);

    /// <summary>Gets an AudioStateMonitor object that allows a UWP app to determine if any of the app's audio streams are currently being muted or having their volume reduced by the system.</summary>
    /// <returns>An AudioStateMonitor object.</returns>
    public extern AudioStateMonitor AudioStateMonitor { [MethodImpl] get; }
  }
}
