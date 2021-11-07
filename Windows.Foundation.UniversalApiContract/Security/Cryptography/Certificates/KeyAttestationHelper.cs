// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.KeyAttestationHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Provides access to key attestation methods.</summary>
  [Static(typeof (IKeyAttestationHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKeyAttestationHelperStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class KeyAttestationHelper
  {
    /// <summary>Decrypts a TPM key attestation credential.</summary>
    /// <param name="credential">The TPM key attestation credential to decrypt.</param>
    /// <param name="containerName">The container name of the credential.</param>
    /// <returns>When this method completes, it returns the decrypted TPM key attestation credential.</returns>
    [RemoteAsync]
    [Overload("DecryptTpmAttestationCredentialWithContainerNameAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<string> DecryptTpmAttestationCredentialAsync(
      string credential,
      string containerName);

    /// <summary>Decrypts a TPM key attestation credential.</summary>
    /// <param name="credential">
    /// </param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [Overload("DecryptTpmAttestationCredentialAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<string> DecryptTpmAttestationCredentialAsync(
      string credential);

    /// <summary>Gets the credential ID from a TPM key attestation credential.</summary>
    /// <param name="credential">The TPM key attestation credential to get the credential ID from.</param>
    /// <returns>The credential ID from the TPM key attestation credential.</returns>
    [MethodImpl]
    public static extern string GetTpmAttestationCredentialId(string credential);
  }
}
