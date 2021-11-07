// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundDownloaderStaticMethods2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(799675175, 6868, 19621, 178, 205, 8, 219, 240, 116, 106, 254)]
  [ExclusiveTo(typeof (BackgroundDownloader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundDownloaderStaticMethods2
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsForTransferGroupAsync(
      BackgroundTransferGroup group);
  }
}
