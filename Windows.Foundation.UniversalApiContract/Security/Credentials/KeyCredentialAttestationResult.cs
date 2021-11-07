// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredentialAttestationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  /// <summary>Represents the results of the KeyCredential.GetAttestationAsync method.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class KeyCredentialAttestationResult : IKeyCredentialAttestationResult
  {
    /// <summary>Gets the chain of certificates used to verify the attestation.</summary>
    /// <returns>The chain of certificates used to verify the attestation.</returns>
    public extern IBuffer CertificateChainBuffer { [MethodImpl] get; }

    /// <summary>Gets the attestation information for the KeyCredential.</summary>
    /// <returns>The attestation information for the KeyCredential.</returns>
    public extern IBuffer AttestationBuffer { [MethodImpl] get; }

    /// <summary>Gets the status of the key credential attestation.</summary>
    /// <returns>The status of the key credential attestation.</returns>
    public extern KeyCredentialAttestationStatus Status { [MethodImpl] get; }
  }
}
