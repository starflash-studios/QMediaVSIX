// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.IFileInformationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.BulkAccess
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileInformationFactory))]
  [Guid(1075677374, 38415, 19821, 167, 208, 26, 56, 97, 231, 108, 131)]
  internal interface IFileInformationFactory
  {
    [Overload("GetItemsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    [Overload("GetItemsAsyncDefaultStartAndCount")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<IStorageItemInformation>> GetItemsAsync();

    [RemoteAsync]
    [Overload("GetFilesAsync")]
    IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    [RemoteAsync]
    [Overload("GetFilesAsyncDefaultStartAndCount")]
    IAsyncOperation<IVectorView<FileInformation>> GetFilesAsync();

    [RemoteAsync]
    [Overload("GetFoldersAsync")]
    IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync(
      uint startIndex,
      uint maxItemsToRetrieve);

    [RemoteAsync]
    [Overload("GetFoldersAsyncDefaultStartAndCount")]
    IAsyncOperation<IVectorView<FolderInformation>> GetFoldersAsync();

    object GetVirtualizedItemsVector();

    object GetVirtualizedFilesVector();

    object GetVirtualizedFoldersVector();
  }
}
