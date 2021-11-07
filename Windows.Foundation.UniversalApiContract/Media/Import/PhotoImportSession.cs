// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Import
{
  /// <summary>Represents a photo import session with a photo import source.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PhotoImportSession : IPhotoImportSession, IClosable, IPhotoImportSession2
  {
    /// <summary>Gets an object representing the source device associated with the photo import session.</summary>
    /// <returns>An object representing the source device associated with the photo import session.</returns>
    public extern PhotoImportSource Source { [MethodImpl] get; }

    /// <summary>Gets a unique identifier for the import session.</summary>
    /// <returns>A unique identifier for the import session.</returns>
    public extern Guid SessionId { [MethodImpl] get; }

    /// <summary>Gets or sets the destination folder for the photo import session.</summary>
    /// <returns>The destination folder for the photo import session.</returns>
    public extern IStorageFolder DestinationFolder { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value specifying whether the session date should be appended to the destination folder name.</summary>
    /// <returns>True if the session date should be appended to the folder name; otherwise, false.</returns>
    public extern bool AppendSessionDateToDestinationFolder { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating the method used for naming subfolders within the destination folder.</summary>
    /// <returns>A value indicating method used for naming subfolders within the destination folder.</returns>
    public extern PhotoImportSubfolderCreationMode SubfolderCreationMode { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the prefix for the destination file name.</summary>
    /// <returns>The prefix for the destination file name.</returns>
    public extern string DestinationFileNamePrefix { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Asynchronously finds items on the source device that are available for import.</summary>
    /// <param name="contentTypeFilter">A value indicating whether the find operation includes images, videos, or both in the results.</param>
    /// <param name="itemSelectionMode">A value indicating whether all items, no items, or only new items in the results are initially marked as selected.</param>
    /// <returns>An asynchronous operation that returns a PhotoImportFindItemsResult on successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<PhotoImportFindItemsResult, uint> FindItemsAsync(
      PhotoImportContentTypeFilter contentTypeFilter,
      PhotoImportItemSelectionMode itemSelectionMode);

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets or sets a value indicating the date format used by the session for subfolders.</summary>
    /// <returns>A value indicating the date format used by the session for subfolders.</returns>
    public extern PhotoImportSubfolderDateFormat SubfolderDateFormat { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the deselected items for the session should be remembered.</summary>
    /// <returns>True if the deselected items for the session should be remembered; otherwise, false.</returns>
    public extern bool RememberDeselectedItems { [MethodImpl] set; [MethodImpl] get; }
  }
}
