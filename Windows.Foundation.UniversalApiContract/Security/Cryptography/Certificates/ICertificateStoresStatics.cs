// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateStoresStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(4226598713, 50942, 19943, 153, 207, 116, 195, 229, 150, 224, 50)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CertificateStores))]
  internal interface ICertificateStoresStatics
  {
    [RemoteAsync]
    [Overload("FindAllAsync")]
    IAsyncOperation<IVectorView<Certificate>> FindAllAsync();

    [RemoteAsync]
    [Overload("FindAllWithQueryAsync")]
    IAsyncOperation<IVectorView<Certificate>> FindAllAsync(
      CertificateQuery query);

    CertificateStore TrustedRootCertificationAuthorities { get; }

    CertificateStore IntermediateCertificationAuthorities { get; }

    CertificateStore GetStoreByName(string storeName);
  }
}
