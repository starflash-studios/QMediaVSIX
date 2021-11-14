#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using CSCore.CoreAudioAPI;

using QMediaVSIX.Core.Collections;
using QMediaVSIX.Core.MediaSource.Ecosystem;

#endregion

//using QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

namespace QMediaVSIX.Core.MediaSource.Hardware;

public class MediaDevice : NotifyPropertyChange, IMediaDevice {

	public AudioSessionControl Control { get; }
	public AudioSessionControl2 Control2 { get; }
	public SimpleAudioVolume SimpleAV { get; }

	#region Properties

	#region Volume Property

	float _Volume;

	/// <inheritdoc cref="SimpleAudioVolume.MasterVolume"/>
	public float Volume {
		get => _Volume;
		set => SimpleAV.MasterVolume = value;
		//set => SetValue(ref _Volume, value);
	}

	#endregion

	#region Mute Property

	bool _Mute;

	/// <inheritdoc cref="SimpleAudioVolume.IsMuted"/>
	public bool Mute {
		get => _Mute;
		set => SimpleAV.IsMuted = value;
		//set => SetValue(ref _Mute, value);
	}

	#endregion

	#endregion

	public MediaDevice( AudioSessionControl Control ) : this(Control, Control.QueryInterface<AudioSessionControl2>()) { }

	public MediaDevice( AudioSessionControl Control, AudioSessionControl2 Control2 ) {
		this.Control = Control;
		this.Control2 = Control2;
		//Control2 = Control.QueryInterface<AudioSessionControl2>();
		SimpleAV = Control.QueryInterface<SimpleAudioVolume>();
		_Volume = SimpleAV.MasterVolume;
		_Mute = SimpleAV.IsMuted;

		Control2.SimpleVolumeChanged += ( _, E ) => {
			//Volume = E.NewVolume;
			//Mute = E.IsMuted;
			SetValue(ref _Volume, E.NewVolume, nameof(Volume));
			SetValue(ref _Mute, E.IsMuted, nameof(Mute));
		};

		Identifier = GetIdentifier(Control2);
	}

	public static Guid GetIdentifier( AudioSessionControl2 Control2 ) => Control2.SessionInstanceIdentifier.GetGuid();
	//public static Guid GetIdentifier( MediaDevice Device ) => GetIdentifier(Device.Control2);
	public readonly Guid Identifier;

	public override string ToString() => Control.DisplayName.CatchEmpty(Control2.Process.ProcessName, Control2.Process.GetApplicationUserModelId(), Control2.Process.MainWindowTitle);
}