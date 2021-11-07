// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CmsAttachedSignature
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
  /// <summary>Represents a signature attached to a signed CMS message.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICmsAttachedSignatureStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [Activatable(typeof (ICmsAttachedSignatureFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CmsAttachedSignature : ICmsAttachedSignature
  {
    /// <summary>Creates a new instance of the CmsAttachedSignature class for the specified signed CMS message.</summary>
    /// <param name="inputBlob">A signed CMS message blob.</param>
    [MethodImpl]
    public extern CmsAttachedSignature(IBuffer inputBlob);

    /// <summary>Gets the list of certificates that are used for chain building for the signer certificate.</summary>
    /// <returns>The list of certificates that are used for chain building for the signer certificate.</returns>
    public extern IVectorView<Certificate> Certificates { [MethodImpl] get; }

    /// <summary>Gets the content of the signed CMS message.</summary>
    /// <returns>The content of the signed CMS message.</returns>
    public extern byte[] Content { [MethodImpl] get; }

    /// <summary>Gets the list of signers that are used for creating or verifying the signature.</summary>
    /// <returns>The list of signers that are used for creating or verifying the signature.</returns>
    public extern IVectorView<CmsSignerInfo> Signers { [MethodImpl] get; }

    /// <summary>Verifies the signature contained in the signed CMS message.</summary>
    /// <returns>The result of the signature verification operation.</returns>
    [MethodImpl]
    public extern SignatureValidationResult VerifySignature();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> GenerateSignatureAsync(
      IBuffer data,
      IIterable<CmsSignerInfo> signers,
      IIterable<Certificate> certificates);
  }
}
