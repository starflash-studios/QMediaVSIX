// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial.Surfaces
{
  [Guid(4176079847, 14775, 14690, 187, 3, 87, 245, 110, 31, 176, 161)]
  [ExclusiveTo(typeof (SpatialSurfaceInfo))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialSurfaceInfo
  {
    Guid Id { get; }

    global::Windows.Foundation.DateTime UpdateTime { get; }

    IReference<SpatialBoundingOrientedBox> TryGetBounds(
      SpatialCoordinateSystem coordinateSystem);

    [Overload("TryComputeLatestMeshAsync")]
    [RemoteAsync]
    IAsyncOperation<SpatialSurfaceMesh> TryComputeLatestMeshAsync(
      double maxTrianglesPerCubicMeter);

    [RemoteAsync]
    [Overload("TryComputeLatestMeshWithOptionsAsync")]
    IAsyncOperation<SpatialSurfaceMesh> TryComputeLatestMeshAsync(
      double maxTrianglesPerCubicMeter,
      SpatialSurfaceMeshOptions options);
  }
}
