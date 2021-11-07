// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionEffectBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Paints a SpriteVisual with the output of a filter effect. The filter effect description is defined using the  CompositionEffectFactory class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositionEffectBrush : CompositionBrush, ICompositionEffectBrush
  {
    /// <summary>Retrieves a CompositionBrush associated with a given CompositionEffectSourceParameter name.</summary>
    /// <param name="name">The name of the input.</param>
    /// <returns>Returns the specified input.</returns>
    [MethodImpl]
    public extern CompositionBrush GetSourceParameter(string name);

    /// <summary>Associates a name declared using CompositionEffectSourceParameter to an effect source.</summary>
    /// <param name="name">The name of the source parameter.</param>
    /// <param name="source">The source to pass to the effect.</param>
    [MethodImpl]
    public extern void SetSourceParameter(string name, CompositionBrush source);
  }
}
