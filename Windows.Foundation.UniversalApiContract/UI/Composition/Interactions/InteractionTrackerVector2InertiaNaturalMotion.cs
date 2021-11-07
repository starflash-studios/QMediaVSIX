// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerVector2InertiaNaturalMotion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>A Vector2NaturalMotionAnimation that defines motion of InteractionTracker during its inertia state.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IInteractionTrackerVector2InertiaNaturalMotionStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class InteractionTrackerVector2InertiaNaturalMotion : 
    InteractionTrackerVector2InertiaModifier,
    IInteractionTrackerVector2InertiaNaturalMotion
  {
    /// <summary>Gets or sets an ExpressionAnimation describing when the modifier should be applied.</summary>
    /// <returns>An ExpressionAnimation describing when the modifier should be applied.</returns>
    public extern ExpressionAnimation Condition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or set a Vector2NaturalMotionAnimation that describes the modified motion for InteractionTracker if the expression in the Condition property is **true**.</summary>
    /// <returns>A Vector2NaturalMotionAnimation that describes the modified motion for InteractionTracker if the expression in the Condition property is **true**.</returns>
    public extern Vector2NaturalMotionAnimation NaturalMotion { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates an instance of InteractionTrackerVector2InertiaNaturalMotion.</summary>
    /// <param name="compositor">The compositor to use when creating the InteractionTrackerInertiaNaturalMotion object.</param>
    /// <returns>Returns the created InteractionTrackerInertiaNaturalMotion object.</returns>
    [MethodImpl]
    public static extern InteractionTrackerVector2InertiaNaturalMotion Create(
      Compositor compositor);
  }
}
