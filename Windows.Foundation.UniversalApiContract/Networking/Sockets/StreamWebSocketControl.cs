// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamWebSocketControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket control data on a StreamWebSocket object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StreamWebSocketControl : 
    IStreamWebSocketControl,
    IWebSocketControl,
    IWebSocketControl2,
    IStreamWebSocketControl2
  {
    /// <summary>A value that indicates whether the Nagle algorithm is used on a StreamWebSocket object.</summary>
    /// <returns>A value that indicates whether the Nagle algorithm is used on the TCP connection of a StreamWebSocket object.</returns>
    public extern bool NoDelay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The size, in bytes, of the send buffer to be used for sending data on a StreamWebSocket object.</summary>
    /// <returns>The size, in bytes, of the send buffer to be used for sending data.</returns>
    public extern uint OutboundBufferSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The credential to use to authenticate to the WebSocket server through HTTP header authentication using a StreamWebSocket object.</summary>
    /// <returns>The credential to use to authenticate to the WebSocket server through HTTP header authentication.</returns>
    public extern PasswordCredential ServerCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The credential to use to authenticate to the proxy server through HTTP header authentication using a StreamWebSocket object.</summary>
    /// <returns>The credential to use to authenticate to the proxy server through HTTP header authentication.</returns>
    public extern PasswordCredential ProxyCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a collection that can be used to add a list of supported sub-protocols that will be advertised to the server during the connect handshake.</summary>
    /// <returns>A collection that contains the WebSocket sub-protocols supported by the StreamWebSocket object.</returns>
    public extern IVector<string> SupportedProtocols { [MethodImpl] get; }

    /// <summary>Gets a list of ignorable server certificate errors. Get this list and add ChainValidationResult values for server certificate errors that you wish to ignore during the secure WebSocket (**wss://** protocol) server certificate validation process.</summary>
    /// <returns>A list of ChainValidationResult values indicating the server certificate errors to ignore when validating server certificates. By default, the list is empty and all errors cause validation to fail.</returns>
    public extern IVector<ChainValidationResult> IgnorableServerCertificateErrors { [MethodImpl] get; }

    /// <summary>Allows an app to get and set the desired unsolicited WebSocket PONG interval.</summary>
    /// <returns>System.Timespan</returns>
    public extern TimeSpan DesiredUnsolicitedPongInterval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Allows an app to get the actual unsolicited WebSocket PONG interval.</summary>
    /// <returns>System.Timespan</returns>
    public extern TimeSpan ActualUnsolicitedPongInterval { [MethodImpl] get; }

    /// <summary>Gets the certificate provided by the client when a secure WebSocket connection has been established.</summary>
    /// <returns>The client certificate.</returns>
    public extern Certificate ClientCertificate { [MethodImpl] get; [MethodImpl] set; }
  }
}
