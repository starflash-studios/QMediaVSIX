// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.MessageWebSocket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  /// <summary>Supports network communication that allows reading and writing whole messages using a WebSocket.</summary>
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MessageWebSocket : 
    IMessageWebSocket,
    IWebSocket,
    IClosable,
    IMessageWebSocket2,
    IMessageWebSocket3
  {
    /// <summary>Creates a new MessageWebSocket object.</summary>
    [MethodImpl]
    public extern MessageWebSocket();

    /// <summary>Gets socket control data on a MessageWebSocket object.</summary>
    /// <returns>Socket control data on a MessageWebSocket object.</returns>
    public extern MessageWebSocketControl Control { [MethodImpl] get; }

    /// <summary>Gets socket information on a MessageWebSocket object.</summary>
    /// <returns>Socket information on a MessageWebSocket object.</returns>
    public extern MessageWebSocketInformation Information { [MethodImpl] get; }

    /// <summary>An event that indicates that a message was received on the MessageWebSocket object.</summary>
    public extern event TypedEventHandler<MessageWebSocket, MessageWebSocketMessageReceivedEventArgs> MessageReceived;

    /// <summary>Gets the output stream to write to the remote network destination on a MessageWebSocket object.</summary>
    /// <returns>A sequential stream of bytes to be written to the remote destination as a single message.</returns>
    public extern IOutputStream OutputStream { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(Uri uri);

    /// <summary>Adds an HTTP request header to the HTTP request message used in the WebSocket protocol handshake by the MessageWebSocket object.</summary>
    /// <param name="headerName">The name of the request header.</param>
    /// <param name="headerValue">The value of the request header.</param>
    [MethodImpl]
    public extern void SetRequestHeader(string headerName, string headerValue);

    /// <summary>Occurs when a close frame is received on the MessageWebSocket object as part of the close handshake.</summary>
    public extern event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Closed;

    /// <summary>Closes the MessageWebSocket object and indicates a reason for the closure.</summary>
    /// <param name="code">Status code indicating the reason for closure. The list of appropriate codes is on the IANA (Internet Assigned Numbers Authority) WebSocket Protocol Registry and is also documented on MDN.</param>
    /// <param name="reason">Optional UTF-8-encoded data with additional information about the closure.</param>
    [Overload("CloseWithStatus")]
    [MethodImpl]
    public extern void Close(ushort code, string reason);

    [MethodImpl]
    public extern void Close();

    /// <summary>Occurs when a new MessageWebSocket connection to a secured server URI (**wss:** protocol) is being validated. Handle this event if you want to implement custom server validation for the connection.</summary>
    public extern event TypedEventHandler<MessageWebSocket, WebSocketServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;

    /// <summary>Asynchronously (with progress) writes a frame of data in a sequential stream, with the semantics that more frames will follow for the same WebSocket message (the FIN bit on this frame is set to 0). This method and SendFinalFrameAsync allow you to send individual WebSocket frames.</summary>
    /// <param name="data">A buffer containing the data that constitutes the frame to be sent.</param>
    /// <returns>An asynchronous byte writer operation with progress.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> SendNonfinalFrameAsync(
      IBuffer data);

    /// <summary>Asynchronously (with progress) writes a frame of data in a sequential stream, with the semantics that this is the last frame in a WebSocket message (the FIN bit on this frame is set to 1). This method and SendNonfinalFrameAsync allow you to send individual WebSocket frames.</summary>
    /// <param name="data">A buffer containing the data that constitutes the frame to be sent.</param>
    /// <returns>An asynchronous byte writer operation with progress.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> SendFinalFrameAsync(
      IBuffer data);
  }
}
