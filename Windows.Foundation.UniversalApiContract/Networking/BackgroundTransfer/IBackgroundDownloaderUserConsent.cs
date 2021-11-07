// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundDownloaderUserConsent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundDownloader))]
  [Deprecated("IBackgroundDownloaderUserConsent is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(1561651462, 37478, 18440, 189, 113, 89, 37, 242, 163, 19, 10)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundDownloaderUserConsent
  {
    [Deprecated("RequestUnconstrainedDownloadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<UnconstrainedTransferRequestResult> RequestUnconstrainedDownloadsAsync(
      IIterable<DownloadOperation> operations);
  }
}
