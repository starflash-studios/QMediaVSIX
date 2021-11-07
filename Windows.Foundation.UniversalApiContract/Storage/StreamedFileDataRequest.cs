// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StreamedFileDataRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  /// <summary>Represents a sequential-access output stream that indicates a request for the data stream of a StorageFile that was created by calling CreateStreamedFileAsync or ReplaceWithStreamedFileAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StreamedFileDataRequest : IOutputStream, IClosable, IStreamedFileDataRequest
  {
    /// <summary>Writes data from a buffer to the current stream.</summary>
    /// <param name="buffer">The buffer that contains the data to write.</param>
    /// <returns>When this method completes, it returns the number of bytes (type UInt32 ) that were written to the stream. If the app specifies a function to monitor progress, that function receives the number of bytes (type UInt32 ) written so far.</returns>
    [MethodImpl]
    public extern IAsyncOperationWithProgress<uint, uint> WriteAsync(
      IBuffer buffer);

    /// <summary>Flushes the data in the current stream.</summary>
    /// <returns>When this method completes, it returns true if the data was flushed successfully or false if the flush operation failed.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> FlushAsync();

    [MethodImpl]
    public extern void Close();

    /// <summary>Indicates that the data can't be streamed and releases system resources that are exposed by the current stream indicating that the data request is complete.</summary>
    /// <param name="failureMode">The enum value that indicates why the data stream can't be accessed.</param>
    [MethodImpl]
    public extern void FailAndClose(StreamedFileFailureMode failureMode);
  }
}
