// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportDeleteImportedItemsFromSourceResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Represents the result of a operation that deletes imported media items from the source.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhotoImportDeleteImportedItemsFromSourceResult : 
    IPhotoImportDeleteImportedItemsFromSourceResult
  {
    /// <summary>Gets the photo import session associated with the delete operation.</summary>
    /// <returns>The photo import session associated with the delete operation.</returns>
    public extern PhotoImportSession Session { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the delete operation has succeeded.</summary>
    /// <returns>True if the delete operation has succeeded; otherwise, false.</returns>
    public extern bool HasSucceeded { [MethodImpl] get; }

    /// <summary>Gets a list of items that were deleted from the source.</summary>
    /// <returns>A list of items that were deleted from the source.</returns>
    public extern IVectorView<PhotoImportItem> DeletedItems { [MethodImpl] get; }

    /// <summary>Gets the number of photos deleted in the operation.</summary>
    /// <returns>The number of photos deleted in the operation.</returns>
    public extern uint PhotosCount { [MethodImpl] get; }

    /// <summary>Gets the size of the deleted photos, in bytes.</summary>
    /// <returns>The size of the deleted photos, in bytes.</returns>
    public extern ulong PhotosSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of videos deleted in the operation.</summary>
    /// <returns>The number of videos deleted in the operation.</returns>
    public extern uint VideosCount { [MethodImpl] get; }

    /// <summary>Gets the size of the deleted videos, in bytes.</summary>
    /// <returns>The size of the deleted videos, in bytes.</returns>
    public extern ulong VideosSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of sidecar files deleted in the operation.</summary>
    /// <returns>The number of sidecar files deleted in the operation.</returns>
    public extern uint SidecarsCount { [MethodImpl] get; }

    /// <summary>Gets the size of the deleted sidecar files, in bytes.</summary>
    /// <returns>The size of the deleted sidecar files, in bytes.</returns>
    public extern ulong SidecarsSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of sibling files deleted in the operation.</summary>
    /// <returns>The number of sibling files deleted in the operation.</returns>
    public extern uint SiblingsCount { [MethodImpl] get; }

    /// <summary>Gets the size of the deleted sibling files, in bytes.</summary>
    /// <returns>The size of the deleted sibling files, in bytes.</returns>
    public extern ulong SiblingsSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the total number of items deleted in the operation.</summary>
    /// <returns>The total number of items deleted in the operation.</returns>
    public extern uint TotalCount { [MethodImpl] get; }

    /// <summary>Gets the total size of the all deleted items, in bytes.</summary>
    /// <returns>The total size of the all deleted items, in bytes.</returns>
    public extern ulong TotalSizeInBytes { [MethodImpl] get; }
  }
}
