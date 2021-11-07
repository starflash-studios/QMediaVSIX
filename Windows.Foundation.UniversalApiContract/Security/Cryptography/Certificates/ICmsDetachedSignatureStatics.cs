// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsDetachedSignatureStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(1024543997, 49051, 18050, 155, 230, 145, 245, 124, 5, 56, 8)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CmsDetachedSignature))]
  internal interface ICmsDetachedSignatureStatics
  {
    [RemoteAsync]
    IAsyncOperation<IBuffer> GenerateSignatureAsync(
      IInputStream data,
      IIterable<CmsSignerInfo> signers,
      IIterable<Certificate> certificates);
  }
}
