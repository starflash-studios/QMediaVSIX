// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Vector3NaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>The base Vector3 NaturalMotionAnimation used to target a Vector3 property.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Composable(typeof (IVector3NaturalMotionAnimationFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  public class Vector3NaturalMotionAnimation : NaturalMotionAnimation, IVector3NaturalMotionAnimation
  {
    /// <summary>Gets or sets a value that indicates where the animation ends.</summary>
    /// <returns>A value that indicates where the animation ends. The default is **null**. If left **null**, the ending value of the property being animated is used.</returns>
    public extern IReference<Vector3> FinalValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates where the animation starts.</summary>
    /// <returns>A value that indicates where the animation starts. The default is **null**. If left **null**, the beginning value of the property being animated is used.</returns>
    public extern IReference<Vector3> InitialValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the velocity that the animation starts with.</summary>
    /// <returns>The velocity that the animation starts with. The default is 0.</returns>
    public extern Vector3 InitialVelocity { [MethodImpl] get; [MethodImpl] set; }
  }
}
