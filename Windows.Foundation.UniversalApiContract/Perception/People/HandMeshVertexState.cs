// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.HandMeshVertexState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Perception.People
{
  /// <summary>Represents the vertex buffer and other state needed to render the hand mesh.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HandMeshVertexState : IHandMeshVertexState
  {
    /// <summary>Gets the coordinate system within which this frame's vertex positions and normals are expressed.</summary>
    /// <returns>The coordinate system.</returns>
    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }

    /// <summary>Fills a vertex buffer for this hand mesh model.</summary>
    /// <param name="vertices">The vertex buffer to fill.</param>
    [MethodImpl]
    public extern void GetVertices([Out] HandMeshVertex[] vertices);

    /// <summary>Gets the timestamp at which the vertex positions and normals were last updated.</summary>
    /// <returns>The update timestamp.</returns>
    public extern PerceptionTimestamp UpdateTimestamp { [MethodImpl] get; }
  }
}
