// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (Certificate))]
  [Guid(859796492, 1240, 17331, 178, 120, 140, 95, 204, 155, 229, 160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICertificate
  {
    [RemoteAsync]
    [Overload("BuildChainAsync")]
    IAsyncOperation<CertificateChain> BuildChainAsync(
      IIterable<Certificate> certificates);

    [RemoteAsync]
    [Overload("BuildChainWithParametersAsync")]
    IAsyncOperation<CertificateChain> BuildChainAsync(
      IIterable<Certificate> certificates,
      ChainBuildingParameters parameters);

    byte[] SerialNumber { get; }

    [Overload("GetHashValue")]
    byte[] GetHashValue();

    [Overload("GetHashValueWithAlgorithm")]
    byte[] GetHashValue(string hashAlgorithmName);

    IBuffer GetCertificateBlob();

    string Subject { get; }

    string Issuer { get; }

    bool HasPrivateKey { get; }

    bool IsStronglyProtected { get; }

    DateTime ValidFrom { get; }

    DateTime ValidTo { get; }

    IVectorView<string> EnhancedKeyUsages { get; }

    string FriendlyName { set; get; }
  }
}
