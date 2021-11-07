// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ISubjectAlternativeNameInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1132099782, 7249, 16874, 179, 74, 61, 101, 67, 152, 163, 112)]
  [ExclusiveTo(typeof (SubjectAlternativeNameInfo))]
  internal interface ISubjectAlternativeNameInfo2
  {
    IVector<string> EmailNames { get; }

    IVector<string> IPAddresses { get; }

    IVector<string> Urls { get; }

    IVector<string> DnsNames { get; }

    IVector<string> DistinguishedNames { get; }

    IVector<string> PrincipalNames { get; }

    CertificateExtension Extension { get; }
  }
}
