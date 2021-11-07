// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionDepthFrameSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Media.Devices.Core;

namespace Windows.Devices.Perception
{
  [ExclusiveTo(typeof (PerceptionDepthFrameSource))]
  [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2043950038, 18427, 19953, 191, 201, 240, 29, 64, 189, 153, 66)]
  internal interface IPerceptionDepthFrameSource
  {
    event TypedEventHandler<PerceptionDepthFrameSource, object> AvailableChanged;

    event TypedEventHandler<PerceptionDepthFrameSource, object> ActiveChanged;

    event TypedEventHandler<PerceptionDepthFrameSource, PerceptionFrameSourcePropertiesChangedEventArgs> PropertiesChanged;

    event TypedEventHandler<PerceptionDepthFrameSource, object> VideoProfileChanged;

    event TypedEventHandler<PerceptionDepthFrameSource, object> CameraIntrinsicsChanged;

    string Id { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string DisplayName { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string DeviceKind { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    bool Available { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    bool Active { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    bool IsControlled { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    IMapView<string, object> Properties { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] [return: HasVariant] get; }

    IVectorView<PerceptionVideoProfile> SupportedVideoProfiles { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    IVectorView<PerceptionVideoProfile> AvailableVideoProfiles { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    PerceptionVideoProfile VideoProfile { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    CameraIntrinsics CameraIntrinsics { [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionControlSession AcquireControlSession();

    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    bool CanControlIndependentlyFrom(string targetId);

    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    bool IsCorrelatedWith(string targetId);

    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    bool TryGetTransformTo(string targetId, out Matrix4x4 result);

    [RemoteAsync]
    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<PerceptionDepthCorrelatedCameraIntrinsics> TryGetDepthCorrelatedCameraIntrinsicsAsync(
      PerceptionDepthFrameSource target);

    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<PerceptionDepthCorrelatedCoordinateMapper> TryGetDepthCorrelatedCoordinateMapperAsync(
      string targetId,
      PerceptionDepthFrameSource depthFrameSourceToMapWith);

    [RemoteAsync]
    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<PerceptionFrameSourcePropertyChangeResult> TrySetVideoProfileAsync(
      PerceptionControlSession controlSession,
      PerceptionVideoProfile profile);

    [Deprecated("PerceptionDepthFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionDepthFrameReader OpenReader();
  }
}
