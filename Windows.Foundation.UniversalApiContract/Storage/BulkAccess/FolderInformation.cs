// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.FolderInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Search;

namespace Windows.Storage.BulkAccess
{
  /// <summary>Provides synchronous access to the properties exposed off StorageFolder and lets an app perform asynchronous management operations such as copy, delete, move, and rename.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FolderInformation : 
    IStorageItemInformation,
    IStorageFolder,
    IStorageItem,
    IStorageItemProperties,
    IStorageFolderQueryOperations,
    IStorageItem2,
    IStorageFolder2,
    IStorageItemPropertiesWithProvider
  {
    /// <summary>Gets the music properties associated with the StorageFolder.</summary>
    /// <returns>The music properties.</returns>
    public extern MusicProperties MusicProperties { [MethodImpl] get; }

    /// <summary>Gets the video properties that are associated with the StorageFolder.</summary>
    /// <returns>The video properties.</returns>
    public extern VideoProperties VideoProperties { [MethodImpl] get; }

    /// <summary>Gets the image properties of the StorageFolder.</summary>
    /// <returns>The image properties.</returns>
    public extern ImageProperties ImageProperties { [MethodImpl] get; }

    /// <summary>Gets the document properties of the StorageFolder.</summary>
    /// <returns>The document properties.</returns>
    public extern DocumentProperties DocumentProperties { [MethodImpl] get; }

    /// <summary>Gets an object that contains the basic properties information of the folder.</summary>
    /// <returns>The basic properties object.</returns>
    public extern BasicProperties BasicProperties { [MethodImpl] get; }

    /// <summary>Gets the thumbnail for the StorageFile.</summary>
    /// <returns>The thumbnail.</returns>
    public extern StorageItemThumbnail Thumbnail { [MethodImpl] get; }

    /// <summary>Fires when the StorageFolder 's thumbnail is updated or a better quality thumbnail is available.</summary>
    public extern event TypedEventHandler<IStorageItemInformation, object> ThumbnailUpdated;

    /// <summary>Occurs when one or more of the StorageFolder 's properties is updated.</summary>
    public extern event TypedEventHandler<IStorageItemInformation, object> PropertiesUpdated;

    /// <summary>Creates a new file in the current folder.</summary>
    /// <param name="desiredName">The name of the new file.</param>
    /// <returns>When this method completes successfully, it returns a StorageFile that represents the new file.</returns>
    [RemoteAsync]
    [Overload("CreateFileAsyncOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName);

    /// <summary>Creates a new file in the current folder, and specifies what to do if a file with the same name already exists in the current folder.</summary>
    /// <param name="desiredName">The name of the new file.</param>
    /// <param name="options">A value that indicates what to do if the file name already exists in the current folder.</param>
    /// <returns>When this method completes successfully, it returns a StorageFile that represents the new file.</returns>
    [Overload("CreateFileAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName,
      CreationCollisionOption options);

    /// <summary>Creates a new child folder of the current folder.</summary>
    /// <param name="desiredName">The name of the new folder.</param>
    /// <returns>When this method completes successfully, it returns a StorageFolder that represents the new file.</returns>
    [RemoteAsync]
    [Overload("CreateFolderAsyncOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName);

    /// <summary>Creates a new child folder of the current folder, and specifies what to do if a folder with the same name already exists in the current folder.</summary>
    /// <param name="desiredName">The name of the new folder.</param>
    /// <param name="options">A value that indicates what to do if the child folder already exists in the current folder.</param>
    /// <returns>When this method completes successfully, it returns a StorageFolder that represents the new file.</returns>
    [RemoteAsync]
    [Overload("CreateFolderAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName,
      CreationCollisionOption options);

    /// <summary>Retrieves a file from the current folder.</summary>
    /// <param name="name">The name of the file to retrieve.</param>
    /// <returns>When this method completes successfully, it returns a StorageFile.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> GetFileAsync(string name);

    /// <summary>Retrieves the specified child folder from the current folder.</summary>
    /// <param name="name">The name of the child folder to retrieve.</param>
    /// <returns>When this method completes successfully, it returns a StorageFolder that represents the specified child folder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetFolderAsync(
      string name);

    /// <summary>Retrieves an item from the folder.</summary>
    /// <param name="name">The name of the item to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the item (type IStorageItem ).</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> GetItemAsync(string name);

    /// <summary>Retrieves all files from the current folder.</summary>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of StorageFile objects in the folder.</returns>
    [RemoteAsync]
    [Overload("GetFilesAsyncOverloadDefaultOptionsStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();

    /// <summary>Retrieves all child folders from the current folder.</summary>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of child folders. Each child folder in this list is represented by a StorageFolder object.</returns>
    [Overload("GetFoldersAsyncOverloadDefaultOptionsStartAndCount")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();

    /// <summary>Retrieves all items from the current folder.</summary>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of items.</returns>
    [RemoteAsync]
    [Overload("GetItemsAsyncOverloadDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();

    /// <summary>Renames the StorageFolder.</summary>
    /// <param name="desiredName">The new name.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("RenameAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RenameAsync(string desiredName);

    /// <summary>Renames the StorageFolder, and specifies what to do if a folder with the same name already exists.</summary>
    /// <param name="desiredName">The new name.</param>
    /// <param name="option">A value that indicates what to do if a folder with *desiredName* already exists.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("RenameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RenameAsync(
      string desiredName,
      NameCollisionOption option);

    /// <summary>Deletes the current folder.</summary>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("DeleteAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Deletes the current folder, optionally moving the deleted folder to the recycle bin.</summary>
    /// <param name="option">A value that specifies whether to move the deleted folder to the recycle bin.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("DeleteAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync(StorageDeleteOption option);

    /// <summary>Retrieves the basic properties of the StorageFolder object.</summary>
    /// <returns>When this method completes successfully, it returns a BasicProperties object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();

    /// <summary>Gets the name of the StorageFolder.</summary>
    /// <returns>The StorageFolder name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the path of the StorageFolder.</summary>
    /// <returns>The path.</returns>
    public extern string Path { [MethodImpl] get; }

    /// <summary>Gets the attributes of a loaded folder.</summary>
    /// <returns>The folder attributes.</returns>
    public extern FileAttributes Attributes { [MethodImpl] get; }

    /// <summary>Gets the date that the folder was created.</summary>
    /// <returns>The folder creation date.</returns>
    public extern DateTime DateCreated { [MethodImpl] get; }

    /// <summary>Determines whether the loaded StorageFolder is the specified type.</summary>
    /// <param name="type">The type of item to check against.</param>
    /// <returns>True if the loaded StorageFolder is the specified type; otherwise false.</returns>
    [MethodImpl]
    public extern bool IsOfType(StorageItemTypes type);

    /// <summary>Retrieves the thumbnail that is associated with the StorageFolder.</summary>
    /// <param name="mode">The thumbnail mode to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the thumbnail image as a StorageItemThumbnail object.</returns>
    [Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode);

    /// <summary>Retrieves the thumbnail that is associated with the StorageFolder, scaling it to the specified size.</summary>
    /// <param name="mode">The thumbnail mode to retrieve.</param>
    /// <param name="requestedSize">The requested size in pixels of thumbnail to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the thumbnail image as a StorageItemThumbnail object.</returns>
    [RemoteAsync]
    [Overload("GetThumbnailAsyncOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    /// <summary>Retrieves the thumbnail that is associated with the StorageFolder, based on the specified options.</summary>
    /// <param name="mode">The thumbnail mode to retrieve.</param>
    /// <param name="requestedSize">The requested size in pixels of thumbnail to retrieve.</param>
    /// <param name="options">The thumbnail retrieval options.</param>
    /// <returns>When this method completes successfully, it returns the thumbnail image as a StorageItemThumbnail object.</returns>
    [Overload("GetThumbnailAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

    /// <summary>Gets the user-friendly name of the StorageFolder.</summary>
    /// <returns>The user-friendly name of the StorageFolder.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the display type of the StorageFolder.</summary>
    /// <returns>The display type.</returns>
    public extern string DisplayType { [MethodImpl] get; }

    /// <summary>Gets the identifier that uniquely identifies the StorageFolder relative to other items in the same folder.</summary>
    /// <returns>The folder-relative identifier.</returns>
    public extern string FolderRelativeId { [MethodImpl] get; }

    /// <summary>Gets an object for retrieving the properties of the StorageFolder.</summary>
    /// <returns>The object for retrieving StorageFolder properties.</returns>
    public extern StorageItemContentProperties Properties { [MethodImpl] get; }

    /// <summary>Retrieves the indexed state of the folder.</summary>
    /// <returns>When this method completes successfully, it returns an IndexedState enumeration value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IndexedState> GetIndexedStateAsync();

    /// <summary>Creates an object for performing filtered search queries for StorageFile in the current folder.</summary>
    /// <returns>An object for managing the search queries and accessing the results.</returns>
    [Overload("CreateFileQueryOverloadDefault")]
    [MethodImpl]
    public extern StorageFileQueryResult CreateFileQuery();

    /// <summary>Creates an object for performing filtered search queries for StorageFile objects in the current folder. Search results are grouped based on the specified file attribute.</summary>
    /// <param name="query">A value that specifies the folder attribute to use to group the search results.</param>
    /// <returns>An object for managing the search queries and accessing the results.</returns>
    [Overload("CreateFileQuery")]
    [MethodImpl]
    public extern StorageFileQueryResult CreateFileQuery(CommonFileQuery query);

    /// <summary>Creates an object used to perform filtered search queries for StorageFile objects in the folder. The object is initialized with the specified query options.</summary>
    /// <param name="queryOptions">The initial query options.</param>
    /// <returns>An object for managing the search queries and accessing the results.</returns>
    [MethodImpl]
    public extern StorageFileQueryResult CreateFileQueryWithOptions(
      QueryOptions queryOptions);

    /// <summary>Creates an object for performing filtered search queries for child StorageFolder objects of the current folder.</summary>
    /// <returns>An object for managing the search queries and accessing the results.</returns>
    [Overload("CreateFolderQueryOverloadDefault")]
    [MethodImpl]
    public extern StorageFolderQueryResult CreateFolderQuery();

    /// <summary>Creates an object for performing filtered search queries for child StorageFolder objects of the current folder. Search results are grouped based on the specified folder attribute.</summary>
    /// <param name="query">A value that specifies the folder attribute to use to group the search results.</param>
    /// <returns>An object for managing the search queries and accessing the results.</returns>
    [Overload("CreateFolderQuery")]
    [MethodImpl]
    public extern StorageFolderQueryResult CreateFolderQuery(
      CommonFolderQuery query);

    /// <summary>Creates an object used to perform filtered search queries for child StorageFolder objects of the current folder. The object is initialized with the specified query options.</summary>
    /// <param name="queryOptions">The initial query options.</param>
    /// <returns>An object for managing the search queries and accessing the results.</returns>
    [MethodImpl]
    public extern StorageFolderQueryResult CreateFolderQueryWithOptions(
      QueryOptions queryOptions);

    /// <summary>Creates an object used to perform filtered search queries for items in the folder.</summary>
    /// <returns>An object for managing the search queries and accessing the results.</returns>
    [MethodImpl]
    public extern StorageItemQueryResult CreateItemQuery();

    /// <summary>Creates an object used to perform filtered search queries for items in the folder. The object is initialized with the specified query options.</summary>
    /// <param name="queryOptions">The initial query options.</param>
    /// <returns>An object for managing the search queries and accessing the results.</returns>
    [MethodImpl]
    public extern StorageItemQueryResult CreateItemQueryWithOptions(
      QueryOptions queryOptions);

    /// <summary>Retrieves a range of files from the current folder based on a common file query.</summary>
    /// <param name="query">The common file query.</param>
    /// <param name="startIndex">The zero-based index of the first file in the range.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of files to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of StorageFile objects in the folder.</returns>
    [RemoteAsync]
    [Overload("GetFilesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      CommonFileQuery query,
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Retrieves files from the current folder based on a common folder query.</summary>
    /// <param name="query">The common file query.</param>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of StorageFile objects in the folder.</returns>
    [Overload("GetFilesAsyncOverloadDefaultStartAndCount")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      CommonFileQuery query);

    /// <summary>Retrieves a range of child folders from the current folder based on a common folder query.</summary>
    /// <param name="query">The common folder query.</param>
    /// <param name="startIndex">The zero-based index of the first child folder in the range.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of child folders to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of child folders. Each child folder in this list is represented by a StorageFolder object.</returns>
    [Overload("GetFoldersAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      CommonFolderQuery query,
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Retrieves child folders from the current folder based on a common folder query.</summary>
    /// <param name="query">The common folder query.</param>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of child folders. Each child folder in this list is represented by a StorageFolder object.</returns>
    [Overload("GetFoldersAsyncOverloadDefaultStartAndCount")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      CommonFolderQuery query);

    /// <summary>Retrieves a range of items from the current folder.</summary>
    /// <param name="startIndex">The zero-based index of the first item in the range.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of items to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of items.</returns>
    [Overload("GetItemsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Retrieves a value that indicates whether the folder supports the specified search query options.</summary>
    /// <param name="queryOptions">The search query options to test.</param>
    /// <returns>True if the folder supports the specified search query options; otherwise false.</returns>
    [MethodImpl]
    public extern bool AreQueryOptionsSupported(QueryOptions queryOptions);

    /// <summary>Retrieves a value that indicates whether the current folder supports the specified common folder query.</summary>
    /// <param name="query">The common folder query to test.</param>
    /// <returns>True if the folder supports the specified common folder query; otherwise false.</returns>
    [MethodImpl]
    public extern bool IsCommonFolderQuerySupported(CommonFolderQuery query);

    /// <summary>Retrieves a value that indicates whether the current folder supports the specified common file query.</summary>
    /// <param name="query">The common file query to test.</param>
    /// <returns>True if the folder supports the specified common file query; otherwise false.</returns>
    [MethodImpl]
    public extern bool IsCommonFileQuerySupported(CommonFileQuery query);

    /// <summary>Gets the parent folder of the current folder.</summary>
    /// <returns>When this method completes, it returns the parent folder as a StorageFolder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetParentAsync();

    /// <summary>Indicates whether the current folder is equal to the specified folder.</summary>
    /// <param name="item">The IStorageItem object that represents the folder to compare against.</param>
    /// <returns>Returns **true** if the current folder is equal to the specified folder; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool IsEqual(IStorageItem item);

    /// <summary>Try to get a specific file or sub-folder from the current folder using the name of the file or folder to get.</summary>
    /// <param name="name">The name (or path relative to the current folder) of the file or sub-folder to try to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the file or folder (type IStorageItem ).</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> TryGetItemAsync(
      string name);

    /// <summary>Gets the StorageProvider object that contains info about the service that stores the current folder.</summary>
    /// <returns>The StorageProvider object that contains info about the service that stores the current folder. The file may be stored by the local file system or by a remote service like Microsoft OneDrive.</returns>
    public extern StorageProvider Provider { [MethodImpl] get; }
  }
}
