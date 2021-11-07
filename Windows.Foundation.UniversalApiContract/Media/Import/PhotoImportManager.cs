// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Provides APIs for determining if photo import is supported on the current device, finding sources from which to import photos, and getting references to any pending photo import operations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPhotoImportManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public static class PhotoImportManager
  {
    /// <summary>Gets a value indicating if photo import is supported on the current device.</summary>
    /// <returns>An asynchronous operation that returns true if photo import is supported. Otherwise, returns false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> IsSupportedAsync();

    /// <summary>Finds all currently available sources from which photos can be imported.</summary>
    /// <returns>An asynchronous operation that returns a list of available sources on successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PhotoImportSource>> FindAllSourcesAsync();

    /// <summary>Gets the list of all pending photo import operations.</summary>
    /// <returns>The list of all pending photo operations.</returns>
    [MethodImpl]
    public static extern IVectorView<PhotoImportOperation> GetPendingOperations();
  }
}
