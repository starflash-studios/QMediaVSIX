// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.StackPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Arranges child elements into a single line that can be oriented horizontally or vertically.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IStackPanelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IStackPanelStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Composable(typeof (IStackPanelFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IStackPanelStatics4), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStackPanelStatics5), 458752, "Windows.Foundation.UniversalApiContract")]
  public class StackPanel : 
    Panel,
    IStackPanel,
    IStackPanel2,
    IStackPanel4,
    IStackPanel5,
    IScrollSnapPointsInfo,
    IInsertionPanel
  {
    /// <summary>Initializes a new instance of the StackPanel class.</summary>
    [MethodImpl]
    public extern StackPanel();

    /// <summary>Gets or sets a value that indicates whether the generated snap points used for panning in the StackPanel are equidistant from each other.</summary>
    /// <returns>**true** if the snap points in the StackPanel are equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreScrollSnapPointsRegular { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the dimension by which child elements are stacked.</summary>
    /// <returns>One of the enumeration values that specifies the orientation of child elements. The default is **Vertical**.</returns>
    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that describes the border fill of the panel.</summary>
    /// <returns>The brush that is used to fill the panel's border. The default is **null**, (a null brush) which is evaluated as Transparent for rendering.</returns>
    public extern Brush BorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the border thickness of the panel.</summary>
    /// <returns>The border thickness of the panel, as a Thickness value.</returns>
    public extern Thickness BorderThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the radius for the corners of the panel's border.</summary>
    /// <returns>The degree to which the corners are rounded, expressed as values of the CornerRadius structure.</returns>
    public extern CornerRadius CornerRadius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance between the border and its child object.</summary>
    /// <returns>The dimensions of the space between the border and its child as a Thickness value. Thickness is a structure that stores dimension values using pixel measures.</returns>
    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a uniform distance (in pixels) between stacked items. It is applied in the direction of the StackPanel's Orientation.</summary>
    /// <returns>The uniform distance (in pixels) between stacked items.</returns>
    public extern double Spacing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how far the background extends in relation to this element's border.</summary>
    /// <returns>A value of the enumeration that indicates how far the background extends. The default is **InnerBorderEdge**.</returns>
    public extern BackgroundSizing BackgroundSizing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the horizontal snap points for the StackPanel are equidistant from each other.</summary>
    /// <returns>**true** if the horizontal snap points for the StackPanel are equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreHorizontalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the vertical snap points for the StackPanel are equidistant from each other.</summary>
    /// <returns>**true** if the vertical snap points for the StackPanel are equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreVerticalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>Occurs when the measurements for horizontal snap points change.</summary>
    public extern event EventHandler<object> HorizontalSnapPointsChanged;

    /// <summary>Occurs when the measurements for vertical snap points change.</summary>
    public extern event EventHandler<object> VerticalSnapPointsChanged;

    /// <summary>Returns the set of distances between irregular snap points for a specified orientation and alignment.</summary>
    /// <param name="orientation">The orientation (dimension) for the desired snap point set.</param>
    /// <param name="alignment">The alignment to use when applying the snap points.</param>
    /// <returns>The read only collection of snap point distances. Returns an empty collection when no snap points are present.</returns>
    [MethodImpl]
    public extern IVectorView<float> GetIrregularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment);

    /// <summary>Gets the distance between regular snap points for a specified orientation and alignment.</summary>
    /// <param name="orientation">The orientation/dimension for the desired snap point set.</param>
    /// <param name="alignment">The alignment to use when applying the snap points.</param>
    /// <param name="offset">Out parameter. The offset of the first snap point.</param>
    /// <returns>The distance between the equidistant snap points. Returns 0 when no snap points are present.</returns>
    [MethodImpl]
    public extern float GetRegularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment,
      out float offset);

    /// <summary>Returns the index values of the items that the specified point is between.</summary>
    /// <param name="position">The point for which to get insertion indexes.</param>
    /// <param name="first">The index of the item before the specified point.</param>
    /// <param name="second">The index of the item after the specified point.</param>
    [MethodImpl]
    public extern void GetInsertionIndexes(Point position, out int first, out int second);

    /// <summary>Identifies the BackgroundSizing dependency property.</summary>
    /// <returns>The identifier for the BackgroundSizing dependency property.</returns>
    public static extern DependencyProperty BackgroundSizingProperty { [MethodImpl] get; }

    /// <summary>Identifies the Spacing dependency property.</summary>
    /// <returns>The identifier for the Spacing dependency property.</returns>
    public static extern DependencyProperty SpacingProperty { [MethodImpl] get; }

    /// <summary>Identifies the BorderBrush dependency property.</summary>
    /// <returns>The identifier for the BorderBrush dependency property.</returns>
    public static extern DependencyProperty BorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the BorderThickness dependency property.</summary>
    /// <returns>The identifier for the BorderThickness dependency property.</returns>
    public static extern DependencyProperty BorderThicknessProperty { [MethodImpl] get; }

    /// <summary>Identifies the CornerRadius dependency property.</summary>
    /// <returns>The identifier for the CornerRadius dependency property.</returns>
    public static extern DependencyProperty CornerRadiusProperty { [MethodImpl] get; }

    /// <summary>Identifies the Padding dependency property.</summary>
    /// <returns>The identifier for the Padding dependency property.</returns>
    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    /// <summary>Identifies the AreScrollSnapPointsRegular dependency property.</summary>
    /// <returns>The identifier for the AreScrollSnapPointsRegular dependency property.</returns>
    public static extern DependencyProperty AreScrollSnapPointsRegularProperty { [MethodImpl] get; }

    /// <summary>Identifies the Orientation  dependency property.</summary>
    /// <returns>The identifier for the Orientation  dependency property.</returns>
    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }
  }
}
