// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionDepthFrameSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [ExclusiveTo(typeof (PerceptionDepthFrameSource))]
  [Guid(1576258722, 504, 19079, 184, 89, 213, 229, 183, 225, 222, 72)]
  [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionDepthFrameSourceStatics
  {
    [Deprecated("PerceptionDepthFrameSource.CreateWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.CreateWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionDepthFrameSourceWatcher CreateWatcher();

    [RemoteAsync]
    [Deprecated("PerceptionDepthFrameSource.FindAllAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FindAllAsync instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<IVectorView<PerceptionDepthFrameSource>> FindAllAsync();

    [RemoteAsync]
    [Deprecated("PerceptionDepthFrameSource.FromIdAsync may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation.FromIdAsync instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<PerceptionDepthFrameSource> FromIdAsync(
      string id);

    [Deprecated("PerceptionDepthFrameSource.RequestAccessAsync may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<PerceptionFrameSourceAccessStatus> RequestAccessAsync();
  }
}
