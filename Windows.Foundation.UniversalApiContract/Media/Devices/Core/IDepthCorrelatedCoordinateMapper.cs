// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IDepthCorrelatedCoordinateMapper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Perception.Spatial;

namespace Windows.Media.Devices.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4183656955, 35568, 19632, 146, 109, 105, 104, 102, 229, 4, 106)]
  [ExclusiveTo(typeof (DepthCorrelatedCoordinateMapper))]
  internal interface IDepthCorrelatedCoordinateMapper : IClosable
  {
    Vector3 UnprojectPoint(Point sourcePoint, SpatialCoordinateSystem targetCoordinateSystem);

    void UnprojectPoints(
      Point[] sourcePoints,
      SpatialCoordinateSystem targetCoordinateSystem,
      [Out] Vector3[] results);

    Point MapPoint(
      Point sourcePoint,
      SpatialCoordinateSystem targetCoordinateSystem,
      CameraIntrinsics targetCameraIntrinsics);

    void MapPoints(
      Point[] sourcePoints,
      SpatialCoordinateSystem targetCoordinateSystem,
      CameraIntrinsics targetCameraIntrinsics,
      [Out] Point[] results);
  }
}
