// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.CurrentApp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Defines methods and properties you can use to get license and listing info about the current app and perform in-app product purchases.</summary>
  [Static(typeof (ICurrentAppWithCampaignId), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICurrentApp2Statics), 131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICurrentAppStaticsWithFiltering), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICurrentApp), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICurrentAppWithConsumables), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class CurrentApp
  {
    /// <summary>Retrieves a Microsoft Store ID key that can be used to grant entitlements for free products on behalf of the current user.</summary>
    /// <param name="serviceTicket">An Azure Active Directory access token that identifies the publisher of the current app. For more information about generating this token, see Manage product entitlements from a service.</param>
    /// <param name="publisherUserId">An anonymous ID that identifies the current user in the context of services that you manage as the publisher of the current app. If you maintain user IDs in the context of your services, you can use this parameter to associate your ID for the current user with the new Microsoft Store ID key (the user ID will be embedded in the key). Otherwise, if you don't need to associate a user ID with the Microsoft Store ID key, you can pass any string value.</param>
    /// <returns>The purchase ID key for the current user. This key is valid for 90 days.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetCustomerPurchaseIdAsync(
      string serviceTicket,
      string publisherUserId);

    /// <summary>Retrieves a Microsoft Store ID key that can be used to query for product entitlements or to consume product entitlements that are owned by the current user.</summary>
    /// <param name="serviceTicket">An Azure Active Directory access token that identifies the publisher of the current app. For more information about generating this token, see Manage product entitlements from a service.</param>
    /// <param name="publisherUserId">An anonymous ID that identifies the current user in the context of services that you manage as the publisher of the current app. If you maintain user IDs in the context of your services, you can use this parameter to associate your ID for the current user with the new Microsoft Store ID key (the user ID will be embedded in the key). Otherwise, if you don't need to associate a user ID with the Microsoft Store ID key, you can pass any string value.</param>
    /// <returns>The collections ID key for the current user. This key is valid for 90 days.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetCustomerCollectionsIdAsync(
      string serviceTicket,
      string publisherUserId);

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

    /// <summary>Notifies the Microsoft Store that the application has fulfilled the in-app product. This product cannot be re-purchased until the app has confirmed fulfillment using this method.</summary>
    /// <param name="productId">The ID of the product that has been delivered to the user.</param>
    [MethodImpl]
    public static extern void ReportProductFulfillment(string productId);

    /// <summary>Notifies the Microsoft Store that the purchase of a consumable add-on (also called an in-app product or IAP) is fulfilled and that the user has the right to access the content.</summary>
    /// <param name="productId">The product ID of the consumable add-on to report as fulfilled.</param>
    /// <param name="transactionId">The transaction ID for the purchase of the consumable add-on.</param>
    /// <returns>A FulfillmentResult value that indicates the fulfillment status for the consumable add-on.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FulfillmentResult> ReportConsumableFulfillmentAsync(
      string productId,
      Guid transactionId);

    /// <summary>Requests the purchase of an add-on (also called an in-app product or IAP). Additionally, calling this method displays the UI that is used to complete the transaction via the Microsoft Store.</summary>
    /// <param name="productId">The product ID of the add-on to purchase.</param>
    /// <returns>A PurchaseResults that contains the results of the in-app product purchase request.</returns>
    [RemoteAsync]
    [Overload("RequestProductPurchaseWithResultsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId);

    /// <summary>Requests the purchase of an add-on (also called an in-app product or IAP). Additionally, calling this method displays the UI that is used to complete the transaction via the Microsoft Store. This overload includes parameters you can use to display details for a specific offer within a large catalog of in-app purchases that is represented by a single product entry in the Store.</summary>
    /// <param name="productId">The product ID of the add-on to purchase.</param>
    /// <param name="offerId">The specific in-app feature or content within the large purchase catalog represented on the Microsoft Store by the *productId.* This value correlates with the content your app is responsible for fulfilling. The Microsoft Store only uses this value to itemize the PurchaseResults.</param>
    /// <param name="displayProperties">The name of the app feature or content offer that is displayed to the user at time of purchase.</param>
    /// <returns>A PurchaseResults that contains the results of the in-app product purchase request.</returns>
    [RemoteAsync]
    [Overload("RequestProductPurchaseWithDisplayPropertiesAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<PurchaseResults> RequestProductPurchaseAsync(
      string productId,
      string offerId,
      ProductPurchaseDisplayProperties displayProperties);

    /// <summary>Returns a list of purchased consumable in-app products that have not been reported to the Microsoft Store as fulfilled.</summary>
    /// <returns>When the operation completes, a list of consumable in-app products not yet reported as fulfilled is returned (UnfulfilledConsumable objects). Each item of this list provides the product ID, offer ID, and transaction ID associated with a product.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<UnfulfilledConsumable>> GetUnfulfilledConsumablesAsync();

    /// <summary>Gets the license metadata for the current app.</summary>
    /// <returns>The license metadata for the current app.</returns>
    public static extern LicenseInformation LicenseInformation { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI) of the app's listing page in the web catalog of the Windows Store.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the app's listing page in the Windows Store.</returns>
    public static extern global::Windows.Foundation.Uri LinkUri { [MethodImpl] get; }

    /// <summary>Gets the GUID generated by the Windows Store when your app has been certified for listing in the Windows Store.</summary>
    /// <returns>The GUID that identifies the app in the Windows Store.</returns>
    public static extern Guid AppId { [MethodImpl] get; }

    /// <summary>Requests the purchase of a full app license.</summary>
    /// <param name="includeReceipt">Determines if this method should return the receipts for this app.</param>
    /// <returns>If the *includeReceipt* parameter is set to true, this string contains XML that represents all receipts for the app and any in-app purchases. If *includeReceipt* is set to false, this string is empty.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> RequestAppPurchaseAsync(
      bool includeReceipt);

    /// <summary>Requests the purchase of an add-on (also called an in-app product or IAP). Additionally, calling this method displays the UI that is used to complete the transaction via the Microsoft Store.</summary>
    /// <deprecated type="deprecate">RequestProductPurchaseAsync(productId, includeReceipt) may be altered or unavailable for releases after Windows 8.1. Instead, use RequestProductPurchaseAsync(productId).</deprecated>
    /// <param name="productId">The product ID of the add-on to purchase.</param>
    /// <param name="includeReceipt">Determines if the method should return the receipts for the specified *productId.*</param>
    /// <returns>A string providing in-app transaction details for the provided *productId*. If *includeReceipt* is set **true**, the returned string will include a full receipt xml.</returns>
    [RemoteAsync]
    [Deprecated("RequestProductPurchaseAsync(productId, includeReceipt) may be altered or unavailable for releases after Windows 8.1. Instead, use RequestProductPurchaseAsync(productId).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("RequestProductPurchaseAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<string> RequestProductPurchaseAsync(
      string productId,
      bool includeReceipt);

    /// <summary>Loads the app's listing information asynchronously. </summary>
    /// <returns>The apps' listing information. If the method fails, it returns an **HRESULT** error code.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ListingInformation> LoadListingInformationAsync();

    /// <summary>Requests all receipts for the purchase of the app and any in-app products. For examples of how receipt information can be used, see Using receipts to verify product purchases.</summary>
    /// <returns>An XML-formatted string that contains all receipt information for the purchase of the app and any in-app products.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetAppReceiptAsync();

    /// <summary>Requests the receipt for the specified product ID. For examples of how receipt information can be used, see Using receipts to verify product purchases.</summary>
    /// <param name="productId">The unique identifier for the product that you specified this identifier when you submitted the app to the Microsoft Store</param>
    /// <returns>An XML-formatted string that contains the receipt for the specified *productId.*</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetProductReceiptAsync(
      string productId);
  }
}
