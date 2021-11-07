// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkDrawingAttributes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  /// <summary>Provides properties associated with the drawing of an InkStroke.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IInkDrawingAttributesStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class InkDrawingAttributes : 
    IInkDrawingAttributes,
    IInkDrawingAttributes2,
    IInkDrawingAttributes3,
    IInkDrawingAttributes4,
    IInkDrawingAttributes5
  {
    /// <summary>Creates a new InkDrawingAttributes object that is used to specify InkStroke attributes.</summary>
    [MethodImpl]
    public extern InkDrawingAttributes();

    /// <summary>Gets or sets a value that indicates the color of an InkStroke.</summary>
    /// <returns>The ink color as an ARGB value. The default is black (0, 0, 0, 0).</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the shape of the pen tip when you draw an InkStroke.</summary>
    /// <returns>The shape of the pen/stylus tip. The default is Circle.</returns>
    public extern PenTipShape PenTip { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the dimensions of the pen tip (PenTip ) used to draw an InkStroke.</summary>
    /// <returns>The Width and Height of the pen tip in . The default value for each is 2.The shape of the PenTip can be specified as a Rectangle or a Circle.</returns>
    public extern Size Size { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the pressure of the contact on the digitizer surface is ignored when you draw an InkStroke.</summary>
    /// <returns>**true** if pressure is ignored; otherwise **false**. The default value is **false**.</returns>
    public extern bool IgnorePressure { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a Bezier curve or a collection of straight line segments is used to draw an InkStroke.</summary>
    /// <returns>**true** if a Bezier curve is used; otherwise **false**. The default value is **true**.</returns>
    public extern bool FitToCurve { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an affine transformation matrix applied to the PenTipShape used for an InkStroke.</summary>
    /// <returns>The 2-D affine transformation matrix. The default is the identity matrix.</returns>
    public extern Matrix3x2 PenTipTransform { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the InkStroke is rendered as a highlighter overlay. The stroke is typically set to a bright color, such as yellow.</summary>
    /// <returns>**true** to render the stroke as a highlighter; otherwise **false**. The default value is **false**.</returns>
    public extern bool DrawAsHighlighter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the InkDrawingAttributes that describe the characteristics of a specific type of InkStroke.</summary>
    /// <returns>The attributes associated with the InkStroke.</returns>
    public extern InkDrawingAttributesKind Kind { [MethodImpl] get; }

    /// <summary>Gets an instance of an InkDrawingAttributesPencilProperties object for setting properties characteristic to a pencil stroke.</summary>
    /// <returns>An InkDrawingAttributesPencilProperties used to set pencil stroke properties.</returns>
    public extern InkDrawingAttributesPencilProperties PencilProperties { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the tilt (tiltx, tilty ) of the contact on the digitizer surface is ignored when you draw an InkStroke.</summary>
    /// <returns>**true** if tilt is ignored; otherwise **false**. The default value is **false**.</returns>
    public extern bool IgnoreTilt { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an instance of a ModelerAttributes object for accessing modeler properties of an ink stroke.</summary>
    /// <returns>A ModelerAttributes object used to process ink stroke rendering properties.</returns>
    public extern InkModelerAttributes ModelerAttributes { [MethodImpl] get; }

    /// <summary>Creates an InkDrawingAttributes object for rendering an ink stroke with pencil characteristics.</summary>
    /// <returns>An InkDrawingAttributes object that supports the following properties:</returns>
    [MethodImpl]
    public static extern InkDrawingAttributes CreateForPencil();
  }
}
