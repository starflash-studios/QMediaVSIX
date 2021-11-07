// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionSpriteShape
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A CompositionShape that draws Stroked and Filled CompositionGeometry.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772165)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class CompositionSpriteShape : CompositionShape, ICompositionSpriteShape
  {
    /// <summary>Gets or sets the brush that paints the interior area of the shape.</summary>
    /// <returns>A brush that paints/fills the shape interior.</returns>
    public extern CompositionBrush FillBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the geometry that defines this shape.</summary>
    /// <returns>The geometry that defines this shape.</returns>
    public extern CompositionGeometry Geometry { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the shape's outline scales.</summary>
    /// <returns>**true** if the shape's outline does not scale; otherwise, **false**.</returns>
    public extern bool IsStrokeNonScaling { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush that paints the outline of the shape.</summary>
    /// <returns>A brush that paints the shape outline.</returns>
    public extern CompositionBrush StrokeBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of values that indicates the pattern of dashes and gaps used to outline shapes.</summary>
    /// <returns>The collection of values that indicates the pattern of dashes and gaps used to outline shapes.</returns>
    public extern CompositionStrokeDashArray StrokeDashArray { [MethodImpl] get; }

    /// <summary>Gets or sets a CompositionStrokeCap enumeration value that specifies how the ends of a dash are drawn.</summary>
    /// <returns>An enumeration value that specifies how the ends of a dash are drawn. The default is **Flat**.</returns>
    public extern CompositionStrokeCap StrokeDashCap { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the distance within the dash pattern where a dash begins.</summary>
    /// <returns>A value that represents the distance within the dash pattern where a dash begins. The default is 0.</returns>
    public extern float StrokeDashOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a CompositionStrokeCap enumeration value that specifies how the end of a line is drawn.</summary>
    /// <returns>An enumeration value that specifies how the end of a line is drawn. The default is **Flat**.</returns>
    public extern CompositionStrokeCap StrokeEndCap { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a CompositionStrokeLineJoin enumeration value that specifies the type of join used at the vertices of a shape.</summary>
    /// <returns>An enumeration value that specifies  the type of join used at the vertices of a shape. The default is **Miter**.</returns>
    public extern CompositionStrokeLineJoin StrokeLineJoin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a limit on the ratio of the miter length to half the StrokeThickness of a shape element.</summary>
    /// <returns>The limit on the ratio of the miter length to the StrokeThickness of a shape element. This value is always a positive number that is greater than or equal to 1.</returns>
    public extern float StrokeMiterLimit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a CompositionStrokeCap enumeration value that specifies how the start of a line is drawn.</summary>
    /// <returns>An enumeration value that specifies how the start of a line is drawn. The default is **Flat**.</returns>
    public extern CompositionStrokeCap StrokeStartCap { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width of the shape outline.</summary>
    /// <returns>The width of the shape outline, in pixels. The default value is 0.</returns>
    public extern float StrokeThickness { [MethodImpl] get; [MethodImpl] set; }
  }
}
