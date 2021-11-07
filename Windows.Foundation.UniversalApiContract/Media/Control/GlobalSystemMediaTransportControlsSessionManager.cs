// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.GlobalSystemMediaTransportControlsSessionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Control
{
  /// <summary>Provides access to playback sessions throughout the system that have integrated with SystemMediaTransportControls to provide playback info and allow remote control.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Static(typeof (IGlobalSystemMediaTransportControlsSessionManagerStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class GlobalSystemMediaTransportControlsSessionManager : 
    IGlobalSystemMediaTransportControlsSessionManager
  {
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
