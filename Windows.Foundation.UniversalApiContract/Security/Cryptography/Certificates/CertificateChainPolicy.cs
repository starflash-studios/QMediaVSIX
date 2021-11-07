// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateChainPolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Describes the policy to use when performing a certificate chain validation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CertificateChainPolicy
  {
    /// <summary>Use the base chain policy verification checks.</summary>
    Base,
    /// <summary>Use the SSL client/server chain policy verification checks.</summary>
    Ssl,
    /// <summary>Use the Windows NT Authentication chain policy checks.</summary>
    NTAuthentication,
    /// <summary>Check the last element of the first simple chain for a Microsoft root public key.</summary>
    MicrosoftRoot,
  }
}
