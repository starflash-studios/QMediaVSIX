// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.RandomAccessStreamReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Provides random access of data in input and output streams for a file.</summary>
  [Static(typeof (IRandomAccessStreamReferenceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  public sealed class RandomAccessStreamReference : IRandomAccessStreamReference
  {
    /// <summary>Opens a stream for random access.</summary>
    /// <returns>The asynchronous operation.</returns>
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();

    /// <summary>Creates a random access stream around a file.</summary>
    /// <param name="file">The file to create a stream around.</param>
    /// <returns>The stream that encapsulates *file*.</returns>
    [MethodImpl]
    public static extern RandomAccessStreamReference CreateFromFile(
      IStorageFile file);

    [MethodImpl]
    public static extern RandomAccessStreamReference CreateFromUri(
      Uri uri);

    /// <summary>Creates a random access stream around the specified stream.</summary>
    /// <param name="stream">The source stream.</param>
    /// <returns>The random access stream that encapsulates *stream*.</returns>
    [MethodImpl]
    public static extern RandomAccessStreamReference CreateFromStream(
      IRandomAccessStream stream);
  }
}
