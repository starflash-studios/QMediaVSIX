// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceMesh
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial.Surfaces
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialSurfaceMesh))]
  [Guid(277829593, 57101, 14672, 160, 253, 249, 114, 199, 124, 39, 180)]
  internal interface ISpatialSurfaceMesh
  {
    SpatialSurfaceInfo SurfaceInfo { get; }

    SpatialCoordinateSystem CoordinateSystem { get; }

    SpatialSurfaceMeshBuffer TriangleIndices { get; }

    SpatialSurfaceMeshBuffer VertexPositions { get; }

    Vector3 VertexPositionScale { get; }

    SpatialSurfaceMeshBuffer VertexNormals { get; }
  }
}
