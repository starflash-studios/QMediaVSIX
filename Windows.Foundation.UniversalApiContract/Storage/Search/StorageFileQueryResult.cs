// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.StorageFileQueryResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Provides access to the results of a query of the files in the location that is represented by a storageFolder object. You can use storageFileQueryResult to enumerate the files in that storageFolder location.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageFileQueryResult : 
    IStorageFileQueryResult,
    IStorageQueryResultBase,
    IStorageFileQueryResult2
  {
    /// <summary>Retrieves a list of files in a specified range.</summary>
    /// <param name="startIndex">The zero-based index of the first file to retrieve. This parameter is 0 by default.</param>
    /// <param name="maxNumberOfItems">The maximum number of files to retrieve. Use -1 to retrieve all files. If the range contains fewer files than the max number, all files in the range are returned.</param>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of files that are represented by storageFile objects.</returns>
    [RemoteAsync]
    [Overload("GetFilesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      uint startIndex,
      uint maxNumberOfItems);

    /// <summary>Retrieves a list of all the files in the query result set.</summary>
    /// <returns>When this method completes successfully, it returns a list (type IVectorView ) of files that are represented by storageFile objects.</returns>
    [RemoteAsync]
    [Overload("GetFilesAsyncDefaultStartAndCount")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();

    /// <summary>Retrieves the number of files in the set of query results.</summary>
    /// <returns>When this method completes successfully, it returns the number of files in the location that match the query.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> GetItemCountAsync();

    /// <summary>Gets the folder that was queried to create the StorageFileQueryResult object. This folder represents the scope of the query.</summary>
    /// <returns>The original folder.</returns>
    public extern StorageFolder Folder { [MethodImpl] get; }

    /// <summary>Fires when a file is added to, deleted from, or modified in the folder being queried. This event only fires after GetFilesAsync has been called at least once.</summary>
    public extern event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;

    /// <summary>Fires when the query options change.</summary>
    public extern event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;

    /// <summary>Retrieves the index of the file from the query results that most closely matches the specified property value (or file, if used with FileActivatedEventArgs.NeighboringFilesQuery ). The property that is matched is determined by the first SortEntry of the QueryOptions.SortOrder list.</summary>
    /// <param name="value">The property value to match when searching the query results. The property to that is used to match this value is the property in the first SortEntry of the QueryOptions.SortOrder list.</param>
    /// <returns>When this method completes successfully, it returns the index of the matched file in the query results or the index of the file in the FileActivatedEventArgs.NeighboringFilesQuery. In the latter case, the file is expected to be sourced from FileActivatedEventArgs.Files. If this function fails, it returns **uint.MaxValue**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> FindStartIndexAsync([Variant] object value);

    /// <summary>Retrieves the query options used to determine query results.</summary>
    /// <returns>The query options.</returns>
    [MethodImpl]
    public extern QueryOptions GetCurrentQueryOptions();

    /// <summary>Modifies query results based on new QueryOptions.</summary>
    /// <param name="newQueryOptions">The new query options.</param>
    [MethodImpl]
    public extern void ApplyNewQueryOptions(QueryOptions newQueryOptions);

    /// <summary>Gets matching file properties with corresponding text ranges.</summary>
    /// <param name="file">The file to query for properties.</param>
    /// <returns>The matched properties and corresponding text ranges.</returns>
    [MethodImpl]
    public extern IMap<string, IVectorView<TextSegment>> GetMatchingPropertiesWithRanges(
      StorageFile file);
  }
}
