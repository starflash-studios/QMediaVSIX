// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportFindItemsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Represents the result of a operation that finds media items on a source.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PhotoImportFindItemsResult : 
    IPhotoImportFindItemsResult,
    IPhotoImportFindItemsResult2
  {
    /// <summary>Gets the photo import session associated with the find operation.</summary>
    /// <returns>The photo import session associated with the find operation.</returns>
    public extern PhotoImportSession Session { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the find operation has succeeded.</summary>
    /// <returns>True if the find operation has succeeded; otherwise, false.</returns>
    public extern bool HasSucceeded { [MethodImpl] get; }

    /// <summary>Gets a list of items that were found on the source.</summary>
    /// <returns>A list of items that were found on the source.</returns>
    public extern IVectorView<PhotoImportItem> FoundItems { [MethodImpl] get; }

    /// <summary>Gets the number of photos found on the source.</summary>
    /// <returns>The number of photos found on the source.</returns>
    public extern uint PhotosCount { [MethodImpl] get; }

    /// <summary>Gets the size of the photos found on the source, in bytes.</summary>
    /// <returns>The size of the found photos, in bytes.</returns>
    public extern ulong PhotosSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of videos found on the source.</summary>
    /// <returns>The number of videos found on the source.</returns>
    public extern uint VideosCount { [MethodImpl] get; }

    /// <summary>Gets the size of the videos found on the source, in bytes.</summary>
    /// <returns>The size of the found videos, in bytes.</returns>
    public extern ulong VideosSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of sidecar files found on the source.</summary>
    /// <returns>The number of sidecar files found on the source.</returns>
    public extern uint SidecarsCount { [MethodImpl] get; }

    /// <summary>Gets the size of the found sidecar files, in bytes.</summary>
    /// <returns>The size of the found sidecar files, in bytes.</returns>
    public extern ulong SidecarsSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of sibling files found on the source.</summary>
    /// <returns>The number of sibling files found on the source.</returns>
    public extern uint SiblingsCount { [MethodImpl] get; }

    /// <summary>Gets the size of the found sibling files, in bytes.</summary>
    /// <returns>The size of the found sibling files, in bytes.</returns>
    public extern ulong SiblingsSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the total number of items found on the source.</summary>
    /// <returns>The total number of items found on the source.</returns>
    public extern uint TotalCount { [MethodImpl] get; }

    /// <summary>Gets the total size of all items found on the source, in bytes.</summary>
    /// <returns>The total size of all items found on the source, in bytes.</returns>
    public extern ulong TotalSizeInBytes { [MethodImpl] get; }

    /// <summary>Selects all items found on the source to be included in the ImportItemsAsync operation.</summary>
    [MethodImpl]
    public extern void SelectAll();

    /// <summary>Deselects all items found on the source, preventing them from being included in the ImportItemsAsync operation.</summary>
    [MethodImpl]
    public extern void SelectNone();

    /// <summary>Selects all new items found on the source to be included in the ImportItemsAsync operation.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SelectNewAsync();

    /// <summary>Sets the photo import mode that determines which types of files are included in the ImportItemsAsync operation.</summary>
    /// <param name="value">The photo import mode.</param>
    [MethodImpl]
    public extern void SetImportMode(PhotoImportImportMode value);

    /// <summary>Gets the photo import mode that determines which types of files are included in the ImportItemsAsync operation.</summary>
    /// <returns>The photo import mode.</returns>
    public extern PhotoImportImportMode ImportMode { [MethodImpl] get; }

    /// <summary>Gets the number of photos that are currently selected to be included in the ImportItemsAsync operation.</summary>
    /// <returns>The number of photos that are currently selected.</returns>
    public extern uint SelectedPhotosCount { [MethodImpl] get; }

    /// <summary>Gets the size of the photos that are currently selected to be included in the ImportItemsAsync operation, in bytes.</summary>
    /// <returns>The size of the photos that are currently selected, in bytes.</returns>
    public extern ulong SelectedPhotosSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of videos that are currently selected to be included in the ImportItemsAsync operation.</summary>
    /// <returns>The number of videos that are currently selected.</returns>
    public extern uint SelectedVideosCount { [MethodImpl] get; }

    /// <summary>Gets the size of the videos that are currently selected to be included in the ImportItemsAsync operation, in bytes.</summary>
    /// <returns>The size of the videos that are currently selected, in bytes.</returns>
    public extern ulong SelectedVideosSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of sidecar files that are currently selected to be included in the ImportItemsAsync operation.</summary>
    /// <returns>The number of sidecar files that are currently selected.</returns>
    public extern uint SelectedSidecarsCount { [MethodImpl] get; }

    /// <summary>Gets the size of the sidecar files that are currently selected to be included in the ImportItemsAsync operation, in bytes.</summary>
    /// <returns>The size of the sidecar files that are currently selected.</returns>
    public extern ulong SelectedSidecarsSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of sibling files that are currently selected to be included in the ImportItemsAsync operation.</summary>
    /// <returns>The number of sibling files that are currently selected.</returns>
    public extern uint SelectedSiblingsCount { [MethodImpl] get; }

    /// <summary>Gets the size of the sibling files that are currently selected to be included in the ImportItemsAsync operation, in bytes.</summary>
    /// <returns>The size of the sibling files that are currently selected.</returns>
    public extern ulong SelectedSiblingsSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the total number of items that are currently selected to be included in the ImportItemsAsync operation.</summary>
    /// <returns>The total number of items that are currently selected</returns>
    public extern uint SelectedTotalCount { [MethodImpl] get; }

    /// <summary>Gets the total size of the all items that are currently selected to be included in the ImportItemsAsync operation, in bytes.</summary>
    /// <returns>The total size of the all items that are currently selected, in bytes.</returns>
    public extern ulong SelectedTotalSizeInBytes { [MethodImpl] get; }

    /// <summary>Occurs when the set of items selected to be included in the ImportItemsAsync operation changes.</summary>
    public extern event TypedEventHandler<PhotoImportFindItemsResult, PhotoImportSelectionChangedEventArgs> SelectionChanged;

    /// <summary>Asynchronously imports the selected items from the source.</summary>
    /// <returns>An asynchronous operation that returns a PhotoImportImportItemsResult on successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<PhotoImportImportItemsResult, PhotoImportProgress> ImportItemsAsync();

    /// <summary>Occurs when an item is imported.</summary>
    public extern event TypedEventHandler<PhotoImportFindItemsResult, PhotoImportItemImportedEventArgs> ItemImported;

    [MethodImpl]
    public extern void AddItemsInDateRangeToSelection(DateTime rangeStart, TimeSpan rangeLength);
  }
}
