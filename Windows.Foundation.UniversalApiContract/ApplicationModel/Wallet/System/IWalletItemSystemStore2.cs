// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.System.IWalletItemSystemStore2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WalletItemSystemStore))]
  [Guid(4186782286, 48640, 20445, 151, 52, 108, 17, 60, 26, 193, 203)]
  internal interface IWalletItemSystemStore2
  {
    event TypedEventHandler<WalletItemSystemStore, object> ItemsChanged;
  }
}
