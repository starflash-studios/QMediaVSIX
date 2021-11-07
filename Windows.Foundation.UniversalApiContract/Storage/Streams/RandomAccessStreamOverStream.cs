// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.RandomAccessStreamOverStream
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Provides a Windows Runtime random access stream for an IStream base implementation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RandomAccessStreamOverStream : 
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

    /// <summary>Gets a value that indicates whether the stream can be written to.</summary>
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
  }
}
