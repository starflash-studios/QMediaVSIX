// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportImportItemsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Guid(3839161464, 54297, 17475, 168, 78, 240, 106, 133, 12, 11, 0)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoImportImportItemsResult))]
  internal interface IPhotoImportImportItemsResult
  {
    PhotoImportSession Session { get; }

    bool HasSucceeded { get; }

    IVectorView<PhotoImportItem> ImportedItems { get; }

    uint PhotosCount { get; }

    ulong PhotosSizeInBytes { get; }

    uint VideosCount { get; }

    ulong VideosSizeInBytes { get; }

    uint SidecarsCount { get; }

    ulong SidecarsSizeInBytes { get; }

    uint SiblingsCount { get; }

    ulong SiblingsSizeInBytes { get; }

    uint TotalCount { get; }

    ulong TotalSizeInBytes { get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<PhotoImportDeleteImportedItemsFromSourceResult, double> DeleteImportedItemsFromSourceAsync();
  }
}
