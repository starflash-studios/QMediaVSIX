// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.HandPose
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
  /// <summary>Represents the poses of the user's hand joints in relation to their surroundings.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HandPose : IHandPose
  {
    /// <summary>Gets the pose of a hand joint, expressed in the specified coordinate system.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the joint pose.</param>
    /// <param name="joint">The hand joint kind to locate.</param>
    /// <param name="jointPose">The pose to fill for the specified joint.</param>
    /// <returns>True if the hand can be located within the specified coordinate system; otherwise, false.</returns>
    [MethodImpl]
    public extern bool TryGetJoint(
      SpatialCoordinateSystem coordinateSystem,
      HandJointKind joint,
      out JointPose jointPose);

    /// <summary>Gets the pose of multiple hand joints, expressed in the specified coordinate system.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the joint poses.</param>
    /// <param name="joints">The array of hand joint kinds to locate.</param>
    /// <param name="jointPoses">The array of poses to fill, one for each matching element in the joints array.</param>
    /// <returns>True if the hand can be located within the specified coordinate system; otherwise, false.</returns>
    [MethodImpl]
    public extern bool TryGetJoints(
      SpatialCoordinateSystem coordinateSystem,
      HandJointKind[] joints,
      [Out] JointPose[] jointPoses);

    /// <summary>Gets the pose of a hand joint, expressed relative to a reference joint.</summary>
    /// <param name="joint">The hand joint kind to locate.</param>
    /// <param name="referenceJoint">The reference hand joint kind, relative to which the joint will be located.</param>
    /// <returns>The relative pose of the joint.</returns>
    [MethodImpl]
    public extern JointPose GetRelativeJoint(
      HandJointKind joint,
      HandJointKind referenceJoint);

    /// <summary>Gets the pose of multiple hand joints, each expressed relative to its matching reference joint.</summary>
    /// <param name="joints">The array of hand joint kinds to locate.</param>
    /// <param name="referenceJoints">The array of reference hand joint kinds, relative to which each matching joint in the *joints* array will be located.</param>
    /// <param name="jointPoses">The array of relative poses to fill, one for each matching element in the *joints* and *referenceJoints* arrays.</param>
    [MethodImpl]
    public extern void GetRelativeJoints(
      HandJointKind[] joints,
      HandJointKind[] referenceJoints,
      [Out] JointPose[] jointPoses);
  }
}
