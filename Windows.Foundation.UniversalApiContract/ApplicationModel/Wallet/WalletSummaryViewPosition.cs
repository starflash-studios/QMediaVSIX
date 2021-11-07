// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletSummaryViewPosition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Describes the position in the summary view of a wallet item that a WalletItemCustomProperty should be displayed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WalletSummaryViewPosition
  {
    /// <summary>The item is hidden in the summary view.</summary>
    Hidden,
    /// <summary>The first summary line.</summary>
    Field1,
    /// <summary>The second summary line.</summary>
    Field2,
  }
}
