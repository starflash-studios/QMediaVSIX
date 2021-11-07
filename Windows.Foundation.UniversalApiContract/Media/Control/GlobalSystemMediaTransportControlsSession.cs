// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.GlobalSystemMediaTransportControlsSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Control
{
  /// <summary>Represents a playback session from another app providing info about that session and possibly allowing control.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GlobalSystemMediaTransportControlsSession : 
    IGlobalSystemMediaTransportControlsSession
  {
    /// <summary>Gets the App user model Id of the source app of the session.</summary>
    /// <returns>The app user model id.</returns>
    public extern string SourceAppUserModelId { [MethodImpl] get; }

    /// <summary>Attempts to get the media properties for this session.</summary>
    /// <returns>GlobalSystemMediaTransportControlsSessionMediaProperties instance representing the session's current media item.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GlobalSystemMediaTransportControlsSessionMediaProperties> TryGetMediaPropertiesAsync();

    /// <summary>Gets the GlobalSystemMediaTransportControlsSessionTimelineProperties instance that represents this sessions timeline state.</summary>
    /// <returns>The object representing the timeline property values.</returns>
    [MethodImpl]
    public extern GlobalSystemMediaTransportControlsSessionTimelineProperties GetTimelineProperties();

    /// <summary>Gets the GlobalSystemMediaTransportControlsSessionPlaybackInfo for this session, accurate to the time of the call.</summary>
    /// <returns>The current playback info for this session.</returns>
    [MethodImpl]
    public extern GlobalSystemMediaTransportControlsSessionPlaybackInfo GetPlaybackInfo();

    /// <summary>Attempts to request the session to start playback.</summary>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryPlayAsync();

    /// <summary>Attempts to request the session to pause.</summary>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryPauseAsync();

    /// <summary>Attempts to request the session to stop playback.</summary>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryStopAsync();

    /// <summary>Attempts to request that the session starts recording.</summary>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRecordAsync();

    /// <summary>Attempts to put the session into a FastForward state.</summary>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryFastForwardAsync();

    /// <summary>Attempts to request the session to rewind.</summary>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRewindAsync();

    /// <summary>Attempts to request the session to skip next.</summary>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySkipNextAsync();

    /// <summary>Attempts to request the session to skip previous.</summary>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySkipPreviousAsync();

    /// <summary>Attempts to change the channel up on the session.</summary>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryChangeChannelUpAsync();

    /// <summary>Attempts to change the channel down on the session.</summary>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryChangeChannelDownAsync();

    /// <summary>Attempts to request the session to start or pause playback, based on its current playback state.</summary>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryTogglePlayPauseAsync();

    /// <summary>Attempts to change the MediaPlaybackAutoRepeatMode on the session.</summary>
    /// <param name="requestedAutoRepeatMode">The requested auto repeat mode.</param>
    /// <returns>Bool indicating success.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryChangeAutoRepeatModeAsync(
      MediaPlaybackAutoRepeatMode requestedAutoRepeatMode);

    /// <summary>Attempts to change the playback rate on the session to the requested value.</summary>
    /// <param name="requestedPlaybackRate">The requested playback rate to change to</param>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryChangePlaybackRateAsync(
      double requestedPlaybackRate);

    /// <summary>Attempts to change whether the session is actively shuffling or not.</summary>
    /// <param name="requestedShuffleState">The requested shuffle state to switch to.</param>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryChangeShuffleActiveAsync(
      bool requestedShuffleState);

    /// <summary>Attempts to change the playback position on the session to the requested value.</summary>
    /// <param name="requestedPlaybackPosition">The requested playback position to seek to.</param>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryChangePlaybackPositionAsync(
      long requestedPlaybackPosition);

    /// <summary>Occurs when the timeline properties of this session change.</summary>
    public extern event TypedEventHandler<GlobalSystemMediaTransportControlsSession, TimelinePropertiesChangedEventArgs> TimelinePropertiesChanged;

    /// <summary>Occurs when the session's playback info has changed.</summary>
    public extern event TypedEventHandler<GlobalSystemMediaTransportControlsSession, PlaybackInfoChangedEventArgs> PlaybackInfoChanged;

    /// <summary>Occurs when the session's MediaProperties have changed.</summary>
    public extern event TypedEventHandler<GlobalSystemMediaTransportControlsSession, MediaPropertiesChangedEventArgs> MediaPropertiesChanged;
  }
}
