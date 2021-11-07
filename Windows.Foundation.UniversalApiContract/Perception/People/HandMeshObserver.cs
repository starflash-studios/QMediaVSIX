// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.HandMeshObserver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Spatial;

namespace Windows.Perception.People
{
  /// <summary>Provides mesh updates each frame that track the detected shape of a hand.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class HandMeshObserver : IHandMeshObserver
  {
    /// <summary>The SpatialInteractionSource whose hand mesh is tracked by this HandMeshObserver.</summary>
    /// <returns>The source.</returns>
    public extern SpatialInteractionSource Source { [MethodImpl] get; }

    /// <summary>Gets the number of elements in the index buffer for this hand mesh model.</summary>
    /// <returns>The index buffer size.</returns>
    public extern uint TriangleIndexCount { [MethodImpl] get; }

    /// <summary>Gets the count of vertices for this hand.</summary>
    /// <returns>The count of vertices for this hand.</returns>
    public extern uint VertexCount { [MethodImpl] get; }

    /// <summary>Fills an index buffer for this hand mesh model.</summary>
    /// <param name="indices">The index buffer to fill.</param>
    [MethodImpl]
    public extern void GetTriangleIndices([Out] ushort[] indices);

    /// <summary>Gets the vertex buffer and other state needed to render the hand mesh for a given frame's hand pose, or for the hand mesh's neutral pose.</summary>
    /// <param name="handPose">The hand pose for which to get the vertex state.</param>
    /// <returns>The vertex state.</returns>
    [MethodImpl]
    public extern HandMeshVertexState GetVertexStateForPose(HandPose handPose);

    /// <summary>Gets the current neutral HandPose for this hand.</summary>
    /// <returns>The neutral hand pose.</returns>
    public extern HandPose NeutralPose { [MethodImpl] get; }

    /// <summary>Gets the version of the NeutralPose for this hand.</summary>
    /// <returns>The neutral hand pose version.</returns>
    public extern int NeutralPoseVersion { [MethodImpl] get; }

    /// <summary>Gets a hand mesh model ID to identify the same index buffer across multiple source detection and loss events.</summary>
    /// <returns>The hand mesh model ID.</returns>
    public extern int ModelId { [MethodImpl] get; }
  }
}
