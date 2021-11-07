// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletVerbFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WalletVerb))]
  [Guid(1979787121, 48728, 19806, 131, 237, 88, 177, 102, 156, 122, 217)]
  internal interface IWalletVerbFactory
  {
    WalletVerb CreateWalletVerb(string name);
  }
}
