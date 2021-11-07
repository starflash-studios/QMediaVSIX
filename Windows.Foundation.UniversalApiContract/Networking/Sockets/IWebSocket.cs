// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides access to network communication that allows reading and writing using a WebSocket.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4168563055, 39345, 19992, 188, 8, 133, 12, 154, 223, 21, 110)]
  public interface IWebSocket : IClosable
  {
    /// <summary>Gets the output stream to write to the remote network destination on a IWebSocket object.</summary>
    /// <returns>A sequential stream of bytes to be written to the remote destination.</returns>
    IOutputStream OutputStream { get; }

    [RemoteAsync]
    IAsyncAction ConnectAsync(Uri uri);

    /// <summary>Adds an HTTP request header to the HTTP request message used in the WebSocket protocol handshake by the IWebSocket object.</summary>
    /// <param name="headerName">The name of the request header.</param>
    /// <param name="headerValue">The value of the request header.</param>
    void SetRequestHeader(string headerName, string headerValue);

    /// <summary>Occurs when a close frame is received on the IWebSocket object as part of the close handshake.</summary>
    event TypedEventHandler<IWebSocket, WebSocketClosedEventArgs> Closed;

    /// <summary>Closes the IWebSocket.</summary>
    /// <param name="code">Status code indicating the reason for closure.</param>
    /// <param name="reason">Optional UTF-8-encoded data with additional information about the closure.</param>
    [Overload("CloseWithStatus")]
    void Close(ushort code, string reason);
  }
}
