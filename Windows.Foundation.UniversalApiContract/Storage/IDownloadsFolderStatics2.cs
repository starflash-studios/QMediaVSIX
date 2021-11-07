// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IDownloadsFolderStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (DownloadsFolder))]
  [Guid(3912254909, 36600, 20366, 141, 21, 172, 14, 38, 95, 57, 13)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IDownloadsFolderStatics2
  {
    [Overload("CreateFileForUserAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFile> CreateFileForUserAsync(
      User user,
      string desiredName);

    [Overload("CreateFolderForUserAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFolder> CreateFolderForUserAsync(
      User user,
      string desiredName);

    [Overload("CreateFileForUserWithCollisionOptionAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFile> CreateFileForUserAsync(
      User user,
      string desiredName,
      CreationCollisionOption option);

    [Overload("CreateFolderForUserWithCollisionOptionAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageFolder> CreateFolderForUserAsync(
      User user,
      string desiredName,
      CreationCollisionOption option);
  }
}
