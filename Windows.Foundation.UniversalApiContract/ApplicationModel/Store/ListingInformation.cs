// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ListingInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  /// <summary>Provides the listing info that describes the app in the Microsoft Store.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ListingInformation : IListingInformation, IListingInformation2
  {
    /// <summary>Gets the country code associated with the user's location, such as **US** or **CA**, that is used to identify their market for transactions in the current session.</summary>
    /// <returns>The country code associated with the user's location, such as **US** or **CA**.</returns>
    public extern string CurrentMarket { [MethodImpl] get; }

    /// <summary>Gets the app's description in the current market.</summary>
    /// <returns>The app's description in the current market.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets information about add-ons (also called in-app products or IAPs) available for purchase.</summary>
    /// <returns>The array of ProductListing objects that describes the app's add-ons.</returns>
    public extern IMapView<string, ProductListing> ProductListings { [MethodImpl] get; }

    /// <summary>Gets the app's purchase price formatted for the current market and currency.</summary>
    /// <returns>The app's purchase price with the appropriate formatting for the current market and currency.</returns>
    public extern string FormattedPrice { [MethodImpl] get; }

    /// <summary>Gets the app's name in the current market.</summary>
    /// <returns>The app's name in the current market.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the age rating for the app.</summary>
    /// <returns>The age rating.</returns>
    public extern uint AgeRating { [MethodImpl] get; }

    /// <summary>Gets the app's base price formatted for the current market and currency.</summary>
    /// <returns>The app's base price with the appropriate formatting for the current market and currency.</returns>
    public extern string FormattedBasePrice { [MethodImpl] get; }

    /// <summary>Gets the end date of the sale period for the app.</summary>
    /// <returns>The date and time that the app's sale period will end.</returns>
    public extern DateTime SaleEndDate { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the app is on sale.</summary>
    /// <returns>Returns true if the app is on sale, and otherwise false.</returns>
    public extern bool IsOnSale { [MethodImpl] get; }

    /// <summary>Gets the currency code associated with the user's market, such as **USD** or **CAD**.</summary>
    /// <returns>The currency code associated with the user's market, such as **USD** or **CAD**.</returns>
    public extern string CurrencyCode { [MethodImpl] get; }
  }
}
