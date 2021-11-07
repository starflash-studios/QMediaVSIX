// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.DevicePortalConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Web.Http;

namespace Windows.System.Diagnostics.DevicePortal
{
  /// <summary>Handles a connection to the Windows Device Portal.</summary>
  [Static(typeof (IDevicePortalConnectionStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class DevicePortalConnection : 
    IDevicePortalConnection,
    IDevicePortalWebSocketConnection
  {
    /// <summary>Raised when the connection to the Windows Device Portal is closed. A device portal plugin app must implement a handler for this event.</summary>
    public extern event TypedEventHandler<DevicePortalConnection, DevicePortalConnectionClosedEventArgs> Closed;

    /// <summary>Raised when a request has been received through the Windows Device Portal server. A device portal plugin app must implement a handler for this event.</summary>
    public extern event TypedEventHandler<DevicePortalConnection, DevicePortalConnectionRequestReceivedEventArgs> RequestReceived;

    /// <summary>Returns a server-side message WebSocket for use with Device Portal.</summary>
    /// <param name="request">The HTTP request message (found as a property of the **DevicePortalConnectionRequestReceivedEventArgs ** class).</param>
    /// <returns>A server-side message WebSocket object that can be used with Device Portal.</returns>
    [Overload("GetServerMessageWebSocketForRequest")]
    [MethodImpl]
    public extern ServerMessageWebSocket GetServerMessageWebSocketForRequest(
      HttpRequestMessage request);

    /// <summary>Returns a server-side message WebSocket for use with Device Portal.</summary>
    /// <param name="request">The HTTP request message (found as a property of the **DevicePortalConnectionRequestReceivedEventArgs ** class).</param>
    /// <param name="messageType">A **SocketMessageType ** value indicating the type of messaging that this WebSocket will use.</param>
    /// <param name="protocol">The sub-protocol that this WebSocket will use.</param>
    /// <returns>A server-side message WebSocket object that can be used with Device Portal.</returns>
    [Overload("GetServerMessageWebSocketForRequest2")]
    [MethodImpl]
    public extern ServerMessageWebSocket GetServerMessageWebSocketForRequest(
      HttpRequestMessage request,
      SocketMessageType messageType,
      string protocol);

    /// <summary>Returns a server-side message WebSocket for use with Device Portal.</summary>
    /// <param name="request">The HTTP request message (found as a property of the **DevicePortalConnectionRequestReceivedEventArgs ** class).</param>
    /// <param name="messageType">A **SocketMessageType ** value indicating the type of messaging that this WebSocket will use.</param>
    /// <param name="protocol">The sub-protocol that this WebSocket will use.</param>
    /// <param name="outboundBufferSizeInBytes">The size, in bytes, of the send buffer to be used for sending data on a **ServerMessageWebSocket ** object.</param>
    /// <param name="maxMessageSize">The maximum message size, in bytes, for a WebSocket message to be configured on the **ServerMessageWebSocket ** object.</param>
    /// <param name="receiveMode">A **MessageWebSocketReceiveMode ** value indicating whether this WebSocket will receive either complete or partial messages.</param>
    /// <returns>A server-side message WebSocket object that can be used with Device Portal.</returns>
    [Overload("GetServerMessageWebSocketForRequest3")]
    [MethodImpl]
    public extern ServerMessageWebSocket GetServerMessageWebSocketForRequest(
      HttpRequestMessage request,
      SocketMessageType messageType,
      string protocol,
      uint outboundBufferSizeInBytes,
      uint maxMessageSize,
      MessageWebSocketReceiveMode receiveMode);

    /// <summary>Returns a server-side stream WebSocket for use with Device Portal.</summary>
    /// <param name="request">The HTTP request message (found as a property of the **DevicePortalConnectionRequestReceivedEventArgs ** class).</param>
    /// <returns>A server-side stream WebSocket object that can be used with Device Portal.</returns>
    [Overload("GetServerStreamWebSocketForRequest")]
    [MethodImpl]
    public extern ServerStreamWebSocket GetServerStreamWebSocketForRequest(
      HttpRequestMessage request);

    /// <summary>Returns a server-side stream WebSocket for use with Device Portal.</summary>
    /// <param name="request">The HTTP request message (found as a property of the **DevicePortalConnectionRequestReceivedEventArgs ** class).</param>
    /// <param name="protocol">The sub-protocol that this WebSocket will use.</param>
    /// <param name="outboundBufferSizeInBytes">The size, in bytes, of the send buffer to be used for sending data on a **ServerMessageWebSocket ** object.</param>
    /// <param name="noDelay">A boolean value indicating whether Nagle's algorithm is used on this WebSocket object. See the **StreamSocketControl ** class for more information on Nagle's algorithm.</param>
    /// <returns>A server-side stream WebSocket object that can be used with Device Portal.</returns>
    [Overload("GetServerStreamWebSocketForRequest2")]
    [MethodImpl]
    public extern ServerStreamWebSocket GetServerStreamWebSocketForRequest(
      HttpRequestMessage request,
      string protocol,
      uint outboundBufferSizeInBytes,
      bool noDelay);

    /// <summary>Initializes an instance of DevicePortalConnection by using the app service connection passed in.</summary>
    /// <param name="appServiceConnection">The AppServiceConnection that was used to launch the background task calling this method.</param>
    /// <returns>The DevicePortalConnection object.</returns>
    [MethodImpl]
    public static extern DevicePortalConnection GetForAppServiceConnection(
      AppServiceConnection appServiceConnection);
  }
}
