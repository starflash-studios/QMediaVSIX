// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IUserCertificateEnrollmentManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(2519807768, 8929, 18457, 178, 11, 171, 70, 166, 236, 160, 110)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserCertificateEnrollmentManager))]
  internal interface IUserCertificateEnrollmentManager
  {
    [RemoteAsync]
    IAsyncOperation<string> CreateRequestAsync(CertificateRequestProperties request);

    [RemoteAsync]
    IAsyncAction InstallCertificateAsync(
      string certificate,
      InstallOptions installOption);

    [RemoteAsync]
    [Overload("ImportPfxDataAsync")]
    IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      ExportOption exportable,
      KeyProtectionLevel keyProtectionLevel,
      InstallOptions installOption,
      string friendlyName);

    [Overload("ImportPfxDataToKspAsync")]
    [RemoteAsync]
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
