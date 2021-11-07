// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.CryptographicEngine
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Encrypts, decrypts, and signs content, and verifies digital signatures.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICryptographicEngineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICryptographicEngineStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public static class CryptographicEngine
  {
    /// <summary>Signs the hashed input data using the specified key.</summary>
    /// <param name="key">The key to use to sign the hash. This key must be an asymmetric key obtained from a PersistedKeyProvider or AsymmetricKeyAlgorithmProvider.</param>
    /// <param name="data">The input data to sign. The data is a hashed value which can be obtained through incremental hash.</param>
    /// <returns>The signed data.</returns>
    [MethodImpl]
    public static extern IBuffer SignHashedData(CryptographicKey key, IBuffer data);

    /// <summary>Verifies the signature of the specified input data against a known signature.</summary>
    /// <param name="key">The key to use to retrieve the signature from the input data. This key must be an asymmetric key obtained from a PersistedKeyProvider or AsymmetricKeyAlgorithmProvider.</param>
    /// <param name="data">The data to be verified. The data is a hashed value of raw data.</param>
    /// <param name="signature">The known signature to use to verify the signature of the input data.</param>
    /// <returns>True if the signature is verified; otherwise false.</returns>
    [MethodImpl]
    public static extern bool VerifySignatureWithHashInput(
      CryptographicKey key,
      IBuffer data,
      IBuffer signature);

    /// <summary>Decrypts the encrypted input data using the supplied key.</summary>
    /// <param name="key">The key to use to decrypt the encrypted input data.</param>
    /// <param name="data">The encrypted data to decrypt.</param>
    /// <param name="iv">The initial vector for a symmetric key. For an asymmetric key, set this value to null.</param>
    /// <returns>The decrypted data.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> DecryptAsync(
      CryptographicKey key,
      IBuffer data,
      IBuffer iv);

    /// <summary>Computes a hash for the supplied input data, and then signs the computed hash using the specified key.</summary>
    /// <param name="key">The key to use to compute and sign the hash.</param>
    /// <param name="data">The raw input data to sign. The data is not hashed.</param>
    /// <returns>An asynchronous operation to retrieve the hashed and signed data.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> SignAsync(
      CryptographicKey key,
      IBuffer data);

    /// <summary>Signs the hashed input data using the specified key.</summary>
    /// <param name="key">The key to use to sign the hash. This key must be an asymmetric key obtained from a PersistedKeyProvider or AsymmetricKeyAlgorithmProvider.</param>
    /// <param name="data">The input data to sign. The data is a hashed value which can be obtained through incremental hash.</param>
    /// <returns>An asynchronous operation to retrieve the signed data.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> SignHashedDataAsync(
      CryptographicKey key,
      IBuffer data);

    /// <summary>Encrypts data by using a symmetric or asymmetric algorithm.</summary>
    /// <param name="key">Cryptographic key to use for encryption. This can be an asymmetric or a symmetric key. For more information, see AsymmetricKeyAlgorithmProvider and SymmetricKeyAlgorithmProvider.</param>
    /// <param name="data">Data to encrypt.</param>
    /// <param name="iv">Buffer that contains the initialization vector. This can be **null** for a symmetric algorithm and should always be **null** for an asymmetric algorithm. If an initialization vector (IV) was used to encrypt the data, you must use the same IV to decrypt the data. You can use the GenerateRandom method to create an IV that contains random data. Other IVs, such as nonce-generated vectors, require custom implementation. For more information, see Cryptographic keys.</param>
    /// <returns>Encrypted data.</returns>
    [MethodImpl]
    public static extern IBuffer Encrypt(CryptographicKey key, IBuffer data, IBuffer iv);

    /// <summary>Decrypts content that was previously encrypted by using a symmetric or asymmetric algorithm.</summary>
    /// <param name="key">Cryptographic key to use for decryption. This can be an asymmetric or a symmetric key. For more information, see AsymmetricKeyAlgorithmProvider and SymmetricKeyAlgorithmProvider.</param>
    /// <param name="data">Buffer that contains the encrypted data.</param>
    /// <param name="iv">Buffer that contains the initialization vector. If an initialization vector (IV) was used to encrypt the data, you must use the same IV to decrypt the data. For more information, see Encrypt.</param>
    /// <returns>Decrypted data.</returns>
    [MethodImpl]
    public static extern IBuffer Decrypt(CryptographicKey key, IBuffer data, IBuffer iv);

    /// <summary>Performs authenticated encryption.</summary>
    /// <param name="key">Symmetric key to use for encryption.</param>
    /// <param name="data">Data to be encrypted and authenticated.</param>
    /// <param name="nonce">Nonce to be used. A nonce is a variable that has minimal chance of repeating. For example, you can use a random value that is newly generated for each use, a time stamp, a sequence number, or some combination of these. The Microsoft GCM implementation requires a 12-byte nonce. The CCM implementation requires a 7- to 13- byte nonce.</param>
    /// <param name="authenticatedData">Authenticated data. This can be **Null**.</param>
    /// <returns>The encrypted and authenticated data.If the method fails, authentication fails; if the method succeeds, the authentication succeeded as well.</returns>
    [MethodImpl]
    public static extern EncryptedAndAuthenticatedData EncryptAndAuthenticate(
      CryptographicKey key,
      IBuffer data,
      IBuffer nonce,
      IBuffer authenticatedData);

    /// <summary>Decrypts and authenticates data. For more information and a complete code sample, see EncryptedAndAuthenticatedData.</summary>
    /// <param name="key">Symmetric key to use.</param>
    /// <param name="data">Data to be decrypted and authenticated.</param>
    /// <param name="nonce">Nonce to be used. This must be the same nonce used by the EncryptAndAuthenticate method.</param>
    /// <param name="authenticationTag">Authentication tag.</param>
    /// <param name="authenticatedData">Authenticated data. This can be **Null**.</param>
    /// <returns>A buffer that contains the decrypted data.If the method fails, authentication fails; if the method succeeds, the authentication succeeded as well.</returns>
    [MethodImpl]
    public static extern IBuffer DecryptAndAuthenticate(
      CryptographicKey key,
      IBuffer data,
      IBuffer nonce,
      IBuffer authenticationTag,
      IBuffer authenticatedData);

    /// <summary>Signs digital content. For more information, see MACs, hashes, and signatures.</summary>
    /// <param name="key">Key used for signing.</param>
    /// <param name="data">Data to be signed.</param>
    /// <returns>The data's signature.</returns>
    [MethodImpl]
    public static extern IBuffer Sign(CryptographicKey key, IBuffer data);

    /// <summary>Verifies a message signature.</summary>
    /// <param name="key">Key used for verification. This must be the same key previously used to sign the message.</param>
    /// <param name="data">Message to be verified.</param>
    /// <param name="signature">Signature previously computed over the message to be verified.</param>
    /// <returns>**true** if the message is verified.</returns>
    [MethodImpl]
    public static extern bool VerifySignature(
      CryptographicKey key,
      IBuffer data,
      IBuffer signature);

    /// <summary>Derives a key from another key by using a key derivation function. For more information, see the KeyDerivationAlgorithmProvider and KeyDerivationParameters classes.</summary>
    /// <param name="key">The symmetric or secret key used for derivation.</param>
    /// <param name="parameters">Derivation parameters. The parameters vary depending on the type of KDF algorithm used.</param>
    /// <param name="desiredKeySize">Requested size, in bytes, of the derived key.</param>
    /// <returns>Buffer that contains the derived key.</returns>
    [MethodImpl]
    public static extern IBuffer DeriveKeyMaterial(
      CryptographicKey key,
      KeyDerivationParameters parameters,
      uint desiredKeySize);
  }
}
