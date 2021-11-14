#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Collections.ObjectModel;

using Windows.Media;
using Windows.Storage.Streams;

#endregion

namespace QMediaVSIX.Core.MediaSource.Software;

public interface IMediaSession {

	#region Timeline Properties

	/// <inheritdoc cref="WMCTimelineProperties.EndTime"/>
	TimeSpan EndTime { get; }

	/// <inheritdoc cref="WMCTimelineProperties.LastUpdatedTime"/>
	DateTimeOffset LastUpdatedTime { get; }

	/// <inheritdoc cref="WMCTimelineProperties.MaxSeekTime"/>
	TimeSpan MaxSeekTime { get; }

	/// <inheritdoc cref="WMCTimelineProperties.MinSeekTime"/>
	TimeSpan MinSeekTime { get; }

	/// <inheritdoc cref="WMCTimelineProperties.Position"/>
	TimeSpan Position { get; set; }

	#endregion

	#region PlaybackInfo Properties

	/// <inheritdoc cref="WMCPlaybackInfo.AutoRepeatMode"/>
	MediaPlaybackAutoRepeatMode? AutoRepeatMode { get; set; }

	/// <inheritdoc cref="WMCPlaybackInfo.IsShuffleActive"/>
	bool? IsShuffleActive { get; set; }

	/// <inheritdoc cref="WMCPlaybackInfo.PlaybackRate"/>
	double? PlaybackRate { get; set; }

	/// <inheritdoc cref="WMCPlaybackInfo.PlaybackStatus"/>
	WMCPlaybackStatus PlaybackStatus { get; set; }

	/// <inheritdoc cref="WMCPlaybackInfo.PlaybackType"/>
	MediaPlaybackType? PlaybackType { get; }

	#endregion

	#region PlaybackInfo.Controls Properties

	/// <inheritdoc cref="WMCPlaybackControls.IsChannelDownEnabled"/>
	bool IsChannelDownEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsChannelUpEnabled"/>
	bool IsChannelUpEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsFastForwardEnabled"/>
	bool IsFastForwardEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsNextEnabled"/>
	bool IsNextEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsPauseEnabled"/>
	bool IsPauseEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsPlaybackPositionEnabled"/>
	bool IsPlaybackPositionEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsPlaybackRateEnabled"/>
	bool IsPlaybackRateEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsPlayEnabled"/>
	bool IsPlayEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsPreviousEnabled"/>
	bool IsPreviousEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsRecordEnabled"/>
	bool IsRecordEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsRepeatEnabled"/>
	bool IsRepeatEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsRewindEnabled"/>
	bool IsRewindEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsShuffleEnabled"/>
	bool IsShuffleEnabled { get; }

	/// <inheritdoc cref="WMCPlaybackControls.IsStopEnabled"/>
	bool IsStopEnabled { get; }

	#endregion

	#region Media Properties

	/// <inheritdoc cref="WMCMediaProperties.AlbumArtist"/>
	string AlbumArtist { get; }

	/// <inheritdoc cref="WMCMediaProperties.AlbumTitle"/>
	string AlbumTitle { get; }

	/// <inheritdoc cref="WMCMediaProperties.AlbumTrackCount"/>
	int AlbumTrackCount { get; }

	/// <inheritdoc cref="WMCMediaProperties.Artist"/>
	string Artist { get; }

	/// <inheritdoc cref="WMCMediaProperties.Genres"/>
	ObservableCollection<string> Genres { get; }

	/// <inheritdoc cref="WMCMediaProperties.Subtitle"/>
	string Subtitle { get; }

	/// <inheritdoc cref="WMCMediaProperties.Thumbnail"/>
	IRandomAccessStreamReference? Thumbnail { get; }

	/// <inheritdoc cref="WMCMediaProperties.Title"/>
	string Title { get; }

	/// <inheritdoc cref="WMCMediaProperties.TrackNumber"/>
	int TrackNumber { get; }

	#endregion

	#region Method Invocations

	/// <inheritdoc cref="WMCSession.TryChangePlaybackPositionAsync(long)"/>
	/// <param name="Position"><inheritdoc cref="WMCSession.TryChangePlaybackPositionAsync(long)"/></param>
	void SetPosition( long Position );

	/// <inheritdoc cref="WMCSession.TryChangeChannelDownAsync()"/>
	void ChannelDown();

	/// <inheritdoc cref="WMCSession.TryChangeChannelUpAsync()"/>
	void ChannelUp();

	/// <inheritdoc cref="WMCSession.TryFastForwardAsync()"/>
	void FastForward();

	/// <inheritdoc cref="WMCSession.TryRecordAsync()"/>
	void Record();

	/// <inheritdoc cref="WMCSession.TryRewindAsync()"/>
	void Rewind();

	/// <inheritdoc cref="WMCSession.TrySkipNextAsync()"/>
	void SkipNext();

	/// <inheritdoc cref="WMCSession.TrySkipPreviousAsync()"/>
	void SkipPrevious();

	/// <inheritdoc cref="WMCSession.TryPlayAsync()"/>
	void Play();

	/// <inheritdoc cref="WMCSession.TryPauseAsync()"/>
	void Pause();

	/// <inheritdoc cref="WMCSession.TryStopAsync()"/>
	void Stop();

	/// <inheritdoc cref="WMCSession.TryTogglePlayPauseAsync()"/>
	void TogglePlayPause();

	#endregion
}