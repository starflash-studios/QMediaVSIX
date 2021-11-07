// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.EnrollKeyUsages
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Specifies the cryptographic operations that can be performed by the private key. This enumeration type is used in the KeyUsages property of a CertificateRequestProperties object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum EnrollKeyUsages : uint
  {
    /// <summary>No usage is specified for the key.</summary>
    None = 0,
    /// <summary>The key can be used for decryption.</summary>
    Decryption = 1,
    /// <summary>The key can be used for signing.</summary>
    Signing = 2,
    /// <summary>The key can be used for secret agreement encryption.</summary>
    KeyAgreement = 4,
    /// <summary>The key can be used for decryption, signing. and key agreement.</summary>
    All = 16777215, // 0x00FFFFFF
  }
}
