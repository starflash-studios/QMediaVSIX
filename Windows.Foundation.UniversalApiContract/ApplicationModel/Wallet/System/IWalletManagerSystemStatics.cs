// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.System.IWalletManagerSystemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet.System
{
  [Guid(3202935689, 9780, 19354, 139, 35, 238, 137, 3, 201, 31, 224)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WalletManagerSystem))]
  internal interface IWalletManagerSystemStatics
  {
    [RemoteAsync]
    IAsyncOperation<WalletItemSystemStore> RequestStoreAsync();
  }
}
