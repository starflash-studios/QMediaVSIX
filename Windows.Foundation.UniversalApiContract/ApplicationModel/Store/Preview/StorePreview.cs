// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StorePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  /// <summary>Defines static methods for retrieving the in-app product SKUs available for the current app and requesting the purchase of an in-app product SKU for the app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IStorePreview), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class StorePreview
  {
    /// <summary>Requests the purchase of a SKU for an in-app product that is associated with the current app. Calling this method displays the UI that is used to complete the transaction via the Microsoft Store.</summary>
    /// <param name="productId">Specifies the ID of the in-app product. This corresponds to the StorePreviewProductInfo.ProductId value and the StorePreviewSkuInfo.ProductId values for all SKUs of the in-app product.</param>
    /// <param name="skuId">Specifies the ID of the SKU for the in-app product. This corresponds to the StorePreviewSkuInfo.SkuId value.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns a StorePreviewPurchaseResults that contains the results of the in-app product purchase request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorePreviewPurchaseResults> RequestProductPurchaseByProductIdAndSkuIdAsync(
      string productId,
      string skuId);

    /// <summary>Retrieves the in-app products available for the current app asynchronously, including the available SKUs for each product.</summary>
    /// <returns>An asynchronous operation that, on successful completion, returns the collection of in-app products for the current app (including the available SKUs for each product). If you use Asynchronous programming, the result type is a read-only list/vector of StorePreviewProductInfo items. (You can use APIs of IVectorView&lt;StorePreviewProductInfo&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;StorePreviewProductInfo&gt; for .NET.)</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<StorePreviewProductInfo>> LoadAddOnProductInfosAsync();
  }
}
