#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

global using Debug = QDebug.Debug;

global using System;
global using System.Linq;
global using System.Collections.Generic;

global using WMCSessionManager = Windows.Media.Control.GlobalSystemMediaTransportControlsSessionManager;
global using WMCSession = Windows.Media.Control.GlobalSystemMediaTransportControlsSession;
global using WMCMediaProperties = Windows.Media.Control.GlobalSystemMediaTransportControlsSessionMediaProperties;
global using WMCPlaybackControls = Windows.Media.Control.GlobalSystemMediaTransportControlsSessionPlaybackControls;
global using WMCPlaybackInfo = Windows.Media.Control.GlobalSystemMediaTransportControlsSessionPlaybackInfo;
global using WMCPlaybackStatus = Windows.Media.Control.GlobalSystemMediaTransportControlsSessionPlaybackStatus;
global using WMCTimelineProperties = Windows.Media.Control.GlobalSystemMediaTransportControlsSessionTimelineProperties;

global using WMCSessionsChangedEventArgs = Windows.Media.Control.SessionsChangedEventArgs;
global using WMCCurrentSessionChangedEventArgs = Windows.Media.Control.CurrentSessionChangedEventArgs;

#endregion