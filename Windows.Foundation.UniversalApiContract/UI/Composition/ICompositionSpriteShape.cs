// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionSpriteShape
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(1075536315, 7, 17251, 177, 243, 107, 204, 0, 63, 184, 62)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (CompositionSpriteShape))]
  internal interface ICompositionSpriteShape
  {
    CompositionBrush FillBrush { get; set; }

    CompositionGeometry Geometry { get; set; }

    bool IsStrokeNonScaling { get; set; }

    CompositionBrush StrokeBrush { get; set; }

    CompositionStrokeDashArray StrokeDashArray { get; }

    CompositionStrokeCap StrokeDashCap { get; set; }

    float StrokeDashOffset { get; set; }

    CompositionStrokeCap StrokeEndCap { get; set; }

    CompositionStrokeLineJoin StrokeLineJoin { get; set; }

    float StrokeMiterLimit { get; set; }

    CompositionStrokeCap StrokeStartCap { get; set; }

    float StrokeThickness { get; set; }
  }
}
