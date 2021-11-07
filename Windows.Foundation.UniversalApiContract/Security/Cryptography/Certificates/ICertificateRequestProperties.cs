// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateRequestProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CertificateRequestProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1216251126, 38114, 19918, 136, 51, 26, 112, 10, 55, 162, 154)]
  internal interface ICertificateRequestProperties
  {
    string Subject { get; set; }

    string KeyAlgorithmName { get; set; }

    uint KeySize { get; set; }

    string FriendlyName { get; set; }

    string HashAlgorithmName { get; set; }

    ExportOption Exportable { get; set; }

    EnrollKeyUsages KeyUsages { get; set; }

    KeyProtectionLevel KeyProtectionLevel { get; set; }

    string KeyStorageProviderName { get; set; }
  }
}
