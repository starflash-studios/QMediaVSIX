// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.IDevicePortalWebSocketConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Web.Http;

namespace Windows.System.Diagnostics.DevicePortal
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1734703392, 54874, 17136, 174, 244, 120, 120, 8, 9, 139, 123)]
  [ExclusiveTo(typeof (DevicePortalConnection))]
  internal interface IDevicePortalWebSocketConnection
  {
    [Overload("GetServerMessageWebSocketForRequest")]
    ServerMessageWebSocket GetServerMessageWebSocketForRequest(
      HttpRequestMessage request);

    [Overload("GetServerMessageWebSocketForRequest2")]
    ServerMessageWebSocket GetServerMessageWebSocketForRequest(
      HttpRequestMessage request,
      SocketMessageType messageType,
      string protocol);

    [Overload("GetServerMessageWebSocketForRequest3")]
    ServerMessageWebSocket GetServerMessageWebSocketForRequest(
      HttpRequestMessage request,
      SocketMessageType messageType,
      string protocol,
      uint outboundBufferSizeInBytes,
      uint maxMessageSize,
      MessageWebSocketReceiveMode receiveMode);

    [Overload("GetServerStreamWebSocketForRequest")]
    ServerStreamWebSocket GetServerStreamWebSocketForRequest(
      HttpRequestMessage request);

    [Overload("GetServerStreamWebSocketForRequest2")]
    ServerStreamWebSocket GetServerStreamWebSocketForRequest(
      HttpRequestMessage request,
      string protocol,
      uint outboundBufferSizeInBytes,
      bool noDelay);
  }
}
