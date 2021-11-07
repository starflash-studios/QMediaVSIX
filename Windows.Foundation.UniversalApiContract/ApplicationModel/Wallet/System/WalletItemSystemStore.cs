// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.System.WalletItemSystemStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet.System
{
  /// <summary>Defines a set of asynchronous actions and operations that manage the wallet items in the system wallet database. These can be used to read the existing items, or to add and remove items.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WalletItemSystemStore : IWalletItemSystemStore, IWalletItemSystemStore2
  {
    /// <summary>Returns the collection of all system wallet items owned by this app.</summary>
    /// <returns>An asynchronous operation that, on successful completion, returns the collection of wallet items accessible by this app. If you use Asynchronous programming, the result type is a read-only list/vector of WalletItem items. (You can use APIs of IVectorView&lt;WalletItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;WalletItem&gt; for .NET.)</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync();

    /// <summary>Asynchronously removes a specific wallet item with the given ID from the wallet system data store.</summary>
    /// <param name="item">The ID of the wallet item to remove from the system data store.</param>
    /// <returns>An asynchronous action. If you use Asynchronous programming, the result type is **void**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync(WalletItem item);

    /// <summary>Imports data from a ".mswallet" XML file into the system wallet store.</summary>
    /// <param name="stream">The ".mswallet" file to import.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the wallet item that was imported into the wallet. If you use Asynchronous programming, the result type on successful completion is a single WalletItem.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WalletItem> ImportItemAsync(
      IRandomAccessStreamReference stream);

    /// <summary>Gets a WalletItemAppAssociation value indicating if an app is installed for the specified WalletItem.</summary>
    /// <param name="item">The item for which to retrieve the status.</param>
    /// <returns>The WalletItemAppAssociation value indicating if an app is installed for the specified WalletItem specified by the *item* parameter.</returns>
    [MethodImpl]
    public extern WalletItemAppAssociation GetAppStatusForItem(
      WalletItem item);

    /// <summary>Launches the app that is associated with the given wallet item.</summary>
    /// <param name="item">The wallet item to launch an app for.</param>
    /// <returns>An async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> LaunchAppForItemAsync(WalletItem item);

    /// <summary>Occurs when items in the WalletItemSystemStore have changed.</summary>
    public extern event TypedEventHandler<WalletItemSystemStore, object> ItemsChanged;
  }
}
