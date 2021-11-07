// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.NaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents a physics-based animation that uses forces to dynamically move content.</summary>
  [Composable(typeof (INaturalMotionAnimationFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  public class NaturalMotionAnimation : CompositionAnimation, INaturalMotionAnimation
  {
    /// <summary>The delay behavior of the NaturalMotionAnimation.</summary>
    /// <returns>The delay behavior of the NaturalMotionAnimation.</returns>
    public extern AnimationDelayBehavior DelayBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Delay before the animation starts after CompositionObject.StartAnimation is called.</summary>
    /// <returns>Delay before the animation starts after CompositionObject.StartAnimation is called.</returns>
    public extern TimeSpan DelayTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies how to set the property value when StopAnimation is called.</summary>
    /// <returns>Specifies how to set the property value when StopAnimation is called.</returns>
    public extern AnimationStopBehavior StopBehavior { [MethodImpl] get; [MethodImpl] set; }
  }
}
