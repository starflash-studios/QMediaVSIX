// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IUserCertificateEnrollmentManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(229481649, 26078, 18730, 184, 109, 252, 92, 72, 44, 55, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserCertificateEnrollmentManager))]
  internal interface IUserCertificateEnrollmentManager2
  {
    [RemoteAsync]
    [Overload("ImportPfxDataToKspWithParametersAsync")]
    IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      PfxImportParameters pfxImportParameters);
  }
}
