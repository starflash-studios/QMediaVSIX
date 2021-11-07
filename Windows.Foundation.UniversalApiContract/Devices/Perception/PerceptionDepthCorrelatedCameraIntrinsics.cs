// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionDepthCorrelatedCameraIntrinsics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Devices.Perception
{
  /// <summary>Provides convenience methods to facilitate geometric math for a camera device, combining the intrinsic properties of that camera with correlated depth frames to provide screen-space pixel to camera-space coordinate projections.</summary>
  /// <deprecated type="deprecate">PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.</deprecated>
  [Threading(ThreadingModel.Both)]
  [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PerceptionDepthCorrelatedCameraIntrinsics : 
    IPerceptionDepthCorrelatedCameraIntrinsics
  {
    /// <summary>Unprojects a point in camera image space out into the coordinate frame of the camera device, using the corresponding depth from a correlated depth camera.</summary>
    /// <deprecated type="deprecate">PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.</deprecated>
    /// <param name="pixelCoordinate">A point, relative to the camera frame.</param>
    /// <param name="depthFrame">The depth frame containing the depth value to use when projecting the point into camera space. The pixelCoordinate will be mapped from camera image space to depth image space, and then used to look up the depth in depthFrame.</param>
    /// <returns>An unprojected coordinate, relative to the coordinate system of the camera device. The coordinate is located in front of the camera, at the depth of the corresponding pixel in depthFrame.</returns>
    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern Vector3 UnprojectPixelAtCorrelatedDepth(
      Point pixelCoordinate,
      PerceptionDepthFrame depthFrame);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void UnprojectPixelsAtCorrelatedDepth(
      Point[] sourceCoordinates,
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction UnprojectRegionPixelsAtCorrelatedDepthAsync(
      Rect region,
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction UnprojectAllPixelsAtCorrelatedDepthAsync(
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);
  }
}
