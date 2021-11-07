// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CmsDetachedSignature
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
  /// <summary>Represents a detached signature for a signed CMS message.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (ICmsDetachedSignatureStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ICmsDetachedSignatureFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CmsDetachedSignature : ICmsDetachedSignature
  {
    /// <summary>Creates a new instance of the CmsDetachedSignature class for the specified signed CMS message.</summary>
    /// <param name="inputBlob">A signed CMS message blob.</param>
    [MethodImpl]
    public extern CmsDetachedSignature(IBuffer inputBlob);

    /// <summary>Gets the list of certificates that are used for chain building for the signer certificate.</summary>
    /// <returns>The list of certificates that are used for chain building for the signer certificate.</returns>
    public extern IVectorView<Certificate> Certificates { [MethodImpl] get; }

    /// <summary>Gets the list of signers that are used for creating or verifying the signature.</summary>
    /// <returns>The list of signers that are used for creating or verifying the signature.</returns>
    public extern IVectorView<CmsSignerInfo> Signers { [MethodImpl] get; }

    /// <summary>Verifies a signed CMS message against the original streaming input.</summary>
    /// <param name="data">The original input stream for the signed CMS message.</param>
    /// <returns>An asynchronous operation to retrieve the result of the signature validation operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SignatureValidationResult> VerifySignatureAsync(
      IInputStream data);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> GenerateSignatureAsync(
      IInputStream data,
      IIterable<CmsSignerInfo> signers,
      IIterable<Certificate> certificates);
  }
}
