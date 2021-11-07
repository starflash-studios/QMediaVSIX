// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.FileRandomAccessStream
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage.Streams
{
  /// <summary>Supports reading and writing to a file at a specified position.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IFileRandomAccessStreamStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FileRandomAccessStream : 
    IRandomAccessStream,
    IOutputStream,
    IClosable,
    IInputStream
  {
    /// <summary>Gets or sets the size of the random access stream.</summary>
    /// <returns>The size of the stream.</returns>
    public extern ulong Size { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns an input stream at a specified location in a stream.</summary>
    /// <param name="position">The location in the stream at which to begin.</param>
    /// <returns>The input stream.</returns>
    [MethodImpl]
    public extern IInputStream GetInputStreamAt(ulong position);

    /// <summary>Returns an output stream at a specified location in a stream.</summary>
    /// <param name="position">The location in the output stream at which to begin.</param>
    /// <returns>The output stream.</returns>
    [MethodImpl]
    public extern IOutputStream GetOutputStreamAt(ulong position);

    /// <summary>Gets the byte offset of the stream.</summary>
    /// <returns>The number of bytes from the start of the stream.</returns>
    public extern ulong Position { [MethodImpl] get; }

    /// <summary>Sets the position of the stream to the specified value.</summary>
    /// <param name="position">The new position of the stream.</param>
    [MethodImpl]
    public extern void Seek(ulong position);

    /// <summary>Creates a new instance of a IRandomAccessStream over the same resource as the current stream.</summary>
    /// <returns>The new stream. The initial, internal position of the stream is 0.</returns>
    [MethodImpl]
    public extern IRandomAccessStream CloneStream();

    /// <summary>Gets a value that indicates whether the stream can be read from.</summary>
    /// <returns>True if the stream can be read from. Otherwise, false.</returns>
    public extern bool CanRead { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the file can be written to.</summary>
    /// <returns>True if the stream can be written to. Otherwise, false.</returns>
    public extern bool CanWrite { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns an asynchronous byte reader object.</summary>
    /// <param name="buffer">The buffer into which the asynchronous read operation places the bytes that are read.</param>
    /// <param name="count">The number of bytes to read that is less than or equal to the Capacity value.</param>
    /// <param name="options">Specifies the type of the asynchronous read operation.</param>
    /// <returns>The asynchronous operation.</returns>
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, uint> ReadAsync(
      IBuffer buffer,
      uint count,
      InputStreamOptions options);

    /// <summary>Writes data asynchronously to a file.</summary>
    /// <param name="buffer">The buffer into which the asynchronous writer operation writes.</param>
    /// <returns>The byte writer operation.</returns>
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> WriteAsync(
      IBuffer buffer);

    /// <summary>Flushes data asynchronously in a sequential stream.</summary>
    /// <returns>The stream flush operation.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> FlushAsync();

    /// <summary>Opens a stream to an existing file given the file's path.</summary>
    /// <param name="filePath">A path to the file to be opened.</param>
    /// <param name="accessMode">The permissions level to open the stream with.</param>
    /// <returns>A stream to the specified file.</returns>
    [RemoteAsync]
    [Overload("OpenAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IRandomAccessStream> OpenAsync(
      string filePath,
      FileAccessMode accessMode);

    /// <summary>Opens a stream to a file given a file path. If the file does not exist, it can be created using FileOpenDisposition.</summary>
    /// <param name="filePath">A path to the file to be opened.</param>
    /// <param name="accessMode">The permissions level to open the stream with.</param>
    /// <param name="sharingOptions">A bitwise combination of the enumeration values that specify options for opening the stream.</param>
    /// <param name="openDisposition">An action to take on the file.</param>
    /// <returns>A stream to the specified file.</returns>
    [Overload("OpenWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IRandomAccessStream> OpenAsync(
      string filePath,
      FileAccessMode accessMode,
      StorageOpenOptions sharingOptions,
      FileOpenDisposition openDisposition);

    /// <summary>Opens a stream for writing to an existing file given the file's path.</summary>
    /// <param name="filePath">A path to the file to be opened.</param>
    /// <returns>When this method completes, it returns a StorageStreamTransaction containing the random-access stream and methods that can be used to complete transactions.</returns>
    [Overload("OpenTransactedWriteAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync(
      string filePath);

    /// <summary>Opens a stream for writing to a file given a file path. If the file does not exist, it can be created using FileOpenDisposition.</summary>
    /// <param name="filePath">A path to the file to be opened.</param>
    /// <param name="openOptions">A bitwise combination of the enumeration values that specify options for opening the stream.</param>
    /// <param name="openDisposition">An action to take on the file.</param>
    /// <returns>When this method completes, it returns a StorageStreamTransaction containing the random-access stream and methods that can be used to complete transactions.</returns>
    [Overload("OpenTransactedWriteWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync(
      string filePath,
      StorageOpenOptions openOptions,
      FileOpenDisposition openDisposition);

    /// <summary>Opens a stream for a user to an existing file given the file path and the user's information.</summary>
    /// <param name="user">The user account for opening the stream.</param>
    /// <param name="filePath">A path to the file to be opened.</param>
    /// <param name="accessMode">The permissions level to open the stream with.</param>
    /// <returns>A stream to the specified file.</returns>
    [RemoteAsync]
    [Overload("OpenForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IRandomAccessStream> OpenForUserAsync(
      User user,
      string filePath,
      FileAccessMode accessMode);

    /// <summary>Opens a stream for a user to a file given a file path and the user's information. If the file does not exist, it can be created using FileOpenDisposition.</summary>
    /// <param name="user">The user account for opening the stream.</param>
    /// <param name="filePath">A path to the file to be opened.</param>
    /// <param name="accessMode">The permissions level to open the stream with.</param>
    /// <param name="sharingOptions">A bitwise combination of the enumeration values that specify options for opening the stream.</param>
    /// <param name="openDisposition">An action to take on the file.</param>
    /// <returns>A stream to the specified file.</returns>
    [RemoteAsync]
    [Overload("OpenForUserWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IRandomAccessStream> OpenForUserAsync(
      User user,
      string filePath,
      FileAccessMode accessMode,
      StorageOpenOptions sharingOptions,
      FileOpenDisposition openDisposition);

    /// <summary>Opens a writable stream for a user to an existing file given the file's path and the user's information.</summary>
    /// <param name="user">The user account for opening the stream.</param>
    /// <param name="filePath">A path to the file to be opened.</param>
    /// <returns>When this method completes, it returns a StorageStreamTransaction containing the random-access stream and methods that can be used to complete transactions.</returns>
    [Overload("OpenTransactedWriteForUserAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteForUserAsync(
      User user,
      string filePath);

    /// <summary>Opens a writable stream for a user to a file given a file path and the user's information. If the file does not exist, it can be created using FileOpenDisposition.</summary>
    /// <param name="user">The user account for opening the stream.</param>
    /// <param name="filePath">A path to the file to be opened.</param>
    /// <param name="openOptions">A bitwise combination of the enumeration values that specify options for opening the stream.</param>
    /// <param name="openDisposition">An action to take on the file.</param>
    /// <returns>When this method completes, it returns a StorageStreamTransaction containing the random-access stream and methods that can be used to complete transactions.</returns>
    [Overload("OpenTransactedWriteForUserWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteForUserAsync(
      User user,
      string filePath,
      StorageOpenOptions openOptions,
      FileOpenDisposition openDisposition);
  }
}
