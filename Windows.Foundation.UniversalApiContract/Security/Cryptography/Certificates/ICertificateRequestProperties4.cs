// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateRequestProperties4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(1312987858, 7265, 20458, 184, 254, 19, 95, 177, 156, 220, 228)]
  [ExclusiveTo(typeof (CertificateRequestProperties))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ICertificateRequestProperties4
  {
    IVector<string> SuppressedDefaults { get; }

    SubjectAlternativeNameInfo SubjectAlternativeName { get; }

    IVector<CertificateExtension> Extensions { get; }
  }
}
