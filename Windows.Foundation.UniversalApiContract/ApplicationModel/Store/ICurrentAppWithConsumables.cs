// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentAppWithConsumables
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CurrentApp))]
  [Guid(2219704433, 40527, 20345, 153, 90, 95, 145, 23, 46, 108, 239)]
  internal interface ICurrentAppWithConsumables
  {
    [RemoteAsync]
    IAsyncOperation<FulfillmentResult> ReportConsumableFulfillmentAsync(
      string productId,
      Guid transactionId);

    [Overload("RequestProductPurchaseWithResultsAsync")]
    [RemoteAsync]
    IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId);

    [Overload("RequestProductPurchaseWithDisplayPropertiesAsync")]
    [RemoteAsync]
    IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId,
      string offerId,
      ProductPurchaseDisplayProperties displayProperties);

    [RemoteAsync]
    IAsyncOperation<IVectorView<UnfulfilledConsumable>> GetUnfulfilledConsumablesAsync();
  }
}
