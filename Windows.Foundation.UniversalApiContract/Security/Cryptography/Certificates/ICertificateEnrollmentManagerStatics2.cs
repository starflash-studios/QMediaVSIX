// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateEnrollmentManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(3696958515, 25641, 16404, 153, 156, 93, 151, 53, 128, 45, 29)]
  [ExclusiveTo(typeof (CertificateEnrollmentManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICertificateEnrollmentManagerStatics2
  {
    UserCertificateEnrollmentManager UserCertificateEnrollmentManager { get; }

    [RemoteAsync]
    [Overload("ImportPfxDataToKspAsync")]
    IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      ExportOption exportable,
      KeyProtectionLevel keyProtectionLevel,
      InstallOptions installOption,
      string friendlyName,
      string keyStorageProvider);
  }
}
