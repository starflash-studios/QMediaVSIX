#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Media.Control {
  [Guid(3402534572, 59502, 20554, 171, 49, 95, 248, 255, 27, 206, 73)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSessionManager))]
  internal interface IGlobalSystemMediaTransportControlsSessionManager {
    GlobalSystemMediaTransportControlsSession GetCurrentSession();

    IVectorView<GlobalSystemMediaTransportControlsSession> GetSessions();

    event TypedEventHandler<GlobalSystemMediaTransportControlsSessionManager, CurrentSessionChangedEventArgs> CurrentSessionChanged;

    event TypedEventHandler<GlobalSystemMediaTransportControlsSessionManager, SessionsChangedEventArgs> SessionsChanged;
  }
}