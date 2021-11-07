// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.KeySize
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Specifies commonly used RSA algorithm key sizes. This enumeration type can be used in the KeySize property of a CertificateRequestProperties object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum KeySize
  {
    /// <summary>No size is specified.</summary>
    Invalid = 0,
    /// <summary>The key length is 2048 bits.</summary>
    Rsa2048 = 2048, // 0x00000800
    /// <summary>The key length is 4096 bits.</summary>
    Rsa4096 = 4096, // 0x00001000
  }
}
