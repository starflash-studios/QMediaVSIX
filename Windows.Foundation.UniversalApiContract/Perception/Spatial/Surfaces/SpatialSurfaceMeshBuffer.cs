// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.SpatialSurfaceMeshBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Storage.Streams;

namespace Windows.Perception.Spatial.Surfaces
{
  /// <summary>Represents a vertex, index, or normal buffer that holds mesh data for surfaces in the user's surroundings.</summary>
  [GCPressure(amount = GCPressureAmount.Medium)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialSurfaceMeshBuffer : ISpatialSurfaceMeshBuffer
  {
    /// <summary>Gets the DXGI format to use when creating a GPU buffer to hold this mesh data or when otherwise interpreting the mesh elements. This enum value can be reinterpreted as a DXGI_FORMAT value.</summary>
    /// <returns>The format.</returns>
    public extern DirectXPixelFormat Format { [MethodImpl] get; }

    /// <summary>Gets the size, in bytes, between the start of each element in the buffer.</summary>
    /// <returns>The stride.</returns>
    public extern uint Stride { [MethodImpl] get; }

    /// <summary>Gets the number of elements in the buffer.</summary>
    /// <returns>The element count.</returns>
    public extern uint ElementCount { [MethodImpl] get; }

    /// <summary>The memory buffer containing the mesh data.</summary>
    /// <returns>The data.</returns>
    public extern IBuffer Data { [MethodImpl] get; }
  }
}
