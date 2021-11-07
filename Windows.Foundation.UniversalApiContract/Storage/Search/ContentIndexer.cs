// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.ContentIndexer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Enables UWP apps to make private content searchable by using the system index.</summary>
  [Static(typeof (IContentIndexerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContentIndexer : IContentIndexer, IContentIndexerQueryOperations
  {
    /// <summary>Adds app-defined items with properties and content to the system index.</summary>
    /// <param name="indexableContent">The content properties to index.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern IAsyncAction AddAsync(IIndexableContent indexableContent);

    /// <summary>Updates app content and properties in the ContentIndexer.</summary>
    /// <param name="indexableContent">The content properties to update.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern IAsyncAction UpdateAsync(IIndexableContent indexableContent);

    /// <summary>Removes the specified app-defined item from the ContentIndexer.</summary>
    /// <param name="contentId">The identifier of the item to remove.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync(string contentId);

    [MethodImpl]
    public extern IAsyncAction DeleteMultipleAsync(IIterable<string> contentIds);

    /// <summary>Removes all app-defined items from the ContentIndexer.</summary>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAllAsync();

    [MethodImpl]
    public extern IAsyncOperation<IMapView<string, object>> RetrievePropertiesAsync(
      string contentId,
      IIterable<string> propertiesToRetrieve);

    /// <summary>Gets the version of the ContentIndexer.</summary>
    /// <returns>The revision number.</returns>
    public extern ulong Revision { [MethodImpl] get; }

    [Overload("CreateQueryWithSortOrderAndLanguage")]
    [MethodImpl]
    public extern ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve,
      IIterable<SortEntry> sortOrder,
      string searchFilterLanguage);

    [Overload("CreateQueryWithSortOrder")]
    [MethodImpl]
    public extern ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve,
      IIterable<SortEntry> sortOrder);

    [Overload("CreateQuery")]
    [MethodImpl]
    public extern ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve);

    /// <summary>Gets the per-app index with the specified name or creates a new one, if necessary.</summary>
    /// <param name="indexName">The index name.</param>
    /// <returns>The index.</returns>
    [Overload("GetIndexerWithName")]
    [MethodImpl]
    public static extern ContentIndexer GetIndexer(string indexName);

    /// <summary>Gets an existing per-app index or creates a new one, if necessary.</summary>
    /// <returns>The index.</returns>
    [Overload("GetIndexer")]
    [MethodImpl]
    public static extern ContentIndexer GetIndexer();
  }
}
