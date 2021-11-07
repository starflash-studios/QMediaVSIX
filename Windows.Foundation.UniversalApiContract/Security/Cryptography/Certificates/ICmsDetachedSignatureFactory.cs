// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsDetachedSignatureFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(3299554563, 44671, 17287, 173, 25, 0, 241, 80, 228, 142, 187)]
  [ExclusiveTo(typeof (CmsDetachedSignature))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICmsDetachedSignatureFactory
  {
    CmsDetachedSignature CreateCmsDetachedSignature(IBuffer inputBlob);
  }
}
