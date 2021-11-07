// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IDownloadOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(3179801520, 22292, 19977, 186, 104, 190, 247, 57, 3, 176, 215)]
  [ExclusiveTo(typeof (DownloadOperation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDownloadOperation : IBackgroundTransferOperation
  {
    IStorageFile ResultFile { get; }

    BackgroundDownloadProgress Progress { get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> StartAsync();

    [RemoteAsync]
    IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> AttachAsync();

    void Pause();

    void Resume();
  }
}
