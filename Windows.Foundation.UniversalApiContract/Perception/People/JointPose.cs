// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.JointPose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.People
{
  /// <summary>The pose of a hand joint.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public struct JointPose
  {
    /// <summary>The joint's orientation, with forward (-z) pointing towards the tip of each finger, up (+y) pointing out of the back of the hand or finger, and right (+x) pointing perpendicular to forward and up.</summary>
    public Quaternion Orientation;
    /// <summary>The joint's position.  All joints except for tip joints are interior to the hand.  Finger joint poses represent the base of the named bone.</summary>
    public Vector3 Position;
    /// <summary>The distance from the joint position to the surface of the hand.</summary>
    public float Radius;
    /// <summary>The accuracy of this joint pose.</summary>
    public JointPoseAccuracy Accuracy;
  }
}
