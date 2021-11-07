// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCredential
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Vpn
{
  /// <summary>Provides an interface for the VPN platform to support requested credentials.</summary>
  [Guid(3085404915, 42093, 16459, 135, 41, 24, 50, 82, 40, 83, 172)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVpnCredential
  {
    /// <summary>Gets password or PIN corresponding to this credential request.</summary>
    /// <returns>The password or PIN corresponding to this credential request.</returns>
    PasswordCredential PasskeyCredential { get; }

    /// <summary>Gets the certificate that the plug-in was granted access to after requesting it.</summary>
    /// <returns>Gets the certificate to which we were granted access for use in the VPN connection.</returns>
    Certificate CertificateCredential { get; }

    /// <summary>Gets an additional PIN supplied by the user, typically when requesting user name, password, and PIN.</summary>
    /// <returns>An additional PIN provided by the user.</returns>
    string AdditionalPin { get; }

    /// <summary>Gets the previous credential the user used to log on to the VPN server, as in the case of a password change.</summary>
    /// <returns>The previous credential the user used to log in to the VPN server.</returns>
    PasswordCredential OldPasswordCredential { get; }
  }
}
