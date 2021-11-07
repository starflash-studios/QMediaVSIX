// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateRequestProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents the properties of a certificate request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public sealed class CertificateRequestProperties : 
    ICertificateRequestProperties,
    ICertificateRequestProperties2,
    ICertificateRequestProperties3,
    ICertificateRequestProperties4
  {
    /// <summary>Creates and initializes a new instance of the CertificateRequestProperties.</summary>
    [MethodImpl]
    public extern CertificateRequestProperties();

    /// <summary>Gets or sets the subject name.</summary>
    /// <returns>The X.500 distinguished name (DN).</returns>
    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the public key algorithm.</summary>
    /// <returns>Algorithm name.</returns>
    public extern string KeyAlgorithmName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the size, in bits, of the private key to be generated.</summary>
    /// <returns>The size, in bits, of the private key.</returns>
    public extern uint KeySize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the display name of the enrolled certificate.</summary>
    /// <returns>The display name.</returns>
    public extern string FriendlyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the hash algorithm used when creating the certificate request signature.</summary>
    /// <returns>Hash algorithm.</returns>
    public extern string HashAlgorithmName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the private key created for the request can be exported.</summary>
    /// <returns>Specifies whether the key can be exported.</returns>
    public extern ExportOption Exportable { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the operation that can be performed by the private key created for this certificate request. The default value is **Signing**.</summary>
    /// <returns>Private key usage.</returns>
    public extern EnrollKeyUsages KeyUsages { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the level of strong key protection.</summary>
    /// <returns>Strong key protection level.</returns>
    public extern KeyProtectionLevel KeyProtectionLevel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of the key storage provider (KSP) that will be used to generate the private key.</summary>
    /// <returns>The KSP name. The default value is "Microsoft Software Key Storage Provider".</returns>
    public extern string KeyStorageProviderName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of the smart card reader used to create the certificate request.</summary>
    /// <returns>The name of the smart card reader used to create the certificate request.</returns>
    public extern string SmartcardReaderName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the certificate used to sign the certificate request.</summary>
    /// <returns>The certificate used to sign the certificate request.</returns>
    public extern Certificate SigningCertificate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the CA exchange certificate that is used to encrypt a key attestation certificate request.</summary>
    /// <returns>The CA exchange certificate that is used to encrypt a key attestation certificate request.</returns>
    public extern Certificate AttestationCredentialCertificate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of the elliptic curve.</summary>
    /// <returns>The name of the elliptic curve.</returns>
    public extern string CurveName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the parameters of the elliptic curve.</summary>
    /// <returns>The parameters of the elliptic curve.</returns>
    public extern byte[] CurveParameters { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the prefix of the container name.</summary>
    /// <returns>The prefix of the container name.</returns>
    public extern string ContainerNamePrefix { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the container name.</summary>
    /// <returns>The container name.</returns>
    public extern string ContainerName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether to use the existing key.</summary>
    /// <returns>True if using the existing key; otherwise, false.</returns>
    public extern bool UseExistingKey { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a vector of suppressed defaults.</summary>
    /// <returns>A vector of suppressed defaults.</returns>
    public extern IVector<string> SuppressedDefaults { [MethodImpl] get; }

    /// <summary>Gets the subject alternative name.</summary>
    /// <returns>The subject alternative name.</returns>
    public extern SubjectAlternativeNameInfo SubjectAlternativeName { [MethodImpl] get; }

    /// <summary>Gets a vector of certificate extensions.</summary>
    /// <returns>A vector of certificate extensions.</returns>
    public extern IVector<CertificateExtension> Extensions { [MethodImpl] get; }
  }
}
