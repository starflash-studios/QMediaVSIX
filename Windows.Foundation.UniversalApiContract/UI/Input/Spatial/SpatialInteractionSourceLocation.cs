// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionSourceLocation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Represents the grip pose and pointer pose of a hand or motion controller.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialInteractionSourceLocation : 
    ISpatialInteractionSourceLocation,
    ISpatialInteractionSourceLocation2,
    ISpatialInteractionSourceLocation3
  {
    /// <summary>Gets the grip pose position, representing the position of the user's hand, either directly or where it holds a motion controller.</summary>
    /// <returns>The position.</returns>
    public extern IReference<Vector3> Position { [MethodImpl] get; }

    /// <summary>Gets the velocity of a hand or motion controller.</summary>
    /// <returns>The velocity.</returns>
    public extern IReference<Vector3> Velocity { [MethodImpl] get; }

    /// <summary>Gets the grip pose orientation, representing the orientation of the user's hand as it holds a motion controller.</summary>
    /// <returns>The orientation.</returns>
    public extern IReference<Quaternion> Orientation { [MethodImpl] get; }

    /// <summary>Gets the accuracy of an interaction source's positional tracking.</summary>
    /// <returns>The position accuracy.</returns>
    public extern SpatialInteractionSourcePositionAccuracy PositionAccuracy { [MethodImpl] get; }

    /// <summary>Gets the angular velocity of a hand or motion controller.</summary>
    /// <returns>The angular velocity.</returns>
    public extern IReference<Vector3> AngularVelocity { [MethodImpl] get; }

    /// <summary>Gets the pointer pose for a particular spatial interaction source, such as a motion controller, at a given timestamp.</summary>
    /// <returns>The interaction source pointer pose.</returns>
    public extern SpatialPointerInteractionSourcePose SourcePointerPose { [MethodImpl] get; }
  }
}
