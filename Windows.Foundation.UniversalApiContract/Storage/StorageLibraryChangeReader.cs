// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageLibraryChangeReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Enables the calling app to read through the changes to items in a storage library.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StorageLibraryChangeReader : 
    IStorageLibraryChangeReader,
    IStorageLibraryChangeReader2
  {
    /// <summary>Asynchronously gets a list of StorageLibraryChange objects.</summary>
    /// <returns>A list of StorageLibraryChange objects.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageLibraryChange>> ReadBatchAsync();

    /// <summary>Tells the system that all of the changes described in the StorageLibraryChange objects returned by the call to ReadBatchAsync have been addressed by the app.</summary>
    /// <returns>An object that is used to manage the asynchronous accept change operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AcceptChangesAsync();

    [MethodImpl]
    public extern ulong GetLastChangeId();
  }
}
