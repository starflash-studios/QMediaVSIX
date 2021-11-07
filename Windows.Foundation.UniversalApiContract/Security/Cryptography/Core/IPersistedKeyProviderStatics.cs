// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IPersistedKeyProviderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (PersistedKeyProvider))]
  [Guid(1999063060, 55764, 19701, 182, 104, 224, 69, 125, 243, 8, 148)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPersistedKeyProviderStatics
  {
    [RemoteAsync]
    IAsyncOperation<CryptographicKey> OpenKeyPairFromCertificateAsync(
      Certificate certificate,
      string hashAlgorithmName,
      CryptographicPadding padding);

    CryptographicKey OpenPublicKeyFromCertificate(
      Certificate certificate,
      string hashAlgorithmName,
      CryptographicPadding padding);
  }
}
