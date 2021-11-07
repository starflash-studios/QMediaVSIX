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
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Media.Control {
  /// <summary>Provides access to playback sessions throughout the system that have integrated with SystemMediaTransportControls to provide playback info and allow remote control.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(Version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Static(typeof (IGlobalSystemMediaTransportControlsSessionManagerStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class GlobalSystemMediaTransportControlsSessionManager :
    IGlobalSystemMediaTransportControlsSessionManager {
    /// <summary>Gets the current session. This is the session the system believes the user would most likely want to control.</summary>
    /// <returns>A session object that represents this remote session.</returns>
    [MethodImpl]
    public extern GlobalSystemMediaTransportControlsSession GetCurrentSession();

    /// <summary>Gets all of the available sessions.</summary>
    /// <returns>A vector of all available sessions.</returns>
    [MethodImpl]
    public extern IVectorView<GlobalSystemMediaTransportControlsSession> GetSessions();

    /// <summary>Occurs when the current session has changed. This is the session that the system believes is the one the user would most likely want to control.</summary>
    public extern event TypedEventHandler<GlobalSystemMediaTransportControlsSessionManager, CurrentSessionChangedEventArgs> CurrentSessionChanged;

    /// <summary>Occurs when the list of available sessions has changed due to a new session connecting or an existing one disconnecting.</summary>
    public extern event TypedEventHandler<GlobalSystemMediaTransportControlsSessionManager, SessionsChangedEventArgs> SessionsChanged;

    /// <summary>Requests an instance of the GlobalSystemMediaTransportControlsSessionManager.</summary>
    /// <returns>A new instance of the Session Manager.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GlobalSystemMediaTransportControlsSessionManager> RequestAsync();
  }
}