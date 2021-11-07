// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketErrorStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Specifies status values for a socket operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SocketErrorStatus
  {
    /// <summary>The socket status is unknown.</summary>
    Unknown,
    /// <summary>The operation was aborted.</summary>
    OperationAborted,
    /// <summary>A bad response was received from the HTTP server.</summary>
    HttpInvalidServerResponse,
    /// <summary>A connection timeout was exceeded.</summary>
    ConnectionTimedOut,
    /// <summary>The address family is not supported.</summary>
    AddressFamilyNotSupported,
    /// <summary>The socket type is not supported.</summary>
    SocketTypeNotSupported,
    /// <summary>The host was not found.</summary>
    HostNotFound,
    /// <summary>The requested name is valid and was found in the database, but it does not have the correct associated data being resolved for.</summary>
    NoDataRecordOfRequestedType,
    /// <summary>This is usually a temporary error during hostname resolution and means that the local server did not receive a response from an authoritative server.</summary>
    NonAuthoritativeHostNotFound,
    /// <summary>The specified class was not found.</summary>
    ClassTypeNotFound,
    /// <summary>The address is already in use.</summary>
    AddressAlreadyInUse,
    /// <summary>Cannot assign requested address.</summary>
    CannotAssignRequestedAddress,
    /// <summary>The connection was refused.</summary>
    ConnectionRefused,
    /// <summary>The network is unreachable.</summary>
    NetworkIsUnreachable,
    /// <summary>The host is unreachable.</summary>
    UnreachableHost,
    /// <summary>The network is down.</summary>
    NetworkIsDown,
    /// <summary>The network dropped connection on reset.</summary>
    NetworkDroppedConnectionOnReset,
    /// <summary>Software caused a connection abort.</summary>
    SoftwareCausedConnectionAbort,
    /// <summary>The connection was reset by the peer.</summary>
    ConnectionResetByPeer,
    /// <summary>The host is down.</summary>
    HostIsDown,
    /// <summary>The pipe is being closed.</summary>
    NoAddressesFound,
    /// <summary>Too many open files.</summary>
    TooManyOpenFiles,
    /// <summary>A message sent on a datagram socket was larger than the internal message buffer or some other network limit, or the buffer used to receive a datagram was smaller than the datagram itself.</summary>
    MessageTooLong,
    /// <summary>A required certificate is not within its validity period when verifying against the current system clock or the timestamp in the signed file. This error is also returned if the validity periods of the certification chain do not nest correctly.</summary>
    CertificateExpired,
    /// <summary>A certificate chain processed, but terminated in a root certificate which is not trusted by the trust provider. This error is also returned if a certificate chain could not be built to a trusted root authority.</summary>
    CertificateUntrustedRoot,
    /// <summary>The certificate is not valid for the requested usage. This error is also returned if the certificate has an invalid name. The name is not included in the permitted list or is explicitly excluded.</summary>
    CertificateCommonNameIsIncorrect,
    /// <summary>The certificate is not valid for the requested usage.</summary>
    CertificateWrongUsage,
    /// <summary>A certificate was explicitly revoked by its issuer. This error is also returned if the certificate was explicitly marked as untrusted by the user.</summary>
    CertificateRevoked,
    /// <summary>The revocation function was unable to check revocation for the certificate.</summary>
    CertificateNoRevocationCheck,
    /// <summary>The revocation function was unable to check revocation because the revocation server was offline.</summary>
    CertificateRevocationServerOffline,
    /// <summary>The supplied certificate is invalid. This can be returned for a number of reasons:</summary>
    CertificateIsInvalid,
  }
}
