// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageFolder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Search;
using Windows.System;

namespace Windows.Storage
{
  /// <summary>Manages folders and their contents and provides information about them.</summary>
  [Static(typeof (IStorageFolderStatics2), 655360, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStorageFolderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageFolder : 
    IStorageFolder,
    IStorageItem,
    IStorageFolderQueryOperations,
    IStorageItemProperties,
    IStorageItemProperties2,
    IStorageItem2,
    IStorageFolder2,
    IStorageItemPropertiesWithProvider,
    IStorageFolder3
  {
    /// <summary>Creates a new file with the specified name in the current folder.</summary>
    /// <param name="desiredName">The name of the new file to create in the current folder.</param>
    /// <returns>When this method completes, it returns a StorageFile that represents the new file.</returns>
    [Overload("CreateFileAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName);

    /// <summary>Creates a new file in the current folder. This method also specifies what to do if a file with the same name already exists in the current folder.</summary>
    /// <param name="desiredName">The name of the new file to create in the current folder.</param>
    /// <param name="options">One of the enumeration values that determines how to handle the collision if a file with the specified *desiredName* already exists in the current folder.</param>
    /// <returns>When this method completes, it returns a StorageFile that represents the new file.</returns>
    [Overload("CreateFileAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName,
      CreationCollisionOption options);

    /// <summary>Creates a new subfolder with the specified name in the current folder.</summary>
    /// <param name="desiredName">The name of the new subfolder to create in the current folder.</param>
    /// <returns>When this method completes, it returns a StorageFolder that represents the new subfolder.</returns>
    [RemoteAsync]
    [Overload("CreateFolderAsyncOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName);

    /// <summary>Creates a new subfolder with the specified name in the current folder. This method also specifies what to do if a subfolder with the same name already exists in the current folder.</summary>
    /// <param name="desiredName">The name of the new subfolder to create in the current folder.</param>
    /// <param name="options">One of the enumeration values that determines how to handle the collision if a subfolder with the specified *desiredName* already exists in the current folder.</param>
    /// <returns>When this method completes, it returns a StorageFolder that represents the new subfolder.</returns>
    [Overload("CreateFolderAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName,
      CreationCollisionOption options);

    /// <summary>Gets the file with the specified name from the current folder.</summary>
    /// <param name="name">The name (or path relative to the current folder) of the file to get.</param>
    /// <returns>When this method completes successfully, it returns a StorageFile that represents the specified file.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> GetFileAsync(string name);

    /// <summary>Gets the subfolder with the specified name from the current folder.</summary>
    /// <param name="name">The name (or path relative to the current folder) of the subfolder to get.</param>
    /// <returns>When this method completes successfully, it returns a StorageFolder that represents the specified subfolder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetFolderAsync(
      string name);

    /// <summary>Gets the file or folder with the specified name from the current folder.</summary>
    /// <param name="name">The name (or path relative to the current folder) of the file or folder to get.</param>
    /// <returns>When this method completes successfully, it returns an IStorageItem that represents the specified file or folder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> GetItemAsync(string name);

    /// <summary>Gets the files in the current folder.</summary>
    /// <returns>When this method completes successfully, it returns a list of the files in the current folder. The list is of type **IReadOnlyList**&lt;StorageFile &gt;. Each file in the list is represented by a StorageFile object.</returns>
    [Overload("GetFilesAsyncOverloadDefaultOptionsStartAndCount")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();

    /// <summary>Gets the subfolders in the current folder.</summary>
    /// <returns>When this method completes successfully, it returns a list of the subfolders in the current folder. The list is of type **IReadOnlyList**&lt;StorageFolder &gt;. Each folder in the list is represented by a StorageFolder object.</returns>
    [Overload("GetFoldersAsyncOverloadDefaultOptionsStartAndCount")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();

    /// <summary>Gets the files and subfolders in the current folder.</summary>
    /// <returns>When this method completes successfully, it returns a list of the files and folders in the current folder. The list is of type **IReadOnlyList**&lt;IStorageItem &gt;. Each item in the list is represented by an IStorageItem object.</returns>
    [RemoteAsync]
    [Overload("GetItemsAsyncOverloadDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();

    /// <summary>Renames the current folder.</summary>
    /// <param name="desiredName">The desired, new name for the current folder.</param>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [Overload("RenameAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RenameAsync(string desiredName);

    /// <summary>Renames the current folder and specifies what to do if a folder with the same name already exists.</summary>
    /// <param name="desiredName">The desired, new name for the current folder.</param>
    /// <param name="option">The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing item in the current folder's location.</param>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [Overload("RenameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RenameAsync(
      string desiredName,
      NameCollisionOption option);

    /// <summary>Deletes the current folder.</summary>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [Overload("DeleteAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Deletes the current folder. This method also specifies whether to delete the folder permanently.</summary>
    /// <param name="option">One of the enumeration values that specifies whether to delete the folder permanently.</param>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [Overload("DeleteAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync(StorageDeleteOption option);

    /// <summary>Gets the basic properties of the current folder or file group.</summary>
    /// <returns>When this method completes successfully, it returns the basic properties of the current folder or file group as a BasicProperties object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();

    /// <summary>Gets the name of the current folder.</summary>
    /// <returns>The name of the current folder.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the full path of the current folder in the file system, if the path is available.</summary>
    /// <returns>The full path of the current folder in the file system, if the path is available.</returns>
    public extern string Path { [MethodImpl] get; }

    /// <summary>Gets the attributes of the current folder.</summary>
    /// <returns>The attributes of the current folder.</returns>
    public extern FileAttributes Attributes { [MethodImpl] get; }

    /// <summary>Gets the date and time that the current folder was created.</summary>
    /// <returns>The date and time that the current folder was created as type DateTime.</returns>
    public extern DateTime DateCreated { [MethodImpl] get; }

    /// <summary>Indicates whether the current StorageFolder matches the specified StorageItemTypes value.</summary>
    /// <param name="type">The enum value that determines the object type to match against.</param>
    /// <returns>True if the StorageFolder matches the specified StorageItemTypes value; otherwise false.</returns>
    [MethodImpl]
    public extern bool IsOfType(StorageItemTypes type);

    /// <summary>Gets the indexed state of the current folder.</summary>
    /// <returns>When this method completes successfully, it returns an IndexedState enum value that describes the state of the folder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IndexedState> GetIndexedStateAsync();

    /// <summary>Gets a query result object that contains the files in the current folder.</summary>
    /// <returns>A query result object. Call the GetFilesAsync method of the query result to get the flat list of files. This method returns a list of type **IReadOnlyList**&lt;StorageFile &gt;. Each file is represented by an item of type StorageFile.</returns>
    [Overload("CreateFileQueryOverloadDefault")]
    [MethodImpl]
    public extern StorageFileQueryResult CreateFileQuery();

    /// <summary>Gets a query result object that contains the files in the current folder. Also gets the files from the subfolders of the current folder when the value of the *query* argument is something other than CommonFileQuery.DefaultQuery. Files are sorted based on the specified CommonFileQuery.</summary>
    /// <param name="query">One of the enumeration values that specifies how to sort the files and determines whether the query is shallow or deep.</param>
    /// <returns>A query result object. Call the GetFilesAsync method of the query result to get the flat list of files, sorted as specified by *query*. This method returns a list of type **IReadOnlyList**&lt;StorageFile &gt;. Each file is represented by an item of type StorageFile.</returns>
    [Overload("CreateFileQuery")]
    [MethodImpl]
    public extern StorageFileQueryResult CreateFileQuery(CommonFileQuery query);

    /// <summary>Gets a query result object that contains the files in the current folder and, optionally, in the subfolders of the current folder. The results are based on the specified QueryOptions.</summary>
    /// <param name="queryOptions">The criteria that are applied to the query.</param>
    /// <returns>A query result object that contains the files in the current folder and, optionally, in the subfolders of the current folder, filtered and sorted based on the specified QueryOptions. Call the GetFilesAsync method of the query result to get the flat list of files, sorted as specified by *queryOptions*. This method returns a list of type **IReadOnlyList**&lt;StorageFile &gt;. Each file is represented by an item of type StorageFile.</returns>
    [MethodImpl]
    public extern StorageFileQueryResult CreateFileQueryWithOptions(
      QueryOptions queryOptions);

    /// <summary>Gets a query result object that contains the subfolders in the current folder.</summary>
    /// <returns>A query result object. Call the GetFoldersAsync method of the query result to get the subfolders in the current folder. This method returns a list of type **IReadOnlyList**&lt;StorageFolder &gt;. Each file or folder is represented by an item of type StorageFolder.</returns>
    [Overload("CreateFolderQueryOverloadDefault")]
    [MethodImpl]
    public extern StorageFolderQueryResult CreateFolderQuery();

    /// <summary>Gets a query result object that contains the subfolders in the current folder. When the value of the *query* argument is something other than CommonFolderQuery.DefaultQuery, gets a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. Files are grouped into folders based on the specified value from the CommonFolderQuery enumeration.</summary>
    /// <param name="query">One of the enumeration values that specifies how to group the files into folders and determines whether the query is shallow or deep.</param>
    /// <returns>A query result object. Call the GetFoldersAsync method of the query result to get the subfolders in the current folder. When the value of the *query* argument is something other than CommonFolderQuery.DefaultQuery, the query result object contains a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. (Files from the current folder are not included.) The files are grouped as specified by *query*.</returns>
    [Overload("CreateFolderQuery")]
    [MethodImpl]
    public extern StorageFolderQueryResult CreateFolderQuery(
      CommonFolderQuery query);

    /// <summary>Gets a query result object that contains the subfolders in the current folder and, optionally, nested subfolders. The results are based on the specified QueryOptions.</summary>
    /// <param name="queryOptions">The criteria that are applied to the query.</param>
    /// <returns>A query result object. Call the GetFoldersAsync method of the query result to get the subfolders in the current folder. If you provided a CommonFolderQuery value other than CommonFolderQuery.DefaultQuery when you instantiated the QueryOptions, the query result object contains a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. (Files from the current folder are not included.) The files are grouped as specified by *queryOptions*.</returns>
    [MethodImpl]
    public extern StorageFolderQueryResult CreateFolderQueryWithOptions(
      QueryOptions queryOptions);

    /// <summary>Gets a query result object that contains the files and subfolders in the current folder.</summary>
    /// <returns>A query result object. Call the GetItemsAsync method of the query result to get the files and subfolders in the current folder. This method returns a list of type **IReadOnlyList**&lt;IStorageItem &gt;. Each file or folder is represented by an item of type IStorageItem.</returns>
    [MethodImpl]
    public extern StorageItemQueryResult CreateItemQuery();

    /// <summary>Gets a query result object that contains the files and subfolders in the current folder and, optionally, in the subfolders of the current folder. The results are based on the specified QueryOptions.</summary>
    /// <param name="queryOptions">The criteria that are applied to the query.</param>
    /// <returns>A query result object. Call the GetItemsAsync method of the query result to get the files and subfolders in the current folder and, optionally, in the subfolders of the current folder, filtered and sorted based on the specified QueryOptions. This method returns a list of type **IReadOnlyList**&lt;IStorageItem &gt;. Each file or folder is represented by an item of type IStorageItem.</returns>
    [MethodImpl]
    public extern StorageItemQueryResult CreateItemQueryWithOptions(
      QueryOptions queryOptions);

    /// <summary>Gets an index-based range of files from the list of all files in the current folder. Also gets the files from the subfolders of the current folder when the value of the *query* argument is something other than CommonFileQuery.DefaultQuery. Files are sorted based on the specified value from the CommonFileQuery enumeration.</summary>
    /// <param name="query">One of the enumeration values that specifies how to sort the files and determines whether the query is shallow or deep.</param>
    /// <param name="startIndex">The zero-based index of the first file in the range to retrieve.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of files to retrieve.</param>
    /// <returns>When this method completes successfully, it returns a flat list of files sorted as specified by *query*. The list is of type **IReadOnlyList**&lt;StorageFile &gt;. Each file in the list is represented by a StorageFile object.</returns>
    [RemoteAsync]
    [Overload("GetFilesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      CommonFileQuery query,
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Gets the files in the current folder. Also gets the files from the subfolders of the current folder when the value of the *query* argument is something other than CommonFileQuery.DefaultQuery. Files are sorted based on the specified value from the CommonFileQuery enumeration.</summary>
    /// <param name="query">One of the enumeration values that specifies how to sort the files and determines whether the query is shallow or deep.</param>
    /// <returns>When this method completes successfully, it returns a flat list of files, sorted as specified by *query*. The list is of type **IReadOnlyList**&lt;StorageFile &gt;. Each file in the list is represented by a StorageFile object.</returns>
    [Overload("GetFilesAsyncOverloadDefaultStartAndCount")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      CommonFileQuery query);

    /// <summary>Gets an index-based range of folders from the list of all subfolders in the current folder. When the value of the *query* argument is something other than CommonFolderQuery.DefaultQuery, gets a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. Files are grouped into folders based on the specified value from the CommonFolderQuery enumeration.</summary>
    /// <param name="query">One of the enumeration values that specifies how to group the files into folders and determines whether the query is shallow or deep.</param>
    /// <param name="startIndex">The zero-based index of the first folder in the range to retrieve.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of folders to retrieve.</param>
    /// <returns>When this method completes successfully, it returns a list of subfolders. When the value of the *query* argument is something other than CommonFolderQuery.DefaultQuery, this method returns a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. (Files from the current folder are not included.) The files are grouped as specified by *query*. The list is of type **IReadOnlyList**&lt;StorageFolder &gt;.</returns>
    [RemoteAsync]
    [Overload("GetFoldersAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      CommonFolderQuery query,
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Gets the subfolders in the current folder. When the value of the *query* argument is something other than CommonFolderQuery.DefaultQuery, gets a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. Files are grouped into folders based on the specified value from the CommonFolderQuery enumeration.</summary>
    /// <param name="query">One of the enumeration values that specifies how to group the files into folders and determines whether the query is shallow or deep.</param>
    /// <returns>When this method completes successfully, it returns a list of subfolders. When the value of the *query* argument is something other than CommonFolderQuery.DefaultQuery, this method returns a list of virtual folders that represent containers for groups of files in the subfolders of the current folder. (Files from the current folder are not included.) The files are grouped as specified by *query*. The list is of type **IReadOnlyList**&lt;StorageFolder &gt;.</returns>
    [Overload("GetFoldersAsyncOverloadDefaultStartAndCount")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      CommonFolderQuery query);

    /// <summary>Gets an index-based range of files and folders from the list of all files and subfolders in the current folder.</summary>
    /// <param name="startIndex">The zero-based index of the first item in the range to get.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of items to get.</param>
    /// <returns>When this method completes successfully, it returns a list of the files and subfolders in the current folder. The list is of type **IReadOnlyList**&lt;IStorageItem &gt;. Each item in the list is represented by an IStorageItem object.</returns>
    [Overload("GetItemsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Indicates whether the current folder supports the specified QueryOptions.</summary>
    /// <param name="queryOptions">The QueryOptions to check.</param>
    /// <returns>True if the folder or file group supports the specified QueryOptions; otherwise false.</returns>
    [MethodImpl]
    public extern bool AreQueryOptionsSupported(QueryOptions queryOptions);

    /// <summary>Indicates whether the current folder supports the specified CommonFolderQuery.</summary>
    /// <param name="query">The value to test.</param>
    /// <returns>True if the folder supports the specified CommonFolderQuery; otherwise, false.</returns>
    [MethodImpl]
    public extern bool IsCommonFolderQuerySupported(CommonFolderQuery query);

    /// <summary>Indicates whether the current folder supports the specified CommonFileQuery.</summary>
    /// <param name="query">The value to test.</param>
    /// <returns>True if the folder supports the specified CommonFileQuery; otherwise, false.</returns>
    [MethodImpl]
    public extern bool IsCommonFileQuerySupported(CommonFileQuery query);

    /// <summary>Gets a thumbnail image for the current folder, sized for the specified purpose of the thumbnail.</summary>
    /// <param name="mode">A value from the enumeration that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image, or **null** if there is no thumbnail image associated with the folder.</returns>
    [Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode);

    /// <summary>Gets a thumbnail image for the current folder, sized for the specified purpose of the thumbnail and adjusted to the requested size.</summary>
    /// <param name="mode">A value from the enumeration that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. This method uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image, or **null** if there is no thumbnail image associated with the folder.</returns>
    [RemoteAsync]
    [Overload("GetThumbnailAsyncOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    /// <summary>Gets a thumbnail image for the current folder, sized for the specified purpose of the thumbnail and adjusted to the requested size with the specified options.</summary>
    /// <param name="mode">A value from the enumeration that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. This method uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <param name="options">A value from the enumeration that specifies how to retrieve and size the image. The default value, **UseCurrentScale**, is suitable for most apps.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image, or **null** if there is no thumbnail image associated with the folder.</returns>
    [Overload("GetThumbnailAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

    /// <summary>Gets the user-friendly name of the current folder.</summary>
    /// <returns>The user-friendly name of the current folder.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the user-friendly description of the type of the folder; for example, `JPEG image`.</summary>
    /// <returns>The user-friendly description of the type of the folder; for example, `JPEG image`.</returns>
    public extern string DisplayType { [MethodImpl] get; }

    /// <summary>Gets an identifier for the current folder. This ID is unique for the query result or StorageFolder that contains the current folder or file group, and can be used to distinguish between items that have the same name.</summary>
    /// <returns>The identifier for the current folder or file group within a query result or StorageFolder.</returns>
    public extern string FolderRelativeId { [MethodImpl] get; }

    /// <summary>Gets an object that provides access to the content-related properties of the current folder.</summary>
    /// <returns>The object that provides access to the content-related properties of the folder.</returns>
    public extern StorageItemContentProperties Properties { [MethodImpl] get; }

    /// <summary>Gets a scaled image as a thumbnail, determined by the purpose of the thumbnail.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [Overload("GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode);

    /// <summary>Gets a scaled image as a thumbnail, determined by the purpose of the thumbnail and the requested size.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [RemoteAsync]
    [Overload("GetScaledImageAsThumbnailAsyncOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    /// <summary>Gets a scaled image as a thumbnail, determined by the purpose of the thumbnail, the requested size, and the specified options</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <param name="options">The enum value that describes the desired behavior to use to retrieve the thumbnail image. The specified behavior might affect the size and/or quality of the image and how quickly the thumbnail image is retrieved.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [RemoteAsync]
    [Overload("GetScaledImageAsThumbnailAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

    /// <summary>Gets the parent folder of the current folder.</summary>
    /// <returns>When this method completes, it returns the parent folder as a StorageFolder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetParentAsync();

    /// <summary>Indicates whether the current folder is equal to the specified folder.</summary>
    /// <param name="item">The IStorageItem object that represents the folder to compare against.</param>
    /// <returns>Returns true if the current folder is equal to the specified folder; otherwise false.</returns>
    [MethodImpl]
    public extern bool IsEqual(IStorageItem item);

    /// <summary>Tries to get the file or folder with the specified name from the current folder. Returns **null** instead of raising a **FileNotFoundException** if the specified file or folder is not found.</summary>
    /// <param name="name">The name (or path relative to the current folder) of the file or folder to get.</param>
    /// <returns>When this method completes successfully, it returns an IStorageItem that represents the specified file or folder. If the specified file or folder is not found, this method returns **null** instead of raising an exception.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> TryGetItemAsync(
      string name);

    /// <summary>Gets the StorageProvider object that contains info about the service that stores the current folder.</summary>
    /// <returns>The StorageProvider object that contains info about the service that stores the current folder. The folder may be stored by the local file system or by a remote service like Microsoft OneDrive.</returns>
    public extern StorageProvider Provider { [MethodImpl] get; }

    /// <summary>Gets the StorageLibraryChangeTracker associated with a StorageFolder.</summary>
    /// <returns>The StorageLibraryChangeTracker associated with a StorageFolder.</returns>
    [MethodImpl]
    public extern StorageLibraryChangeTracker TryGetChangeTracker();

    /// <summary>
    /// </summary>
    /// <param name="user">
    /// </param>
    /// <param name="path">
    /// </param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> GetFolderFromPathForUserAsync(
      User user,
      string path);

    /// <summary>Gets the folder that has the specified absolute path in the file system.</summary>
    /// <param name="path">The absolute path in the file system (not the Uri) of the folder to get.</param>
    /// <returns>When this method completes successfully, it returns a StorageFolder that represents the specified folder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> GetFolderFromPathAsync(
      string path);
  }
}
