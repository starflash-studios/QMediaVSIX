﻿#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using CSCore.CoreAudioAPI;

#endregion

namespace QMediaVSIX.Core.MediaSource.Hardware;

public interface IMediaDevice {
	/// <inheritdoc cref="SimpleAudioVolume.MasterVolume"/>
	float Volume { get; set; }

	/// <inheritdoc cref="SimpleAudioVolume.IsMuted"/>
	bool Mute { get; set; }
}