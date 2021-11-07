// Decompiled with JetBrains decompiler
// Type: Windows.Media.SystemMediaTransportControls
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Represents an object that enables integrate with the system media transport controls and support for media commands.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  [Static(typeof (ISystemMediaTransportControlsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public sealed class SystemMediaTransportControls : 
    ISystemMediaTransportControls,
    ISystemMediaTransportControls2
  {
    /// <summary>Gets or sets the playback status of the media.</summary>
    /// <returns>The playback status.</returns>
    public extern MediaPlaybackStatus PlaybackStatus { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the display updater for the SystemMediaTransportControls which enable updating the information displayed about the currently playing song.</summary>
    /// <returns>The display updater for the SystemMediaTransportControls.</returns>
    public extern SystemMediaTransportControlsDisplayUpdater DisplayUpdater { [MethodImpl] get; }

    /// <summary>Gets the sound level of the media for the capture and render streams.</summary>
    /// <returns>The sound level.</returns>
    public extern SoundLevel SoundLevel { [MethodImpl] get; }

    /// <summary>Enables and disables the system media transport controls for the app.</summary>
    /// <returns>**true** if the system transport controls are enabled for the app; otherwise, **false**.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the play button is supported.</summary>
    /// <returns>**true** if the play is supported; otherwise, **false**.</returns>
    public extern bool IsPlayEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the stop button is supported.</summary>
    /// <returns>**true** if the stop button is supported; otherwise, **false**.</returns>
    public extern bool IsStopEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the pause button is supported.**true** if the pause button is supported; otherwise, **false**.</summary>
    /// <returns>**true** if the pause button is supported; otherwise, **false**.</returns>
    public extern bool IsPauseEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the record button is supported.**true** if the record button is supported; otherwise, **false**.</summary>
    /// <returns>**true** if the record button is supported; otherwise, **false**.</returns>
    public extern bool IsRecordEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the fast forward button is supported.</summary>
    /// <returns>**true** if the fast forward button is supported; otherwise, **false**.</returns>
    public extern bool IsFastForwardEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the rewind button is supported.</summary>
    /// <returns>**true** if the rewind button is supported; otherwise, **false**.</returns>
    public extern bool IsRewindEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the previous button is supported.</summary>
    /// <returns>**true** if the previous button is supported; otherwise, **false**.</returns>
    public extern bool IsPreviousEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the next button is supported.</summary>
    /// <returns>**true** if the next button is supported; otherwise, **false**.</returns>
    public extern bool IsNextEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the channel up button is supported.</summary>
    /// <returns>**true** if the channel up button is supported; otherwise, **false**.</returns>
    public extern bool IsChannelUpEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies if the channel down button is supported.</summary>
    /// <returns>**true** if the channel down button is supported; otherwise, **false**.</returns>
    public extern bool IsChannelDownEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a button is pressed on the SystemMediaTransportControls.</summary>
    public extern event TypedEventHandler<SystemMediaTransportControls, SystemMediaTransportControlsButtonPressedEventArgs> ButtonPressed;

    /// <summary>Occurs when a property on the SystemMediaTransportControls has changed.</summary>
    public extern event TypedEventHandler<SystemMediaTransportControls, SystemMediaTransportControlsPropertyChangedEventArgs> PropertyChanged;

    /// <summary>Gets or sets a value representing the current auto-repeat mode of the SystemMediaTransportControls.</summary>
    /// <returns>A value representing the current auto-repeat mode.</returns>
    public extern MediaPlaybackAutoRepeatMode AutoRepeatMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value representing the current shuffle state of the SystemMediaTransportControls.</summary>
    /// <returns>True if the SystemMediaTransportControls have shuffle enabled; otherwise, false.</returns>
    public extern bool ShuffleEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the playback rate of the SystemMediaTransportControls.</summary>
    /// <returns>The playback rate of the SystemMediaTransportControls.</returns>
    public extern double PlaybackRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Updates the SystemMediaTransportControls timeline properties with the values in the provided object.</summary>
    /// <param name="timelineProperties">The object representing the new timeline property values.</param>
    [MethodImpl]
    public extern void UpdateTimelineProperties(
      SystemMediaTransportControlsTimelineProperties timelineProperties);

    /// <summary>Occurs when the user modifies the playback position of the SystemMediaTransportControls.</summary>
    public extern event TypedEventHandler<SystemMediaTransportControls, PlaybackPositionChangeRequestedEventArgs> PlaybackPositionChangeRequested;

    /// <summary>Occurs when the user modifies the SystemMediaTransportControls playback rate.</summary>
    public extern event TypedEventHandler<SystemMediaTransportControls, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested;

    /// <summary>Occurs when the user modifies the SystemMediaTransportControls shuffle state.</summary>
    public extern event TypedEventHandler<SystemMediaTransportControls, ShuffleEnabledChangeRequestedEventArgs> ShuffleEnabledChangeRequested;

    /// <summary>Occurs when the user modifies the SystemMediaTransportControls auto-repeat mode.</summary>
    public extern event TypedEventHandler<SystemMediaTransportControls, AutoRepeatModeChangeRequestedEventArgs> AutoRepeatModeChangeRequested;

    /// <summary>The system media transport controls for the current view.</summary>
    /// <returns>The system media transport controls for the current view.</returns>
    [MethodImpl]
    public static extern SystemMediaTransportControls GetForCurrentView();
  }
}
