// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IContentIndexerQuery
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentIndexerQuery))]
  [Guid(1893970168, 19452, 17034, 136, 137, 204, 81, 218, 154, 123, 157)]
  internal interface IContentIndexerQuery
  {
    [RemoteAsync]
    IAsyncOperation<uint> GetCountAsync();

    [RemoteAsync]
    [Overload("GetPropertiesAsync")]
    IAsyncOperation<IVectorView<IMapView<string, object>>> GetPropertiesAsync();

    [Overload("GetPropertiesRangeAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IMapView<string, object>>> GetPropertiesAsync(
      uint startIndex,
      uint maxItems);

    [Overload("GetAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IIndexableContent>> GetAsync();

    [Overload("GetRangeAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IIndexableContent>> GetAsync(
      uint startIndex,
      uint maxItems);

    StorageFolder QueryFolder { get; }
  }
}
