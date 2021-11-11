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