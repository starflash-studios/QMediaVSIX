#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Windows.Foundation;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Media.Control {
  [Guid(1900595253, 39700, 23266, 171, 133, 220, 155, 28, 20, 225, 168)]
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSession))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IGlobalSystemMediaTransportControlsSession {
    string SourceAppUserModelId { get; }

    [RemoteAsync]
    IAsyncOperation<GlobalSystemMediaTransportControlsSessionMediaProperties> TryGetMediaPropertiesAsync();

    GlobalSystemMediaTransportControlsSessionTimelineProperties GetTimelineProperties();

    GlobalSystemMediaTransportControlsSessionPlaybackInfo GetPlaybackInfo();

    [RemoteAsync]
    IAsyncOperation<bool> TryPlayAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryPauseAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryStopAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryRecordAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryFastForwardAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryRewindAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TrySkipNextAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TrySkipPreviousAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryChangeChannelUpAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryChangeChannelDownAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryTogglePlayPauseAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryChangeAutoRepeatModeAsync(
      MediaPlaybackAutoRepeatMode RequestedAutoRepeatMode );

    [RemoteAsync]
    IAsyncOperation<bool> TryChangePlaybackRateAsync( double RequestedPlaybackRate );

    [RemoteAsync]
    IAsyncOperation<bool> TryChangeShuffleActiveAsync( bool RequestedShuffleState );

    [RemoteAsync]
    IAsyncOperation<bool> TryChangePlaybackPositionAsync(
      long RequestedPlaybackPosition );

    event TypedEventHandler<GlobalSystemMediaTransportControlsSession, TimelinePropertiesChangedEventArgs> TimelinePropertiesChanged;

    event TypedEventHandler<GlobalSystemMediaTransportControlsSession, PlaybackInfoChangedEventArgs> PlaybackInfoChanged;

    event TypedEventHandler<GlobalSystemMediaTransportControlsSession, MediaPropertiesChangedEventArgs> MediaPropertiesChanged;
  }
}