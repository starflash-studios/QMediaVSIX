// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamSocketInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket information on a StreamSocket object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StreamSocketInformation : IStreamSocketInformation, IStreamSocketInformation2
  {
    /// <summary>Gets the local IP address associated with a StreamSocket object.</summary>
    /// <returns>The local IP address or hostname.</returns>
    public extern HostName LocalAddress { [MethodImpl] get; }

    /// <summary>Get the TCP port number associated with a StreamSocket.</summary>
    /// <returns>The local TCP port number of service name.</returns>
    public extern string LocalPort { [MethodImpl] get; }

    /// <summary>Get the hostname or IP address of the remote network destination associated with a StreamSocket object.</summary>
    /// <returns>The hostname or IP address of the remote network destination.</returns>
    public extern HostName RemoteHostName { [MethodImpl] get; }

    /// <summary>Get the IP address or hostname of the remote network destination associated with a StreamSocket object.</summary>
    /// <returns>The IP address of the remote network endpoint after a connection is established.</returns>
    public extern HostName RemoteAddress { [MethodImpl] get; }

    /// <summary>Get the service name or TCP port number of the remote network destination associated with a StreamSocket object.</summary>
    /// <returns>The service name or TCP port number of the remote network destination.</returns>
    public extern string RemoteServiceName { [MethodImpl] get; }

    /// <summary>Get the TCP port number or service name of the remote network destination associated with a StreamSocket object.</summary>
    /// <returns>The TCP port number of the remote network endpoint after a connection is established.</returns>
    public extern string RemotePort { [MethodImpl] get; }

    /// <summary>Gets round trip time information for a StreamSocket object.</summary>
    /// <returns>Round trip time information for a StreamSocket object.</returns>
    public extern RoundTripTimeStatistics RoundTripTimeStatistics { [MethodImpl] get; }

    /// <summary>Gets bandwidth information for network data transfer on a StreamSocket object.</summary>
    /// <returns>Bandwidth information for network data transfer on a StreamSocket object.</returns>
    public extern BandwidthStatistics BandwidthStatistics { [MethodImpl] get; }

    /// <summary>Gets the protection level that represents the integrity and encryption set on a StreamSocket object.</summary>
    /// <returns>The protection level that represents the integrity and encryption set on a StreamSocket object.</returns>
    public extern SocketProtectionLevel ProtectionLevel { [MethodImpl] get; }

    /// <summary>Get a byte array that represents the private shared secret exchanged by proximity devices.</summary>
    /// <returns>A byte array that represents the private shared secret exchanged by proximity devices.</returns>
    public extern IBuffer SessionKey { [MethodImpl] get; }

    /// <summary>Gets the category of an error that occurred making an SSL connection with a StreamSocket.</summary>
    /// <returns>The category of error on an SSL connection.</returns>
    public extern SocketSslErrorSeverity ServerCertificateErrorSeverity { [MethodImpl] get; }

    /// <summary>Gets the list of errors that occurred making an SSL connection with a StreamSocket.</summary>
    /// <returns>The list of errors that occurred making an SSL connection.</returns>
    public extern IVectorView<ChainValidationResult> ServerCertificateErrors { [MethodImpl] get; }

    /// <summary>Gets the certificate from the server when making an SSL connection with a StreamSocket.</summary>
    /// <returns>The certificate from the server with the SSL information.</returns>
    public extern Certificate ServerCertificate { [MethodImpl] get; }

    /// <summary>Gets the intermediate certificates sent by the server during SSL negotiation when making an SSL connection with a StreamSocket.</summary>
    /// <returns>The set of certificates sent by the server during SSL negotiation.</returns>
    public extern IVectorView<Certificate> ServerIntermediateCertificates { [MethodImpl] get; }
  }
}
