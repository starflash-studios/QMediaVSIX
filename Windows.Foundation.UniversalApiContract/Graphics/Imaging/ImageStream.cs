// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.ImageStream
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Imaging
{
  /// <summary>An implementation of IRandomAccessStreamWithContent type used in the Imaging namespace.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ImageStream : 
    IRandomAccessStreamWithContentType,
    IContentTypeProvider,
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

    /// <summary>Returns the file stream for the ImageStream.</summary>
    /// <returns>The file stream for the image.</returns>
    [MethodImpl]
    public extern IRandomAccessStream CloneStream();

    /// <summary>Indicates if you can read the stream.</summary>
    /// <returns>Indicates whether or not you can read the stream.</returns>
    public extern bool CanRead { [MethodImpl] get; }

    /// <summary>Indicates if you can write to the stream.</summary>
    /// <returns>Indicates whether or not you can write to the stream.</returns>
    public extern bool CanWrite { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Reads data asynchronously from a sequential stream.</summary>
    /// <param name="buffer">The buffer into which the asynchronous read operation stores the data.</param>
    /// <param name="count">The size of the buffer.</param>
    /// <param name="options">The options for the stream to be read.</param>
    /// <returns>The byte reader operation.</returns>
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

    /// <summary>Asynchronously commits the current frame data and flushes all of the data on the image stream.</summary>
    /// <returns>An object that manages the asynchronous flush operation.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> FlushAsync();

    /// <summary>Returns the data format of the stream.</summary>
    /// <returns>The data format of the stream.</returns>
    public extern string ContentType { [MethodImpl] get; }
  }
}
