// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.CryptographicPrivateKeyBlobType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Specifies the type of the private key contained in a buffer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CryptographicPrivateKeyBlobType
  {
    /// <summary>This is the default value. The private key is encoded as an ASN.1 **PrivateKeyInfo** type defined in the PKCS#8 standard. The private key information syntax is defined as follows in RFC 5208.</summary>
    Pkcs8RawPrivateKeyInfo,
    /// <summary>The key is an RSA private key defined in the PKCS #1 standard. For more information, see the RSA Cryptography Specification in RFC 3347.</summary>
    Pkcs1RsaPrivateKey,
    /// <summary>Microsoft private key format defined by Cryptography API: Next Generation (CNG). For examples, see the following CNG structures:</summary>
    BCryptPrivateKey,
    /// <summary>Microsoft private key format defined by the legacy Cryptography API (CAPI). For more information, see Base Provider Key BLOBs.</summary>
    Capi1PrivateKey,
    /// <summary>The key is a BCrypt full elliptic curve cryptography (ECC) private key.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] BCryptEccFullPrivateKey,
  }
}
