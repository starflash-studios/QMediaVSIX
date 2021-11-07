// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFileStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorageFile))]
  [Guid(1501873936, 56050, 17352, 139, 180, 164, 211, 234, 207, 208, 63)]
  internal interface IStorageFileStatics
  {
    [RemoteAsync]
    IAsyncOperation<StorageFile> GetFileFromPathAsync(string path);

    [RemoteAsync]
    IAsyncOperation<StorageFile> GetFileFromApplicationUriAsync(Uri uri);

    [RemoteAsync]
    IAsyncOperation<StorageFile> CreateStreamedFileAsync(
      string displayNameWithExtension,
      StreamedFileDataRequestedHandler dataRequested,
      IRandomAccessStreamReference thumbnail);

    [RemoteAsync]
    IAsyncOperation<StorageFile> ReplaceWithStreamedFileAsync(
      IStorageFile fileToReplace,
      StreamedFileDataRequestedHandler dataRequested,
      IRandomAccessStreamReference thumbnail);

    [RemoteAsync]
    IAsyncOperation<StorageFile> CreateStreamedFileFromUriAsync(
      string displayNameWithExtension,
      Uri uri,
      IRandomAccessStreamReference thumbnail);

    [RemoteAsync]
    IAsyncOperation<StorageFile> ReplaceWithStreamedFileFromUriAsync(
      IStorageFile fileToReplace,
      Uri uri,
      IRandomAccessStreamReference thumbnail);
  }
}
