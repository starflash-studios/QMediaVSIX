// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerInertiaNaturalMotion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>A ScalarNaturalMotionAnimation that defines motion of InteractionTracker during its inertia state.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [Static(typeof (IInteractionTrackerInertiaNaturalMotionStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class InteractionTrackerInertiaNaturalMotion : 
    InteractionTrackerInertiaModifier,
    IInteractionTrackerInertiaNaturalMotion
  {
    /// <summary>Gets or sets an ExpressionAnimation describing when the modifier should be applied.</summary>
    /// <returns>An ExpressionAnimation describing when the modifier should be applied.</returns>
    public extern ExpressionAnimation Condition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or set a ScalarNaturalMotionAnimation that describes the modified motion for InteractionTracker if the expression in the Condition property is **true**.</summary>
    /// <returns>A ScalarNaturalMotionAnimation that describes the modified motion for InteractionTracker if the expression in the Condition property is **true**.</returns>
    public extern ScalarNaturalMotionAnimation NaturalMotion { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates an instance of InteractionTrackerInertiaNaturalMotion.</summary>
    /// <param name="compositor">The compositor to use when creating the InteractionTrackerInertiaNaturalMotion object.</param>
    /// <returns>Returns the created InteractionTrackerInertiaNaturalMotion object.</returns>
    [MethodImpl]
    public static extern InteractionTrackerInertiaNaturalMotion Create(
      Compositor compositor);
  }
}
