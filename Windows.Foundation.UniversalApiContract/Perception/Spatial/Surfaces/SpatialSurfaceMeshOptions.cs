// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.Perception.Spatial.Surfaces
{
  /// <summary>Provides options to customize the SpatialSurfaceMesh objects you get back from SpatialSurfaceInfo.TryComputeLatestMeshAsync.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISpatialSurfaceMeshOptionsStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [Activatable(131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialSurfaceMeshOptions : ISpatialSurfaceMeshOptions
  {
    /// <summary>Initializes a new instance of the SpatialSurfaceMeshOptions class.</summary>
    [MethodImpl]
    public extern SpatialSurfaceMeshOptions();

    /// <summary>Gets or sets the element format for generated vertex buffers.</summary>
    /// <returns>The vertex position format.</returns>
    public extern DirectXPixelFormat VertexPositionFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the element format for generated index buffers.</summary>
    /// <returns>The triangle index format.</returns>
    public extern DirectXPixelFormat TriangleIndexFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the element format for generated normal buffers.</summary>
    /// <returns>The vertex normal format.</returns>
    public extern DirectXPixelFormat VertexNormalFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether to compute a normal buffer.</summary>
    /// <returns>Whether to compute normals.</returns>
    public extern bool IncludeVertexNormals { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of the vertex position formats that the system can generate a vertex buffer in.</summary>
    /// <returns>The supported vertex buffer formats.</returns>
    public static extern IVectorView<DirectXPixelFormat> SupportedVertexPositionFormats { [MethodImpl] get; }

    /// <summary>Gets a list of the triangle index formats that the system can generate an index buffer in.</summary>
    /// <returns>The supported index buffer formats.</returns>
    public static extern IVectorView<DirectXPixelFormat> SupportedTriangleIndexFormats { [MethodImpl] get; }

    /// <summary>Gets a list of the vertex normal formats that the system can generate a normal buffer in.</summary>
    /// <returns>The supported normal buffer formats.</returns>
    public static extern IVectorView<DirectXPixelFormat> SupportedVertexNormalFormats { [MethodImpl] get; }
  }
}
