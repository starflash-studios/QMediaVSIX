// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentAppSimulatorWithConsumables
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (CurrentAppSimulator))]
  [Guid(1313992875, 8423, 17426, 155, 133, 89, 187, 120, 56, 134, 103)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICurrentAppSimulatorWithConsumables
  {
    [RemoteAsync]
    IAsyncOperation<FulfillmentResult> ReportConsumableFulfillmentAsync(
      string productId,
      Guid transactionId);

    [Overload("RequestProductPurchaseWithResultsAsync")]
    [RemoteAsync]
    IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId);

    [RemoteAsync]
    [Overload("RequestProductPurchaseWithDisplayPropertiesAsync")]
    IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId,
      string offerId,
      ProductPurchaseDisplayProperties displayProperties);

    [RemoteAsync]
    IAsyncOperation<IVectorView<UnfulfilledConsumable>> GetUnfulfilledConsumablesAsync();
  }
}
