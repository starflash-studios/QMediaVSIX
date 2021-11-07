// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ICurrentAppSimulator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (CurrentAppSimulator))]
  [Guid(4051672497, 29901, 18311, 151, 135, 25, 134, 110, 154, 85, 89)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICurrentAppSimulator
  {
    LicenseInformation LicenseInformation { get; }

    global::Windows.Foundation.Uri LinkUri { get; }

    Guid AppId { get; }

    [RemoteAsync]
    IAsyncOperation<string> RequestAppPurchaseAsync(bool includeReceipt);

    [RemoteAsync]
    [Deprecated("RequestProductPurchaseAsync(productId, includeReceipt) may be altered or unavailable for releases after Windows 8.1. Instead, use RequestProductPurchaseAsync(productId).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("RequestProductPurchaseAsync")]
    IAsyncOperation<string> RequestProductPurchaseAsync(
      string productId,
      bool includeReceipt);

    [RemoteAsync]
    IAsyncOperation<ListingInformation> LoadListingInformationAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetAppReceiptAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetProductReceiptAsync(string productId);

    [RemoteAsync]
    IAsyncAction ReloadSimulatorAsync(StorageFile simulatorSettingsFile);
  }
}
