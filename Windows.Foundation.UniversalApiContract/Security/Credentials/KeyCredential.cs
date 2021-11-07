// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredential
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  /// <summary>Represents a key credential, an RSA, 2048-bit, asymmetric key that represents a user's identity for an application.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class KeyCredential : IKeyCredential
  {
    /// <summary>Gets the name of the key credential.</summary>
    /// <returns>The name of the key credential.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the public portion of the asymmetric KeyCredential.</summary>
    /// <returns>The public portion of the asymmetric key credential.</returns>
    [Overload("RetrievePublicKeyWithDefaultBlobType")]
    [MethodImpl]
    public extern IBuffer RetrievePublicKey();

    /// <summary>Gets the public portion of the asymmetric KeyCredential.</summary>
    /// <param name="blobType">The blob type of the public key to retrieve.</param>
    /// <returns>The public portion of the asymmetric key credential.</returns>
    [Overload("RetrievePublicKeyWithBlobType")]
    [MethodImpl]
    public extern IBuffer RetrievePublicKey(CryptographicPublicKeyBlobType blobType);

    /// <summary>Prompts the user to cryptographcally sign data using their key credential.</summary>
    /// <param name="data">The data to cryptographically sign.</param>
    /// <returns>When this method completes, it returns a key credential operation result.</returns>
    [MethodImpl]
    public extern IAsyncOperation<KeyCredentialOperationResult> RequestSignAsync(
      IBuffer data);

    /// <summary>Gets an attestation for a key credential. Call this method after provisioning a key credential for the current user and application.</summary>
    /// <returns>When this method completes, it returns a key credential attestation result.</returns>
    [MethodImpl]
    public extern IAsyncOperation<KeyCredentialAttestationResult> GetAttestationAsync();
  }
}
