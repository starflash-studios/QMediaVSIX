// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageFile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.Storage
{
  /// <summary>Represents a file. Provides information about the file and its content, and ways to manipulate them.</summary>
  [Static(typeof (IStorageFileStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IStorageFileStatics2), 655360, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  public sealed class StorageFile : 
    IStorageFile,
    IInputStreamReference,
    IRandomAccessStreamReference,
    IStorageItem,
    IStorageItemProperties,
    IStorageItemProperties2,
    IStorageItem2,
    IStorageItemPropertiesWithProvider,
    IStorageFilePropertiesWithAvailability,
    IStorageFile2
  {
    /// <summary>Gets the type (file name extension) of the file.</summary>
    /// <returns>The file name extension of the file.</returns>
    public extern string FileType { [MethodImpl] get; }

    /// <summary>Gets the MIME type of the contents of the file.</summary>
    /// <returns>The MIME type of the file contents.</returns>
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

    /// <summary>Creates a copy of the file in the specified folder.</summary>
    /// <param name="destinationFolder">The destination folder where the copy of the file is created.</param>
    /// <returns>When this method completes, it returns a StorageFile that represents the copy of the file created in the *destinationFolder*.</returns>
    [Overload("CopyOverloadDefaultNameAndOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder);

    /// <summary>Creates a copy of the file in the specified folder and renames the copy.</summary>
    /// <param name="destinationFolder">The destination folder where the copy of the file is created.</param>
    /// <param name="desiredNewName">The new name for the copy of the file created in the *destinationFolder*.</param>
    /// <returns>When this method completes, it returns a StorageFile that represents the copy of the file created in the *destinationFolder*.</returns>
    [RemoteAsync]
    [Overload("CopyOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder,
      string desiredNewName);

    /// <summary>Creates a copy of the file in the specified folder and renames the copy. This method also specifies what to do if a file with the same name already exists in the destination folder.</summary>
    /// <param name="destinationFolder">The destination folder where the copy of the file is created.</param>
    /// <param name="desiredNewName">The new name for the copy of the file created in the *destinationFolder*.</param>
    /// <param name="option">One of the enumeration values that determines how to handle the collision if a file with the specified *desiredNewName* already exists in the destination folder.</param>
    /// <returns>When this method completes, it returns a StorageFile that represents the copy of the file created in the *destinationFolder*.</returns>
    [RemoteAsync]
    [Overload("CopyOverload")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder,
      string desiredNewName,
      NameCollisionOption option);

    /// <summary>Replaces the specified file with a copy of the current file.</summary>
    /// <param name="fileToReplace">The file to replace.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CopyAndReplaceAsync(IStorageFile fileToReplace);

    /// <summary>Moves the current file to the specified folder.</summary>
    /// <param name="destinationFolder">The destination folder where the file is moved.</param>
    /// <returns>No object or value is returned by this method.</returns>
    [Overload("MoveOverloadDefaultNameAndOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MoveAsync(IStorageFolder destinationFolder);

    /// <summary>Moves the current file to the specified folder and renames the file according to the desired name.</summary>
    /// <param name="destinationFolder">The destination folder where the file is moved.</param>
    /// <param name="desiredNewName">The desired name of the file after it is moved.</param>
    /// <returns>No object or value is returned by this method.</returns>
    [Overload("MoveOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MoveAsync(
      IStorageFolder destinationFolder,
      string desiredNewName);

    /// <summary>Moves the current file to the specified folder and renames the file according to the desired name. This method also specifies what to do if a file with the same name already exists in the specified folder.</summary>
    /// <param name="destinationFolder">The destination folder where the file is moved.</param>
    /// <param name="desiredNewName">The desired name of the file after it is moved.</param>
    /// <param name="option">An enum value that determines how Windows responds if the *desiredNewName* is the same as the name of an existing file in the destination folder.</param>
    /// <returns>No object or value is returned by this method.</returns>
    [RemoteAsync]
    [Overload("MoveOverload")]
    [MethodImpl]
    public extern IAsyncAction MoveAsync(
      IStorageFolder destinationFolder,
      string desiredNewName,
      NameCollisionOption option);

    /// <summary>Moves the current file to the location of the specified file and replaces the specified file in that location.</summary>
    /// <param name="fileToReplace">The file to replace.</param>
    /// <returns>No object or value is returned by this method.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MoveAndReplaceAsync(IStorageFile fileToReplace);

    /// <summary>Renames the current file.</summary>
    /// <param name="desiredName">The desired, new name of the current item.</param>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [RemoteAsync]
    [Overload("RenameAsyncOverloadDefaultOptions")]
    [MethodImpl]
    public extern IAsyncAction RenameAsync(string desiredName);

    /// <summary>Renames the current file. This method also specifies what to do if an existing item in the current file's location has the same name.</summary>
    /// <param name="desiredName">The desired, new name of the current file.</param>
    /// <param name="option">The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing item in the current file's location.</param>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [Overload("RenameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RenameAsync(
      string desiredName,
      NameCollisionOption option);

    /// <summary>Deletes the current file.</summary>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [Overload("DeleteAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Deletes the current file, optionally deleting the item permanently.</summary>
    /// <param name="option">A value that indicates whether to delete the item permanently.</param>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [RemoteAsync]
    [Overload("DeleteAsync")]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync(StorageDeleteOption option);

    /// <summary>Gets the basic properties of the current file.</summary>
    /// <returns>When this method completes successfully, it returns the basic properties of the current file as a BasicProperties object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();

    /// <summary>Gets the name of the file including the file name extension.</summary>
    /// <returns>The name of the file including the file name extension.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the full file-system path of the current file, if the file has a path.</summary>
    /// <returns>The full path of the file, if the file has a path in the user's file-system.</returns>
    public extern string Path { [MethodImpl] get; }

    /// <summary>Gets the attributes of a file.</summary>
    /// <returns>The file attributes.</returns>
    public extern FileAttributes Attributes { [MethodImpl] get; }

    /// <summary>Gets the date and time when the current file was created.</summary>
    /// <returns>The date and time when the current file was created.</returns>
    public extern DateTime DateCreated { [MethodImpl] get; }

    /// <summary>Determines whether the current StorageFile matches the specified StorageItemTypes value.</summary>
    /// <param name="type">The value to match against.</param>
    /// <returns>True if the StorageFile matches the specified value; otherwise false.</returns>
    [MethodImpl]
    public extern bool IsOfType(StorageItemTypes type);

    /// <summary>Opens a random-access stream over the current file for reading file contents.</summary>
    /// <returns>When this method completes, it returns the random-access stream (type IRandomAccessStreamWithContentType ).</returns>
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();

    /// <summary>Opens a sequential-access stream over the current file for reading file contents.</summary>
    /// <returns>When this method completes, it returns the sequential-access stream (type IInputStream ).</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IInputStream> OpenSequentialReadAsync();

    /// <summary>Retrieves an adjusted thumbnail image for the file, determined by the purpose of the thumbnail.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the file.</returns>
    [RemoteAsync]
    [Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode);

    /// <summary>Retrieves an adjusted thumbnail image for the file, determined by the purpose of the thumbnail and the requested size.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the file.</returns>
    [Overload("GetThumbnailAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    /// <summary>Retrieves an adjusted thumbnail image for the file, determined by the purpose of the thumbnail, the requested size, and the specified options.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <param name="options">The enum value that describes the desired behavior to use to retrieve the thumbnail image. The specified behavior might affect the size and/or quality of the image and how quickly the thumbnail image is retrieved.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the file.</returns>
    [Overload("GetThumbnailAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

    /// <summary>Gets a user-friendly name for the file.</summary>
    /// <returns>The user-friendly name for the file.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets a user-friendly description of the type of the file.</summary>
    /// <returns>The user-friendly description of the type of the file.</returns>
    public extern string DisplayType { [MethodImpl] get; }

    /// <summary>Gets an identifier for the file. This ID is unique for the query result or StorageFolder that contains the file and can be used to distinguish between items that have the same name.</summary>
    /// <returns>The identifier for the file.</returns>
    public extern string FolderRelativeId { [MethodImpl] get; }

    /// <summary>Gets an object that provides access to the content-related properties of the file.</summary>
    /// <returns>The object that provides access to the content-related properties of the file.</returns>
    public extern StorageItemContentProperties Properties { [MethodImpl] get; }

    /// <summary>Gets a scaled image as a thumbnail, determined by the purpose of the thumbnail.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [RemoteAsync]
    [Overload("GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode);

    /// <summary>Gets a scaled image as a thumbnail, determined by the purpose of the thumbnail and the requested size.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [Overload("GetScaledImageAsThumbnailAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    /// <summary>Gets a scaled image as a thumbnail, determined by the purpose of the thumbnail, the requested size, and the specified options</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <param name="options">The enum value that describes the desired behavior to use to retrieve the thumbnail image. The specified behavior might affect the size and/or quality of the image and how quickly the thumbnail image is retrieved.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [Overload("GetScaledImageAsThumbnailAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

    /// <summary>Gets the parent folder of the current file.</summary>
    /// <returns>When this method completes, it returns the parent folder as a StorageFolder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetParentAsync();

    /// <summary>Indicates whether the current file is equal to the specified file.</summary>
    /// <param name="item">The IStorageItem object that represents a file to compare against.</param>
    /// <returns>Returns true if the current file is equal to the specified file; otherwise false.</returns>
    [MethodImpl]
    public extern bool IsEqual(IStorageItem item);

    /// <summary>Gets the StorageProvider object that contains info about the service that stores the current file.</summary>
    /// <returns>The StorageProvider object that contains info about the service that stores the current file. The file may be stored by the local file system or by a remote service like Microsoft OneDrive.</returns>
    public extern StorageProvider Provider { [MethodImpl] get; }

    /// <summary>Indicates if the file is local, is cached locally, or can be downloaded.</summary>
    /// <returns>**True** if the file is local, is cached locally, or can be downloaded. Otherwise, **false**.</returns>
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
    public static extern IAsyncOperation<StorageFile> GetFileFromPathForUserAsync(
      User user,
      string path);

    /// <summary>Gets a StorageFile object to represent the file at the specified path.</summary>
    /// <param name="path">The path of the file to get a StorageFile to represent.</param>
    /// <returns>When this method completes, it returns the file as a StorageFile.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> GetFileFromPathAsync(
      string path);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> GetFileFromApplicationUriAsync(
      Uri uri);

    /// <summary>Creates a StorageFile to represent the specified stream of data. This method lets the app produce the data on-demand by specifying a function to be invoked when the StorageFile that represents the stream is first accessed.</summary>
    /// <param name="displayNameWithExtension">The user-friendly name of the StorageFile to create, including a file type extension.</param>
    /// <param name="dataRequested">The function that should be invoked when the StorageFile that is returned is first accessed. This function should produce the data stream represented by the returned StorageFile and lets the app produce data on-demand instead of writing the contents of the file at creation time.</param>
    /// <param name="thumbnail">The thumbnail image for the StorageFile to create.</param>
    /// <returns>When this method completes, it returns a StorageFile object that represents the new stream of data.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateStreamedFileAsync(
      string displayNameWithExtension,
      StreamedFileDataRequestedHandler dataRequested,
      IRandomAccessStreamReference thumbnail);

    /// <summary>Replaces the contents of the file referred to by the specified IStorageFile object with a new data stream. This method lets the app produce the data on-demand by specifying a function to be invoked when the StorageFile that represents the stream is first accessed.</summary>
    /// <param name="fileToReplace">The file (type IStorageFile ) that the new data stream should be written to.</param>
    /// <param name="dataRequested">The function that should be invoked when the StorageFile that is returned is first accessed. This function should produce the data stream represented by the returned StorageFile and lets the app produce data on-demand instead of writing the contents of the file at creation time.</param>
    /// <param name="thumbnail">The thumbnail image for the StorageFile to create.</param>
    /// <returns>When this method completes, it returns a StorageFile object that represents the new data stream. Subsequently, this StorageFile object should be used to access file content instead of the file (type IStorageFile ) that was specified to be replace.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> ReplaceWithStreamedFileAsync(
      IStorageFile fileToReplace,
      StreamedFileDataRequestedHandler dataRequested,
      IRandomAccessStreamReference thumbnail);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateStreamedFileFromUriAsync(
      string displayNameWithExtension,
      Uri uri,
      IRandomAccessStreamReference thumbnail);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> ReplaceWithStreamedFileFromUriAsync(
      IStorageFile fileToReplace,
      Uri uri,
      IRandomAccessStreamReference thumbnail);
  }
}
