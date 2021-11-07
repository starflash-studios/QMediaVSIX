// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletItemCustomPropertyFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [Guid(3489950276, 24993, 16810, 178, 89, 165, 97, 10, 181, 213, 117)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WalletItemCustomProperty))]
  internal interface IWalletItemCustomPropertyFactory
  {
    WalletItemCustomProperty CreateWalletItemCustomProperty(
      string name,
      string value);
  }
}
