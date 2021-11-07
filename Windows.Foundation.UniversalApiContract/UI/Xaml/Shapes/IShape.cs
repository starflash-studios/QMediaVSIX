// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IShape
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Shape))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2020551541, 39584, 17741, 174, 6, 162, 70, 110, 55, 200, 50)]
  internal interface IShape
  {
    Brush Fill { get; set; }

    Brush Stroke { get; set; }

    double StrokeMiterLimit { get; set; }

    double StrokeThickness { get; set; }

    PenLineCap StrokeStartLineCap { get; set; }

    PenLineCap StrokeEndLineCap { get; set; }

    PenLineJoin StrokeLineJoin { get; set; }

    double StrokeDashOffset { get; set; }

    PenLineCap StrokeDashCap { get; set; }

    DoubleCollection StrokeDashArray { get; set; }

    Stretch Stretch { get; set; }

    Transform GeometryTransform { get; }
  }
}
