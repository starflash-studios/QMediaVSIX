// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Vector2NaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>The base Vector2 NaturalMotionAnimation used to target a Vector2 property.</summary>
  [DualApiPartition(version = 167772164)]
  [Composable(typeof (IVector2NaturalMotionAnimationFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public class Vector2NaturalMotionAnimation : NaturalMotionAnimation, IVector2NaturalMotionAnimation
  {
    /// <summary>Gets or sets a value that indicates where the animation ends.</summary>
    /// <returns>A value that indicates where the animation ends. The default is **null**. If left **null**, the ending value of the property being animated is used.</returns>
    public extern IReference<Vector2> FinalValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates where the animation starts.</summary>
    /// <returns>A value that indicates where the animation starts. The default is **null**. If left **null**, the beginning value of the property being animated is used.</returns>
    public extern IReference<Vector2> InitialValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the velocity that the animation starts with.</summary>
    /// <returns>The velocity that the animation starts with. The default is 0.</returns>
    public extern Vector2 InitialVelocity { [MethodImpl] get; [MethodImpl] set; }
  }
}
