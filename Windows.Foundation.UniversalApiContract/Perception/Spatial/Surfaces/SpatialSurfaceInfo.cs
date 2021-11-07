// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.SpatialSurfaceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial.Surfaces
{
  /// <summary>Represents a snapshot of metadata for a surface observed in the user's surroundings.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialSurfaceInfo : ISpatialSurfaceInfo
  {
    /// <summary>Gets the persistent identifier for this surface.</summary>
    /// <returns>The identifier.</returns>
    public extern Guid Id { [MethodImpl] get; }

    /// <summary>Gets the last update time represented by this surface metadata snapshot.</summary>
    /// <returns>The update time.</returns>
    public extern global::Windows.Foundation.DateTime UpdateTime { [MethodImpl] get; }

    /// <summary>Gets the bounds of this surface, expressed in the specified coordinate system.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the bounds.</param>
    /// <returns>The bounds.</returns>
    [MethodImpl]
    public extern IReference<SpatialBoundingOrientedBox> TryGetBounds(
      SpatialCoordinateSystem coordinateSystem);

    /// <summary>Generates a mesh object and its vertex and index buffers for this surface. This chooses the most detailed mesh that does not exceed the specified triangle density, in triangles per cubic meter.</summary>
    /// <param name="maxTrianglesPerCubicMeter">The maximum triangle density that the app can accept, in triangles per cubic meter.</param>
    /// <returns>The operation that triggers once the mesh is ready.</returns>
    [RemoteAsync]
    [Overload("TryComputeLatestMeshAsync")]
    [MethodImpl]
    public extern IAsyncOperation<SpatialSurfaceMesh> TryComputeLatestMeshAsync(
      double maxTrianglesPerCubicMeter);

    /// <summary>Generates a mesh object and its vertex and index buffers for this surface, with the specified mesh generation options. This chooses the most detailed mesh that does not exceed the specified triangle density, in triangles per cubic meter.</summary>
    /// <param name="maxTrianglesPerCubicMeter">The maximum triangle density that the app can accept, in triangles per cubic meter.</param>
    /// <param name="options">The mesh generation options.</param>
    /// <returns>The operation that triggers once the mesh is ready.</returns>
    [RemoteAsync]
    [Overload("TryComputeLatestMeshWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<SpatialSurfaceMesh> TryComputeLatestMeshAsync(
      double maxTrianglesPerCubicMeter,
      SpatialSurfaceMeshOptions options);
  }
}
