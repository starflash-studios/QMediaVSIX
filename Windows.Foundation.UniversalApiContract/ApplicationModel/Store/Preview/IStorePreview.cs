// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStorePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [ExclusiveTo(typeof (StorePreview))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2316661313, 33806, 18857, 188, 1, 93, 91, 1, 251, 200, 233)]
  internal interface IStorePreview
  {
    [RemoteAsync]
    IAsyncOperation<StorePreviewPurchaseResults> RequestProductPurchaseByProductIdAndSkuIdAsync(
      string productId,
      string skuId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<StorePreviewProductInfo>> LoadAddOnProductInfosAsync();
  }
}
