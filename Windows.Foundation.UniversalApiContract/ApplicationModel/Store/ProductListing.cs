// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ProductListing
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Provides localized information that details an add-on (also called an in-app product or IAP).</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ProductListing : IProductListing, IProductListingWithMetadata, IProductListing2
  {
    /// <summary>Gets the product ID for the add-on that this **ProductListing** represents.</summary>
    /// <returns>The product ID for the add-on.</returns>
    public extern string ProductId { [MethodImpl] get; }

    /// <summary>Gets the purchase price for the in-app product with the appropriate formatting for the current market.</summary>
    /// <returns>The purchase price with the appropriate formatting for the current market.</returns>
    public extern string FormattedPrice { [MethodImpl] get; }

    /// <summary>Gets the descriptive name of the add-on (also called an in-app product or IAP) that is displayed customers in the current market.</summary>
    /// <returns>The add-on's descriptive name as it is seen by customers in the current market.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the description for the add-on (also called an in-app product or IAP).</summary>
    /// <returns>The description for the product.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets the list of keywords associated with the add-on (also called an in-app product or IAP). These strings correspond to the value of the **Keywords** field in the properties page for the add-on in Partner Center. These keywords are useful for filtering product lists by keyword, for example, when calling LoadListingInformationByKeywordsAsync.</summary>
    /// <returns>The keywords associated with the add-on.</returns>
    public extern IIterable<string> Keywords { [MethodImpl] get; }

    /// <summary>Gets the type of this add-on (also called an in-app product or IAP). Possible values are defined by ProductType.</summary>
    /// <returns>The product type. Possible values include **Consumable** and **Durable**.</returns>
    public extern ProductType ProductType { [MethodImpl] get; }

    /// <summary>Gets the custom developer data string (also called a tag) that contains custom information about an add-on (also called an in-app product or IAP). This string corresponds to the value of the **Custom developer data** field in the properties page for the add-on in Partner Center.</summary>
    /// <returns>The custom developer data for the add-on.</returns>
    public extern string Tag { [MethodImpl] get; }

    /// <summary>Gets the URI of the image associated with the add-on (also called an in-app product or IAP).</summary>
    /// <returns>The URI to the image associated with the add-on.</returns>
    public extern Uri ImageUri { [MethodImpl] get; }

    /// <summary>Gets the base price for the add-on (also called an in-app product or IAP) with the appropriate formatting for the current market.</summary>
    /// <returns>The base price for the add-on with the appropriate formatting for the current market.</returns>
    public extern string FormattedBasePrice { [MethodImpl] get; }

    /// <summary>Gets the end date of the sale period for the add-on (also called an in-app product or IAP).</summary>
    /// <returns>The date and time that the add-on's sale period will end.</returns>
    public extern DateTime SaleEndDate { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the add-on (also called an in-app product or IAP) is on sale.</summary>
    /// <returns>Returns true if the in-app product is on sale, and otherwise false.</returns>
    public extern bool IsOnSale { [MethodImpl] get; }

    /// <summary>Gets the currency code associated with the user's market, such as **USD** or **CAD**.</summary>
    /// <returns>The currency code associated with the user's market, such as **USD** or **CAD**.</returns>
    public extern string CurrencyCode { [MethodImpl] get; }
  }
}
