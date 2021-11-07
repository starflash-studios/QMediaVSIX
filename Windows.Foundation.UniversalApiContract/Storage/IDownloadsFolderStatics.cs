// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IDownloadsFolderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(663105232, 16462, 18399, 161, 226, 227, 115, 8, 190, 123, 55)]
  [ExclusiveTo(typeof (DownloadsFolder))]
  internal interface IDownloadsFolderStatics
  {
    [Overload("CreateFileAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFile> CreateFileAsync(string desiredName);

    [RemoteAsync]
    [Overload("CreateFolderAsync")]
    IAsyncOperation<StorageFolder> CreateFolderAsync(string desiredName);

    [Overload("CreateFileWithCollisionOptionAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName,
      CreationCollisionOption option);

    [Overload("CreateFolderWithCollisionOptionAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName,
      CreationCollisionOption option);
  }
}
