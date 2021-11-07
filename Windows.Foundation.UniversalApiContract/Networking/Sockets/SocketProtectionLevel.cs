// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketProtectionLevel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Specifies the level of encryption to use on a StreamSocket object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SocketProtectionLevel
  {
    /// <summary>A plain socket with no encryption.</summary>
    PlainSocket,
    /// <summary>A TCP socket that must use the Secure Sockets Layer (SSL) for encryption. This value requires encryption and never allows a NULL cipher (no encryption).</summary>
    /// <deprecated type="deprecate">Ssl may result in insecure connections and may be altered or unavailable for releases after Windows 8.1. Instead, use one of the TLS SocketProtectionLevel values.</deprecated>
    [Deprecated("Ssl may result in insecure connections and may be altered or unavailable for releases after Windows 8.1. Instead, use one of the TLS SocketProtectionLevel values.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] Ssl,
    /// <summary>A TCP socket that prefers to use SSL for encryption. This value prefers that full encryption be used, but allows a NULL cipher (no encryption) based on the server configuration.</summary>
    SslAllowNullEncryption,
    /// <summary>A Bluetooth socket that prefers that encryption be used, but allows a NULL cipher (no encryption) based on the configuration of the target server.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] BluetoothEncryptionAllowNullAuthentication,
    /// <summary>A Bluetooth socket that must use encryption. This value requires encryption and never allows a NULL cipher.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] BluetoothEncryptionWithAuthentication,
    /// <summary>A TCP socket that must use SSL for encryption. This value supports the SSL 3.0 protocol and all encryption ciphers installed on the system except the NULL cipher. This value allows RC4 and other weak ciphers which are considered insecure. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.</summary>
    /// <deprecated type="deprecate">Ssl3AllowWeakEncryption may result in insecure connections and may be altered or unavailable for releases after Windows 8.1. Instead, use one of the TLS SocketProtectionLevel values.</deprecated>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536), Deprecated("Ssl3AllowWeakEncryption may result in insecure connections and may be altered or unavailable for releases after Windows 8.1. Instead, use one of the TLS SocketProtectionLevel values.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] Ssl3AllowWeakEncryption,
    /// <summary>A TCP socket that must use SSL for encryption. This value supports the TLS 1.0 protocol and all encryption ciphers installed on the system except RC4, other weak ciphers, and the NULL cipher. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Tls10,
    /// <summary>A TCP socket that must use SSL for encryption. This value supports the TLS 1.1 and TLS 1.0 protocols and all encryption ciphers installed on the system except RC4, other weak ciphers, and the NULL cipher. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Tls11,
    /// <summary>A TCP socket that must use SSL for encryption. This value supports the TLS 1.2, TLS 1.1 and TLS 1.0 protocols and all encryption ciphers installed on the system except RC4, other weak ciphers, and the NULL cipher. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Tls12,
    /// <summary>The protection level is unspecified.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] Unspecified,
  }
}
