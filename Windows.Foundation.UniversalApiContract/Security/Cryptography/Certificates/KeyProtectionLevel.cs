// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.KeyProtectionLevel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Specifies the key protection level. This enumeration type is used in the KeyProtectionLevel property of a CertificateRequestProperties object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum KeyProtectionLevel
  {
    /// <summary>No strong key protection.</summary>
    NoConsent,
    /// <summary>The user is notified through a dialog box when the private key is created or used.</summary>
    ConsentOnly,
    /// <summary>The user is prompted to enter a password for the key when the key is created or used.</summary>
    ConsentWithPassword,
    /// <summary>The user is prompted to enter a fingerprint verification for the key when the key is created or used.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ConsentWithFingerprint,
  }
}
