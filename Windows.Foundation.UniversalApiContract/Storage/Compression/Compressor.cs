// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Compression.Compressor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Compression
{
  /// <summary>A compressor takes information written to a stream and compresses it using a compression algorithm.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ICompressorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Compressor : ICompressor, IOutputStream, IClosable
  {
    /// <summary>Creates an instance of a compressor.</summary>
    /// <param name="underlyingStream">The stream of compressed information to be written by the compressor.</param>
    [MethodImpl]
    public extern Compressor(IOutputStream underlyingStream);

    /// <summary>Creates an instance of a compressor.</summary>
    /// <param name="underlyingStream">The stream of compressed information to be written by the compressor.</param>
    /// <param name="algorithm">The compression algorithm used by the compressor to write *underlyingStream*.</param>
    /// <param name="blockSize">Size in bytes of the intermediate buffer used by the compression algorithm. A value of 0 specifies that the compression algorithm will use its default block size. Valid non-zero values for this parameter are 32Kb to 64Mb.</param>
    [MethodImpl]
    public extern Compressor(
      IOutputStream underlyingStream,
      CompressAlgorithm algorithm,
      uint blockSize);

    /// <summary>Finishes writing the compression stream.</summary>
    /// <returns>The asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> FinishAsync();

    /// <summary>Detaches the underlying stream from the Compressor object so that the object can be closed using the Compressor.Close method without also closing the underlying stream.</summary>
    /// <returns>The stream of information.</returns>
    [MethodImpl]
    public extern IOutputStream DetachStream();

    /// <summary>Writes information to the compression stream asynchronously.</summary>
    /// <param name="buffer">The buffer that contains the information to be written to the stream.</param>
    /// <returns>The asynchronous operation.</returns>
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> WriteAsync(
      IBuffer buffer);

    /// <summary>Flushes the compression stream asynchronously.</summary>
    /// <returns>The asynchronous operation.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> FlushAsync();

    [MethodImpl]
    public extern void Close();
  }
}
