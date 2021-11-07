// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletItemStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet
{
  [Guid(1902135371, 27977, 18680, 145, 169, 64, 161, 208, 241, 62, 244)]
  [ExclusiveTo(typeof (WalletItemStore))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWalletItemStore
  {
    [RemoteAsync]
    IAsyncAction AddAsync(string id, WalletItem item);

    [RemoteAsync]
    IAsyncAction ClearAsync();

    [RemoteAsync]
    IAsyncOperation<WalletItem> GetWalletItemAsync(string id);

    [Overload("GetItemsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync();

    [Overload("GetItemsWithKindAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync(
      WalletItemKind kind);

    [RemoteAsync]
    IAsyncOperation<WalletItem> ImportItemAsync(
      IRandomAccessStreamReference stream);

    [RemoteAsync]
    IAsyncAction DeleteAsync(string id);

    [RemoteAsync]
    [Overload("ShowAsync")]
    IAsyncAction ShowAsync();

    [RemoteAsync]
    [Overload("ShowItemAsync")]
    IAsyncAction ShowAsync(string id);

    [RemoteAsync]
    IAsyncAction UpdateAsync(WalletItem item);
  }
}
