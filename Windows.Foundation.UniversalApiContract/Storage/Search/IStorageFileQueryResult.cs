// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageFileQueryResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ExclusiveTo(typeof (StorageFileQueryResult))]
  [Guid(1392354375, 11178, 16684, 178, 159, 212, 177, 119, 142, 250, 30)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStorageFileQueryResult : IStorageQueryResultBase
  {
    [RemoteAsync]
    [Overload("GetFilesAsync")]
    IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync(
      uint startIndex,
      uint maxNumberOfItems);

    [RemoteAsync]
    [Overload("GetFilesAsyncDefaultStartAndCount")]
    IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();
  }
}
