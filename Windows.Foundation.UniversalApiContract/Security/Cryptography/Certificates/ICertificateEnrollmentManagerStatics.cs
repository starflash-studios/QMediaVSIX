﻿// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateEnrollmentManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2286350143, 43398, 18683, 159, 215, 154, 236, 6, 147, 91, 241)]
  [ExclusiveTo(typeof (CertificateEnrollmentManager))]
  internal interface ICertificateEnrollmentManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<string> CreateRequestAsync(CertificateRequestProperties request);

    [RemoteAsync]
    IAsyncAction InstallCertificateAsync(
      string certificate,
      InstallOptions installOption);

    [Overload("ImportPfxDataAsync")]
    [RemoteAsync]
    IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      ExportOption exportable,
      KeyProtectionLevel keyProtectionLevel,
      InstallOptions installOption,
      string friendlyName);
  }
}