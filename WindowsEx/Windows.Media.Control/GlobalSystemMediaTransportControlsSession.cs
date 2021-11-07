#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Media.Control {
  /// <summary>Represents a playback session from another app providing info about that session and possibly allowing control.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(Version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GlobalSystemMediaTransportControlsSession :
    IGlobalSystemMediaTransportControlsSession {
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
    /// <param name="RequestedAutoRepeatMode">The requested auto repeat mode.</param>
    /// <returns>Bool indicating success.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryChangeAutoRepeatModeAsync(
      MediaPlaybackAutoRepeatMode RequestedAutoRepeatMode );

    /// <summary>Attempts to change the playback rate on the session to the requested value.</summary>
    /// <param name="RequestedPlaybackRate">The requested playback rate to change to</param>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryChangePlaybackRateAsync(
      double RequestedPlaybackRate );

    /// <summary>Attempts to change whether the session is actively shuffling or not.</summary>
    /// <param name="RequestedShuffleState">The requested shuffle state to switch to.</param>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryChangeShuffleActiveAsync(
      bool RequestedShuffleState );

    /// <summary>Attempts to change the playback position on the session to the requested value.</summary>
    /// <param name="RequestedPlaybackPosition">The requested playback position to seek to.</param>
    /// <returns>True indicates success; False otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryChangePlaybackPositionAsync(
      long RequestedPlaybackPosition );

    /// <summary>Occurs when the timeline properties of this session change.</summary>
    public extern event TypedEventHandler<GlobalSystemMediaTransportControlsSession, TimelinePropertiesChangedEventArgs> TimelinePropertiesChanged;

    /// <summary>Occurs when the session's playback info has changed.</summary>
    public extern event TypedEventHandler<GlobalSystemMediaTransportControlsSession, PlaybackInfoChangedEventArgs> PlaybackInfoChanged;

    /// <summary>Occurs when the session's MediaProperties have changed.</summary>
    public extern event TypedEventHandler<GlobalSystemMediaTransportControlsSession, MediaPropertiesChangedEventArgs> MediaPropertiesChanged;
  }
}