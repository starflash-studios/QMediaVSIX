// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionRequestReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.System.Diagnostics.DevicePortal
{
  /// <summary>Describes a DevicePortalConnection.RequestReceived event that was raised.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class DevicePortalConnectionRequestReceivedEventArgs : 
    IDevicePortalConnectionRequestReceivedEventArgs,
    IDevicePortalWebSocketConnectionRequestReceivedEventArgs
  {
    /// <summary>Gets the HTTP request message for this request.</summary>
    /// <returns>An HttpRequestMessage instance representing the HTTP request coming in through the Windows Device Portal server.</returns>
    public extern HttpRequestMessage RequestMessage { [MethodImpl] get; }

    /// <summary>Gets the HTTP response message for this request.</summary>
    /// <returns>An HttpResponseMessage instance that will contain the device portal plugin's response to an HTTP request. Its properties must be set by the plugin app.</returns>
    public extern HttpResponseMessage ResponseMessage { [MethodImpl] get; }

    /// <summary>Gets a value describing whether the request is for WebSocket communication.</summary>
    /// <returns>**True** if a WebSocket is being requested, otherwise **False**.</returns>
    public extern bool IsWebSocketUpgradeRequest { [MethodImpl] get; }

    /// <summary>Gets a list of the sub-protocols that the WebSocket is requested to follow.</summary>
    /// <returns>A list of strings representing WebSocket sub-protocols.</returns>
    public extern IVectorView<string> WebSocketProtocolsRequested { [MethodImpl] get; }

    /// <summary>Retrieves a deferral object to allow the background task to continue executing while a Device Portal connection is open.</summary>
    /// <returns>The deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
