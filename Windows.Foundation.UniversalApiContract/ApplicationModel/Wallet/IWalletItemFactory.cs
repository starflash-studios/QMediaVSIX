// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1407349872, 20235, 19006, 153, 229, 11, 187, 30, 171, 56, 212)]
  [ExclusiveTo(typeof (WalletItem))]
  internal interface IWalletItemFactory
  {
    WalletItem CreateWalletItem(WalletItemKind kind, string displayName);
  }
}
