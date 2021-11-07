// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ServerMessageWebSocket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  /// <summary>Supports network communication that allows reading and writing whole messages using a WebSocket object owned by a web server. You can't register for an arbitrary WebSocket connection; instead, an instance of **ServerMessageWebSocket** is created by system code such as the Windows Device Portal (WDP).</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ServerMessageWebSocket : IServerMessageWebSocket, IClosable
  {
    /// <summary>An event that indicates that a message was received on the ServerMessageWebSocket object.</summary>
    public extern event TypedEventHandler<ServerMessageWebSocket, MessageWebSocketMessageReceivedEventArgs> MessageReceived;

    /// <summary>Gets socket control data on a ServerMessageWebSocket object.</summary>
    /// <returns>Socket control data on a ServerMessageWebSocket object.</returns>
    public extern ServerMessageWebSocketControl Control { [MethodImpl] get; }

    /// <summary>Gets socket information on a ServerMessageWebSocket object.</summary>
    /// <returns>Socket information on a ServerMessageWebSocket object.</returns>
    public extern ServerMessageWebSocketInformation Information { [MethodImpl] get; }

    /// <summary>Gets the output stream to write to the remote network destination on a ServerMessageWebSocket object.</summary>
    /// <returns>A sequential stream of bytes to be written to the remote destination as a single message.</returns>
    public extern IOutputStream OutputStream { [MethodImpl] get; }

    /// <summary>Occurs when a close frame is received on the ServerMessageWebSocket object as part of the close handshake.</summary>
    public extern event TypedEventHandler<ServerMessageWebSocket, WebSocketClosedEventArgs> Closed;

    /// <summary>Closes the ServerMessageWebSocket object and indicates a reason for the closure.</summary>
    /// <param name="code">Status code indicating the reason for closure. The list of appropriate codes is on the IANA (Internet Assigned Numbers Authority) WebSocket Protocol Registry and is also documented on MDN.</param>
    /// <param name="reason">Optional UTF-8-encoded data with additional information about the closure.</param>
    [Overload("CloseWithStatus")]
    [MethodImpl]
    public extern void Close(ushort code, string reason);

    [MethodImpl]
    public extern void Close();
  }
}
