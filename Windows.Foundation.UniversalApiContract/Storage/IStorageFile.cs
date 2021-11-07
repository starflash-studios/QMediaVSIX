// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  /// <summary>Represents a file. Provides information about the file and its contents, and ways to manipulate them.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4198457734, 16916, 17036, 166, 76, 20, 201, 172, 115, 21, 234)]
  public interface IStorageFile : IStorageItem, IRandomAccessStreamReference, IInputStreamReference
  {
    /// <summary>Gets the type (file name extension) of the file.</summary>
    /// <returns>The file name extension of the file.</returns>
    string FileType { get; }

    /// <summary>Gets the MIME type of the contents of the file.</summary>
    /// <returns>The MIME type of the file contents.</returns>
    string ContentType { get; }

    /// <summary>Opens a random-access stream over the file.</summary>
    /// <param name="accessMode">The type of access to allow.</param>
    /// <returns>When this method completes, it returns the random-access stream (type [IRandomAccessStream](https://docs.microsoft.com/previous-versions/hh438400(v=vs.85))).</returns>
    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> OpenAsync(
      FileAccessMode accessMode);

    /// <summary>Opens a transacted, random-access stream for writing to the file.</summary>
    /// <returns>When this method completes, it returns a StorageStreamTransaction that contains the random-access stream and methods that can be used to complete transactions.</returns>
    [RemoteAsync]
    IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync();

    /// <summary>Creates a copy of the file in the specified folder.</summary>
    /// <param name="destinationFolder">The destination folder where the copy is created.</param>
    /// <returns>When this method completes, it returns a StorageFile that represents the copy.</returns>
    [Overload("CopyOverloadDefaultNameAndOptions")]
    [RemoteAsync]
    IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder);

    /// <summary>Creates a copy of the file in the specified folder, using the desired name.</summary>
    /// <param name="destinationFolder">The destination folder where the copy is created.</param>
    /// <param name="desiredNewName">The desired name of the copy.</param>
    /// <returns>When this method completes, it returns a StorageFile that represents the copy.</returns>
    [RemoteAsync]
    [Overload("CopyOverloadDefaultOptions")]
    IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder,
      string desiredNewName);

    /// <summary>Creates a copy of the file in the specified folder, using the desired name. This method also specifies what to do if an existing file in the specified folder has the same name.</summary>
    /// <param name="destinationFolder">The destination folder where the copy is created.</param>
    /// <param name="desiredNewName">The desired name of the copy.</param>
    /// <param name="option">An enum value that determines how Windows responds if the *desiredNewName* is the same as the name of an existing file in the destination folder.</param>
    /// <returns>When this method completes, it returns a StorageFile that represents the copy.</returns>
    [Overload("CopyOverload")]
    [RemoteAsync]
    IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder,
      string desiredNewName,
      NameCollisionOption option);

    /// <summary>Replaces the specified file with a copy of the current file.</summary>
    /// <param name="fileToReplace">The file to replace.</param>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    IAsyncAction CopyAndReplaceAsync(IStorageFile fileToReplace);

    /// <summary>Moves the current file to the specified folder.</summary>
    /// <param name="destinationFolder">The destination folder where the file is moved.</param>
    /// <returns>No object or value is returned by this method.</returns>
    [RemoteAsync]
    [Overload("MoveOverloadDefaultNameAndOptions")]
    IAsyncAction MoveAsync(IStorageFolder destinationFolder);

    /// <summary>Moves the current file to the specified folder and renames the file according to the desired name.</summary>
    /// <param name="destinationFolder">The destination folder where the file is moved.</param>
    /// <param name="desiredNewName">The desired name of the file after it is moved.</param>
    /// <returns>No object or value is returned by this method.</returns>
    [RemoteAsync]
    [Overload("MoveOverloadDefaultOptions")]
    IAsyncAction MoveAsync(IStorageFolder destinationFolder, string desiredNewName);

    /// <summary>Moves the current file to the specified folder and renames the file according to the desired name. This method also specifies what to do if a file with the same name already exists in the specified folder.</summary>
    /// <param name="destinationFolder">The destination folder where the file is moved.</param>
    /// <param name="desiredNewName">The desired name of the file after it is moved.</param>
    /// <param name="option">An enum value that determines how Windows responds if the *desiredNewName* is the same as the name of an existing file in the destination folder.</param>
    /// <returns>No object or value is returned by this method.</returns>
    [RemoteAsync]
    [Overload("MoveOverload")]
    IAsyncAction MoveAsync(
      IStorageFolder destinationFolder,
      string desiredNewName,
      NameCollisionOption option);

    /// <summary>Moves the current file to the location of the specified file and replaces the specified file in that location.</summary>
    /// <param name="fileToReplace">The file to replace.</param>
    /// <returns>No object or value is returned by this method.</returns>
    [RemoteAsync]
    IAsyncAction MoveAndReplaceAsync(IStorageFile fileToReplace);
  }
}
