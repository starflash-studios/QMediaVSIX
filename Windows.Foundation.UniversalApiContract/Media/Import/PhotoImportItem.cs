// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Import
{
  /// <summary>Represents an media item that has been imported from a source.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PhotoImportItem : IPhotoImportItem, IPhotoImportItem2
  {
    /// <summary>Gets the name of the item.</summary>
    /// <returns>The name of the item.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the key used to identify the item.</summary>
    /// <returns>The key used to identify the item.</returns>
    public extern ulong ItemKey { [MethodImpl] get; }

    /// <summary>Gets the content type of the imported item.</summary>
    /// <returns>The content type of the imported item.</returns>
    public extern PhotoImportContentType ContentType { [MethodImpl] get; }

    /// <summary>Gets the size of the item, in bytes.</summary>
    /// <returns>The size of the item, in bytes.</returns>
    public extern ulong SizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the creation date of the imported item.</summary>
    /// <returns>The creation date of the imported item.</returns>
    public extern DateTime Date { [MethodImpl] get; }

    /// <summary>Gets the sibling file associated with the item, if one exists.</summary>
    /// <returns>The sibling file associated with the item</returns>
    public extern PhotoImportSidecar Sibling { [MethodImpl] get; }

    /// <summary>Gets the list of sidecar files associated with the item, if any exists.</summary>
    /// <returns>The list of sidecar files associated with the item</returns>
    public extern IVectorView<PhotoImportSidecar> Sidecars { [MethodImpl] get; }

    /// <summary>Gets the list of video segments associated with the item.</summary>
    /// <returns>The list of video segments associated with the item.</returns>
    public extern IVectorView<PhotoImportVideoSegment> VideoSegments { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the item is currently selected for import.</summary>
    /// <returns>True if the item is currently selected; otherwise, false.</returns>
    public extern bool IsSelected { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a random access stream containing the thumbnail image associated with the item.</summary>
    /// <returns>A random access stream containing the thumbnail image associated with the item.</returns>
    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; }

    /// <summary>Gets a list of the names of files associated with this item that were imported.</summary>
    /// <returns>A list of the names of files associated with this item that were imported.</returns>
    public extern IVectorView<string> ImportedFileNames { [MethodImpl] get; }

    /// <summary>Gets a list of the names of files associated with this item that were deleted.</summary>
    /// <returns>A list of the names of files associated with this item that were deleted.</returns>
    public extern IVectorView<string> DeletedFileNames { [MethodImpl] get; }

    /// <summary>Gets the file system path of the PhotoImportItem.</summary>
    /// <returns>The file system path of the PhotoImportItem.</returns>
    public extern string Path { [MethodImpl] get; }
  }
}
