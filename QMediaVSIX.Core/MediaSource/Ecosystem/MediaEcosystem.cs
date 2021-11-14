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

using CSCore.CoreAudioAPI;

using QMediaVSIX.Core.Collections;
using QMediaVSIX.Core.MediaSource.Hardware;
using QMediaVSIX.Core.MediaSource.Software;

#endregion

namespace QMediaVSIX.Core.MediaSource.Ecosystem;

public class MediaEcosystem : NotifyPropertyChange, IMediaEcosystem {
	public MediaSession Session { get; }
	public MediaDevice Device { get; }
	public int ProcessId { get; }

	public MediaEcosystem( int ProcessId, MediaSession Session, MediaDevice Device ) {
		this.ProcessId = ProcessId;
		this.Session = Session;
		this.Device = Device;

		Identifier = GetIdentifier(Session, Device);
	}

	public override string ToString() => $"[{Session},{Device}]";

	public static Guid GetIdentifier( WMCSession Session, AudioSessionControl2 Control2 ) => MediaSession.GetIdentifier(Session).Combine(MediaDevice.GetIdentifier(Control2));
	public static Guid GetIdentifier( MediaSession Session, MediaDevice Device ) => Session.Identifier.Combine(Device.Identifier);
	public readonly Guid Identifier;

	#region IMediaDevice Implementation

	#region Volume Property

	//float _Volume;
	public float Volume {
		//get => _Volume;
		//set => SetValue(ref _Volume, value);
		get => Device.Volume;
		set => Device.Volume = value;
	}

	#endregion

	#region Mute Property

	//bool _Mute;
	public bool Mute {
		//get => _Mute;
		//set => SetValue(ref _Mute, value);
		get => Device.Mute;
		set => Device.Mute = value;
	}

	#endregion

	#region Flow Property

	public DataFlow Flow {
		get => Device.Flow;
		set => Device.Flow = value;
	}

	#endregion

	#region Role Property

	public Role Role {
		get => Device.Role;
		set => Device.Role = value;
	}

	#endregion

	#endregion

	#region IMediaSession Implementation

	#region Timeline Properties

	/// <inheritdoc/>
	public TimeSpan EndTime => Session.EndTime;

	/// <inheritdoc/>
	public DateTimeOffset LastUpdatedTime => Session.LastUpdatedTime;

	/// <inheritdoc/>
	public TimeSpan MaxSeekTime => Session.MaxSeekTime;

	/// <inheritdoc/>
	public TimeSpan MinSeekTime => Session.MinSeekTime;

	/// <inheritdoc/>
	public TimeSpan Position {
		get => Session.Position;
		set => Session.Position = value;
	}

	#endregion

	#region PlaybackInfo Properties

	/// <inheritdoc/>
	public MediaPlaybackAutoRepeatMode? AutoRepeatMode {
		get => Session.AutoRepeatMode;
		set => Session.AutoRepeatMode = value;
	}

	/// <inheritdoc/>
	public bool? IsShuffleActive {
		get => Session.IsShuffleActive;
		set => Session.IsShuffleActive = value;
	}

	/// <inheritdoc/>
	public double? PlaybackRate {
		get => Session.PlaybackRate;
		set => Session.PlaybackRate = value;
	}

	/// <inheritdoc/>
	public WMCPlaybackStatus PlaybackStatus {
		get => Session.PlaybackStatus;
		set => Session.PlaybackStatus = value;
	}

	/// <inheritdoc/>
	public MediaPlaybackType? PlaybackType => Session.PlaybackType;

	#endregion

	#region PlaybackInfo.Controls Properties

	/// <inheritdoc/>
	public bool IsChannelDownEnabled => Session.IsChannelDownEnabled;

	/// <inheritdoc/>
	public bool IsChannelUpEnabled => Session.IsChannelUpEnabled;

	/// <inheritdoc/>
	public bool IsFastForwardEnabled => Session.IsFastForwardEnabled;

	/// <inheritdoc/>
	public bool IsNextEnabled => Session.IsNextEnabled;

	/// <inheritdoc/>
	public bool IsPauseEnabled => Session.IsPauseEnabled;

	/// <inheritdoc/>
	public bool IsPlaybackPositionEnabled => Session.IsPlaybackPositionEnabled;

	/// <inheritdoc/>
	public bool IsPlaybackRateEnabled => Session.IsPlaybackRateEnabled;

	/// <inheritdoc/>
	public bool IsPlayEnabled => Session.IsPlayEnabled;

	/// <inheritdoc/>
	public bool IsPreviousEnabled => Session.IsPreviousEnabled;

	/// <inheritdoc/>
	public bool IsRecordEnabled => Session.IsRecordEnabled;

	/// <inheritdoc/>
	public bool IsRepeatEnabled => Session.IsRepeatEnabled;

	/// <inheritdoc/>
	public bool IsRewindEnabled => Session.IsRewindEnabled;

	/// <inheritdoc/>
	public bool IsShuffleEnabled => Session.IsShuffleEnabled;

	/// <inheritdoc/>
	public bool IsStopEnabled => Session.IsStopEnabled;

	#endregion

	#region Media Properties

	/// <inheritdoc/>
	public string AlbumArtist => Session.AlbumArtist;

	/// <inheritdoc/>
	public string AlbumTitle => Session.AlbumTitle;

	/// <inheritdoc/>
	public int AlbumTrackCount => Session.AlbumTrackCount;

	/// <inheritdoc/>
	public string Artist => Session.Artist;

	/// <inheritdoc/>
	public ObservableCollection<string> Genres => Session.Genres;

/// <inheritdoc/>
public string Subtitle => Session.Subtitle;

	/// <inheritdoc/>
	public IRandomAccessStreamReference? Thumbnail => Session.Thumbnail;

	/// <inheritdoc/>
	public string Title => Session.Title;

	/// <inheritdoc/>
	public int TrackNumber => Session.TrackNumber;

	#endregion

	#region Method Invocations

	/// <inheritdoc/>
	public void SetPosition( long Position ) => Session.SetPosition(Position);

	/// <inheritdoc/>
	public void ChannelDown() => Session.ChannelDown();

	/// <inheritdoc/>
	public void ChannelUp() => Session.ChannelUp();

	/// <inheritdoc/>
	public void FastForward() => Session.FastForward();

	/// <inheritdoc/>
	public void Record() => Session.Record();

	/// <inheritdoc/>
	public void Rewind() => Session.Rewind();

	/// <inheritdoc/>
	public void SkipNext() => Session.SkipNext();

	/// <inheritdoc/>
	public void SkipPrevious() => Session.SkipPrevious();

	/// <inheritdoc/>
	public void Play() => Session.Play();

	/// <inheritdoc/>
	public void Pause() => Session.Pause();

	/// <inheritdoc/>
	public void Stop() => Session.Stop();

	/// <inheritdoc/>
	public void TogglePlayPause() => Session.TogglePlayPause();

	#endregion

	#endregion
}