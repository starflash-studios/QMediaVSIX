// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.Certificate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents a cryptography certificate.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Activatable(typeof (ICertificateFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Certificate : ICertificate, ICertificate2, ICertificate3
  {
    /// <summary>Create a new instance of the Certificate class using the specified certificate data.</summary>
    /// <param name="certBlob">The certificate data as an ASN.1 DER encoded certificate blob (.cer or .p7b).</param>
    [MethodImpl]
    public extern Certificate(IBuffer certBlob);

    [RemoteAsync]
    [Overload("BuildChainAsync")]
    [MethodImpl]
    public extern IAsyncOperation<CertificateChain> BuildChainAsync(
      IIterable<Certificate> certificates);

    [Overload("BuildChainWithParametersAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CertificateChain> BuildChainAsync(
      IIterable<Certificate> certificates,
      ChainBuildingParameters parameters);

    /// <summary>Gets the serial number of the certificate.</summary>
    /// <returns>The serial number of the certificate.</returns>
    public extern byte[] SerialNumber { [MethodImpl] get; }

    /// <summary>Gets the SHA1 hash value for the certificate.</summary>
    /// <returns>The SHA1 hash value for the certificate.</returns>
    [Overload("GetHashValue")]
    [MethodImpl]
    public extern byte[] GetHashValue();

    /// <summary>Gets the hash value for the certificate for a specified algorithm.</summary>
    /// <param name="hashAlgorithmName">The hash algorithm to use for the hash value of the certificate. Only values of "SHA1" or "SHA256" are supported. To get the SHA2 hash value for the certificate, specify "SHA256".</param>
    /// <returns>The hash value of the certificate.</returns>
    [Overload("GetHashValueWithAlgorithm")]
    [MethodImpl]
    public extern byte[] GetHashValue(string hashAlgorithmName);

    /// <summary>Gets the ASN.1 DER encoded certificate blob.</summary>
    /// <returns>The ASN.1 DER encoded certificate blob.</returns>
    [MethodImpl]
    public extern IBuffer GetCertificateBlob();

    /// <summary>Gets the subject name of the certificate.</summary>
    /// <returns>The subject name of the certificate.</returns>
    public extern string Subject { [MethodImpl] get; }

    /// <summary>Gets the name of the certificate issuer.</summary>
    /// <returns>The name of the certificate issuer.</returns>
    public extern string Issuer { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the certificate has a private key.</summary>
    /// <returns>True if the certificate has a private key; otherwise false.</returns>
    public extern bool HasPrivateKey { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the private key associated with the certificate is strongly protected.</summary>
    /// <returns>True if the certificate is strongly protected; otherwise false.</returns>
    public extern bool IsStronglyProtected { [MethodImpl] get; }

    /// <summary>Gets the date and time after which the certificate is valid.</summary>
    /// <returns>The date and time after which the certificate is valid.</returns>
    public extern DateTime ValidFrom { [MethodImpl] get; }

    /// <summary>Gets the date and time after which the certificate is no longer valid.</summary>
    /// <returns>The date and time after which the certificate is no longer valid.</returns>
    public extern DateTime ValidTo { [MethodImpl] get; }

    /// <summary>Gets a collection of object identifiers (OIDs) for the enhanced key usage extension.</summary>
    /// <returns>A collection of object identifiers (OIDs) for the enhanced key usage extension</returns>
    public extern IVectorView<string> EnhancedKeyUsages { [MethodImpl] get; }

    /// <summary>Gets or sets the friendly name for the certificate.</summary>
    /// <returns>The friendly name for the certificate. If the certificate does not have a friendly name set, then an empty string is returned.</returns>
    public extern string FriendlyName { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets whether the security device is bound.</summary>
    /// <returns>True if the security device is bound; otherwise, false.</returns>
    public extern bool IsSecurityDeviceBound { [MethodImpl] get; }

    /// <summary>Gets the key uses for the certificate.</summary>
    /// <returns>The key uses for the certificate.</returns>
    public extern CertificateKeyUsages KeyUsages { [MethodImpl] get; }

    /// <summary>Gets the name of the cryptographic algorithm used to create the key.</summary>
    /// <returns>The name of the cryptographic algorithm used to create the key.</returns>
    public extern string KeyAlgorithmName { [MethodImpl] get; }

    /// <summary>Gets the signature algorithm name.</summary>
    /// <returns>The signature algorithm name.</returns>
    public extern string SignatureAlgorithmName { [MethodImpl] get; }

    /// <summary>Gets the signature hash algorithm name.</summary>
    /// <returns>The signature hash algorithm name.</returns>
    public extern string SignatureHashAlgorithmName { [MethodImpl] get; }

    /// <summary>Gets info on the subject alternative name.</summary>
    /// <returns>Info on the subject alternative name.</returns>
    public extern SubjectAlternativeNameInfo SubjectAlternativeName { [MethodImpl] get; }

    /// <summary>Gets whether the certificate is per-user.</summary>
    /// <returns>True if the certificate is per-user; otherwise, false.</returns>
    public extern bool IsPerUser { [MethodImpl] get; }

    /// <summary>Gets the certificate's store name.</summary>
    /// <returns>The certificate's store name.</returns>
    public extern string StoreName { [MethodImpl] get; }

    /// <summary>Gets the certificate's key storage provider name.</summary>
    /// <returns>The certificate's key storage provider name.</returns>
    public extern string KeyStorageProviderName { [MethodImpl] get; }
  }
}
