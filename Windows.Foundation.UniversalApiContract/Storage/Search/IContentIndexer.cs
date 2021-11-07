// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IContentIndexer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ExclusiveTo(typeof (ContentIndexer))]
  [Guid(2977333133, 63128, 18818, 176, 95, 58, 110, 140, 171, 1, 162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContentIndexer
  {
    IAsyncAction AddAsync(IIndexableContent indexableContent);

    IAsyncAction UpdateAsync(IIndexableContent indexableContent);

    [RemoteAsync]
    IAsyncAction DeleteAsync(string contentId);

    IAsyncAction DeleteMultipleAsync(IIterable<string> contentIds);

    [RemoteAsync]
    IAsyncAction DeleteAllAsync();

    IAsyncOperation<IMapView<string, object>> RetrievePropertiesAsync(
      string contentId,
      IIterable<string> propertiesToRetrieve);

    ulong Revision { get; }
  }
}
