// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCredential
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents the credentials requested and provided by the platform. This class holds username, password, PIN, OTP, and any additional PIN or certificate to which access has been granted.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnCredential : IVpnCredential
  {
    /// <summary>Gets the current password credential used by the user to log on to the VPN server.</summary>
    /// <returns>The current password credential used by the user to log in to the VPN server.</returns>
    public extern PasswordCredential PasskeyCredential { [MethodImpl] get; }

    /// <summary>Gets the certificate to which we were granted access for use in the VPN connection.</summary>
    /// <returns>The certificate to which we were granted access for use in the VPN connection.</returns>
    public extern Certificate CertificateCredential { [MethodImpl] get; }

    /// <summary>Gets an additional PIN provided by the user, typically used when requesting a credential type of username, password, and PIN.</summary>
    /// <returns>An additional PIN provided by the user.</returns>
    public extern string AdditionalPin { [MethodImpl] get; }

    /// <summary>Gets the previous credential the user used to log on to the VPN server, as in the case of a password change.</summary>
    /// <returns>The previous credential the user used to log in to the VPN server.</returns>
    public extern PasswordCredential OldPasswordCredential { [MethodImpl] get; }
  }
}
