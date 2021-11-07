// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFolder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Manipulates folders and their contents, and provides information about them.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1926351736, 46063, 20341, 168, 11, 111, 217, 218, 226, 148, 75)]
  public interface IStorageFolder : IStorageItem
  {
    /// <summary>Creates a new file in the current folder.</summary>
    /// <param name="desiredName">The desired name of the file to create.</param>
    /// <returns>When this method completes, it returns the new file as a StorageFile.</returns>
    [RemoteAsync]
    [Overload("CreateFileAsyncOverloadDefaultOptions")]
    IAsyncOperation<StorageFile> CreateFileAsync(string desiredName);

    /// <summary>Creates a new file in the current folder, and specifies what to do if a file with the same name already exists in the current folder.</summary>
    /// <param name="desiredName">The desired name of the file to create.</param>
    /// <param name="options">The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing file in the current folder.</param>
    /// <returns>When this method completes, it returns the new file as a StorageFile.</returns>
    [Overload("CreateFileAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName,
      CreationCollisionOption options);

    /// <summary>Creates a new folder in the current folder.</summary>
    /// <param name="desiredName">The desired name of the folder to create.</param>
    /// <returns>When this method completes, it returns the new folder as a StorageFolder.</returns>
    [RemoteAsync]
    [Overload("CreateFolderAsyncOverloadDefaultOptions")]
    IAsyncOperation<StorageFolder> CreateFolderAsync(string desiredName);

    /// <summary>Creates a new folder in the current folder, and specifies what to do if a folder with the same name already exists in the current folder.</summary>
    /// <param name="desiredName">The desired name of the folder to create.</param>
    /// <param name="options">The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing folder in the current folder.</param>
    /// <returns>When this method completes, it returns the new folder as a StorageFolder.</returns>
    [Overload("CreateFolderAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName,
      CreationCollisionOption options);

    /// <summary>Gets the specified file from the current folder.</summary>
    /// <param name="name">The name (or path relative to the current folder) of the file to retrieve.</param>
    /// <returns>When this method completes successfully, it returns a StorageFile that represents the file.</returns>
    [RemoteAsync]
    IAsyncOperation<StorageFile> GetFileAsync(string name);

    /// <summary>Gets the specified folder from the current folder.</summary>
    /// <param name="name">The name of the child folder to retrieve.</param>
    /// <returns>When this method completes successfully, it returns a StorageFolder that represents the child folder.</returns>
    [RemoteAsync]
    IAsyncOperation<StorageFolder> GetFolderAsync(string name);

    /// <summary>Gets the specified item from the IStorageFolder.</summary>
    /// <param name="name">The name of the item to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the file or folder (type IStorageItem ).</returns>
    [RemoteAsync]
    IAsyncOperation<IStorageItem> GetItemAsync(string name);

    /// <summary>Gets the files from the current folder.</summary>
    /// <returns>When this method completes successfully, it returns a list of the files (type IVectorView ) in the folder. Each file in the list is represented by a StorageFile object.</returns>
    [RemoteAsync]
    [Overload("GetFilesAsyncOverloadDefaultOptionsStartAndCount")]
    IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();

    /// <summary>Gets the folders in the current folder.</summary>
    /// <returns>When this method completes successfully, it returns a list of the files (type IVectorView ). Each folder in the list is represented by a StorageFolder.</returns>
    [RemoteAsync]
    [Overload("GetFoldersAsyncOverloadDefaultOptionsStartAndCount")]
    IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();

    /// <summary>Gets the items from the current folder.</summary>
    /// <returns>When this method completes successfully, it returns a list of the files and folders (type IVectorView ). The files and folders in the list are represented by objects of type IStorageItem.</returns>
    [Overload("GetItemsAsyncOverloadDefaultStartAndCount")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
  }
}
