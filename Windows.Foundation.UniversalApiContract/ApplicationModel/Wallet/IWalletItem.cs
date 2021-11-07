// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.Wallet
{
  [ExclusiveTo(typeof (WalletItem))]
  [Guid(548752360, 4493, 20164, 153, 108, 185, 99, 231, 189, 62, 116)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWalletItem
  {
    string DisplayName { get; set; }

    string Id { get; }

    bool IsAcknowledged { get; set; }

    string IssuerDisplayName { get; set; }

    IReference<DateTime> LastUpdated { get; set; }

    WalletItemKind Kind { get; }

    WalletBarcode Barcode { get; set; }

    IReference<DateTime> ExpirationDate { get; set; }

    IRandomAccessStreamReference Logo159x159 { get; set; }

    IRandomAccessStreamReference Logo336x336 { get; set; }

    IRandomAccessStreamReference Logo99x99 { get; set; }

    string DisplayMessage { get; set; }

    bool IsDisplayMessageLaunchable { get; set; }

    string LogoText { get; set; }

    Color HeaderColor { get; set; }

    Color BodyColor { get; set; }

    Color HeaderFontColor { get; set; }

    Color BodyFontColor { get; set; }

    IRandomAccessStreamReference HeaderBackgroundImage { get; set; }

    IRandomAccessStreamReference BodyBackgroundImage { get; set; }

    IRandomAccessStreamReference LogoImage { get; set; }

    IRandomAccessStreamReference PromotionalImage { get; set; }

    IReference<DateTime> RelevantDate { get; set; }

    string RelevantDateDisplayMessage { get; set; }

    IMap<string, WalletTransaction> TransactionHistory { get; }

    IMap<string, WalletRelevantLocation> RelevantLocations { get; }

    bool IsMoreTransactionHistoryLaunchable { get; set; }

    IMap<string, WalletItemCustomProperty> DisplayProperties { get; }

    IMap<string, WalletVerb> Verbs { get; }
  }
}
