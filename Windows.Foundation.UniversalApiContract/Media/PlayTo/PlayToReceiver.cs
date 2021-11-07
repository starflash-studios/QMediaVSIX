// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToReceiver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Represents a Play To target.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayToReceiver : IPlayToReceiver
  {
    /// <summary>Creates a new instance of a Play To receiver.</summary>
    [MethodImpl]
    public extern PlayToReceiver();

    /// <summary>Occurs when audio or video playback starts.</summary>
    public extern event TypedEventHandler<PlayToReceiver, object> PlayRequested;

    /// <summary>Occurs when audio or video playback has been paused.</summary>
    public extern event TypedEventHandler<PlayToReceiver, object> PauseRequested;

    /// <summary>Occurs when the source media for the Play To receiver have changed.</summary>
    public extern event TypedEventHandler<PlayToReceiver, SourceChangeRequestedEventArgs> SourceChangeRequested;

    /// <summary>Occurs when the rate of audio or video playback has changed.</summary>
    public extern event TypedEventHandler<PlayToReceiver, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested;

    /// <summary>Occurs when the time location of the playback has changed.</summary>
    public extern event TypedEventHandler<PlayToReceiver, CurrentTimeChangeRequestedEventArgs> CurrentTimeChangeRequested;

    /// <summary>Occurs when the audio has been muted or unmuted.</summary>
    public extern event TypedEventHandler<PlayToReceiver, MuteChangeRequestedEventArgs> MuteChangeRequested;

    /// <summary>Occurs when the volume for the source audio or video has changed.</summary>
    public extern event TypedEventHandler<PlayToReceiver, VolumeChangeRequestedEventArgs> VolumeChangeRequested;

    /// <summary>Occurs when the current playback position has changed.</summary>
    public extern event TypedEventHandler<PlayToReceiver, object> TimeUpdateRequested;

    /// <summary>Occurs when a request has been made for the Play To receiver to stop playing the streamed media.</summary>
    public extern event TypedEventHandler<PlayToReceiver, object> StopRequested;

    /// <summary>Notifies the Play To receiver that the volume of the audio or video playback has changed.</summary>
    /// <param name="volume">The new value for the volume.</param>
    /// <param name="mute">True if the volume was muted; otherwise false.</param>
    [MethodImpl]
    public extern void NotifyVolumeChange(double volume, bool mute);

    /// <summary>Notifies the Play To receiver that the rate of the audio or video playback has changed.</summary>
    /// <param name="rate">The new value of the playback rate.</param>
    [MethodImpl]
    public extern void NotifyRateChange(double rate);

    /// <summary>Notifies the Play To receiver that metadata for the media has finished loading.</summary>
    [MethodImpl]
    public extern void NotifyLoadedMetadata();

    [MethodImpl]
    public extern void NotifyTimeUpdate(TimeSpan currentTime);

    [MethodImpl]
    public extern void NotifyDurationChange(TimeSpan duration);

    /// <summary>Notifies the Play To receiver that the audio or video playback element is seeking a new playback location.</summary>
    [MethodImpl]
    public extern void NotifySeeking();

    /// <summary>Notifies the Play To receiver that the audio or video playback element has started at a new playback location.</summary>
    [MethodImpl]
    public extern void NotifySeeked();

    /// <summary>Notifies the Play To receiver that the audio or video playback has been paused.</summary>
    [MethodImpl]
    public extern void NotifyPaused();

    /// <summary>Notifies the Play To receiver that the audio or video playback has started.</summary>
    [MethodImpl]
    public extern void NotifyPlaying();

    /// <summary>Notifies the Play To receiver that the audio or video playback has ended.</summary>
    [MethodImpl]
    public extern void NotifyEnded();

    /// <summary>Notifies the Play To receiver that an error has occurred in displaying or playing the media.</summary>
    [MethodImpl]
    public extern void NotifyError();

    /// <summary>Notifies the Play To receiver that the audio or video playback has stopped.</summary>
    [MethodImpl]
    public extern void NotifyStopped();

    /// <summary>Gets or sets the display name of the Play To target.</summary>
    /// <returns>The display name of the Play To target.</returns>
    public extern string FriendlyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the Play To target supports images.</summary>
    /// <returns>True if the Play To target supports images; otherwise false.</returns>
    public extern bool SupportsImage { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the Play To target supports audio.</summary>
    /// <returns>True if the Play To target supports audio; otherwise false.</returns>
    public extern bool SupportsAudio { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the Play To target supports video.</summary>
    /// <returns>True if the Play To target supports video; otherwise false.</returns>
    public extern bool SupportsVideo { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a set of custom properties for the Play To receiver.</summary>
    /// <returns>A set of custom properties for the Play To receiver.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }

    /// <summary>Start receiving Play To commands.</summary>
    /// <returns>An asynchronous handler that's called when the start operation is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    /// <summary>Stop receiving Play To commands.</summary>
    /// <returns>An asynchronous handler that's called when the stop operation is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();
  }
}
