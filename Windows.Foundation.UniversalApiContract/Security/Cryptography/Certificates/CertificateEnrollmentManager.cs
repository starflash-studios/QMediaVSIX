// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents a certificate enrollment manager.</summary>
  [DualApiPartition(version = 100794368)]
  [Static(typeof (ICertificateEnrollmentManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICertificateEnrollmentManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICertificateEnrollmentManagerStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class CertificateEnrollmentManager
  {
    /// <summary>Asynchronously imports a certificate from a Personal Information Exchange (PFX) message using import parameters.</summary>
    /// <param name="pfxData">Base64-encoded PFX message.</param>
    /// <param name="password">The password used to decrypt and verify the PFX packet. The password must be exactly the same as the password that was used to encrypt the packet.</param>
    /// <param name="pfxImportParameters">The PFX import parameters.</param>
    /// <returns>This method does not return a value.</returns>
    [Overload("ImportPfxDataToKspWithParametersAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      PfxImportParameters pfxImportParameters);

    /// <summary>Gets the associated UserCertificateEnrollmentManager.</summary>
    /// <returns>The associated UserCertificateEnrollmentManager.</returns>
    public static extern UserCertificateEnrollmentManager UserCertificateEnrollmentManager { [MethodImpl] get; }

    /// <summary>Asynchronously imports a certificate from a Personal Information Exchange (PFX) message using the specified key storage provider.</summary>
    /// <param name="pfxData">Base64-encoded PFX message.</param>
    /// <param name="password">The password used to decrypt and verify the PFX packet. The password must be exactly the same as the password that was used to encrypt the packet.</param>
    /// <param name="exportable">A value of the ExportOption enumeration that specifies whether the key can be exported.</param>
    /// <param name="keyProtectionLevel">A value of the KeyProtectionLevel enumeration that specifies the strength of the key protection. The default is **NoConsent**.</param>
    /// <param name="installOption">An InstallOptions enumeration value that specifies the certificate installation option.</param>
    /// <param name="friendlyName">The display name of the enrolled certificate. This value overwrites the **FriendlyName** property inside the PFX message.</param>
    /// <param name="keyStorageProvider">The name of the key storage provider to use when importing the certificate.</param>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [Overload("ImportPfxDataToKspAsync")]
    [MethodImpl]
    public static extern IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      ExportOption exportable,
      KeyProtectionLevel keyProtectionLevel,
      InstallOptions installOption,
      string friendlyName,
      string keyStorageProvider);

    /// <summary>Asynchronously creates a PKCS #10 certificate request based on properties specified in a CertificateRequestProperties object.</summary>
    /// <param name="request">A CertificateRequestProperties object that contains the property values used to create the certificate request.</param>
    /// <returns>This method returns a string that contains the base64 encoded PKCS #10 certificate request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> CreateRequestAsync(
      CertificateRequestProperties request);

    /// <summary>Asynchronously Installs a certificate chain into the app container on the local computer.</summary>
    /// <param name="certificate">The encoded certificate. The *certificate* is encoded by using Distinguished Encoding Rules (DER) as defined by the Abstract Syntax Notation One (ASN.1) standard.</param>
    /// <param name="installOption">An InstallOptions enumeration value that specifies the certificate installation option.</param>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction InstallCertificateAsync(
      string certificate,
      InstallOptions installOption);

    /// <summary>Asynchronously imports a certificate from a Personal Information Exchange (PFX) message.</summary>
    /// <param name="pfxData">Base64-encoded PFX message.</param>
    /// <param name="password">The password used to decrypt and verify the PFX packet. The password must be exactly the same as the password that was used to encrypt the packet.</param>
    /// <param name="exportable">A value of the ExportOption enumeration that specifies whether the key can be exported.</param>
    /// <param name="keyProtectionLevel">A value of the KeyProtectionLevel enumeration that specifies the strength of the key protection. The default is **NoConsent**.</param>
    /// <param name="installOption">An InstallOptions enumeration value that specifies the certificate installation option.</param>
    /// <param name="friendlyName">The display name of the enrolled certificate. This value overwrites the **FriendlyName** property inside the PFX message.</param>
    /// <returns>This method does not return a value.</returns>
    [Overload("ImportPfxDataAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      ExportOption exportable,
      KeyProtectionLevel keyProtectionLevel,
      InstallOptions installOption,
      string friendlyName);
  }
}
