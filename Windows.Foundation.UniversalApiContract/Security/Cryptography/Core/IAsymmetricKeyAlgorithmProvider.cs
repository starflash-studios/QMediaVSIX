// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IAsymmetricKeyAlgorithmProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (AsymmetricKeyAlgorithmProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3906142007, 25177, 20104, 183, 224, 148, 25, 31, 222, 105, 158)]
  internal interface IAsymmetricKeyAlgorithmProvider
  {
    string AlgorithmName { get; }

    CryptographicKey CreateKeyPair(uint keySize);

    [Overload("ImportDefaultPrivateKeyBlob")]
    CryptographicKey ImportKeyPair(IBuffer keyBlob);

    [Overload("ImportKeyPairWithBlobType")]
    CryptographicKey ImportKeyPair(
      IBuffer keyBlob,
      CryptographicPrivateKeyBlobType BlobType);

    [Overload("ImportDefaultPublicKeyBlob")]
    CryptographicKey ImportPublicKey(IBuffer keyBlob);

    [Overload("ImportPublicKeyWithBlobType")]
    CryptographicKey ImportPublicKey(
      IBuffer keyBlob,
      CryptographicPublicKeyBlobType BlobType);
  }
}
