﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletItemStore2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1709605616, 28681, 18965, 189, 84, 79, 255, 55, 155, 255, 226)]
  [ExclusiveTo(typeof (WalletItemStore))]
  internal interface IWalletItemStore2
  {
    event TypedEventHandler<WalletItemStore, object> ItemsChanged;
  }
}