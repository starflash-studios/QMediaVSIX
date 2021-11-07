// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.StorageItemThumbnail
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.FileProperties
{
  /// <summary>Represents the thumbnail image associated with a system resource (like a file or folder).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageItemThumbnail : 
    IRandomAccessStreamWithContentType,
    IContentTypeProvider,
    IRandomAccessStream,
    IOutputStream,
    IClosable,
    IInputStream,
    IThumbnailProperties
  {
    /// <summary>Gets or sets the size of the thumbnail image.</summary>
    /// <returns>The size, in bytes, of the thumbnail image.</returns>
    public extern ulong Size { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Retrieves the thumbnail image data as an undecoded stream.</summary>
    /// <param name="position">The position in the storage item to start reading thumbnail image data.</param>
    /// <returns>An object for reading the thumbnail image data.</returns>
    [MethodImpl]
    public extern IInputStream GetInputStreamAt(ulong position);

    /// <summary>Retrieves an output stream object for writing thumbnail image data to a storage item.</summary>
    /// <param name="position">The position in the storage item to start writing thumbnail image data.</param>
    /// <returns>The output stream.</returns>
    [MethodImpl]
    public extern IOutputStream GetOutputStreamAt(ulong position);

    /// <summary>Gets the byte offset of the thumbnail stream.</summary>
    /// <returns>The number of bytes from the start of the thumbnail stream.</returns>
    public extern ulong Position { [MethodImpl] get; }

    /// <summary>Sets the offset of the thumbnail stream to the specified value.</summary>
    /// <param name="position">The number of bytes from the start of the thumbnail stream where the position of the thumbnail stream is set.</param>
    [MethodImpl]
    public extern void Seek(ulong position);

    /// <summary>Creates a new stream over the thumbnail that is represented by the current storageItemThumbnail object.</summary>
    /// <returns>The new thumbnail stream. The initial, internal position of the stream is 0.</returns>
    [MethodImpl]
    public extern IRandomAccessStream CloneStream();

    /// <summary>Gets a value that indicates whether the thumbnail stream can be read from.</summary>
    /// <returns>True if the thumbnail stream can be read from. Otherwise, false.</returns>
    public extern bool CanRead { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the thumbnail stream can be written to.</summary>
    /// <returns>True if the thumbnail stream can be written to. Otherwise, false.</returns>
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

    /// <summary>Writes data asynchronously in a sequential stream.</summary>
    /// <param name="buffer">The buffer into which the asynchronous writer operation writes.</param>
    /// <returns>The byte writer operation.</returns>
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> WriteAsync(
      IBuffer buffer);

    /// <summary>Flushes data asynchronously in a sequential stream.</summary>
    /// <returns>The stream flush operation.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> FlushAsync();

    /// <summary>Gets the MIME content type of the thumbnail image.</summary>
    /// <returns>The MIME content type.</returns>
    public extern string ContentType { [MethodImpl] get; }

    /// <summary>Gets the original (not scaled) width of the thumbnail image.</summary>
    /// <returns>The original width, in pixels.</returns>
    public extern uint OriginalWidth { [MethodImpl] get; }

    /// <summary>Gets the original (not scaled) height of the thumbnail image.</summary>
    /// <returns>The original height, in pixels.</returns>
    public extern uint OriginalHeight { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the thumbnail image returned was a cached version with a smaller size.</summary>
    /// <returns>The value that indicates whether the thumbnail image returned was a cached version with a smaller size.</returns>
    public extern bool ReturnedSmallerCachedSize { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if the thumbnail is an icon or an image.</summary>
    /// <returns>The value that indicates if the thumbnail is an icon or an image.</returns>
    public extern ThumbnailType Type { [MethodImpl] get; }
  }
}
