// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.MessageWebSocketInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket information on a MessageWebSocket.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MessageWebSocketInformation : IWebSocketInformation, IWebSocketInformation2
  {
    /// <summary>Gets the IP address associated with a MessageWebSocket object.</summary>
    /// <returns>The IP address associated with a MessageWebSocket object.</returns>
    public extern HostName LocalAddress { [MethodImpl] get; }

    /// <summary>Gets bandwidth information for network data transfer on a MessageWebSocket object.</summary>
    /// <returns>Bandwidth information for network data transfer on a MessageWebSocket object.</returns>
    public extern BandwidthStatistics BandwidthStatistics { [MethodImpl] get; }

    /// <summary>Gets the WebSocket sub-protocol negotiated with the server during WebSocket handshake on a MessageWebSocket object.</summary>
    /// <returns>The sub-protocol negotiated with the server during the WebSocket handshake.</returns>
    public extern string Protocol { [MethodImpl] get; }

    /// <summary>Gets the certificate provided by the server when a secure WebSocket connection has been established.</summary>
    /// <returns>The server certificate.</returns>
    public extern Certificate ServerCertificate { [MethodImpl] get; }

    /// <summary>Gets the category of an error that occurred making an SSL connection with a WebSocket server.</summary>
    /// <returns>The category of error on an SSL connection.</returns>
    public extern SocketSslErrorSeverity ServerCertificateErrorSeverity { [MethodImpl] get; }

    /// <summary>Gets a list of the errors that occurred while establishing a secure WebSocket connection.</summary>
    /// <returns>A list of values describing secure connection errors.</returns>
    public extern IVectorView<ChainValidationResult> ServerCertificateErrors { [MethodImpl] get; }

    /// <summary>Gets the intermediate certificates sent by the server during SSL negotiation when making an SSL connection with a WebSockets server.</summary>
    /// <returns>The set of certificates sent by the server during SSL negotiation.</returns>
    public extern IVectorView<Certificate> ServerIntermediateCertificates { [MethodImpl] get; }
  }
}
