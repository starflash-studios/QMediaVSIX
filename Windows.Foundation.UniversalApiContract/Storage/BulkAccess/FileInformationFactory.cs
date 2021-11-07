// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.FileInformationFactory
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
  /// <summary>Used to load information about files and folders from the results of a query and to bind these file system items to JavaScript [ListView](https://docs.microsoft.com/previous-versions/windows/apps/br211837(v=win.10)) or XAML ListView and GridView controls. After information is loaded, an app can then access that information quickly using synchronous operations.</summary>
  [Activatable(typeof (IFileInformationFactoryFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FileInformationFactory : IFileInformationFactory
  {
    /// <summary>Creates a new FileInformationFactory object that retrieves information about the StorageFile and StorageFolder objects in the specified query result.</summary>
    /// <param name="queryResult">The result of a query of files and folders on the system.</param>
    /// <param name="mode">A value that indicates the type of thumbnail view to retrieve for the StorageFile and StorageFolder.</param>
    [MethodImpl]
    public extern FileInformationFactory(IStorageQueryResultBase queryResult, ThumbnailMode mode);

    /// <summary>Creates a new FileInformationFactory object that retrieves information about the StorageFile and StorageFolder objects in the specified query result and that specifies the requested size for thumbnails that are retrieved for the objects.</summary>
    /// <param name="queryResult">The result of a query of files and folders on the system.</param>
    /// <param name="mode">A value that indicates the type of thumbnail view to retrieve for the StorageFile and StorageFolder.</param>
    /// <param name="requestedThumbnailSize">The requested minimum size, in pixels, of the StorageFile and StorageFolder thumbnails.</param>
    [MethodImpl]
    public extern FileInformationFactory(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize);

    /// <summary>Creates a new FileInformationFactory object that retrieves information about the StorageFile and StorageFolder objects in the specified query result, and that specifies the requested size and options for thumbnails that are retrieved for the objects.</summary>
    /// <param name="queryResult">The result of a query of files and folders on the system.</param>
    /// <param name="mode">A value that indicates the type of thumbnail view to retrieve for the StorageFile and StorageFolder.</param>
    /// <param name="requestedThumbnailSize">The requested minimum size, in pixels, of the StorageFile and StorageFolder thumbnails.</param>
    /// <param name="thumbnailOptions">The thumbnail retrieval options.</param>
    [MethodImpl]
    public extern FileInformationFactory(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize,
      ThumbnailOptions thumbnailOptions);

    /// <summary>Creates a new FileInformationFactory object that retrieves information about the StorageFile and StorageFolder objects in the specified query result, specifies the requested size and options for thumbnails that are retrieved for the objects, and indicates whether to delay loading information.</summary>
    /// <param name="queryResult">The result of a query of files and folders on the system.</param>
    /// <param name="mode">A value that indicates the type of thumbnail view to retrieve for the StorageFile and StorageFolder.</param>
    /// <param name="requestedThumbnailSize">The requested minimum size, in pixels, of the StorageFile and StorageFolder thumbnails.</param>
    /// <param name="thumbnailOptions">The thumbnail retrieval options.</param>
    /// <param name="delayLoad">True to delay loading information; otherwise false. By default, this option is false and delay loading is not used.</param>
    [MethodImpl]
    public extern FileInformationFactory(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize,
      ThumbnailOptions thumbnailOptions,
      bool delayLoad);

    /// <summary>Retrieves a collection of IStorageItemInformation objects that contain information about a range of items in a collection.</summary>
    /// <param name="startIndex">The zero-based index of the first item in the range.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of items to retrieve information for.</param>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of FileInformation and FolderInformation objects.</returns>
    [Overload("GetItemsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Retrieves a collection of IStorageItemInformation objects that contain information about all the items in the collection.</summary>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of FileInformation and FolderInformation objects.</returns>
    [RemoteAsync]
    [Overload("GetItemsAsyncDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync();

    /// <summary>Retrieves a collection of FileInformation objects that contain information about a range of StorageFile objects in a collection.</summary>
    /// <param name="startIndex">The zero-based index of the first StorageFile in the range.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of StorageFile objects to retrieve information for.</param>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of FileInformation objects.</returns>
    [RemoteAsync]
    [Overload("GetFilesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Retrieves a collection of FileInformation objects that contain information about all StorageFile objects in a collection.</summary>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of FileInformation objects.</returns>
    [RemoteAsync]
    [Overload("GetFilesAsyncDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync();

    /// <summary>Retrieves a collection of FolderInformation objects that contain information about a range of StorageFolder objects in a collection.</summary>
    /// <param name="startIndex">The zero-based index of the first StorageFolder in the range.</param>
    /// <param name="maxItemsToRetrieve">The maximum number of StorageFolder objects to retrieve information for.</param>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of FolderInformation objects.</returns>
    [RemoteAsync]
    [Overload("GetFoldersAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    /// <summary>Retrieves a collection of FolderInformation objects that contain information about all StorageFolder objects in a collection.</summary>
    /// <returns>When this method completes successfully, it returns the list (type IVectorView ) of FolderInformation objects.</returns>
    [Overload("GetFoldersAsyncDefaultStartAndCount")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync();

    /// <summary>Gets a virtualized vector of IStorageItemInformation objects that can be bound to ListView or GridView controls in C#, C++, and VB.</summary>
    /// <returns>The virtualized vector of IStorageItemInformation objects.</returns>
    [MethodImpl]
    public extern object GetVirtualizedItemsVector();

    /// <summary>Gets a virtualized vector of IStorageItemInformation objects that can be bound to ListView or GridView controls in C#, C++, and VB.</summary>
    /// <returns>The virtualized vector of IStorageItemInformation objects.</returns>
    [MethodImpl]
    public extern object GetVirtualizedFilesVector();

    /// <summary>Gets a virtualized vector of IStorageItemInformation objects that can be bound to ListView or GridView controls in C#, C++, and VB.</summary>
    /// <returns>The virtualized vector of IStorageItemInformation objects.</returns>
    [MethodImpl]
    public extern object GetVirtualizedFoldersVector();
  }
}
