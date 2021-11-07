// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionMaskBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Paints a SpriteVisual with a CompositionBrush with an opacity mask applied to it. The source of the opacity mask can be any CompositionBrush of type CompositionColorBrush, CompositionLinearGradientBrush, CompositionSurfaceBrush, CompositionEffectBrush or a CompositionNineGridBrush. The opacity mask must be specified as a CompositionSurfaceBrush.</summary>
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositionMaskBrush : CompositionBrush, ICompositionMaskBrush
  {
    /// <summary>A brush that contains the opacity mask with which the Source brush's content is to be masked. Can be of type CompositionSurfaceBrush or CompositionNineGridBrush.</summary>
    /// <returns>A brush that contains the opacity mask with which the Source brush's content is to be masked. Can be of type CompositionSurfaceBrush or CompositionNineGridBrush.</returns>
    public extern CompositionBrush Mask { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A brush whose content is to be masked by the opacity mask. Can be of type CompositionSurfaceBrush, CompositionColorBrush, or CompositionNineGridBrush.</summary>
    /// <returns>A brush whose content is to be masked by the opacity mask. Can be of type CompositionSurfaceBrush, CompositionColorBrush, or CompositionNineGridBrush.</returns>
    public extern CompositionBrush Source { [MethodImpl] get; [MethodImpl] set; }
  }
}
