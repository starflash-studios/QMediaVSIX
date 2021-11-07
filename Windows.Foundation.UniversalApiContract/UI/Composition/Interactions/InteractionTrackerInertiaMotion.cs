// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>An ExpressionAnimation that defines motion of InteractionTracker during its inertia state.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IInteractionTrackerInertiaMotionStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class InteractionTrackerInertiaMotion : 
    InteractionTrackerInertiaModifier,
    IInteractionTrackerInertiaMotion
  {
    /// <summary>An ExpressionAnimation describing when the modifier should be applied.</summary>
    /// <returns>An ExpressionAnimation describing when the modifier should be applied.</returns>
    public extern ExpressionAnimation Condition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>An ExpressionAnimation describing the modified motion for InteractionTracker if the expression in the Condition property is true.</summary>
    /// <returns>An ExpressionAnimation describing the modified motion for InteractionTracker if the expression in the Condition property is true.</returns>
    public extern ExpressionAnimation Motion { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates an instance of InteractionTrackerInertiaMotion.</summary>
    /// <param name="compositor">The compositor to use when creating the InteractionTrackerInertiaMotion object.</param>
    /// <returns>Returns the created InteractionTrackerInertiaMotion object.</returns>
    [MethodImpl]
    public static extern InteractionTrackerInertiaMotion Create(
      Compositor compositor);
  }
}
