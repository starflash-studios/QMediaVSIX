// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MediaElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Casting;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Media.PlayTo;
using Windows.Media.Protection;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an object that renders audio and video to the display. See Remarks.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMediaElementStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MediaElement : FrameworkElement, IMediaElement, IMediaElement2, IMediaElement3
  {
    /// <summary>Instantiates a new instance of the MediaElement class.</summary>
    [MethodImpl]
    public extern MediaElement();

    /// <summary>Gets or sets the image source that is used for a placeholder image during MediaElement loading transition states.</summary>
    /// <returns>An image source for a transition ImageBrush that is applied to the MediaElement content area.</returns>
    public extern ImageSource PosterSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a media source on the MediaElement.</summary>
    /// <returns>The source of the element, as an object describing a Uniform Resource Identifier (URI). The default is **null**.</returns>
    public extern Uri Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether the audio is muted.</summary>
    /// <returns>**true** if audio is muted; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsMuted { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that reports whether the current source media is an audio-only media file.</summary>
    /// <returns>**true** if the current source media is audio-only, otherwise, **false**.</returns>
    public extern bool IsAudioOnly { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether media will begin playback automatically when the Source property is set.</summary>
    /// <returns>**true** if playback is automatic; otherwise, **false**. The default is **true**.</returns>
    public extern bool AutoPlay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the media's volume.</summary>
    /// <returns>The media's volume represented on a linear scale between 0 and 1. The default is 0.5.</returns>
    public extern double Volume { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a ratio of volume across stereo speakers.</summary>
    /// <returns>The ratio of volume across speakers in the range between -1 and 1. The default value is 0.</returns>
    public extern double Balance { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the height of the video associated with the media.</summary>
    /// <returns>The height of the video that is associated with the media, in pixels. Audio files return 0. The default is 0.</returns>
    public extern int NaturalVideoHeight { [MethodImpl] get; }

    /// <summary>Gets the width of the video associated with the media.</summary>
    /// <returns>The width of the video associated with the media. The default is 0.</returns>
    public extern int NaturalVideoWidth { [MethodImpl] get; }

    /// <summary>Gets the duration of the media file currently opened.</summary>
    /// <returns>The natural duration of the media. The default value is a Duration structure that evaluates as Automatic, which is the value held if you query this property before MediaOpened.</returns>
    public extern Duration NaturalDuration { [MethodImpl] get; }

    /// <summary>Gets or sets the current position of progress through the media's playback time.</summary>
    /// <returns>The amount of time since the beginning of the media. The default is a **TimeSpan** with value "0:0:0".</returns>
    public extern TimeSpan Position { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates the amount of download completed for content located on a remote server.</summary>
    /// <returns>A value that indicates the amount of download completed for content that is located on a remote server. The value ranges from 0 to 1. Multiply by 100 to obtain a percentage.</returns>
    public extern double DownloadProgress { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the current buffering progress.</summary>
    /// <returns>The amount of buffering that is completed for media content. The value ranges from 0 to 1. Multiply by 100 to obtain a percentage.</returns>
    public extern double BufferingProgress { [MethodImpl] get; }

    /// <summary>Gets the offset of download progress, which is relevant in seek-ahead scenarios.</summary>
    /// <returns>The offset of download progress.</returns>
    public extern double DownloadProgressOffset { [MethodImpl] get; }

    /// <summary>Gets the status of this MediaElement.</summary>
    /// <returns>The current state of this MediaElement. The state can be one of the following (as defined in the MediaElementState enumeration): **Buffering**, **Closed**, **Opening**, **Paused**, **Playing**, or **Stopped**. The default value is **Closed**.</returns>
    public extern MediaElementState CurrentState { [MethodImpl] get; }

    /// <summary>Gets the collection of timeline markers associated with the currently loaded media file.</summary>
    /// <returns>The collection of timeline markers (represented as TimelineMarker objects) associated with the currently loaded media file. The default is an empty collection.</returns>
    public extern TimelineMarkerCollection Markers { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether media can be repositioned by setting the value of the Position property.</summary>
    /// <returns>**true** if the media can be repositioned; otherwise, **false**.</returns>
    public extern bool CanSeek { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether media can be paused if the Pause method is called.</summary>
    /// <returns>**true** if the media can be paused; otherwise, **false**.</returns>
    public extern bool CanPause { [MethodImpl] get; }

    /// <summary>Gets the number of audio streams that exist in the current media file.</summary>
    /// <returns>The number of audio streams that exist in the source media file. The default value is 0.</returns>
    public extern int AudioStreamCount { [MethodImpl] get; }

    /// <summary>Gets or sets the index of the audio stream that plays along with the video component. The collection of audio streams is composed at run time and represents all audio streams that are available in the media file.</summary>
    /// <returns>The index in the media file of the audio component that plays along with the video component. The index can be unspecified, in which case the value is null. The default value is null.</returns>
    public extern IReference<int> AudioStreamIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the playback rate ratio for the media engine.</summary>
    /// <returns>The playback rate ratio for the media. A value of 1.0 is the normal playback speed. Value can be negative to play backwards.</returns>
    public extern double PlaybackRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that describes whether the media source currently loaded in the media engine should automatically set the position to the media start after reaching its end.</summary>
    /// <returns>**true** to loop the media and play continuously. **false** to not loop the media automatically. The default is **false**.</returns>
    public extern bool IsLooping { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the information that is transmitted if the MediaElement is used for a "PlayTo" scenario.</summary>
    /// <returns>A reference object that carries the "PlayTo" source information.</returns>
    public extern PlayToSource PlayToSource { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets the default playback rate for the media engine. The playback rate applies when the user isn't using fast forward or reverse.</summary>
    /// <returns>The default playback rate. The default is 1.0, which indicates normal playback speed.</returns>
    public extern double DefaultPlaybackRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the width portion of the native aspect ratio of the media.</summary>
    /// <returns>The width portion of the native aspect ratio of the media. This value holds meaning only when you compare it with the value for the AspectRatioHeight property; the two properties together describe the aspect ratio.</returns>
    public extern int AspectRatioWidth { [MethodImpl] get; }

    /// <summary>Gets the height portion of the native aspect ratio of the media.</summary>
    /// <returns>The height portion of the native aspect ratio of the media. This value holds meaning only when you compare it with the value for the AspectRatioWidth property; the two properties together describe the aspect ratio.</returns>
    public extern int AspectRatioHeight { [MethodImpl] get; }

    /// <summary>Gets or sets a value that configures the MediaElement for real-time communications scenarios.</summary>
    /// <returns>**true** to configure for real-time communications. **false** to not configure the MediaElement for real-time communications.</returns>
    public extern bool RealTimePlayback { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that describes the purpose of the audio information in an audio stream.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern AudioCategory AudioCategory { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that describes the primary usage of the device that is being used to play back audio.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern AudioDeviceType AudioDeviceType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the dedicated object for media content protection that is associated with this MediaElement.</summary>
    /// <returns>The dedicated object for media content protection.</returns>
    public extern MediaProtectionManager ProtectionManager { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an enumeration value that determines the stereo 3-D video frame-packing mode for the current media source.</summary>
    /// <returns>A value of the enumeration. See Remarks.</returns>
    public extern Stereo3DVideoPackingMode Stereo3DVideoPackingMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an enumeration value that determines the stereo 3-D video render mode for the current media source.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern Stereo3DVideoRenderMode Stereo3DVideoRenderMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that reports whether the current source media is a stereo 3-D video media file.</summary>
    /// <returns>**true** if the current source media is stereo 3-D video, otherwise, **false**.</returns>
    public extern bool IsStereo3DVideo { [MethodImpl] get; }

    /// <summary>Occurs when the media stream has been validated and opened, and the file headers have been read.</summary>
    public extern event RoutedEventHandler MediaOpened;

    /// <summary>Occurs when the MediaElement finishes playing audio or video.</summary>
    public extern event RoutedEventHandler MediaEnded;

    /// <summary>Occurs when there is an error associated with the media Source.</summary>
    public extern event ExceptionRoutedEventHandler MediaFailed;

    /// <summary>Occurs when the DownloadProgress property has changed.</summary>
    public extern event RoutedEventHandler DownloadProgressChanged;

    /// <summary>Occurs when the BufferingProgress property changes.</summary>
    public extern event RoutedEventHandler BufferingProgressChanged;

    /// <summary>Occurs when the value of the CurrentState property changes.</summary>
    public extern event RoutedEventHandler CurrentStateChanged;

    /// <summary>Occurs when a timeline marker is encountered during media playback.</summary>
    public extern event TimelineMarkerRoutedEventHandler MarkerReached;

    /// <summary>Occurs when PlaybackRate or DefaultPlaybackRate value changes.</summary>
    public extern event RateChangedRoutedEventHandler RateChanged;

    /// <summary>Occurs when the value of the Volume property changes.</summary>
    public extern event RoutedEventHandler VolumeChanged;

    /// <summary>Occurs when the seek point of a requested seek operation is ready for playback. </summary>
    public extern event RoutedEventHandler SeekCompleted;

    /// <summary>Stops and resets media to be played from the beginning.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Plays media from the current position.</summary>
    [MethodImpl]
    public extern void Play();

    /// <summary>Pauses media at the current position.</summary>
    [MethodImpl]
    public extern void Pause();

    /// <summary>Returns an enumeration value that describes the likelihood that the current MediaElement and its client configuration can play that media source.</summary>
    /// <param name="type">A string that describes the desired type as a MIME string.</param>
    /// <returns>A value of the enumeration that describes the likelihood that the current media engine can play the source.</returns>
    [MethodImpl]
    public extern MediaCanPlayResponse CanPlayType(string type);

    /// <summary>Sets the Source property using the specified stream and MIME type.</summary>
    /// <param name="stream">The stream that contains the media to load.</param>
    /// <param name="mimeType">The MIME type of the media resource, expressed as the string form typically seen in HTTP headers and requests. The empty string "" can be passed in as the *mimeType* value if the MIME type is unknown.</param>
    [MethodImpl]
    public extern void SetSource(IRandomAccessStream stream, string mimeType);

    [MethodImpl]
    public extern string GetAudioStreamLanguage(IReference<int> index);

    /// <summary>Applies an audio effect to playback. Takes effect for the next source that is set on this MediaElement.</summary>
    /// <param name="effectID">The identifier for the desired effect.</param>
    /// <param name="effectOptional">**true** if the effect shouldn't block playback when the effect can't be used at run time. **false** if the effect should block playback when the effect can't be used at run time.</param>
    /// <param name="effectConfiguration">A property set that transmits property values to specific effects as selected by *effectID*.</param>
    [MethodImpl]
    public extern void AddAudioEffect(
      string effectID,
      bool effectOptional,
      IPropertySet effectConfiguration);

    /// <summary>Applies a video effect to playback. Takes effect for the next source that is set on this MediaElement.</summary>
    /// <param name="effectID">The identifier for the desired effect.</param>
    /// <param name="effectOptional">**true** if the effect shouldn't block playback when the effect can't be used at run time. **false** if the effect should block playback when the effect can't be used at run time.</param>
    /// <param name="effectConfiguration">A property set that transmits property values to specific effects as selected by *effectID*.</param>
    [MethodImpl]
    public extern void AddVideoEffect(
      string effectID,
      bool effectOptional,
      IPropertySet effectConfiguration);

    /// <summary>Removes all effects for the next source set for this MediaElement.</summary>
    [MethodImpl]
    public extern void RemoveAllEffects();

    /// <summary>Gets an enumeration value that determines the current value of stereo 3-D video frame-packing mode, accounting for other factors such as whether the media engine is ready for use.</summary>
    /// <returns>A value of the enumeration. May be **None** if media engine is not ready for use.</returns>
    public extern Stereo3DVideoPackingMode ActualStereo3DVideoPackingMode { [MethodImpl] get; }

    /// <summary>Gets or sets a value that determines whether the standard transport controls are enabled.</summary>
    /// <returns>**true** if the standard transport controls are enabled; otherwise, **false**. The default is **false**.</returns>
    public extern bool AreTransportControlsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that describes how an MediaElement should be stretched to fill the destination rectangle.</summary>
    /// <returns>A value of the Stretch enumeration that specifies how the source visual media is rendered. The default value is **Uniform**.</returns>
    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that specifies if the MediaElement is rendering in full window mode. Setting this property enables or disables full window rendering.</summary>
    /// <returns>**true** if the MediaElement is in full window mode; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsFullWindow { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Sets the Source of the MediaElement to the specified MediaStreamSource.</summary>
    /// <param name="source">The media source.</param>
    [MethodImpl]
    public extern void SetMediaStreamSource(IMediaSource source);

    /// <summary>Gets or sets the path to the preferred media source which enables the Play To target device to stream the media content, which can be DRM protected, from a different location, such as a cloud media server.</summary>
    /// <returns>The path to the preferred media source.</returns>
    public extern Uri PlayToPreferredSourceUri { [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the transport controls for the media.</summary>
    /// <returns>The transport controls for the media.</returns>
    public extern MediaTransportControls TransportControls { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when one or more streams fails to decode in content containing multiple streams.</summary>
    public extern event TypedEventHandler<MediaElement, PartialMediaFailureDetectedEventArgs> PartialMediaFailureDetected;

    /// <summary>Sets the source of the MediaElement to the specified media playback source.</summary>
    /// <param name="source">The media playback source.</param>
    [MethodImpl]
    public extern void SetPlaybackSource(IMediaPlaybackSource source);

    /// <summary>Returns the media element as a CastingSource.</summary>
    /// <returns>The media element as a CastingSource.</returns>
    [MethodImpl]
    public extern CastingSource GetAsCastingSource();

    /// <summary>Identifies the AreTransportControlsEnabled dependency property.</summary>
    /// <returns>The identifier for the AreTransportControlsEnabled dependency property.</returns>
    public static extern DependencyProperty AreTransportControlsEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the Stretch dependency property.</summary>
    /// <returns>The identifier for the Stretch dependency property.</returns>
    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFullWindow dependency property.</summary>
    /// <returns>The identifier for the IsFullWindow dependency property.</returns>
    public static extern DependencyProperty IsFullWindowProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlayToPreferredSourceUri dependency property.</summary>
    /// <returns>The identifier for the PlayToPreferredSourceUri dependency property.</returns>
    public static extern DependencyProperty PlayToPreferredSourceUriProperty { [Deprecated("PlayToPreferredSourceUri may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource().PreferredSourceUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the PosterSource dependency property.</summary>
    /// <returns>The identifier for the PosterSource dependency property.</returns>
    public static extern DependencyProperty PosterSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the Source  dependency property.</summary>
    /// <returns>The identifier for the Source dependency property.</returns>
    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsMuted  dependency property.</summary>
    /// <returns>The identifier for the IsMuted dependency property.</returns>
    public static extern DependencyProperty IsMutedProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsAudioOnly dependency property.</summary>
    /// <returns>The identifier for the IsAudioOnly dependency property.</returns>
    public static extern DependencyProperty IsAudioOnlyProperty { [MethodImpl] get; }

    /// <summary>Identifies the AutoPlay dependency property.</summary>
    /// <returns>The identifier for the AutoPlay dependency property.</returns>
    public static extern DependencyProperty AutoPlayProperty { [MethodImpl] get; }

    /// <summary>Identifies the Volume  dependency property.</summary>
    /// <returns>The identifier for the Volume dependency property.</returns>
    public static extern DependencyProperty VolumeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Balance  dependency property.</summary>
    /// <returns>The identifier for the Balance dependency property.</returns>
    public static extern DependencyProperty BalanceProperty { [MethodImpl] get; }

    /// <summary>Identifies the NaturalVideoHeight dependency property.</summary>
    /// <returns>The identifier for the NaturalVideoHeight dependency property.</returns>
    public static extern DependencyProperty NaturalVideoHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the NaturalVideoWidth dependency property.</summary>
    /// <returns>The identifier for the NaturalVideoWidth dependency property.</returns>
    public static extern DependencyProperty NaturalVideoWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the NaturalDuration dependency property.</summary>
    /// <returns>The identifier for the NaturalDuration dependency property.</returns>
    public static extern DependencyProperty NaturalDurationProperty { [MethodImpl] get; }

    /// <summary>Identifies the Position dependency property.</summary>
    /// <returns>The identifier the Position dependency property.</returns>
    public static extern DependencyProperty PositionProperty { [MethodImpl] get; }

    /// <summary>Identifies the DownloadProgress dependency property.</summary>
    /// <returns>The identifier for the DownloadProgress dependency property.</returns>
    public static extern DependencyProperty DownloadProgressProperty { [MethodImpl] get; }

    /// <summary>Identifies the BufferingProgress dependency property.</summary>
    /// <returns>The identifier for the BufferingProgress dependency property.</returns>
    public static extern DependencyProperty BufferingProgressProperty { [MethodImpl] get; }

    /// <summary>Identifies the DownloadProgressOffset dependency property.</summary>
    /// <returns>The identifier for the DownloadProgressOffset dependency property.</returns>
    public static extern DependencyProperty DownloadProgressOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the CurrentState dependency property.</summary>
    /// <returns>The identifier for the CurrentState dependency property.</returns>
    public static extern DependencyProperty CurrentStateProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanSeek dependency property.</summary>
    /// <returns>The identifier for the CanSeek dependency property.</returns>
    public static extern DependencyProperty CanSeekProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanPause dependency property.</summary>
    /// <returns>The identifier for the CanPause dependency property.</returns>
    public static extern DependencyProperty CanPauseProperty { [MethodImpl] get; }

    /// <summary>Identifies the AudioStreamCount dependency property.</summary>
    /// <returns>The identifier for the AudioStreamCount dependency property.</returns>
    public static extern DependencyProperty AudioStreamCountProperty { [MethodImpl] get; }

    /// <summary>Identifies the AudioStreamIndex dependency property.</summary>
    /// <returns>The identifier for the AudioStreamIndex dependency property.</returns>
    public static extern DependencyProperty AudioStreamIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaybackRate  dependency property.</summary>
    /// <returns>The identifier for the PlaybackRate dependency property.</returns>
    public static extern DependencyProperty PlaybackRateProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsLooping dependency property.</summary>
    /// <returns>The identifier for the IsLooping dependency property.</returns>
    public static extern DependencyProperty IsLoopingProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlayToSource dependency property.</summary>
    /// <returns>The identifier for the PlayToSource dependency property.</returns>
    public static extern DependencyProperty PlayToSourceProperty { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the DefaultPlaybackRate  dependency property.</summary>
    /// <returns>The identifier for the DefaultPlaybackRate dependency property.</returns>
    public static extern DependencyProperty DefaultPlaybackRateProperty { [MethodImpl] get; }

    /// <summary>Identifies the AspectRatioWidth  dependency property.</summary>
    /// <returns>The identifier for the AspectRatioWidth dependency property.</returns>
    public static extern DependencyProperty AspectRatioWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the AspectRatioHeight  dependency property.</summary>
    /// <returns>The identifier for the AspectRatioHeight dependency property.</returns>
    public static extern DependencyProperty AspectRatioHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the RealTimePlayback dependency property.</summary>
    /// <returns>The identifier for the RealTimePlayback dependency property.</returns>
    public static extern DependencyProperty RealTimePlaybackProperty { [MethodImpl] get; }

    /// <summary>Identifies the AudioCategory dependency property.</summary>
    /// <returns>The identifier for the AudioCategory dependency property.</returns>
    public static extern DependencyProperty AudioCategoryProperty { [MethodImpl] get; }

    /// <summary>Identifies the AudioDeviceType dependency property.</summary>
    /// <returns>The identifier for the AudioDeviceType dependency property.</returns>
    public static extern DependencyProperty AudioDeviceTypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the ProtectionManager dependency property.</summary>
    /// <returns>The identifier for the ProtectionManager dependency property.</returns>
    public static extern DependencyProperty ProtectionManagerProperty { [MethodImpl] get; }

    /// <summary>Identifies the Stereo3DVideoPackingMode dependency property.</summary>
    /// <returns>The identifier for the Stereo3DVideoPackingMode dependency property.</returns>
    public static extern DependencyProperty Stereo3DVideoPackingModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Stereo3DVideoRenderMode dependency property.</summary>
    /// <returns>The identifier for the Stereo3DVideoRenderMode dependency property.</returns>
    public static extern DependencyProperty Stereo3DVideoRenderModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsStereo3DVideo dependency property.</summary>
    /// <returns>The identifier for the IsStereo3DVideo dependency property.</returns>
    public static extern DependencyProperty IsStereo3DVideoProperty { [MethodImpl] get; }

    /// <summary>Identifies the ActualStereo3DVideoPackingMode dependency property.</summary>
    /// <returns>The identifier for the ActualStereo3DVideoPackingMode dependency property.</returns>
    public static extern DependencyProperty ActualStereo3DVideoPackingModeProperty { [MethodImpl] get; }
  }
}
