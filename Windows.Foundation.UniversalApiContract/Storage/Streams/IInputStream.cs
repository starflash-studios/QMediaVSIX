// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IInputStream
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Represents a sequential stream of bytes to be read.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2421821410, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218)]
  public interface IInputStream : IClosable
  {
    /// <summary>Reads data from the stream asynchronously.</summary>
    /// <param name="buffer">A buffer that may be used to return the bytes that are read. The return value contains the buffer that holds the results.</param>
    /// <param name="count">The number of bytes to read that is less than or equal to the Capacity value.</param>
    /// <param name="options">Specifies the type of the asynchronous read operation.</param>
    /// <returns>The asynchronous operation.</returns>
    IAsyncOperationWithProgress<IBuffer, uint> ReadAsync(
      IBuffer buffer,
      uint count,
      InputStreamOptions options);
  }
}
