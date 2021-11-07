// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Shape
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  /// <summary>Provides a base class for shape elements, such as Ellipse, Polygon, and Rectangle.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IShapeFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IShapeStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class Shape : FrameworkElement, IShape, IShape2
  {
    /// <summary>Provides base class initialization behavior for Shape derived classes.</summary>
    [MethodImpl]
    protected extern Shape();

    /// <summary>Gets or sets the Brush that paints the interior area of the shape.</summary>
    /// <returns>A Brush that paints/fills the shape interior. The default is **null**, (a null brush) which is evaluated as Transparent for rendering.</returns>
    public extern Brush Fill { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Brush that specifies how the Shape outline is painted.</summary>
    /// <returns>A Brush that specifies how the Shape outline is painted. The default is null.</returns>
    public extern Brush Stroke { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a limit on the ratio of the miter length to half the StrokeThickness of a Shape element.</summary>
    /// <returns>The limit on the ratio of the miter length to the StrokeThickness of a Shape element. This value is always a positive number that is greater than or equal to 1.</returns>
    public extern double StrokeMiterLimit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width of the Shape stroke outline.</summary>
    /// <returns>The width of the Shape outline, in pixels. The default value is 0.</returns>
    public extern double StrokeThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a PenLineCap enumeration value that describes the Shape at the start of a Stroke.</summary>
    /// <returns>A value of the PenLineCap enumeration that specifies the shape at the start of a Stroke. The default is **Flat**.</returns>
    public extern PenLineCap StrokeStartLineCap { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a PenLineCap enumeration value that describes the Shape at the end of a line.</summary>
    /// <returns>One of the enumeration values for PenLineCap. The default is **Flat**.</returns>
    public extern PenLineCap StrokeEndLineCap { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a PenLineJoin enumeration value that specifies the type of join that is used at the vertices of a Shape.</summary>
    /// <returns>A value of the PenLineJoin enumeration that specifies the join appearance. The default value is **Miter**.</returns>
    public extern PenLineJoin StrokeLineJoin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the distance within the dash pattern where a dash begins.</summary>
    /// <returns>A value that represents the distance within the dash pattern where a dash begins. The default value is 0.</returns>
    public extern double StrokeDashOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a PenLineCap enumeration value that specifies how the ends of a dash are drawn.</summary>
    /// <returns>One of the enumeration values for PenLineCap. The default is **Flat**.</returns>
    public extern PenLineCap StrokeDashCap { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a collection of Double values that indicates the pattern of dashes and gaps that is used to outline shapes.</summary>
    /// <returns>A collection of Double values that specifies the pattern of dashes and gaps.</returns>
    public extern DoubleCollection StrokeDashArray { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Stretch enumeration value that describes how the shape fills its allocated space.</summary>
    /// <returns>One of the Stretch enumeration values. The default value at run time depends on the type of Shape.</returns>
    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that represents a Transform that is applied to the geometry of a Shape before it is drawn.</summary>
    /// <returns>A Transform that is applied to the geometry of a Shape before it is drawn.</returns>
    public extern Transform GeometryTransform { [MethodImpl] get; }

    /// <summary>Returns a mask that represents the alpha channel of a XAML shape as a CompositionBrush.</summary>
    /// <returns>A mask that represents the alpha channel of a XAML shape.</returns>
    [MethodImpl]
    public extern CompositionBrush GetAlphaMask();

    /// <summary>Identifies the Fill dependency property.</summary>
    /// <returns>The identifier for the Fill dependency property.</returns>
    public static extern DependencyProperty FillProperty { [MethodImpl] get; }

    /// <summary>Identifies the Stroke dependency property.</summary>
    /// <returns>The identifier for the Stroke dependency property.</returns>
    public static extern DependencyProperty StrokeProperty { [MethodImpl] get; }

    /// <summary>Identifies the StrokeMiterLimit dependency property.</summary>
    /// <returns>The identifier for the StrokeMiterLimit dependency property.</returns>
    public static extern DependencyProperty StrokeMiterLimitProperty { [MethodImpl] get; }

    /// <summary>Identifies the StrokeThickness dependency property.</summary>
    /// <returns>The identifier for the StrokeThickness dependency property.</returns>
    public static extern DependencyProperty StrokeThicknessProperty { [MethodImpl] get; }

    /// <summary>Identifies the StrokeStartLineCap dependency property.</summary>
    /// <returns>The identifier for the StrokeStartLineCap dependency property.</returns>
    public static extern DependencyProperty StrokeStartLineCapProperty { [MethodImpl] get; }

    /// <summary>Identifies the StrokeEndLineCap dependency property.</summary>
    /// <returns>The identifier for the StrokeEndLineCap dependency property.</returns>
    public static extern DependencyProperty StrokeEndLineCapProperty { [MethodImpl] get; }

    /// <summary>Identifies the StrokeLineJoin dependency property.</summary>
    /// <returns>The identifier for the StrokeLineJoin dependency property.</returns>
    public static extern DependencyProperty StrokeLineJoinProperty { [MethodImpl] get; }

    /// <summary>Identifies the StrokeDashOffset dependency property.</summary>
    /// <returns>The identifier for the StrokeDashOffset dependency property.</returns>
    public static extern DependencyProperty StrokeDashOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the StrokeDashCap dependency property.</summary>
    /// <returns>The identifier for the StrokeDashCap dependency property.</returns>
    public static extern DependencyProperty StrokeDashCapProperty { [MethodImpl] get; }

    /// <summary>Identifies the StrokeDashArray dependency property.</summary>
    /// <returns>The identifier for the StrokeDashArray dependency property.</returns>
    public static extern DependencyProperty StrokeDashArrayProperty { [MethodImpl] get; }

    /// <summary>Identifies the Stretch dependency property.</summary>
    /// <returns>The identifier for the Stretch dependency property.</returns>
    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }
  }
}
