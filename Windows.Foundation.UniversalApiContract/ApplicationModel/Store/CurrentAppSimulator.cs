// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.CurrentAppSimulator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Defines methods and properties used to instantiate an object that you can use to get simulated license info during testing.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICurrentAppSimulator), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICurrentAppSimulatorWithCampaignId), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICurrentAppSimulatorWithConsumables), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICurrentAppSimulatorStaticsWithFiltering), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class CurrentAppSimulator
  {
    /// <summary>Retrieves the promotion campaign ID for the current app.</summary>
    /// <returns>The advertising campaign ID for your app.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetAppPurchaseCampaignIdAsync();

    [MethodImpl]
    public static extern IAsyncOperation<ListingInformation> LoadListingInformationByProductIdsAsync(
      IIterable<string> productIds);

    [MethodImpl]
    public static extern IAsyncOperation<ListingInformation> LoadListingInformationByKeywordsAsync(
      IIterable<string> keywords);

    /// <summary>Simulates notifying the Microsoft Store that the purchase of a consumable add-on (also called an in-app product or IAP) is fulfilled and that the user has the right to access the content.</summary>
    /// <param name="productId">The product ID of the consumable add-on to report as fulfilled.</param>
    /// <param name="transactionId">The transaction ID for the simulated purchase of the consumable add-on.</param>
    /// <returns>A FulfillmentResult value that indicates the fulfillment status for the consumable add-on.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FulfillmentResult> ReportConsumableFulfillmentAsync(
      string productId,
      Guid transactionId);

    /// <summary>Creates the async operation that displays the UI that is used to simulate the purchase of an add-on (also called an in-app product or IAP) from the Microsoft Store.</summary>
    /// <param name="productId">The product ID (as defined by the simulation) of the add-on to purchase.</param>
    /// <returns>A PurchaseResults that contains the results of the simulated in-app product purchase request.</returns>
    [Overload("RequestProductPurchaseWithResultsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId);

    /// <summary>Creates the async operation that displays the UI that is used to simulate the purchase of an add-on (also called an in-app product or IAP) from the Microsoft Store. This overload includes parameters you can use to display details for a specific offer within a large catalog of in-app purchases that is represented by a single product entry in the Store.</summary>
    /// <param name="productId">The product ID (as defined by the simulation) of the add-on to purchase.</param>
    /// <param name="offerId">The specific in-app product within the large purchase catalog represented on the Microsoft Store by the *productId.* This value correlates with the content your app is responsible for fulfilling. The Microsoft Store only uses this parameter value to itemize the PurchaseResults.</param>
    /// <param name="displayProperties">The name of the in-app product that is displayed to the user at time of purchase.</param>
    /// <returns>A PurchaseResults that contains the results of the simulated in-app product purchase request.</returns>
    [RemoteAsync]
    [Overload("RequestProductPurchaseWithDisplayPropertiesAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId,
      string offerId,
      ProductPurchaseDisplayProperties displayProperties);

    /// <summary>Returns a list of purchased consumable in-app products that have not been fulfilled locally.</summary>
    /// <returns>When the operation completes, a list of unfulfilled consumable in-app products (UnfulfilledConsumable objects) is returned. Each item in this list provides the product ID, offer ID, and transaction ID associated with a product.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<UnfulfilledConsumable>> GetUnfulfilledConsumablesAsync();

    /// <summary>Gets the simulated license metadata for the current app as provided by the simulation.</summary>
    /// <returns>The license metadata for the current app as provided by the simulation.</returns>
    public static extern LicenseInformation LicenseInformation { [MethodImpl] get; }

    /// <summary>Gets the simulated Uniform Resource Identifier (URI) that represents a Microsoft Store listing page for the current app.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the Microsoft Store listing page for the current app as defined by the simulation.</returns>
    public static extern global::Windows.Foundation.Uri LinkUri { [MethodImpl] get; }

    /// <summary>Gets a simulated app ID. Since CurrentAppSimulator is intended only for testing during app development, the returned CurrentAppSimulator.AppId will contain only 0's.</summary>
    /// <returns>The GUID that identifies the app in the Windows Store.</returns>
    public static extern Guid AppId { [MethodImpl] get; }

    /// <summary>Creates the async operation that simulates a user request to buy a full license for the current app.</summary>
    /// <param name="includeReceipt">Determines if the method should return the receipts for this app.</param>
    /// <returns>If the *includeReceipt* parameter is set to true, this string contains XML that represents all receipts for the app and any in-app product purchases. If *includeReceipt* is set to false, this string is empty.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> RequestAppPurchaseAsync(
      bool includeReceipt);

    /// <summary>Creates the async operation that displays the UI that is used to simulate the purchase of an add-on (also called an in-app product or IAP) from the Microsoft Store.</summary>
    /// <deprecated type="deprecate">RequestProductPurchaseAsync(productId, includeReceipt) may be altered or unavailable for releases after Windows 8.1. Instead, use RequestProductPurchaseAsync(productId).</deprecated>
    /// <param name="productId">The product ID (as defined by the simulation) of the add-on to purchase.</param>
    /// <param name="includeReceipt">Determines if the method should return the receipts for the specified *productId.*</param>
    /// <returns>A string providing in-app product purchase details for the provided *productId*. If *includeReceipt* is set **true**, the returned string will include a full receipt xml.</returns>
    [Overload("RequestProductPurchaseAsync")]
    [Deprecated("RequestProductPurchaseAsync(productId, includeReceipt) may be altered or unavailable for releases after Windows 8.1. Instead, use RequestProductPurchaseAsync(productId).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> RequestProductPurchaseAsync(
      string productId,
      bool includeReceipt);

    /// <summary>Loads the simulated app listing information asynchronously. </summary>
    /// <returns>The app listing information as defined by the simulation. If the method fails, it returns an **HRESULT** error code.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ListingInformation> LoadListingInformationAsync();

    /// <summary>Creates the async operation that the user can use to simulate requesting all receipts for this app and any in-app product purchases. For examples of how receipt information can be used, see Using receipts to verify product purchases.</summary>
    /// <returns>An XML-formatted string that contains all receipts for this app and any in-app product purchases.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetAppReceiptAsync();

    /// <summary>Creates the async operation that the user can use to simulate requesting the receipt for the specified product ID. For examples of how receipt information can be used, see Using receipts to verify product purchases.</summary>
    /// <param name="productId">The unique identifier for the product. This ID is that was specified when the product was submitted for the app to the Store.</param>
    /// <returns>An XML-formatted string that contains the receipt for the specified product ID.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetProductReceiptAsync(
      string productId);

    /// <summary>Reloads the simulator using a StorageFile containing the **WindowsStoreProxy.xml** file.</summary>
    /// <param name="simulatorSettingsFile">The WindowsStoreProxy.xml file that the simulator uses.</param>
    /// <returns>The async operation that reloads the simulator.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ReloadSimulatorAsync(
      StorageFile simulatorSettingsFile);
  }
}
