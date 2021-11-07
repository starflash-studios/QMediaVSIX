// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>An ExpressionAnimation that defines the rest position after an interaction.</summary>
  [DualApiPartition(version = 167772164)]
  [Static(typeof (IInteractionTrackerInertiaRestingValueStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class InteractionTrackerInertiaRestingValue : 
    InteractionTrackerInertiaModifier,
    IInteractionTrackerInertiaRestingValue
  {
    /// <summary>An ExpressionAnimation describing when the modifier should be applied.</summary>
    /// <returns>An ExpressionAnimation describing when the modifier should be applied.</returns>
    public extern ExpressionAnimation Condition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>An ExpressionAnimation to define the resting value of InteractionTracker if the expression in the Condition property is true.</summary>
    /// <returns>An ExpressionAnimation to define the resting value if the expression in the Condition property is true.</returns>
    public extern ExpressionAnimation RestingValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates an instance of InteractionTrackerInertiaRestingValue.</summary>
    /// <param name="compositor">The compositor to use when creating the InteractionTrackerInertiaRestingValue object.</param>
    /// <returns>Returns the created InteractionTrackerInertiaRestingValue object.</returns>
    [MethodImpl]
    public static extern InteractionTrackerInertiaRestingValue Create(
      Compositor compositor);
  }
}
