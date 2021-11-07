// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Represents an item (data) that is stored in the wallet.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IWalletItemFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WalletItem : IWalletItem
  {
    /// <summary>Initializes a new instance of the WalletItem class.</summary>
    /// <param name="kind">The type of wallet item.</param>
    /// <param name="displayName">The display name of the item.</param>
    [MethodImpl]
    public extern WalletItem(WalletItemKind kind, string displayName);

    /// <summary>Gets or sets the name or title to be displayed to the user.</summary>
    /// <returns>The display name of the wallet item.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the unique identifier of the wallet item.</summary>
    /// <returns>The unique identifier of the wallet item. This usually isn't displayed in UI. This might be the same value as was used for the Value of the Barcode, but that's up to the implementation (yours or the wallet item provider).</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets or sets whether this item is acknowledged by the app.</summary>
    /// <returns>**false** if the item is new to the app (the default); Otherwise, **true**.</returns>
    public extern bool IsAcknowledged { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the issuer name of the wallet item.</summary>
    /// <returns>The issuer name of the wallet item.</returns>
    public extern string IssuerDisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the date and time the data for this item was last updated.</summary>
    /// <returns>The date and time the data for this item was last updated. Can be **null** (the default).</returns>
    public extern IReference<DateTime> LastUpdated { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the type of the wallet item.</summary>
    /// <returns>The type of the item, as a value of the enumeration.</returns>
    public extern WalletItemKind Kind { [MethodImpl] get; }

    /// <summary>Gets or sets the barcode that's representative of the wallet item.</summary>
    /// <returns>The barcode of the item.</returns>
    public extern WalletBarcode Barcode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the expiration date of the wallet item.</summary>
    /// <returns>The expiration date of the item. Can be **null** (the default).</returns>
    public extern IReference<DateTime> ExpirationDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the medium (159 x 159) logo image of the wallet item.</summary>
    /// <returns>The medium logo of the item, represented as a stream.</returns>
    public extern IRandomAccessStreamReference Logo159x159 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the large (336 x 336) logo image of the wallet item.</summary>
    /// <returns>The large logo of the item, represented as a stream.</returns>
    public extern IRandomAccessStreamReference Logo336x336 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the small (99 x 99) logo image of the wallet item.</summary>
    /// <returns>The small logo image of the item, represented as a stream.</returns>
    public extern IRandomAccessStreamReference Logo99x99 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that appears next to the app name in **About** info.</summary>
    /// <returns>A string that appears next to the app name in the **About** info associated with a wallet item.</returns>
    public extern string DisplayMessage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether to launch your app when the user taps on the DisplayMessage.</summary>
    /// <returns>**true** if your app should launch when the users taps on the display message; Otherwise, **false**;</returns>
    public extern bool IsDisplayMessageLaunchable { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the logo text of the wallet item.</summary>
    /// <returns>The logo text of the item.</returns>
    public extern string LogoText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the header color of the wallet item.</summary>
    /// <returns>The header color of the item.</returns>
    public extern Color HeaderColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the body color of the wallet item.</summary>
    /// <returns>The body color of the item.</returns>
    public extern Color BodyColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the header font color of the wallet item.</summary>
    /// <returns>The header font color of the item.</returns>
    public extern Color HeaderFontColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the body font color of the wallet item.</summary>
    /// <returns>The body font color of the item.</returns>
    public extern Color BodyFontColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the header background image of the wallet item.</summary>
    /// <returns>The header background image of the item.</returns>
    public extern IRandomAccessStreamReference HeaderBackgroundImage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the background image of the body of the wallet item (uses a stream).</summary>
    /// <returns>The background image of the body of the wallet item. This is a stream that contains the bitmap image.</returns>
    public extern IRandomAccessStreamReference BodyBackgroundImage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the logo image of the wallet item. Use this property for a logo that doesn't have a specified size.</summary>
    /// <returns>The logo image of the wallet item, represented as a stream.</returns>
    public extern IRandomAccessStreamReference LogoImage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the promotional image of the wallet item.</summary>
    /// <returns>The promotional image of the wallet item that will be displayed on back of the card, as a stream.</returns>
    public extern IRandomAccessStreamReference PromotionalImage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the date on which the item is valid.</summary>
    /// <returns>The date on which the item is valid. Can be **null** (the default).</returns>
    public extern IReference<DateTime> RelevantDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the description of the relevant date of the wallet item.</summary>
    /// <returns>The description of the relevant date of the wallet item.</returns>
    public extern string RelevantDateDisplayMessage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the transaction history collection of the wallet item.</summary>
    /// <returns>The transaction history collection of the item. This is a keyed map of WalletTransaction items.</returns>
    public extern IMap<string, WalletTransaction> TransactionHistory { [MethodImpl] get; }

    /// <summary>Gets a collection of all relevant locations for the wallet item.</summary>
    /// <returns>A collection of all relevant locations for the wallet item</returns>
    public extern IMap<string, WalletRelevantLocation> RelevantLocations { [MethodImpl] get; }

    /// <summary>Gets or sets whether your app should be launched when the user taps "see more transaction history".</summary>
    /// <returns>**true** if your app should be launched when the user taps on "see more transaction history", Otherwise, **false**.</returns>
    public extern bool IsMoreTransactionHistoryLaunchable { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of WalletItemCustomProperty objects associated with the wallet item.</summary>
    /// <returns>The collection of WalletItemCustomProperty objects associated with the wallet item.</returns>
    public extern IMap<string, WalletItemCustomProperty> DisplayProperties { [MethodImpl] get; }

    /// <summary>Gets the collection of WalletVerb objects associated with the wallet item.</summary>
    /// <returns>The collection of WalletVerb objects associated with the wallet item.</returns>
    public extern IMap<string, WalletVerb> Verbs { [MethodImpl] get; }
  }
}
