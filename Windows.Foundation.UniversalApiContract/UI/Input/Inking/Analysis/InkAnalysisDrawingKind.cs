// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.InkAnalysisDrawingKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  /// <summary>Specifies the shapes that an InkAnalyzer can recognize when InkAnalysisNode.Kind is set to InkDrawing.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum InkAnalysisDrawingKind
  {
    /// <summary>Drawing is not recognized as one of the shapes listed.</summary>
    Drawing,
    /// <summary>Drawing is recognized as a circle.</summary>
    Circle,
    /// <summary>Drawing is recognized as an ellipse.</summary>
    Ellipse,
    /// <summary>Drawing is recognized as a triangle.</summary>
    Triangle,
    /// <summary>Drawing is recognized as an isosceles triangle.</summary>
    IsoscelesTriangle,
    /// <summary>Drawing is recognized as an equilateral triangle.</summary>
    EquilateralTriangle,
    /// <summary>Drawing is recognized as a right angle triangle.</summary>
    RightTriangle,
    /// <summary>Drawing is recognized as a quadrilateral.</summary>
    Quadrilateral,
    /// <summary>Drawing is recognized as a right rectangle.</summary>
    Rectangle,
    /// <summary>Drawing is recognized as a square.</summary>
    Square,
    /// <summary>Drawing is recognized as a diamond.</summary>
    Diamond,
    /// <summary>Drawing is recognized as a trapezoid.</summary>
    Trapezoid,
    /// <summary>Drawing is recognized as a parallelogram.</summary>
    Parallelogram,
    /// <summary>Drawing is recognized as a pentagon.</summary>
    Pentagon,
    /// <summary>Drawing is recognized as a hexagon.</summary>
    Hexagon,
  }
}
