// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.AsymmetricKeyAlgorithmProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Represents a provider of asymmetric (public) key algorithms. For more information, see Cryptographic keys.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IAsymmetricKeyAlgorithmProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AsymmetricKeyAlgorithmProvider : 
    IAsymmetricKeyAlgorithmProvider,
    IAsymmetricKeyAlgorithmProvider2
  {
    /// <summary>Gets the name of the open asymmetric algorithm.</summary>
    /// <returns>Algorithm name.</returns>
    public extern string AlgorithmName { [MethodImpl] get; }

    /// <summary>Creates a public/private key pair.</summary>
    /// <param name="keySize">Size, in bits, of the key. Typical key sizes are 512, 1024, 2048, or 4096 bits.</param>
    /// <returns>Represents the asymmetric key pair.</returns>
    [MethodImpl]
    public extern CryptographicKey CreateKeyPair(uint keySize);

    /// <summary>Imports a public/private key pair from a buffer.</summary>
    /// <param name="keyBlob">Buffer that contains the key pair to import.</param>
    /// <returns>Represents the imported key pair.</returns>
    [Overload("ImportDefaultPrivateKeyBlob")]
    [MethodImpl]
    public extern CryptographicKey ImportKeyPair(IBuffer keyBlob);

    /// <summary>Imports a public/private key pair from a buffer in the specified format.</summary>
    /// <param name="keyBlob">Buffer that contains the key pair to import.</param>
    /// <param name="BlobType">A CryptographicPrivateKeyBlobType enumeration value that specifies information about the private key contained in the *keyBlob* buffer. The default value is **Pkcs8RawPrivateKeyInfo**.</param>
    /// <returns>Represents the imported key pair.</returns>
    [Overload("ImportKeyPairWithBlobType")]
    [MethodImpl]
    public extern CryptographicKey ImportKeyPair(
      IBuffer keyBlob,
      CryptographicPrivateKeyBlobType BlobType);

    /// <summary>Imports a public key into a buffer.</summary>
    /// <param name="keyBlob">Buffer that contains the key to import.</param>
    /// <returns>Represents the imported key.</returns>
    [Overload("ImportDefaultPublicKeyBlob")]
    [MethodImpl]
    public extern CryptographicKey ImportPublicKey(IBuffer keyBlob);

    /// <summary>Imports a public key into a buffer for a specified format.</summary>
    /// <param name="keyBlob">Buffer that contains the key to import.</param>
    /// <param name="BlobType">A CryptographicPublicKeyBlobType enumeration value that specifies the format of the public key contained in the *keyBlob* buffer. The default value is **X509SubjectPublicKeyInfo**.</param>
    /// <returns>Represents the imported key.</returns>
    [Overload("ImportPublicKeyWithBlobType")]
    [MethodImpl]
    public extern CryptographicKey ImportPublicKey(
      IBuffer keyBlob,
      CryptographicPublicKeyBlobType BlobType);

    /// <summary>Creates a public/private key pair using a curve name.</summary>
    /// <param name="curveName">The name of the curve.</param>
    /// <returns>Represents the asymmetric key pair.</returns>
    [MethodImpl]
    public extern CryptographicKey CreateKeyPairWithCurveName(string curveName);

    /// <summary>Creates a public/private key pair using curve parameters.</summary>
    /// <param name="parameters">The curve parameters.</param>
    /// <returns>Represents the asymmetric key pair.</returns>
    [MethodImpl]
    public extern CryptographicKey CreateKeyPairWithCurveParameters(
      [Range(0, 65536)] byte[] parameters);

    /// <summary>Creates an instance of the AsymmetricKeyAlgorithmProvider class and opens the specified algorithm for use.</summary>
    /// <param name="algorithm">Algorithm name.</param>
    /// <returns>Represents a public key algorithm provider.</returns>
    [MethodImpl]
    public static extern AsymmetricKeyAlgorithmProvider OpenAlgorithm(
      string algorithm);
  }
}
