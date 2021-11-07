// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletTransaction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WalletTransaction))]
  [Guid(1088547136, 9734, 17689, 129, 203, 191, 241, 198, 13, 31, 121)]
  internal interface IWalletTransaction
  {
    string Description { get; set; }

    string DisplayAmount { get; set; }

    bool IgnoreTimeOfDay { get; set; }

    string DisplayLocation { get; set; }

    IReference<DateTime> TransactionDate { get; set; }

    bool IsLaunchable { get; set; }
  }
}
