// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateKeyUsages
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents the usages of a certificate key.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CertificateKeyUsages : ICertificateKeyUsages
  {
    /// <summary>Creates a new instance of the CertificateKeyUsages class.</summary>
    [MethodImpl]
    public extern CertificateKeyUsages();

    /// <summary>Gets or sets if the key is for encipher only.</summary>
    /// <returns>True if the key is for encipher only; otherwise, false.</returns>
    public extern bool EncipherOnly { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets if the key is for cRLSign.</summary>
    /// <returns>True if the key is for cRLSign; otherwise, false.</returns>
    public extern bool CrlSign { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets if the key is for key certificate sign.</summary>
    /// <returns>True if the key is for key certificate sign; otherwise, false.</returns>
    public extern bool KeyCertificateSign { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets if the key is for key agreement.</summary>
    /// <returns>True if the key is for key agreement; otherwise, false.</returns>
    public extern bool KeyAgreement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets if the key is for data encipherment.</summary>
    /// <returns>True if the key is for data encipherment; otherwise, false.</returns>
    public extern bool DataEncipherment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets if the key is for key encipherment.</summary>
    /// <returns>True if the key is for key encipherment; otherwise, false.</returns>
    public extern bool KeyEncipherment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets if the key is for non-repudiation.</summary>
    /// <returns>True if the key is for non-repudiation; otherwise, false.</returns>
    public extern bool NonRepudiation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets if the key is for digital signature.</summary>
    /// <returns>True if the key is for digital signature; otherwise, false.</returns>
    public extern bool DigitalSignature { [MethodImpl] get; [MethodImpl] set; }
  }
}
