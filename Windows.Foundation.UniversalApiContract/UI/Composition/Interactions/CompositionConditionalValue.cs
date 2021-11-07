// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.CompositionConditionalValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Allows conditional modification of the position and scale of a visual interaction source.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772164)]
  [Static(typeof (ICompositionConditionalValueStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class CompositionConditionalValue : CompositionObject, ICompositionConditionalValue
  {
    /// <summary>The condition expression that determines when to apply modifiers to the visual interaction source.</summary>
    /// <returns>The condition expression that determines when to apply modifiers to the visual interaction source.</returns>
    public extern ExpressionAnimation Condition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The modified input expression to be applied when the condition is true.</summary>
    /// <returns>The modified input expression to be applied when the condition is true.</returns>
    public extern ExpressionAnimation Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates an instance of CompositionConditionalValue.</summary>
    /// <param name="compositor">
    /// </param>
    /// <returns>Returns the created CompositionConditionalValue.</returns>
    [MethodImpl]
    public static extern CompositionConditionalValue Create(
      Compositor compositor);
  }
}
