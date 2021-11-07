// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionDepthCorrelatedCoordinateMapper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Provides convenience methods to map pixel coordinates in camera image space to depth image space.</summary>
  /// <deprecated type="deprecate">PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.</deprecated>
  [Threading(ThreadingModel.Both)]
  [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PerceptionDepthCorrelatedCoordinateMapper : 
    IPerceptionDepthCorrelatedCoordinateMapper
  {
    /// <summary>Maps a pixel from camera image space to depth image space.</summary>
    /// <deprecated type="deprecate">PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.</deprecated>
    /// <param name="sourcePixelCoordinate">A pixel coordinate, in camera image space.</param>
    /// <param name="depthFrame">The depth frame to map the pixel to.</param>
    /// <returns>Returns the mapping of the pixel coordinate to depth image space.</returns>
    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern Point MapPixelToTarget(
      Point sourcePixelCoordinate,
      PerceptionDepthFrame depthFrame);

    /// <summary>Maps a set of pixels from camera image space to depth image space.</summary>
    /// <deprecated type="deprecate">PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.</deprecated>
    /// <param name="sourceCoordinates">A set of pixel coordinates, in camera image space.</param>
    /// <param name="depthFrame">The depth frame to map the pixels to.</param>
    /// <param name="results">The mapping of the pixel coordinate to depth image space.</param>
    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void MapPixelsToTarget(
      Point[] sourceCoordinates,
      PerceptionDepthFrame depthFrame,
      [Out] Point[] results);

    /// <summary>Maps a region of pixels from camera image space to depth image space.</summary>
    /// <deprecated type="deprecate">PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.</deprecated>
    /// <param name="region">The region of pixels to map from camera image space to depth image space.</param>
    /// <param name="depthFrame">The depth frame to map the region of pixels to.</param>
    /// <param name="targetCoordinates">The pixel coordinates, mapped to depth image space.</param>
    /// <returns>This function returns asynchronously.</returns>
    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction MapRegionOfPixelsToTargetAsync(
      Rect region,
      PerceptionDepthFrame depthFrame,
      [Out] Point[] targetCoordinates);

    /// <summary>Maps all pixels in an image from camera image space to depth image space.</summary>
    /// <deprecated type="deprecate">PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.</deprecated>
    /// <param name="depthFrame">The depth frame to map the pixels to.</param>
    /// <param name="targetCoordinates">Returns the pixel coordinates, mapped to depth image space.</param>
    /// <returns>This function returns asynchronously.</returns>
    [Deprecated("PerceptionDepthCorrelatedCoordinateMapper may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction MapAllPixelsToTargetAsync(
      PerceptionDepthFrame depthFrame,
      [Out] Point[] targetCoordinates);
  }
}
