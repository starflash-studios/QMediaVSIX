// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsDetachedSignature
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(253686100, 63070, 17718, 131, 57, 89, 68, 8, 29, 178, 202)]
  [ExclusiveTo(typeof (CmsDetachedSignature))]
  internal interface ICmsDetachedSignature
  {
    IVectorView<Certificate> Certificates { get; }

    IVectorView<CmsSignerInfo> Signers { get; }

    [RemoteAsync]
    IAsyncOperation<SignatureValidationResult> VerifySignatureAsync(
      IInputStream data);
  }
}
