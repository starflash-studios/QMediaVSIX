// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.System.IWalletItemSystemStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet.System
{
  [ExclusiveTo(typeof (WalletItemSystemStore))]
  [Guid(1378757631, 38562, 18967, 141, 25, 254, 29, 159, 131, 117, 97)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWalletItemSystemStore
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync();

    [RemoteAsync]
    IAsyncAction DeleteAsync(WalletItem item);

    [RemoteAsync]
    IAsyncOperation<WalletItem> ImportItemAsync(
      IRandomAccessStreamReference stream);

    WalletItemAppAssociation GetAppStatusForItem(WalletItem item);

    [RemoteAsync]
    IAsyncOperation<bool> LaunchAppForItemAsync(WalletItem item);
  }
}
