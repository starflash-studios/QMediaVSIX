// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionDepthCorrelatedCameraIntrinsics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Devices.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1699269121, 34526, 23521, 101, 130, 128, 127, 207, 76, 149, 207)]
  [ExclusiveTo(typeof (PerceptionDepthCorrelatedCameraIntrinsics))]
  [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionDepthCorrelatedCameraIntrinsics
  {
    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    Vector3 UnprojectPixelAtCorrelatedDepth(
      Point pixelCoordinate,
      PerceptionDepthFrame depthFrame);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void UnprojectPixelsAtCorrelatedDepth(
      Point[] sourceCoordinates,
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction UnprojectRegionPixelsAtCorrelatedDepthAsync(
      Rect region,
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);

    [Deprecated("PerceptionDepthCorrelatedCameraIntrinsics may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction UnprojectAllPixelsAtCorrelatedDepthAsync(
      PerceptionDepthFrame depthFrame,
      [Out] Vector3[] results);
  }
}
