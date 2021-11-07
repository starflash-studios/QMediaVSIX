// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.SpriteVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Hosts 2D boxed content of type CompositionBrush. Any part of the visual not covered by pixels from the brush are rendered as transparent pixels. CompositionBrush can be either a CompositionBackdropBrush, CompositionColorBrush, a CompositionSurfaceBrush or a CompositionEffectBrush.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpriteVisual : ContainerVisual, ISpriteVisual, ISpriteVisual2
  {
    /// <summary>A CompositionBrush describing how the SpriteVisual is painted.</summary>
    /// <returns>A CompositionBrush describing how the SpriteVisual is painted.</returns>
    public extern CompositionBrush Brush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The shadow for the SpriteVisual.</summary>
    /// <returns>The shadow for the SpriteVisual.</returns>
    public extern CompositionShadow Shadow { [MethodImpl] get; [MethodImpl] set; }
  }
}
