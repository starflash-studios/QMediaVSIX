// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.IHandPose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Perception.People
{
  [Guid(1301866394, 47880, 23817, 145, 222, 223, 13, 211, 250, 228, 108)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (HandPose))]
  internal interface IHandPose
  {
    bool TryGetJoint(
      SpatialCoordinateSystem coordinateSystem,
      HandJointKind joint,
      out JointPose jointPose);

    bool TryGetJoints(
      SpatialCoordinateSystem coordinateSystem,
      HandJointKind[] joints,
      [Out] JointPose[] jointPoses);

    JointPose GetRelativeJoint(HandJointKind joint, HandJointKind referenceJoint);

    void GetRelativeJoints(
      HandJointKind[] joints,
      HandJointKind[] referenceJoints,
      [Out] JointPose[] jointPoses);
  }
}
