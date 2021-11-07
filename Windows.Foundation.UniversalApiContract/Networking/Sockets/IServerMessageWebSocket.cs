// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IServerMessageWebSocket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [Guid(3819737664, 33083, 24317, 126, 17, 174, 35, 5, 252, 119, 241)]
  [ExclusiveTo(typeof (ServerMessageWebSocket))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IServerMessageWebSocket : IClosable
  {
    event TypedEventHandler<ServerMessageWebSocket, MessageWebSocketMessageReceivedEventArgs> MessageReceived;

    ServerMessageWebSocketControl Control { get; }

    ServerMessageWebSocketInformation Information { get; }

    IOutputStream OutputStream { get; }

    event TypedEventHandler<ServerMessageWebSocket, WebSocketClosedEventArgs> Closed;

    [Overload("CloseWithStatus")]
    void Close(ushort code, string reason);
  }
}
