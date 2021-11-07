// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateEnrollmentManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CertificateEnrollmentManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4260135614, 24956, 16986, 183, 45, 57, 139, 38, 172, 114, 100)]
  internal interface ICertificateEnrollmentManagerStatics3
  {
    [Overload("ImportPfxDataToKspWithParametersAsync")]
    [RemoteAsync]
    IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      PfxImportParameters pfxImportParameters);
  }
}
