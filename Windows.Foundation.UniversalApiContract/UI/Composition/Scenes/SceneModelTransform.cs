// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneModelTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents a group of 3-D transforms on a node, including rotation, scale, and translation.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772166)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class SceneModelTransform : CompositionTransform, ISceneModelTransform
  {
    /// <summary>Gets or sets the orientation of the node.</summary>
    /// <returns>The orientation of the node.</returns>
    public extern Quaternion Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rotation angle applied to the node, in radians.</summary>
    /// <returns>The rotation angle applied to the node, in radians.</returns>
    public extern float RotationAngle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rotation angle applied to the node, in degrees.</summary>
    /// <returns>The rotation angle applied to the node, in degrees.</returns>
    public extern float RotationAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the axes around which the node is rotated.</summary>
    /// <returns>The axes around which the node is rotated.</returns>
    public extern Vector3 RotationAxis { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the relative size of the node on the x, y, and z axes.</summary>
    /// <returns>A vector that describes the relative size of the node on the x, y, and z axes.</returns>
    public extern Vector3 Scale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the position of the node on the x, y, and z axes.</summary>
    /// <returns>A vector that describes the position of the node on the x, y, and z axes.</returns>
    public extern Vector3 Translation { [MethodImpl] get; [MethodImpl] set; }
  }
}
