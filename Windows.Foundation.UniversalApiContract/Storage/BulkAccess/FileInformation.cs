// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.FileInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;

namespace Windows.Storage.BulkAccess
{
  /// <summary>Provides synchronous access to the properties exposed off StorageFile and lets an app perform asynchronous file operations such as copy, delete, move, and rename.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileInformation : 
    IStorageItemInformation,
    IStorageFile,
    IInputStreamReference,
    IRandomAccessStreamReference,
    IStorageItem,
    IStorageItemProperties,
    IStorageItem2,
    IStorageItemPropertiesWithProvider,
    IStorageFilePropertiesWithAvailability,
    IStorageFile2
  {
    /// <summary>Gets the music properties associated with the StorageFile, such as the album name, artist name, bit rate, and so on.</summary>
    /// <returns>The music properties.</returns>
    public extern MusicProperties MusicProperties { [MethodImpl] get; }

    /// <summary>Gets an object that provides access to the video properties of the StorageFile, such as the duration, rating, date released, and so on.</summary>
    /// <returns>The video properties.</returns>
    public extern VideoProperties VideoProperties { [MethodImpl] get; }

    /// <summary>Gets the image properties of the StorageFile, such as the title, rating, date that the image was taken,</summary>
    /// <returns>The image properties.</returns>
    public extern ImageProperties ImageProperties { [MethodImpl] get; }

    /// <summary>Gets an object that provides access to the document properties of the StorageFile, such as the title, author name, and so on.</summary>
    /// <returns>The document properties.</returns>
    public extern DocumentProperties DocumentProperties { [MethodImpl] get; }

    /// <summary>Gets an object that contains the basic properties information of the file.</summary>
    /// <returns>The basic properties object.</returns>
    public extern BasicProperties BasicProperties { [MethodImpl] get; }

    /// <summary>Gets the thumbnail associated with the StorageFile.</summary>
    /// <returns>The thumbnail.</returns>
    public extern StorageItemThumbnail Thumbnail { [MethodImpl] get; }

    /// <summary>Fires when the StorageFile 's thumbnail is updated or a better quality thumbnail is available.</summary>
    public extern event TypedEventHandler<IStorageItemInformation, object> ThumbnailUpdated;

    /// <summary>Occurs when one or more of the StorageFile 's properties is updated.</summary>
    public extern event TypedEventHandler<IStorageItemInformation, object> PropertiesUpdated;

    /// <summary>Gets the file type.</summary>
    /// <returns>The file type.</returns>
    public extern string FileType { [MethodImpl] get; }

    /// <summary>Gets a string that describes the contents of the file.</summary>
    /// <returns>The content type string.</returns>
    public extern string ContentType { [MethodImpl] get; }

    /// <summary>Opens a random-access stream with the specified options over the specified file.</summary>
    /// <param name="accessMode">One of the enumeration values that specifies the type of access to allow.</param>
    /// <returns>When this method completes, it returns an IRandomAccessStream that contains the requested random-access stream.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> OpenAsync(
      FileAccessMode accessMode);

    /// <summary>Opens a random-access stream to the file that can be used for transacted-write operations.</summary>
    /// <returns>When this method completes, it returns a StorageStreamTransaction that contains the random-access stream and methods that can be used to complete transactions.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync();

    /// <summary>Creates a copy of the StorageFile and stores it in the specified StorageFolder.</summary>
    /// <param name="destinationFolder">The folder in which to store the copied file.</param>
    /// <returns>When this method completes successfully, it returns the copy as a StorageFile object.</returns>
    [Overload("CopyOverloadDefaultNameAndOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder);

    /// <summary>Creates a copy of the StorageFile, gives it the specified file name, and stores it in the specified StorageFolder.</summary>
    /// <param name="destinationFolder">The folder in which to store the copied file.</param>
    /// <param name="desiredNewName">The name of the new copy.</param>
    /// <returns>When this method completes successfully, it returns the copy as a StorageFile object.</returns>
    [RemoteAsync]
    [Overload("CopyOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder,
      string desiredNewName);

    /// <summary>Creates a copy of the StorageFile, gives it the specified file name, and stores it in the specified StorageFolder. The method also specifies what to do if a file with the same name already exists in the specified folder.</summary>
    /// <param name="destinationFolder">The folder in which to store the copied file.</param>
    /// <param name="desiredNewName">The name of the new copy.</param>
    /// <param name="option">A value that indicates what to do if the file name already exists in the destination folder.</param>
    /// <returns>When this method completes successfully, it returns the copy as a StorageFile object.</returns>
    [RemoteAsync]
    [Overload("CopyOverload")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder,
      string desiredNewName,
      NameCollisionOption option);

    /// <summary>Replaces the specified StorageFile with a copy of the current file.</summary>
    /// <param name="fileToReplace">The StorageFile to be replaced.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CopyAndReplaceAsync(IStorageFile fileToReplace);

    /// <summary>Moves the StorageFile to the specified StorageFolder.</summary>
    /// <param name="destinationFolder">The destination folder.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("MoveOverloadDefaultNameAndOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MoveAsync(IStorageFolder destinationFolder);

    /// <summary>Moves the StorageFile to the specified folder, and gives the file the specified file name.</summary>
    /// <param name="destinationFolder">The destination folder.</param>
    /// <param name="desiredNewName">The new file name.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [Overload("MoveOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncAction MoveAsync(
      IStorageFolder destinationFolder,
      string desiredNewName);

    /// <summary>Moves the StorageFile to the specified folder and gives it the specified file name. The method also specifies what to do if a file with the same name already exists in the specified folder.</summary>
    /// <param name="destinationFolder">The destination folder.</param>
    /// <param name="desiredNewName">The new file name.</param>
    /// <param name="option">A value that indicates what to do if the file name already exists in the destination folder.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("MoveOverload")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MoveAsync(
      IStorageFolder destinationFolder,
      string desiredNewName,
      NameCollisionOption option);

    /// <summary>Moves the current StorageFile from its location and uses it to replace the specified StorageFile.</summary>
    /// <param name="fileToReplace">The StorageFile to be replaced.</param>
    /// <returns>An object for managing the asynchronous move and replace operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MoveAndReplaceAsync(IStorageFile fileToReplace);

    /// <summary>Renames the StorageFile.</summary>
    /// <param name="desiredName">The new name.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("RenameAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RenameAsync(string desiredName);

    /// <summary>Renames the StorageFile, and specifies what to do if a file with the same name already exists in the current folder.</summary>
    /// <param name="desiredName">The new name.</param>
    /// <param name="option">A value that indicates what to do if the file name already exists in the current folder.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [Overload("RenameAsync")]
    [MethodImpl]
    public extern IAsyncAction RenameAsync(
      string desiredName,
      NameCollisionOption option);

    /// <summary>Deletes a file.</summary>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("DeleteAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Deletes a file, optionally moving the deleted file to the recycle bin.</summary>
    /// <param name="option">A value that specifies whether the deleted file is moved to the recycle bin.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("DeleteAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync(StorageDeleteOption option);

    /// <summary>Retrieves the basic properties of the StorageFile.</summary>
    /// <returns>When this method completes successfully, it returns a BasicProperties object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();

    /// <summary>Gets the name of the StorageFile.</summary>
    /// <returns>The name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the path of the StorageFile.</summary>
    /// <returns>The path.</returns>
    public extern string Path { [MethodImpl] get; }

    /// <summary>Gets the attributes of a file.</summary>
    /// <returns>The file attributes.</returns>
    public extern FileAttributes Attributes { [MethodImpl] get; }

    /// <summary>Gets the date that the file was created.</summary>
    /// <returns>The file creation date.</returns>
    public extern DateTime DateCreated { [MethodImpl] get; }

    /// <summary>Determines whether the loaded StorageFile is the specified type.</summary>
    /// <param name="type">The type of item to check against.</param>
    /// <returns>True if the loaded StorageFile is the specified type; otherwise false.</returns>
    [MethodImpl]
    public extern bool IsOfType(StorageItemTypes type);

    /// <summary>Opens a read-only, random-access stream over the StorageFile.</summary>
    /// <returns>When this method completes successfully, it returns a read-only, random-access stream (type IRandomAccessStreamWithContentType ).</returns>
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();

    /// <summary>Opens a read-only, sequential-access stream over the StorageFile.</summary>
    /// <returns>When this method completes successfully, it returns a read-only, sequential-access stream (type IInputStream ).</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IInputStream> OpenSequentialReadAsync();

    /// <summary>Retrieves the thumbnail that is associated with the StorageFile.</summary>
    /// <param name="mode">The thumbnail mode to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the thumbnail image as a StorageItemThumbnail object.</returns>
    [RemoteAsync]
    [Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode);

    /// <summary>Retrieves the thumbnail that is associated with the StorageFile, scaling it to the specified size.</summary>
    /// <param name="mode">The thumbnail mode to retrieve.</param>
    /// <param name="requestedSize">The requested size in pixels of thumbnail to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the thumbnail image as a StorageItemThumbnail object.</returns>
    [Overload("GetThumbnailAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    /// <summary>Retrieves the thumbnail that is associated with the StorageFile, based on the specified options.</summary>
    /// <param name="mode">The thumbnail mode to retrieve.</param>
    /// <param name="requestedSize">The requested size in pixels of thumbnail to retrieve.</param>
    /// <param name="options">The thumbnail retrieval options.</param>
    /// <returns>When this method completes successfully, it returns the thumbnail image as a StorageItemThumbnail object.</returns>
    [RemoteAsync]
    [Overload("GetThumbnailAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

    /// <summary>Gets the user-friendly name of the StorageFile.</summary>
    /// <returns>The user-friendly name of the StorageFile.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the display type of the StorageFile.</summary>
    /// <returns>The display type.</returns>
    public extern string DisplayType { [MethodImpl] get; }

    /// <summary>Gets the identifier that uniquely identifies the StorageFile relative to other items in the same folder.</summary>
    /// <returns>The folder-relative identifier.</returns>
    public extern string FolderRelativeId { [MethodImpl] get; }

    /// <summary>Gets an object for retrieving the properties of the StorageFile.</summary>
    /// <returns>An object for retrieving StorageFile properties.</returns>
    public extern StorageItemContentProperties Properties { [MethodImpl] get; }

    /// <summary>Gets the parent folder of the current file.</summary>
    /// <returns>When this method completes, it returns the parent folder as a StorageFolder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetParentAsync();

    /// <summary>Indicates whether the current file is the same as the specified storage item.</summary>
    /// <param name="item">The IStorageItem object that represents a storage item to compare against.</param>
    /// <returns>Returns **true** if the current storage item is the same as the specified storage item; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool IsEqual(IStorageItem item);

    /// <summary>Gets the StorageProvider object that contains info about the service that stores the current file.</summary>
    /// <returns>The StorageProvider object that contains info about the service that stores the current file. The file may be stored by the local file system or by a remote service like Microsoft OneDrive.</returns>
    public extern StorageProvider Provider { [MethodImpl] get; }

    /// <summary>Indicates if the current file has been downloaded or can be downloaded.</summary>
    /// <returns>**True** if the file has been downloaded or can be downloaded. Otherwise, **false**.</returns>
    public extern bool IsAvailable { [MethodImpl] get; }

    /// <summary>Opens a random-access stream with the specified options over the specified file.</summary>
    /// <param name="accessMode">One of the enumeration values that specifies the type of access to allow.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for opening the stream.</param>
    /// <returns>When this method completes, it returns an IRandomAccessStream that contains the requested random-access stream.</returns>
    [Overload("OpenWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> OpenAsync(
      FileAccessMode accessMode,
      StorageOpenOptions options);

    /// <summary>Opens a random-access stream to the file that can be used for transacted-write operations with the specified options.</summary>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for opening the stream.</param>
    /// <returns>When this method completes, it returns a StorageStreamTransaction that contains the random-access stream and methods that can be used to complete transactions.</returns>
    [RemoteAsync]
    [Overload("OpenTransactedWriteWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync(
      StorageOpenOptions options);
  }
}
