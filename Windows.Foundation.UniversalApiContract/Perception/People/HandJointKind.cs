// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.HandJointKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.People
{
  /// <summary>Specifies a joint within the user's hand.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum HandJointKind
  {
    /// <summary>The center of the palm.</summary>
    Palm,
    /// <summary>The center of the wrist.</summary>
    Wrist,
    /// <summary>The joint in the base of the hand that poses the thumb's metacarpal bone.</summary>
    ThumbMetacarpal,
    /// <summary>The first knuckle that poses the thumb's proximal phalanx.</summary>
    ThumbProximal,
    /// <summary>The second knuckle that poses the thumb's distal phalanx.</summary>
    ThumbDistal,
    /// <summary>The point on the surface of the thumb at the tip.</summary>
    ThumbTip,
    /// <summary>The joint in the base of the hand that poses the index finger's metacarpal bone.</summary>
    IndexMetacarpal,
    /// <summary>The first knuckle that poses the index finger's proximal phalanx.</summary>
    IndexProximal,
    /// <summary>The second knuckle that poses the index finger's intermediate phalanx.</summary>
    IndexIntermediate,
    /// <summary>The third knuckle that poses the index finger's distal phalanx.</summary>
    IndexDistal,
    /// <summary>The point on the surface of the index finger at the tip.</summary>
    IndexTip,
    /// <summary>The joint in the base of the hand that poses the middle finger's metacarpal bone.</summary>
    MiddleMetacarpal,
    /// <summary>The first knuckle that poses the middle finger's proximal phalanx.</summary>
    MiddleProximal,
    /// <summary>The second knuckle that poses the middle finger's intermediate phalanx.</summary>
    MiddleIntermediate,
    /// <summary>The third knuckle that poses the middle finger's distal phalanx.</summary>
    MiddleDistal,
    /// <summary>The point on the surface of the middle finger at the tip.</summary>
    MiddleTip,
    /// <summary>The joint in the base of hand that poses the ring finger's metacarpal bone.</summary>
    RingMetacarpal,
    /// <summary>The first knuckle that poses the ring finger's proximal phalanx.</summary>
    RingProximal,
    /// <summary>The second knuckle that poses the ring finger's intermediate phalanx.</summary>
    RingIntermediate,
    /// <summary>The third knuckle that poses the ring finger's distal phalanx.</summary>
    RingDistal,
    /// <summary>The point on the surface of the ring finger at the tip.</summary>
    RingTip,
    /// <summary>The joint in the base of hand that poses the little finger's (pinky's) metacarpal bone.</summary>
    LittleMetacarpal,
    /// <summary>The first knuckle that poses the little finger's (pinky's) proximal phalanx.</summary>
    LittleProximal,
    /// <summary>The second knuckle that poses the little finger's (pinky's) intermediate phalanx.</summary>
    LittleIntermediate,
    /// <summary>The third knuckle that poses the little finger's (pinky's) distal phalanx.</summary>
    LittleDistal,
    /// <summary>The point on the surface of the little finger's (pinky's) at the tip.</summary>
    LittleTip,
  }
}
