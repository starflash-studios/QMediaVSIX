// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCredentialType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Specifies the types of credentials that can be requested by the VPN platform.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VpnCredentialType
  {
    /// <summary>Represents a credential of type Username and Password.</summary>
    UsernamePassword,
    /// <summary>Represents a credential type of username, and a PIN or OTP.</summary>
    UsernameOtpPin,
    /// <summary>Represents a credential type of username, password, and PIN.</summary>
    UsernamePasswordAndPin,
    /// <summary>Represents a password change. The current password, new password, and a confirmation of the new password will be collected.</summary>
    UsernamePasswordChange,
    /// <summary>Represents a credential type of smart card.</summary>
    SmartCard,
    /// <summary>Represents a credential type of a protected certificate.</summary>
    ProtectedCertificate,
    /// <summary>Represents a credential type of a certificate.</summary>
    UnProtectedCertificate,
  }
}
