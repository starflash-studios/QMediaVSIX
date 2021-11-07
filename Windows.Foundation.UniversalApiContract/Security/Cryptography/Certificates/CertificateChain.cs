// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateChain
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents a certificate chain used for signature verification.</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class CertificateChain : ICertificateChain
  {
    /// <summary>Verifies whether or not the certificate chain is valid.</summary>
    /// <returns>The result of the certificate chain verification operation.</returns>
    [Overload("Validate")]
    [MethodImpl]
    public extern ChainValidationResult Validate();

    /// <summary>Verifies whether or not the certificate chain is valid using the specified validation parameters.</summary>
    /// <param name="parameter">The validation parameters to use when verifying the certificate chain.</param>
    /// <returns>The result of the certificate chain verification operation.</returns>
    [Overload("ValidateWithParameters")]
    [MethodImpl]
    public extern ChainValidationResult Validate(
      ChainValidationParameters parameter);

    /// <summary>Gets the list of certificates from the certificate chain.</summary>
    /// <param name="includeRoot">True to include the root certificate in the results; otherwise false.</param>
    /// <returns>The list of certificates from the certificate chain.</returns>
    [MethodImpl]
    public extern IVectorView<Certificate> GetCertificates(bool includeRoot);
  }
}
