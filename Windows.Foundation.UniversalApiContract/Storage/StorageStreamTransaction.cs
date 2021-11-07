// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageStreamTransaction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  /// <summary>Represents a write transaction for a random-access stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageStreamTransaction : IStorageStreamTransaction, IClosable
  {
    /// <summary>Gets the random-access stream used in the transaction.</summary>
    /// <returns>The random-access stream.</returns>
    public extern IRandomAccessStream Stream { [MethodImpl] get; }

    /// <summary>Save the stream to the underlying file.</summary>
    /// <returns>No object or value is returned by this method.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CommitAsync();

    [MethodImpl]
    public extern void Close();
  }
}
