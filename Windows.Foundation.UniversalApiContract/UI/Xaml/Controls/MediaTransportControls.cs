// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MediaTransportControls
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the playback controls for a media player element.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (IMediaTransportControlsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaTransportControlsStatics4), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaTransportControlsStatics3), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaTransportControlsStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaTransportControlsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class MediaTransportControls : 
    Control,
    IMediaTransportControls,
    IMediaTransportControls2,
    IMediaTransportControls3,
    IMediaTransportControls4
  {
    /// <summary>Initializes a new instance of the MediaTransportControls class.</summary>
    [MethodImpl]
    public extern MediaTransportControls();

    /// <summary>Gets or sets a value that indicates whether the full screen button is shown.</summary>
    /// <returns>**true** to show the full screen button. **false** to hide the full screen button. The default is **true**.</returns>
    public extern bool IsFullWindowButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can play the media in full-screen mode.</summary>
    /// <returns>**true** to allow the user to play the media in full-screen mode; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsFullWindowEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the zoom button is shown.</summary>
    /// <returns>**true** to show the zoom button. **false** to hide the zoom button. The default is **true**.</returns>
    public extern bool IsZoomButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can zoom the media.</summary>
    /// <returns>**true** to allow the user to zoom; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsZoomEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the fast forward button is shown.</summary>
    /// <returns>**true** to show the fast forward button. **false** to hide the fast forward button. The default is **false**.</returns>
    public extern bool IsFastForwardButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can fast forward the media.</summary>
    /// <returns>**true** to allow the user to fast forward; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsFastForwardEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the rewind button is shown.</summary>
    /// <returns>**true** to show the rewind button. **false** to hide the rewind button. The default is **false**.</returns>
    public extern bool IsFastRewindButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can rewind the media.</summary>
    /// <returns>**true** to allow the user to rewind; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsFastRewindEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the stop button is shown.</summary>
    /// <returns>**true** to show the stop button. **false** to hide the stop button. The default is **false**.</returns>
    public extern bool IsStopButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can stop the media playback.</summary>
    /// <returns>**true** to allow the user to stop playback; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsStopEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the volume button is shown.</summary>
    /// <returns>**true** to show the volume button. **false** to hide the volume button. The default is **true**.</returns>
    public extern bool IsVolumeButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can adjust the volume of the media.</summary>
    /// <returns>**true** to allow the user to adjust the volume; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsVolumeEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the playback rate button is shown.</summary>
    /// <returns>**true** to show the playback rate button. **false** to hide the playback rate button. The default is **false**.</returns>
    public extern bool IsPlaybackRateButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can adjust the playback rate of the media.</summary>
    /// <returns>**true** to allow the user to adjust the playback rate; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsPlaybackRateEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the seek bar is shown.</summary>
    /// <returns>**true** to show the seek bar. **false** to hide the seek bar. The default is **true**.</returns>
    public extern bool IsSeekBarVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can use the seek bar to find a location in the media.</summary>
    /// <returns>**true** to allow the user to use the seek bar to find a location; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsSeekEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether transport controls are shown on one row instead of two.</summary>
    /// <returns>**true** if the transport controls are shown in one row; **false** if the transport controls are shown in two rows. The default is **false**.</returns>
    public extern bool IsCompact { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the skip forward button is shown.</summary>
    /// <returns>**true** to show the skip forward button. **false** to hide the skip forward button. The default is **false**.</returns>
    public extern bool IsSkipForwardButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can skip forward in the media.</summary>
    /// <returns>**true** to allow the user to skip forward; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsSkipForwardEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the skip backward button is shown.</summary>
    /// <returns>**true** to show the skip backward button. **false** to hide the skip backward button. The default is **false**.</returns>
    public extern bool IsSkipBackwardButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can skip backward in the media.</summary>
    /// <returns>**true** to allow the user to skip backward; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsSkipBackwardEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the next track button is shown.</summary>
    /// <returns>**true** to show the next track button. **false** to hide the next track button. The default is **false**.</returns>
    public extern bool IsNextTrackButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the previous track button is shown.</summary>
    /// <returns>**true** to show the previous track button. **false** to hide the previous track button. The default is **false**.</returns>
    public extern bool IsPreviousTrackButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies how the fast-forward/fast-rewind buttons behave.</summary>
    /// <returns>A value of the enumeration that specifies how the fast-forward/fast-rewind buttons behave.</returns>
    public extern FastPlayFallbackBehaviour FastPlayFallbackBehaviour { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs whenever the app needs to display a thumbnail adjacent to the seek bar when the user performs a seek operation.</summary>
    public extern event TypedEventHandler<MediaTransportControls, MediaTransportControlsThumbnailRequestedEventArgs> ThumbnailRequested;

    /// <summary>Gets or sets a value that indicates whether the controls are shown and hidden automatically.</summary>
    /// <returns>**true** if the controls are shown and hidden automatically; otherwise, **false**. The default is **true**.</returns>
    public extern bool ShowAndHideAutomatically { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user repeat the playback of the media.</summary>
    /// <returns>**true** to allow the user to repeat the media; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsRepeatEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the repeat button is shown.</summary>
    /// <returns>**true** to show the repeat button. **false** to hide the repeat button. The default is **false**.</returns>
    public extern bool IsRepeatButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Shows the tranport controls if they're hidden.</summary>
    [MethodImpl]
    public extern void Show();

    /// <summary>Hides the transport controls if they're shown.</summary>
    [MethodImpl]
    public extern void Hide();

    /// <summary>Gets or sets a value that indicates whether the compact overlay button is shown.</summary>
    /// <returns>**true** to show the compact overlay button. **false** to hide the compact overlay button. The default is **false**.</returns>
    public extern bool IsCompactOverlayButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can enter compact overlay mode.</summary>
    /// <returns>**true** to allow the user to enter compact overlay mode; otherwise, **false**.</returns>
    public extern bool IsCompactOverlayEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsCompactOverlayButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsCompactOverlayButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsCompactOverlayButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsCompactOverlayEnabled dependency property.</summary>
    /// <returns>The identifier for the IsCompactOverlayEnabled dependency property.</returns>
    public static extern DependencyProperty IsCompactOverlayEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the ShowAndHideAutomatically dependency property.</summary>
    /// <returns>The identifier for the ShowAndHideAutomatically dependency property.</returns>
    public static extern DependencyProperty ShowAndHideAutomaticallyProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsRepeatEnabled dependency property.</summary>
    /// <returns>The identifier for the IsRepeatEnabled dependency property.</returns>
    public static extern DependencyProperty IsRepeatEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsRepeatButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsRepeatButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsRepeatButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSkipForwardButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsSkipForwardButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsSkipForwardButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSkipForwardEnabled dependency property.</summary>
    /// <returns>The identifier for the IsSkipForwardEnabled dependency property.</returns>
    public static extern DependencyProperty IsSkipForwardEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSkipBackwardButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsSkipBackwardButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsSkipBackwardButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSkipBackwardEnabled dependency property.</summary>
    /// <returns>The identifier for the IsSkipBackwardEnabled dependency property.</returns>
    public static extern DependencyProperty IsSkipBackwardEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsNextTrackButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsNextTrackButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsNextTrackButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsPreviousTrackButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsPreviousTrackButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsPreviousTrackButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the FastPlayFallbackBehaviour dependency property.</summary>
    /// <returns>The identifier for the FastPlayFallbackBehaviour dependency property.</returns>
    public static extern DependencyProperty FastPlayFallbackBehaviourProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFullWindowButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsFullWindowButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsFullWindowButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFullWindowEnabled dependency property.</summary>
    /// <returns>The identifier for the IsFullWindowEnabled dependency property.</returns>
    public static extern DependencyProperty IsFullWindowEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsZoomButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsZoomButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsZoomButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsZoomEnabled dependency property.</summary>
    /// <returns>The identifier for the IsZoomEnabled dependency property.</returns>
    public static extern DependencyProperty IsZoomEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFastForwardButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsFastForwardButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsFastForwardButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFastForwardEnabled dependency property.</summary>
    /// <returns>The identifier for the IsFastForwardEnabled dependency property.</returns>
    public static extern DependencyProperty IsFastForwardEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFastRewindButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsFastRewindButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsFastRewindButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFastRewindEnabled dependency property.</summary>
    /// <returns>The identifier for the IsFastRewindEnabled dependency property.</returns>
    public static extern DependencyProperty IsFastRewindEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsStopButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsStopButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsStopButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsStopEnabled dependency property.</summary>
    /// <returns>The identifier for the IsStopEnabled dependency property.</returns>
    public static extern DependencyProperty IsStopEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsVolumeButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsVolumeButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsVolumeButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsVolumeEnabled dependency property.</summary>
    /// <returns>The identifier for the IsVolumeEnabled dependency property.</returns>
    public static extern DependencyProperty IsVolumeEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsPlaybackRateButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsPlaybackRateButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsPlaybackRateButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsPlaybackRateEnabled dependency property.</summary>
    /// <returns>The identifier for the IsPlaybackRateEnabled dependency property.</returns>
    public static extern DependencyProperty IsPlaybackRateEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSeekBarVisible dependency property.</summary>
    /// <returns>The identifier for the IsSeekBarVisible dependency property.</returns>
    public static extern DependencyProperty IsSeekBarVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSeekEnabled dependency property.</summary>
    /// <returns>The identifier for the IsSeekEnabled dependency property.</returns>
    public static extern DependencyProperty IsSeekEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsCompact  dependency property.</summary>
    /// <returns>The identifier for the IsCompact   dependency property.</returns>
    public static extern DependencyProperty IsCompactProperty { [MethodImpl] get; }
  }
}
