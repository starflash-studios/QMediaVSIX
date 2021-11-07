// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamWebSocket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  /// <summary>Supports network communication that allows reading and writing streams using a WebSocket.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class StreamWebSocket : IStreamWebSocket, IWebSocket, IClosable, IStreamWebSocket2
  {
    /// <summary>Creates a new StreamWebSocket object.</summary>
    [MethodImpl]
    public extern StreamWebSocket();

    /// <summary>Gets socket control data on a StreamWebSocket object.</summary>
    /// <returns>Socket control data on a StreamWebSocket object.</returns>
    public extern StreamWebSocketControl Control { [MethodImpl] get; }

    /// <summary>Gets socket information on a StreamWebSocket object.</summary>
    /// <returns>Socket information on a StreamWebSocket object.</returns>
    public extern StreamWebSocketInformation Information { [MethodImpl] get; }

    /// <summary>Gets the input stream to read from the remote destination on a StreamWebSocket object.</summary>
    /// <returns>A sequential stream of bytes to be read from the remote destination.</returns>
    public extern IInputStream InputStream { [MethodImpl] get; }

    /// <summary>Gets the output stream to write to the remote network destination on a StreamWebSocket object.</summary>
    /// <returns>A sequential stream of bytes to be written to the remote destination.</returns>
    public extern IOutputStream OutputStream { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(Uri uri);

    /// <summary>Adds an HTTP request header to the HTTP request message used in the WebSocket protocol handshake by the StreamWebSocket object.</summary>
    /// <param name="headerName">The name of the request header.</param>
    /// <param name="headerValue">The value of the request header.</param>
    [MethodImpl]
    public extern void SetRequestHeader(string headerName, string headerValue);

    /// <summary>Occurs when a close frame is received on the StreamWebSocket object as part of the close handshake.</summary>
    public extern event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Closed;

    /// <summary>Closes the StreamWebSocket and indicates a reason for the closure.</summary>
    /// <param name="code">Status code indicating the reason for closure.</param>
    /// <param name="reason">Optional UTF-8-encoded data with additional information about the closure.</param>
    [Overload("CloseWithStatus")]
    [MethodImpl]
    public extern void Close(ushort code, string reason);

    [MethodImpl]
    public extern void Close();

    /// <summary>Occurs when a new StreamWebSocket connection to a secured server URI (**wss:** protocol) is being validated. Handle this event if you want to implement custom server validation for the connection.</summary>
    public extern event TypedEventHandler<StreamWebSocket, WebSocketServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;
  }
}
