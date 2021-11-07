// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageFolderQueryOperations
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Provides methods to create search queries and retrieve files from a folder. This interface is implemented by StorageFolder objects, which can represent file system folders, libraries, or virtual folders that are automatically generated when queries are created using group-based CommonFolderQuery values like GroupByAlbum.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3410218185, 17515, 19023, 190, 151, 117, 119, 113, 190, 82, 3)]
  public interface IStorageFolderQueryOperations
  {
    /// <summary>Retrieves a value that indicates the indexed state of the StorageFolder location associated with the query.</summary>
    /// <returns>When this method completes successfully, it returns a value of the IndexedState enumeration.</returns>
    [RemoteAsync]
    IAsyncOperation<IndexedState> GetIndexedStateAsync();

    /// <summary>Retrieves an object for enumerating the files in a storage location and subscribing to events that fire when the contents of the storage location change.</summary>
    /// <returns>An object for enumerating files and subscribing to events.</returns>
    [Overload("CreateFileQueryOverloadDefault")]
    StorageFileQueryResult CreateFileQuery();

    /// <summary>Retrieves an object with the specified options for enumerating the storage location in a folder and subscribing to events that fire when the contents of the storage location change.</summary>
    /// <param name="query">The type of folder query to perform. This parameter defaults to CommonFileQuery.DefaultQuery.</param>
    /// <returns>An object for enumerating files and subscribing to events.</returns>
    [Overload("CreateFileQuery")]
    StorageFileQueryResult CreateFileQuery(CommonFileQuery query);

    /// <summary>Retrieves an object with the specified options for enumerating the files in a storage location and subscribing to events that fire when the contents of the storage location change.</summary>
    /// <param name="queryOptions">The options for filtering the query results.</param>
    /// <returns>An object for enumerating files and subscribing to events.</returns>
    StorageFileQueryResult CreateFileQueryWithOptions(
      QueryOptions queryOptions);

    /// <summary>Retrieves an object for enumerating folders in a storage location and subscribing to events that fire when the contents of the storage location change.</summary>
    /// <returns>An object for enumerating folders and subscribing to events.</returns>
    [Overload("CreateFolderQueryOverloadDefault")]
    StorageFolderQueryResult CreateFolderQuery();

    /// <summary>Retrieves an object with the specified options for enumerating folders in a storage location and subscribing to events that fire when the contents of the storage location change.</summary>
    /// <param name="query">The type of folder query to perform. This parameter defaults to CommonFolderQuery.DefaultQuery.</param>
    /// <returns>An object for enumerating folders and subscribing to events.</returns>
    [Overload("CreateFolderQuery")]
    StorageFolderQueryResult CreateFolderQuery(CommonFolderQuery query);

    /// <summary>Retrieves an object with the specified options for enumerating folders in a storage location and subscribing to events that fire when the contents of the storage location change.</summary>
    /// <param name="queryOptions">The options for filtering the query results.</param>
    /// <returns>An object for enumerating folders and subscribing to events.</returns>
    StorageFolderQueryResult CreateFolderQueryWithOptions(
      QueryOptions queryOptions);

    /// <summary>Retrieves an object for performing shallow enumerations of the files and folders in a storage location. An app can use the object to enumerate the items in a storage location and subscribe to events that fire when the contents of the storage location change.</summary>
    /// <returns>An object for enumerating storage items and subscribing to events.</returns>
    StorageItemQueryResult CreateItemQuery();

    /// <summary>Retrieves an object with the specified options for enumerating the files and folders in a storage location and subscribing to events that fire when the contents of the storage location change.</summary>
    /// <param name="queryOptions">The options for filtering the query results.</param>
    /// <returns>An object for enumerating storage items and subscribing to events.</returns>
    StorageItemQueryResult CreateItemQueryWithOptions(
      QueryOptions queryOptions);

    /// <summary>Retrieves a list of files in a specified range that are based on the specified file query. This returns a snapshot of the files at a point in time and does not allow you to keep track of changes through events.</summary>
    /// <param name="query">The type of file query to perform.</param>
    /// <param name="startIndex">The zero-based index of the first file in the range. This parameter defaults to 0.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of files to retrieve. Use -1 to retrieve all files.</param>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of files that are represented by StorageFile objects.</returns>
    [Overload("GetFilesAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      CommonFileQuery query,
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Retrieves a list of files based on the specified query (shallow enumeration). This returns a snapshot of the files at a point in time and does not allow you to keep track of changes through events.</summary>
    /// <param name="query">The type of file query to perform.</param>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of files that are represented by StorageFile objects.</returns>
    [Overload("GetFilesAsyncOverloadDefaultStartAndCount")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      CommonFileQuery query);

    /// <summary>Asynchronously retrieves a range of folders in this folder based on a folder query. This returns a snapshot of the folders or file groups at a point in time and does not allow you to keep track of changes through events.</summary>
    /// <param name="query">The type of folder query to perform.</param>
    /// <param name="startIndex">The zero-based index of the first folder or file group in the range. This parameter defaults to 0.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of folders or file groups to retrieve. Use -1 to retrieve all folders or file groups.</param>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of folders of file groups that are represented by StorageFolder objects.</returns>
    [RemoteAsync]
    [Overload("GetFoldersAsync")]
    IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      CommonFolderQuery query,
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Retrieves a list of folders and file groups based on a specified folder query. This returns a snapshot of the folders or file groups at a point in time and does not allow you to keep track of changes through events.</summary>
    /// <param name="query">The type of folder query to perform.</param>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of folders of file groups that are represented by StorageFolder objects.</returns>
    [Overload("GetFoldersAsyncOverloadDefaultStartAndCount")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      CommonFolderQuery query);

    /// <summary>Retrieves a list items like files, folders, or file groups, in a specified range (shallow enumeration).</summary>
    /// <param name="startIndex">The zero-based index of the first item in the range. This parameter defaults to 0.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of items to retrieve. Use -1 to retrieve all items.</param>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of items. Each item is the IStorageItem type and represents a file, folder, or file group.</returns>
    [RemoteAsync]
    [Overload("GetItemsAsync")]
    IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Verifies whether the folder supports the specified search query options (returns true or false).</summary>
    /// <param name="queryOptions">The search query options to test.</param>
    /// <returns>True if the folder supports the specified search query options; otherwise false.</returns>
    bool AreQueryOptionsSupported(QueryOptions queryOptions);

    /// <summary>Verifies whether this folder supports the specified folder query (returns true or false).</summary>
    /// <param name="query">The folder query to test.</param>
    /// <returns>True if the folder supports the specified folder query; otherwise false.</returns>
    bool IsCommonFolderQuerySupported(CommonFolderQuery query);

    /// <summary>Verifies whether this folder supports the specified file query (returns true or false).</summary>
    /// <param name="query">The file query to test.</param>
    /// <returns>True if the folder supports the specified file query; otherwise false.</returns>
    bool IsCommonFileQuerySupported(CommonFileQuery query);
  }
}
