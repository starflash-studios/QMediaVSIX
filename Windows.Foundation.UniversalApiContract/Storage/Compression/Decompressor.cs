// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Compression.Decompressor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Compression
{
  /// <summary>A decompressor takes a stream compressed by a compressor and decompresses it.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Activatable(typeof (IDecompressorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Decompressor : IDecompressor, IInputStream, IClosable
  {
    /// <summary>This method creates an instance of a decompressor.</summary>
    /// <param name="underlyingStream">The stream of compressed information to be read and decompressed by the decompressor.</param>
    [MethodImpl]
    public extern Decompressor(IInputStream underlyingStream);

    /// <summary>Detaches the underlying stream from the Decompressor object so that the object can be closed using the Decompressor.Close method without also closing the underlying stream.</summary>
    /// <returns>The stream of information.</returns>
    [MethodImpl]
    public extern IInputStream DetachStream();

    /// <summary>Reads from the compression stream asynchronously.</summary>
    /// <param name="buffer">The buffer that contains the information to be read from the stream.</param>
    /// <param name="count">The number of bytes to read.</param>
    /// <param name="options">Read options</param>
    /// <returns>The asynchronous operation.</returns>
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, uint> ReadAsync(
      IBuffer buffer,
      uint count,
      InputStreamOptions options);

    [MethodImpl]
    public extern void Close();
  }
}
