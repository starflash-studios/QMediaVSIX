// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionDepthCorrelatedCoordinateMapper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(1531813149, 46582, 18076, 184, 194, 185, 122, 69, 230, 134, 59)]
  [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PerceptionDepthCorrelatedCoordinateMapper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionDepthCorrelatedCoordinateMapper
  {
    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    Point MapPixelToTarget(Point sourcePixelCoordinate, PerceptionDepthFrame depthFrame);

    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void MapPixelsToTarget(
      Point[] sourceCoordinates,
      PerceptionDepthFrame depthFrame,
      [Out] Point[] results);

    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction MapRegionOfPixelsToTargetAsync(
      Rect region,
      PerceptionDepthFrame depthFrame,
      [Out] Point[] targetCoordinates);

    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction MapAllPixelsToTargetAsync(
      PerceptionDepthFrame depthFrame,
      [Out] Point[] targetCoordinates);
  }
}
