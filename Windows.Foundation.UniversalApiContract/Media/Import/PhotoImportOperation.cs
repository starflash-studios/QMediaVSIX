// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Represents an in-progress photo import operation.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhotoImportOperation : IPhotoImportOperation
  {
    /// <summary>Gets the current stage of the in-progress operation.</summary>
    /// <returns>The current stage of the in-progress operation.</returns>
    public extern PhotoImportStage Stage { [MethodImpl] get; }

    /// <summary>Gets the photo import session associated with the operation.</summary>
    /// <returns>The photo import session associated with the operation.</returns>
    public extern PhotoImportSession Session { [MethodImpl] get; }

    /// <summary>Causes in-progress find operations to continue.</summary>
    /// <returns>An asynchronous operation that returns a PhotoImportFindItemsResult object on successful completion.</returns>
    [RemoteAsync]
    public extern IAsyncOperationWithProgress<PhotoImportFindItemsResult, uint> ContinueFindingItemsAsync { [RemoteAsync, MethodImpl] get; }

    /// <summary>Causes in-progress import items operations to continue.</summary>
    /// <returns>An asynchronous operation that returns a PhotoImportImportItemsResult object on successful completion.</returns>
    [RemoteAsync]
    public extern IAsyncOperationWithProgress<PhotoImportImportItemsResult, PhotoImportProgress> ContinueImportingItemsAsync { [RemoteAsync, MethodImpl] get; }

    /// <summary>Causes in-progress delete from source operations to continue.</summary>
    /// <returns>An asynchronous operation that returns a PhotoImportDeleteImportedItemsFromSourceResult object on successful completion.</returns>
    [RemoteAsync]
    public extern IAsyncOperationWithProgress<PhotoImportDeleteImportedItemsFromSourceResult, double> ContinueDeletingImportedItemsFromSourceAsync { [RemoteAsync, MethodImpl] get; }
  }
}
