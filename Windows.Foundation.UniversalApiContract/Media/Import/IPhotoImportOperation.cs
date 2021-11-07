// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ExclusiveTo(typeof (PhotoImportOperation))]
  [Guid(3656882148, 41114, 20196, 164, 177, 32, 148, 2, 119, 165, 190)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhotoImportOperation
  {
    PhotoImportStage Stage { get; }

    PhotoImportSession Session { get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<PhotoImportFindItemsResult, uint> ContinueFindingItemsAsync { [RemoteAsync] get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<PhotoImportImportItemsResult, PhotoImportProgress> ContinueImportingItemsAsync { [RemoteAsync] get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<PhotoImportDeleteImportedItemsFromSourceResult, double> ContinueDeletingImportedItemsFromSourceAsync { [RemoteAsync] get; }
  }
}
