// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.CryptographicPadding
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Specifies a padding mode for asymmetric algorithm signature or encryption operations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CryptographicPadding
  {
    /// <summary>Do not use padding.</summary>
    None,
    /// <summary>Use the Optimal Asymmetric Encryption Padding (OAEP) scheme.</summary>
    RsaOaep,
    /// <summary>Use the standard padding scheme for public-key cryptography based on the RSA algorithm as defined in RFC 3447.</summary>
    RsaPkcs1V15,
    /// <summary>Use the Probabilistic Signature Scheme (PSS) scheme.</summary>
    RsaPss,
  }
}
