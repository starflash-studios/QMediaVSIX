// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportFindItemsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Guid(957736519, 27768, 18731, 132, 78, 143, 229, 232, 246, 191, 185)]
  [ExclusiveTo(typeof (PhotoImportFindItemsResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhotoImportFindItemsResult
  {
    PhotoImportSession Session { get; }

    bool HasSucceeded { get; }

    IVectorView<PhotoImportItem> FoundItems { get; }

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

    void SelectAll();

    void SelectNone();

    [RemoteAsync]
    IAsyncAction SelectNewAsync();

    void SetImportMode(PhotoImportImportMode value);

    PhotoImportImportMode ImportMode { get; }

    uint SelectedPhotosCount { get; }

    ulong SelectedPhotosSizeInBytes { get; }

    uint SelectedVideosCount { get; }

    ulong SelectedVideosSizeInBytes { get; }

    uint SelectedSidecarsCount { get; }

    ulong SelectedSidecarsSizeInBytes { get; }

    uint SelectedSiblingsCount { get; }

    ulong SelectedSiblingsSizeInBytes { get; }

    uint SelectedTotalCount { get; }

    ulong SelectedTotalSizeInBytes { get; }

    event TypedEventHandler<PhotoImportFindItemsResult, PhotoImportSelectionChangedEventArgs> SelectionChanged;

    [RemoteAsync]
    IAsyncOperationWithProgress<PhotoImportImportItemsResult, PhotoImportProgress> ImportItemsAsync();

    event TypedEventHandler<PhotoImportFindItemsResult, PhotoImportItemImportedEventArgs> ItemImported;
  }
}
