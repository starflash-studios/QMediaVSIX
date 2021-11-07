// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.RandomAccessStream
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Provides random access of data in input and output streams.</summary>
  [Static(typeof (IRandomAccessStreamStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class RandomAccessStream
  {
    /// <summary>Copies a source stream to a destination stream.</summary>
    /// <param name="source">The stream to copy data from.</param>
    /// <param name="destination">The stream to copy data to.</param>
    /// <returns>The asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("CopyAsync")]
    [MethodImpl]
    public static extern IAsyncOperationWithProgress<ulong, ulong> CopyAsync(
      IInputStream source,
      IOutputStream destination);

    /// <summary>Copies the specified number of bytes from a source stream to a destination stream.</summary>
    /// <param name="source">The stream to copy data from.</param>
    /// <param name="destination">The stream to copy data to.</param>
    /// <param name="bytesToCopy">The number of bytes to copy.</param>
    /// <returns>The asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("CopySizeAsync")]
    [MethodImpl]
    public static extern IAsyncOperationWithProgress<ulong, ulong> CopyAsync(
      IInputStream source,
      IOutputStream destination,
      ulong bytesToCopy);

    /// <summary>Copies a source stream to a destination stream and waits for the copy operation to complete.</summary>
    /// <param name="source">The stream to copy data from.</param>
    /// <param name="destination">The stream to copy data to.</param>
    /// <returns>The asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperationWithProgress<ulong, ulong> CopyAndCloseAsync(
      IInputStream source,
      IOutputStream destination);
  }
}
