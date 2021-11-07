// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageFolderQueryResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1716832529, 32102, 18170, 174, 207, 228, 164, 186, 169, 58, 184)]
  [ExclusiveTo(typeof (StorageFolderQueryResult))]
  internal interface IStorageFolderQueryResult : IStorageQueryResultBase
  {
    [RemoteAsync]
    [Overload("GetFoldersAsync")]
    IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(
      uint startIndex,
      uint maxNumberOfItems);

    [RemoteAsync]
    [Overload("GetFoldersAsyncDefaultStartAndCount")]
    IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();
  }
}
