// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IOutputStream
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Represents a sequential stream of bytes to be written.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2421821414, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218)]
  public interface IOutputStream : IClosable
  {
    /// <summary>Writes data asynchronously in a sequential stream.</summary>
    /// <param name="buffer">A buffer that contains the data to be written.</param>
    /// <returns>The byte writer operation. The first integer represents the number of bytes written. The second integer represents the progress of the write operation.</returns>
    IAsyncOperationWithProgress<uint, uint> WriteAsync(IBuffer buffer);

    /// <summary>Flushes data asynchronously in a sequential stream.</summary>
    /// <returns>The stream flush operation.</returns>
    IAsyncOperation<bool> FlushAsync();
  }
}
