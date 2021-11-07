// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletItemStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Defines a set of asynchronous actions and operations that manage the wallet items in the wallet database. These can be used to read the existing items, or to add and remove items.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WalletItemStore : IWalletItemStore
  {
    /// <summary>Adds a new wallet item to the wallet.</summary>
    /// <param name="id">The identifier of the wallet item. This value must be unique. This sets the initial WalletItem.Id value (the identifier is for the WalletItemStore store, and isn't part of the initialization of a WalletItem object.</param>
    /// <param name="item">The wallet item to add to the wallet.</param>
    /// <returns>An asynchronous action. If you use Asynchronous programming, the return type is **void**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AddAsync(string id, WalletItem item);

    /// <summary>Clears all app-owned wallet items from the wallet data store.</summary>
    /// <returns>An asynchronous action. If you use Asynchronous programming, the result type is **void**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearAsync();

    /// <summary>Gets an individual wallet item with the given ID from the wallet database. The item requested must be owned by this app.</summary>
    /// <param name="id">The ID of the wallet item.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the wallet item with the specified ID that is owned by this app. If you use Asynchronous programming, the result type is a single WalletItem. If an item with the specified ID cannot be found for this app in the current WalletItemStore or if the item isn't owned by this app, the result is **null**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WalletItem> GetWalletItemAsync(string id);

    /// <summary>Returns the collection of all wallet items owned by this app.</summary>
    /// <returns>An asynchronous operation that, on successful completion, returns the collection of wallet items accessible by this app. If you use Asynchronous programming, the result type is a read-only list/vector of WalletItem items. (You can use APIs of IVectorView&lt;WalletItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;WalletItem&gt; for .NET.)</returns>
    [Overload("GetItemsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync();

    /// <summary>Returns the collection of wallet items of the given type that are owned by this app.</summary>
    /// <param name="kind">The type of wallet item to retrieve.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the collection of wallet items of the specified type that are accessible by this app. If you use Asynchronous programming, the result type is a read-only list/vector of WalletItem items. (You can use APIs of IVectorView&lt;WalletItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;WalletItem&gt; for .NET.)</returns>
    [Overload("GetItemsWithKindAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync(
      WalletItemKind kind);

    /// <summary>Imports data from a ".mswallet" XML file into the wallet store.".mswallet" is an XML serialization format for wallet item info. For a guide to the ".mswallet" format (and a link to schema in XSD), see [Quickstart: Creating and distributing .mswallet files](https://docs.microsoft.com/previous-versions/windows/apps/dn631256(v=win.10)).</summary>
    /// <param name="stream">The ".mswallet" file to import.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the wallet item that was imported into the wallet. If you use Asynchronous programming, the result type on successful completion is a single WalletItem.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WalletItem> ImportItemAsync(
      IRandomAccessStreamReference stream);

    /// <summary>Removes a specific wallet item with the given ID from the wallet data store.</summary>
    /// <param name="id">The ID of the wallet item to remove from the data store.</param>
    /// <returns>An asynchronous action. If you use Asynchronous programming, the result type is **void**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync(string id);

    /// <summary>Displays the Wallet UI.</summary>
    /// <returns>An asynchronous action. If you use Asynchronous programming, the result type is **void**.</returns>
    [Overload("ShowAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowAsync();

    /// <summary>Displays the item with the given ID in the Wallet UI.</summary>
    /// <param name="id">The ID of the item to display.</param>
    /// <returns>An asynchronous action. If you use Asynchronous programming, the result type is **void**.</returns>
    [RemoteAsync]
    [Overload("ShowItemAsync")]
    [MethodImpl]
    public extern IAsyncAction ShowAsync(string id);

    /// <summary>Updates a wallet item in the shared store, based on the changed values in the WalletItem object provided.</summary>
    /// <param name="item">The updated data for the wallet item.</param>
    /// <returns>An asynchronous action. If you use Asynchronous programming, the result type is **void**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpdateAsync(WalletItem item);
  }
}
