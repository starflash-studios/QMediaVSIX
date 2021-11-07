// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploaderStaticMethods
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundUploader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4068957435, 39685, 18241, 145, 33, 116, 10, 131, 226, 71, 223)]
  internal interface IBackgroundUploaderStaticMethods
  {
    [Overload("GetCurrentUploadsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync();

    [Deprecated("GetCurrentUploadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentUploadsForTransferGroupAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("GetCurrentUploadsForGroupAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync(
      string group);
  }
}
