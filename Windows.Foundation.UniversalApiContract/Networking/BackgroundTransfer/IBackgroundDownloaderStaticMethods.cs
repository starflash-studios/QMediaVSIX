// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundDownloaderStaticMethods
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(1386633781, 50766, 17004, 153, 25, 84, 13, 13, 33, 166, 80)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BackgroundDownloader))]
  internal interface IBackgroundDownloaderStaticMethods
  {
    [Overload("GetCurrentDownloadsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync();

    [Overload("GetCurrentDownloadsForGroupAsync")]
    [RemoteAsync]
    [Deprecated("GetCurrentDownloadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentDownloadsForTransferGroupAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync(
      string group);
  }
}
