// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.ICryptographicEngineStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CryptographicEngine))]
  [Guid(2682914361, 28663, 19589, 160, 149, 149, 235, 49, 113, 94, 185)]
  internal interface ICryptographicEngineStatics
  {
    IBuffer Encrypt(CryptographicKey key, IBuffer data, IBuffer iv);

    IBuffer Decrypt(CryptographicKey key, IBuffer data, IBuffer iv);

    EncryptedAndAuthenticatedData EncryptAndAuthenticate(
      CryptographicKey key,
      IBuffer data,
      IBuffer nonce,
      IBuffer authenticatedData);

    IBuffer DecryptAndAuthenticate(
      CryptographicKey key,
      IBuffer data,
      IBuffer nonce,
      IBuffer authenticationTag,
      IBuffer authenticatedData);

    IBuffer Sign(CryptographicKey key, IBuffer data);

    bool VerifySignature(CryptographicKey key, IBuffer data, IBuffer signature);

    IBuffer DeriveKeyMaterial(
      CryptographicKey key,
      KeyDerivationParameters parameters,
      uint desiredKeySize);
  }
}
