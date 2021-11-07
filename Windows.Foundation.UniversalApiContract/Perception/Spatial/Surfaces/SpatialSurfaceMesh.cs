// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.SpatialSurfaceMesh
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial.Surfaces
{
  /// <summary>Represents the mesh data for a surface observed in the user's surroundings.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [GCPressure(amount = GCPressureAmount.Medium)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialSurfaceMesh : ISpatialSurfaceMesh
  {
    /// <summary>Gets the surface metadata that's associated with this mesh.</summary>
    /// <returns>The surface info.</returns>
    public extern SpatialSurfaceInfo SurfaceInfo { [MethodImpl] get; }

    /// <summary>Gets the coordinate system in which the VertexPositions and VertexNormals buffers express their coordinates.</summary>
    /// <returns>The vertex coordinate system.</returns>
    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }

    /// <summary>Gets the buffer object representing the mesh's index buffer.</summary>
    /// <returns>The mesh buffer.</returns>
    public extern SpatialSurfaceMeshBuffer TriangleIndices { [MethodImpl] get; }

    /// <summary>Gets the buffer object representing the mesh's vertex buffer.</summary>
    /// <returns>The mesh buffer.</returns>
    public extern SpatialSurfaceMeshBuffer VertexPositions { [MethodImpl] get; }

    /// <summary>Gets the scale vector that you must use to scale the elements of VertexPositions.</summary>
    /// <returns>The scale vector.</returns>
    public extern Vector3 VertexPositionScale { [MethodImpl] get; }

    /// <summary>Gets the buffer object representing the mesh's normal buffer, if IncludeVertexNormals was set as a mesh option in the call to SpatialSurfaceInfo.TryComputeLatestMeshAsync. Otherwise, this property is null.</summary>
    /// <returns>The mesh buffer if available; otherwise null.</returns>
    public extern SpatialSurfaceMeshBuffer VertexNormals { [MethodImpl] get; }
  }
}
