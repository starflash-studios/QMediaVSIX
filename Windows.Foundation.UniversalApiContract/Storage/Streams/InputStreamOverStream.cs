// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.InputStreamOverStream
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Provides a Windows Runtime input stream for an IStream base implementation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InputStreamOverStream : IInputStream, IClosable
  {
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

    [MethodImpl]
    public extern void Close();
  }
}
