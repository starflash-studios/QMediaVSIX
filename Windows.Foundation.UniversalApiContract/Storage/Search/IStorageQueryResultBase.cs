// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageQueryResultBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Provides methods to access to and manage query results.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3264730893, 29523, 18347, 186, 88, 140, 97, 66, 93, 197, 75)]
  public interface IStorageQueryResultBase
  {
    /// <summary>Retrieves the number of items that match the query that created a StorageFileQueryResult, StorageFolderQueryResult, or StorageItemQueryResult object.</summary>
    /// <returns>When this method completes successfully, it returns the number of items that match the query.</returns>
    [RemoteAsync]
    IAsyncOperation<uint> GetItemCountAsync();

    /// <summary>Gets the folder originally used to create a StorageFileQueryResult, StorageFolderQueryResult, or StorageItemQueryResult object. This folder represents the scope of the query.</summary>
    /// <returns>The original folder.</returns>
    StorageFolder Folder { get; }

    /// <summary>Fires when an item is added, deleted or modified in the folder being queried.</summary>
    event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;

    /// <summary>Fires when the query options are changed for a StorageFileQueryResult, StorageFolderQueryResult, or StorageItemQueryResult object.</summary>
    event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;

    /// <summary>Retrieves the index of the file from the query results that most closely matches the specified property value. The property that is matched is determined by the first SortEntry of the QueryOptions.SortOrder list.</summary>
    /// <param name="value">The property value to match when searching the query results.</param>
    /// <returns>When this method completes successfully it returns the index of the matched item in the query results.</returns>
    [RemoteAsync]
    IAsyncOperation<uint> FindStartIndexAsync([Variant] object value);

    /// <summary>Retrieves the query options used to create a StorageFileQueryResult, StorageFolderQueryResult, or StorageItemQueryResult object.</summary>
    /// <returns>The query options.</returns>
    QueryOptions GetCurrentQueryOptions();

    /// <summary>Applies new query options to the results retrieved by the StorageFileQueryResult, StorageFolderQueryResult, or StorageItemQueryResult object.</summary>
    /// <param name="newQueryOptions">The new query options.</param>
    void ApplyNewQueryOptions(QueryOptions newQueryOptions);
  }
}
