// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateQuery2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CertificateQuery))]
  [Guid(2472151799, 3033, 20341, 184, 194, 226, 122, 127, 116, 238, 205)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICertificateQuery2
  {
    bool IncludeDuplicates { get; set; }

    bool IncludeExpiredCertificates { get; set; }

    string StoreName { get; set; }
  }
}
