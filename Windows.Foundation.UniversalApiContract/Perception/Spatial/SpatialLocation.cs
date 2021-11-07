// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialLocation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  /// <summary>Represents the location of the device in the user's surroundings at a point in time.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialLocation : ISpatialLocation, ISpatialLocation2
  {
    /// <summary>Gets the position of the device within the supplied coordinate system.</summary>
    /// <returns>The position.</returns>
    public extern Vector3 Position { [MethodImpl] get; }

    /// <summary>Gets the orientation of the device within the supplied coordinate system.</summary>
    /// <returns>The orientation.</returns>
    public extern Quaternion Orientation { [MethodImpl] get; }

    /// <summary>Gets the absolute velocity vector of the device in units of meters per second. This velocity is expressed in the supplied coordinate system, although the motion is measured relative to the user's surroundings.</summary>
    /// <returns>The velocity.</returns>
    public extern Vector3 AbsoluteLinearVelocity { [MethodImpl] get; }

    /// <summary>Gets the absolute acceleration vector of the device in units of meters per second squared. This acceleration is expressed in the supplied coordinate system, although the motion is measured relative to the user's surroundings.</summary>
    /// <returns>The acceleration.</returns>
    public extern Vector3 AbsoluteLinearAcceleration { [MethodImpl] get; }

    /// <summary>Gets the absolute angular velocity of the device in a clamped quaternion representation of the rotation per second. This velocity is expressed in the supplied coordinate system, although the motion is measured relative to the user's surroundings.</summary>
    /// <returns>The angular velocity as a clamped quaternion.</returns>
    public extern Quaternion AbsoluteAngularVelocity { [Deprecated("Use AbsoluteAngularVelocityAxisAngle instead of AbsoluteAngularVelocity. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the absolute angular acceleration of the device in a clamped quaternion representation of the rotation per second squared. This acceleration is expressed in the supplied coordinate system, although the motion is measured relative to the user's surroundings.</summary>
    /// <returns>The angular acceleration as a clamped quaternion.</returns>
    public extern Quaternion AbsoluteAngularAcceleration { [Deprecated("Use AbsoluteAngularAccelerationAxisAngle instead of AbsoluteAngularAcceleration. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the absolute angular velocity of the device in an axis-angle representation in units of radians per second. This velocity is expressed in the supplied coordinate system, although the motion is measured relative to the user's surroundings.</summary>
    /// <returns>The angular velocity as an axis-angle.</returns>
    public extern Vector3 AbsoluteAngularVelocityAxisAngle { [MethodImpl] get; }

    /// <summary>Gets the absolute angular acceleration of the device in an axis-angle representation in units of radians per second squared. This acceleration is expressed in the supplied coordinate system, although the motion is measured relative to the user's surroundings.</summary>
    /// <returns>The angular acceleration as an axis-angle.</returns>
    public extern Vector3 AbsoluteAngularAccelerationAxisAngle { [MethodImpl] get; }
  }
}
