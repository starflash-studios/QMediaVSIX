// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.OutputStreamOverStream
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Provides a Windows Runtime output stream for an IStream base implementation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class OutputStreamOverStream : IOutputStream, IClosable
  {
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

    [MethodImpl]
    public extern void Close();
  }
}
