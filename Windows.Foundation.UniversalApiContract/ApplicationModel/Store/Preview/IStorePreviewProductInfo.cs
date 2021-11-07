// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStorePreviewProductInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [ExclusiveTo(typeof (StorePreviewProductInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(423091123, 27649, 19613, 133, 205, 91, 171, 170, 194, 179, 81)]
  internal interface IStorePreviewProductInfo
  {
    string ProductId { get; }

    string ProductType { get; }

    string Title { get; }

    string Description { get; }

    IVectorView<StorePreviewSkuInfo> SkuInfoList { get; }
  }
}
