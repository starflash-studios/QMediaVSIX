// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamSocketControl
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
  /// <summary>Provides socket control data on a StreamSocket object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StreamSocketControl : 
    IStreamSocketControl,
    IStreamSocketControl2,
    IStreamSocketControl3,
    IStreamSocketControl4
  {
    /// <summary>A value that indicates whether the Nagle algorithm is used on a StreamSocket object.</summary>
    /// <returns>A value that indicates whether the Nagle algorithm is used on the TCP connection of a StreamSocket object</returns>
    public extern bool NoDelay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A value that indicates whether keep-alive packets are sent to the remote destination on a StreamSocket object.</summary>
    /// <returns>Whether keep-alive packets are sent to the remote destination.</returns>
    public extern bool KeepAlive { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The size, in bytes, of the send buffer to be used for sending data on a StreamSocket object.</summary>
    /// <returns>The size, in bytes, of the send buffer to be used for sending data.</returns>
    public extern uint OutboundBufferSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The quality of service on a StreamSocket object.</summary>
    /// <returns>The quality of service on a StreamSocket object.</returns>
    public extern SocketQualityOfService QualityOfService { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The hop limit on an outbound packet sent to a unicast IP address by the StreamSocket object.</summary>
    /// <returns>The hop limit on an outbound packet sent by the StreamSocket object. The default is 128.</returns>
    public extern byte OutboundUnicastHopLimit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get a vector of SSL server errors to ignore when making an SSL connection with a StreamSocket.</summary>
    /// <returns>A vector of SSL server errors to ignore.</returns>
    public extern IVector<ChainValidationResult> IgnorableServerCertificateErrors { [MethodImpl] get; }

    /// <summary>A value that indicates whether, when multiple connection attempts are being made, the attempts are made in parallel or serially.</summary>
    /// <returns>When true, at most one connection attempt will be active at one time on this StreamSocket. Default value is false.</returns>
    public extern bool SerializeConnectionAttempts { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the client SSL/TLS certificate that will be sent to the server if the server requests a client certificate.</summary>
    /// <returns>The client certificate.</returns>
    public extern Certificate ClientCertificate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Constrains the TLS protocol version that will be negotiated when the developer uses the ConnectAsync() or UpgradeToSslAsync() methods that require TLS.</summary>
    /// <returns>A SocketProtectionLevel enumeration member indicating the socket protection level.</returns>
    public extern SocketProtectionLevel MinProtectionLevel { [MethodImpl] get; [MethodImpl] set; }
  }
}
