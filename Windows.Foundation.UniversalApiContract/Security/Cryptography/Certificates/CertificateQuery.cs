// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateQuery
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents parameters for a query for certificates from the certificate store for an app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CertificateQuery : ICertificateQuery, ICertificateQuery2
  {
    /// <summary>Creates a new instance of a certificate query.</summary>
    [MethodImpl]
    public extern CertificateQuery();

    /// <summary>Gets a collection of object identifiers (OIDs) for the enhanced key usage extension to search for.</summary>
    /// <returns>A collection of object identifiers (OIDs) for the enhanced key usage extension to search for.</returns>
    public extern IVector<string> EnhancedKeyUsages { [MethodImpl] get; }

    /// <summary>Gets or sets the name of the certificate issuer to search for.</summary>
    /// <returns>The name of the certificate issuer to search for.</returns>
    public extern string IssuerName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the certificate friendly name to search for.</summary>
    /// <returns>The certificate friendly name to search for.</returns>
    public extern string FriendlyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a certificate thumbprint to search for.</summary>
    /// <returns>A certificate thumbprint to search for.</returns>
    public extern byte[] Thumbprint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether only hardware certificates (SC or TPM) are to be returned from the query.</summary>
    /// <returns>True if only hardware certificates (SC or TPM) are to be returned from the query; otherwise false.</returns>
    public extern bool HardwareOnly { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether to include duplicates.</summary>
    /// <returns>True if duplicates are included; otherwise, false.</returns>
    public extern bool IncludeDuplicates { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether to include expired certificates.</summary>
    /// <returns>True if expired certificates should be included; otherwise, false.</returns>
    public extern bool IncludeExpiredCertificates { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the store name.</summary>
    /// <returns>The store name.</returns>
    public extern string StoreName { [MethodImpl] get; [MethodImpl] set; }
  }
}
