// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsAttachedSignatureStatics
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
  [ExclusiveTo(typeof (CmsAttachedSignature))]
  [Guid(2274925710, 45229, 18829, 167, 245, 120, 181, 155, 206, 75, 54)]
  internal interface ICmsAttachedSignatureStatics
  {
    [RemoteAsync]
    IAsyncOperation<IBuffer> GenerateSignatureAsync(
      IBuffer data,
      IIterable<CmsSignerInfo> signers,
      IIterable<Certificate> certificates);
  }
}
