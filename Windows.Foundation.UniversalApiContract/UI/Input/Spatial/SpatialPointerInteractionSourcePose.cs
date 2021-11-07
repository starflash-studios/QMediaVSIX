// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialPointerInteractionSourcePose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Represents a motion controller's pointer pose in relation to its surroundings.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialPointerInteractionSourcePose : 
    ISpatialPointerInteractionSourcePose,
    ISpatialPointerInteractionSourcePose2
  {
    /// <summary>Gets the position of the motion controller's pointer pose in the specified coordinate system.</summary>
    /// <returns>The position.</returns>
    public extern Vector3 Position { [MethodImpl] get; }

    /// <summary>Gets the forward direction of the motion controller's pointer pose in the specified coordinate system, as a unit vector.</summary>
    /// <returns>The forward direction unit vector.</returns>
    public extern Vector3 ForwardDirection { [MethodImpl] get; }

    /// <summary>Gets the up direction that orients the motion controller's pointer pose in the specified coordinate system, as a unit vector.</summary>
    /// <returns>The up direction unit vector.</returns>
    public extern Vector3 UpDirection { [MethodImpl] get; }

    /// <summary>Gets the orientation of the motion controller's pointer pose in the specified coordinate system.</summary>
    /// <returns>The orientation.</returns>
    public extern Quaternion Orientation { [MethodImpl] get; }

    /// <summary>Gets the accuracy of an interaction source's positional tracking.</summary>
    /// <returns>The position accuracy.</returns>
    public extern SpatialInteractionSourcePositionAccuracy PositionAccuracy { [MethodImpl] get; }
  }
}
