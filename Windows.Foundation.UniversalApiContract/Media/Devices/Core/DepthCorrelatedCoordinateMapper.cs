// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.DepthCorrelatedCoordinateMapper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Perception.Spatial;

namespace Windows.Media.Devices.Core
{
  /// <summary>Maps 2D points in a MediaFrameSource to 3D space or to a frame from a different **MediaFrameSource** using data from a DepthMediaFrame.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  public sealed class DepthCorrelatedCoordinateMapper : IDepthCorrelatedCoordinateMapper, IClosable
  {
    /// <summary>Unprojects a 2D point from a MediaFrameSource to a point in 3D space, using depth information from the DepthMediaFrame from which the coordinate mapper was created with a call to TryCreateCoordinateMapper.</summary>
    /// <param name="sourcePoint">The 2D source point within the MediaFrameSource to map.</param>
    /// <param name="targetCoordinateSystem">The coordinate system to which the point is unprojected.</param>
    /// <returns>An point in 3D space.</returns>
    [MethodImpl]
    public extern Vector3 UnprojectPoint(
      Point sourcePoint,
      SpatialCoordinateSystem targetCoordinateSystem);

    [MethodImpl]
    public extern void UnprojectPoints(
      Point[] sourcePoints,
      SpatialCoordinateSystem targetCoordinateSystem,
      [Out] Vector3[] results);

    /// <summary>Maps a point from one MediaFrameSource to another, using depth information from the DepthMediaFrame from which the coordinate mapper was created with a call to TryCreateCoordinateMapper.</summary>
    /// <param name="sourcePoint">The source point to be mapped to the coordinate system of a different media frame source, which is specified in the *targetCoordinateSystem* parameter.</param>
    /// <param name="targetCoordinateSystem">The coordinate system of the target media frame source to which the point is mapped.</param>
    /// <param name="targetCameraIntrinsics">The camera intrinsics describing the projection and distortion models of the media frame source to which the point is mapped.</param>
    /// <returns>A mapped point.</returns>
    [MethodImpl]
    public extern Point MapPoint(
      Point sourcePoint,
      SpatialCoordinateSystem targetCoordinateSystem,
      CameraIntrinsics targetCameraIntrinsics);

    /// <summary>Maps an array of points from one MediaFrameSource to another, using depth information from the DepthMediaFrame from which the coordinate mapper was created with a call to TryCreateCoordinateMapper.</summary>
    /// <param name="sourcePoints">An array of source points to be mapped to the coordinate system of a different media frame source, which is specified in the *targetCoordinateSystem* parameter.</param>
    /// <param name="targetCoordinateSystem">The coordinate system of the target media frame source to which the points are mapped.</param>
    /// <param name="targetCameraIntrinsics">The camera intrinsics describing the projection and distortion models of the media frame source to which the points are mapped.</param>
    /// <param name="results">An array mapped points.</param>
    [MethodImpl]
    public extern void MapPoints(
      Point[] sourcePoints,
      SpatialCoordinateSystem targetCoordinateSystem,
      CameraIntrinsics targetCameraIntrinsics,
      [Out] Point[] results);

    [MethodImpl]
    public extern void Close();
  }
}
