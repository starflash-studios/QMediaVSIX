// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundDownloader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundDownloader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3251082035, 26185, 19229, 168, 38, 164, 179, 221, 35, 77, 11)]
  internal interface IBackgroundDownloader : IBackgroundTransferBase
  {
    [Overload("CreateDownload")]
    DownloadOperation CreateDownload(Uri uri, IStorageFile resultFile);

    [Overload("CreateDownloadFromFile")]
    DownloadOperation CreateDownload(
      Uri uri,
      IStorageFile resultFile,
      IStorageFile requestBodyFile);

    [RemoteAsync]
    IAsyncOperation<DownloadOperation> CreateDownloadAsync(
      Uri uri,
      IStorageFile resultFile,
      IInputStream requestBodyStream);
  }
}
