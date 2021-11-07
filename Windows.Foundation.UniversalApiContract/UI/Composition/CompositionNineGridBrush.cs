// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionNineGridBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Paints a SpriteVisual with a CompositionBrush after applying Nine-Grid Stretching to the contents of the Source brush. The source of the nine-grid stretch can by any CompositionBrush of type CompositionColorBrush, CompositionSurfaceBrush or a CompositionEffectBrush.</summary>
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositionNineGridBrush : CompositionBrush, ICompositionNineGridBrush
  {
    /// <summary>Inset from the bottom edge of the source content that specifies the thickness of the bottom row. Defaults to 0.0f.</summary>
    /// <returns>Inset from the bottom edge of the source content that specifies the thickness of the bottom row. Defaults to 0.0f.</returns>
    public extern float BottomInset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Scale to be applied to BottomInset. Defaults to 1.0f.</summary>
    /// <returns>Scale to be applied to BottomInset. Defaults to 1.0f.</returns>
    public extern float BottomInsetScale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether the center of the Nine-Grid is drawn.</summary>
    /// <returns>Indicates whether the center of the Nine-Grid is drawn.</returns>
    public extern bool IsCenterHollow { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Inset from the left edge of the source content that specifies the thickness of the left column. Defaults to 0.0f.</summary>
    /// <returns>Inset from the left edge of the source content that specifies the thickness of the left column. Defaults to 0.0f.</returns>
    public extern float LeftInset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Scale to be applied to LeftInset. Defaults to 1.0f.</summary>
    /// <returns>Scale to be applied to LeftInset. Defaults to 1.0f.</returns>
    public extern float LeftInsetScale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Inset from the right edge of the source content that specifies the thickness of the right column. Defaults to 0.0f.</summary>
    /// <returns>Inset from the right edge of the source content that specifies the thickness of the right column. Defaults to 0.0f.</returns>
    public extern float RightInset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Scale to be applied to RightInset. Defaults to 1.0f.</summary>
    /// <returns>Scale to be applied to RightInset. Defaults to 1.0f.</returns>
    public extern float RightInsetScale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The brush whose content is to be Nine-Grid stretched. Can be of type CompositionSurfaceBrush or CompositionColorBrush.</summary>
    /// <returns>The brush whose content is to be scaled using Nine-Grid Scaling. Can be of type CompositionSurfaceBrush or CompositionColorBrush.</returns>
    public extern CompositionBrush Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Inset from the top edge of the source content that specifies the thickness of the top row. Defaults to 0.0f.</summary>
    /// <returns>Inset from the top edge of the source content that specifies the thickness of the top row. Defaults to 0.0f.</returns>
    public extern float TopInset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Scale to be applied to TopInset. Defaults to 1.0f.</summary>
    /// <returns>Scale to be applied to TopInset. Defaults to 1.0f.</returns>
    public extern float TopInsetScale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Sets the insets of a CompositionNineGridBrush using the same value for the top, bottom, left, and right. Defaults to 0.0f.</summary>
    /// <param name="inset">The inset value to use for the top, bottom, left, and right.</param>
    [Overload("SetInsets")]
    [MethodImpl]
    public extern void SetInsets(float inset);

    /// <summary>Sets the insets of a CompositionNineGridBrush using the specified values for the top, bottom, left, and right. Defaults to 0.0f.</summary>
    /// <param name="left">The inset from the left of the image.</param>
    /// <param name="top">The inset from the top of the image.</param>
    /// <param name="right">The inset from the right of the image.</param>
    /// <param name="bottom">The inset from the bottom of the image.</param>
    [Overload("SetInsetsWithValues")]
    [MethodImpl]
    public extern void SetInsets(float left, float top, float right, float bottom);

    /// <summary>Sets the (same) scale to be applied to the left, top, right, and bottom insets. Defaults to 1.0f.</summary>
    /// <param name="scale">The scale for all of the insets.</param>
    [Overload("SetInsetScales")]
    [MethodImpl]
    public extern void SetInsetScales(float scale);

    /// <summary>Sets the scale to be applied to the left, top, right, and bottom insets respectively. Defaults to 1.0f.</summary>
    /// <param name="left">The scale of the left inset.</param>
    /// <param name="top">The scale of the top inset.</param>
    /// <param name="right">The scale of the right inset.</param>
    /// <param name="bottom">The scale of the bottom inset.</param>
    [Overload("SetInsetScalesWithValues")]
    [MethodImpl]
    public extern void SetInsetScales(float left, float top, float right, float bottom);
  }
}
