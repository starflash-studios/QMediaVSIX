// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.StorageItemQueryResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Provides access to the results of a query that lists all items including files and folders (or file groups) in the folder being queried (which is represented by a storageFolder ). You can use storageItemQueryResult to enumerate the files and folders in that storageFolder.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageItemQueryResult : IStorageItemQueryResult, IStorageQueryResultBase
  {
    /// <summary>Retrieves a list of items (files and folders) in a specified range.</summary>
    /// <param name="startIndex">The zero-based index of the first item to retrieve. This parameter defaults to 0.</param>
    /// <param name="maxNumberOfItems">The maximum number of items to retrieve. Use -1 to retrieve all items. If the range contains fewer items than the max number, all items in the range are returned.</param>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of items. Each item is the IStorageItem type and represents a file, folder, or file group.</returns>
    [Overload("GetItemsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync(
      uint startIndex,
      uint maxNumberOfItems);

    /// <summary>Retrieves a list of all the items (files and folders) in the query results set.</summary>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of items. Each item is the IStorageItem type and represents a file, folder, or file group.</returns>
    [RemoteAsync]
    [Overload("GetItemsAsyncDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();

    /// <summary>Retrieves the number of items in the set of query results.</summary>
    /// <returns>When this method completes successfully, it returns the number of items in the location that match the query.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> GetItemCountAsync();

    /// <summary>Gets the folder originally used to create the StorageItemQueryResult object. This folder represents the scope of the query.</summary>
    /// <returns>The original folder.</returns>
    public extern StorageFolder Folder { [MethodImpl] get; }

    /// <summary>Fires when an item is added to, deleted from, or modified in the folder being queried. This event only fires after GetItemsAsync has been called at least once.</summary>
    public extern event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;

    /// <summary>Fires when the query options change.</summary>
    public extern event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;

    /// <summary>Retrieves the index of the item from the query results that most closely matches the specified property value. The property that is matched is determined by the first SortEntry of the QueryOptions.SortOrder list.</summary>
    /// <param name="value">The property value to match when searching the query results. The property to that is used to match this value is the property in the first SortEntry of the QueryOptions.SortOrder list.</param>
    /// <returns>When this method completes successfully it returns the index of the matched item in the query results.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> FindStartIndexAsync([Variant] object value);

    /// <summary>Retrieves the query options used to determine query results.</summary>
    /// <returns>The query options.</returns>
    [MethodImpl]
    public extern QueryOptions GetCurrentQueryOptions();

    /// <summary>Modifies query results based on new QueryOptions.</summary>
    /// <param name="newQueryOptions">The new query options.</param>
    [MethodImpl]
    public extern void ApplyNewQueryOptions(QueryOptions newQueryOptions);
  }
}
