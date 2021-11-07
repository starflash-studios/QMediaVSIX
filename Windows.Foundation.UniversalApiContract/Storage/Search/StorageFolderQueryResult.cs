// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.StorageFolderQueryResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Provides access to the results of a query that lists the folder (or file groups) in the folder being queried (which is represented by a storageFolder ). You can use a storageFolderQueryResult to enumerate folders or file groups in that folder.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageFolderQueryResult : IStorageFolderQueryResult, IStorageQueryResultBase
  {
    /// <summary>Retrieves folders (or file groups) in a specified range.</summary>
    /// <param name="startIndex">The zero-based index of the first folder to retrieve. This parameter defaults to 0.</param>
    /// <param name="maxNumberOfItems">The maximum number of folders or file groups to retrieve. Use -1 to retrieve all folders. If the range contains fewer folders than the max number, all folders in the range are returned.</param>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of folders or file groups that are represented by storageFolder objects.</returns>
    [RemoteAsync]
    [Overload("GetFoldersAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      uint startIndex,
      uint maxNumberOfItems);

    /// <summary>Retrieves a list of all the folders (or file groups) in the result set.</summary>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of folders or file groups that are represented by storageFolder objects. Each of these folder or file group can also be enumerated to retrieve its contents.</returns>
    [RemoteAsync]
    [Overload("GetFoldersAsyncDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();

    /// <summary>Retrieves the number of folders (or file groups) in the set of query results.</summary>
    /// <returns>When this method completes successfully, it returns the number of folders or file groups in the location that match the query.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> GetItemCountAsync();

    /// <summary>Gets the folder originally used to create the StorageFolderQueryResult object. This folder represents the scope of the query.</summary>
    /// <returns>The original folder.</returns>
    public extern StorageFolder Folder { [MethodImpl] get; }

    /// <summary>Fires when a file is added to, deleted from, or modified in the folder being queried. This event only fires after GetFilesAsync has been called at least once.</summary>
    public extern event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;

    /// <summary>Fires when the query options change.</summary>
    public extern event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;

    /// <summary>Retrieves the index of the folder from the query results that most closely matches the specified property value. The property that is matched is determined by the first SortEntry of the QueryOptions.SortOrder list.</summary>
    /// <param name="value">The property value to match when searching the query results. The property to that is used to match this value is the property in the first SortEntry of the QueryOptions.SortOrder list.</param>
    /// <returns>When this method completes successfully it returns the index of the matched folder in the query results; otherwise it returns **uint.MaxValue**.</returns>
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
