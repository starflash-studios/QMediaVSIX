// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ICodecQuery
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(573216058, 44897, 19972, 128, 138, 164, 99, 78, 47, 58, 196)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CodecQuery))]
  internal interface ICodecQuery
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<CodecInfo>> FindAllAsync(
      CodecKind kind,
      CodecCategory category,
      string subType);
  }
}
