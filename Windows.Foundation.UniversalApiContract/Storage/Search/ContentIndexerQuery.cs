// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.ContentIndexerQuery
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Represents a query for content properties in the ContentIndexer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContentIndexerQuery : IContentIndexerQuery
  {
    /// <summary>Gets the number of items in the search results.</summary>
    /// <returns>When this method completes, it returns the number of items in the search results.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> GetCountAsync();

    /// <summary>Retrieves a collection of property sets for an app, where the property sets are key-value pairs.</summary>
    /// <returns>When this method completes, it returns the query results as a collection of PropertyValue instances.</returns>
    [Overload("GetPropertiesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IMapView<string, object>>> GetPropertiesAsync();

    /// <summary>Runs the query on the app's indexed content properties and returns the specified number of properties from the specified start index in the results collection.</summary>
    /// <param name="startIndex">The index of the first item to get from the results collection.</param>
    /// <param name="maxItems">The maximum number of items to get.</param>
    /// <returns>When this method completes, it returns the query results as a collection of PropertyValue instances.</returns>
    [Overload("GetPropertiesRangeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IMapView<string, object>>> GetPropertiesAsync(
      uint startIndex,
      uint maxItems);

    /// <summary>Runs the query on the app's indexed content properties.</summary>
    /// <returns>When this method completes, it returns the query results, represented as a collection of IIndexableContent instances.</returns>
    [Overload("GetAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IIndexableContent>> GetAsync();

    /// <summary>Runs the query on the app's indexed content properties and returns the specified number of items from the specified start index in the results collection.</summary>
    /// <param name="startIndex">The index of the first item to get from the results collection.</param>
    /// <param name="maxItems">The maximum number of items to get.</param>
    /// <returns>When this method completes, it returns the query results, represented as a collection of IndexableContent instances.</returns>
    [RemoteAsync]
    [Overload("GetRangeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IIndexableContent>> GetAsync(
      uint startIndex,
      uint maxItems);

    /// <summary>Gets the StorageFolder representation of the app-provided items in the ContentIndexer query.</summary>
    /// <returns>The folder that contains app-provided content.</returns>
    public extern StorageFolder QueryFolder { [MethodImpl] get; }
  }
}
