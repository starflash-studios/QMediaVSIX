// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletTransaction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Represents a single wallet transaction in the transaction history.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WalletTransaction : IWalletTransaction
  {
    /// <summary>Initializes a new instance of the WalletTransaction class.</summary>
    [MethodImpl]
    public extern WalletTransaction();

    /// <summary>Gets or sets the summary description (suitable for user UI) of the transaction.</summary>
    /// <returns>The transaction description.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the transaction amount.</summary>
    /// <returns>The transaction amount.</returns>
    public extern string DisplayAmount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether to display the time of the transaction.</summary>
    /// <returns>**true** if the time of the transaction should be displayed; otherwise, **false**.</returns>
    public extern bool IgnoreTimeOfDay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a description (suitable for user UI) of the transaction location.</summary>
    /// <returns>The text description of the transaction location.</returns>
    public extern string DisplayLocation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the date and time of the transaction.</summary>
    /// <returns>The date and time of the transaction. Can be **null** (the default), but for this particular property it's uncommon for the value to remain **null** when you're viewing an existing transaction.</returns>
    public extern IReference<DateTime> TransactionDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether to launch your app when the user taps "see more transaction history".</summary>
    /// <returns>**true** if your app should be launched when the user taps "see more transaction history"; otherwise, **false**.</returns>
    public extern bool IsLaunchable { [MethodImpl] get; [MethodImpl] set; }
  }
}
