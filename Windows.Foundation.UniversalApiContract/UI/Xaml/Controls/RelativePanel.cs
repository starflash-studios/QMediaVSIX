// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RelativePanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines an area within which you can position and align child objects in relation to each other or the parent panel.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IRelativePanelStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IRelativePanelFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRelativePanelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class RelativePanel : Panel, IRelativePanel, IRelativePanel2
  {
    /// <summary>Initializes a new instance of the RelativePanel class.</summary>
    [MethodImpl]
    public extern RelativePanel();

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

    /// <summary>Gets or sets a value that indicates how far the background extends in relation to this element's border.</summary>
    /// <returns>A value of the enumeration that indicates how far the background extends. The default is **InnerBorderEdge**.</returns>
    public extern BackgroundSizing BackgroundSizing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the BackgroundSizing dependency property.</summary>
    /// <returns>The identifier for the BackgroundSizing dependency property.</returns>
    public static extern DependencyProperty BackgroundSizingProperty { [MethodImpl] get; }

    /// <summary>Identifies the RelativePanel.LeftOf XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.LeftOf XAML attached property.</returns>
    public static extern DependencyProperty LeftOfProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.LeftOf XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.LeftOf XAML attached property value of the specified object. (The element to position this element to the left of.)</returns>
    [MethodImpl]
    public static extern object GetLeftOf(UIElement element);

    /// <summary>Sets the value of the RelativePanel.LeftOf XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (The element to position this element to the left of.)</param>
    [MethodImpl]
    public static extern void SetLeftOf(UIElement element, object value);

    /// <summary>Identifies the RelativePanel.Above XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.Above XAML attached property.</returns>
    public static extern DependencyProperty AboveProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.Above XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.Above XAML attached property value of the specified object. (The element to position this element above.)</returns>
    [MethodImpl]
    public static extern object GetAbove(UIElement element);

    /// <summary>Sets the value of the RelativePanel.Above XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (The element to position this element above.)</param>
    [MethodImpl]
    public static extern void SetAbove(UIElement element, object value);

    /// <summary>Identifies the RelativePanel.RightOf XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.RightOf XAML attached property.</returns>
    public static extern DependencyProperty RightOfProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.RightOf XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.RightOf XAML attached property value of the specified object. (The element to position this element to the right of.)</returns>
    [MethodImpl]
    public static extern object GetRightOf(UIElement element);

    /// <summary>Sets the value of the RelativePanel.RightOf XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (The element to position this element to the right of.)</param>
    [MethodImpl]
    public static extern void SetRightOf(UIElement element, object value);

    /// <summary>Identifies the RelativePanel.Below XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.Below XAML attached property.</returns>
    public static extern DependencyProperty BelowProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.Below XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.Below XAML attached property value of the specified object. (The element to position this element below.)</returns>
    [MethodImpl]
    public static extern object GetBelow(UIElement element);

    /// <summary>Sets the value of the RelativePanel.Below XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (The element to position this element below.)</param>
    [MethodImpl]
    public static extern void SetBelow(UIElement element, object value);

    /// <summary>Gets the value of the RelativePanel.AlignHorizontalCenterWith XAML attached property for the target element.</summary>
    /// <returns>The identifier for the RelativePanel.AlignHorizontalCenterWith XAML attached property.</returns>
    public static extern DependencyProperty AlignHorizontalCenterWithProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignHorizontalCenterWith XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignHorizontalCenterWith XAML attached property value of the specified object. (The element to align this element's horizontal center with.)</returns>
    [MethodImpl]
    public static extern object GetAlignHorizontalCenterWith(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignHorizontalCenterWith XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (The element to align this element's horizontal center with.)</param>
    [MethodImpl]
    public static extern void SetAlignHorizontalCenterWith(UIElement element, object value);

    /// <summary>Gets the value of the RelativePanel.AlignVerticalCenterWith XAML attached property for the target element.</summary>
    /// <returns>The identifier for the RelativePanel.AlignVerticalCenterWith XAML attached property.</returns>
    public static extern DependencyProperty AlignVerticalCenterWithProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignVerticalCenterWith XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignVerticalCenterWith XAML attached property value of the specified object. (The element to align this element's vertical center with.)</returns>
    [MethodImpl]
    public static extern object GetAlignVerticalCenterWith(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignVerticalCenterWith XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (The element to align this element's horizontal center with.)</param>
    [MethodImpl]
    public static extern void SetAlignVerticalCenterWith(UIElement element, object value);

    /// <summary>Identifies the RelativePanel.AlignLeftWith XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.AlignLeftWith XAML attached property.</returns>
    public static extern DependencyProperty AlignLeftWithProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignLeftWith XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignLeftWith XAML attached property value of the specified object. (The element to align this element's left edge with.)</returns>
    [MethodImpl]
    public static extern object GetAlignLeftWith(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignLeftWith XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (The element to align this element's left edge with.)</param>
    [MethodImpl]
    public static extern void SetAlignLeftWith(UIElement element, object value);

    /// <summary>Identifies the RelativePanel.AlignTopWith XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.AlignTopWith XAML attached property.</returns>
    public static extern DependencyProperty AlignTopWithProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignTopWith XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignTopWith XAML attached property value of the specified object. (The element to align this element's top edge with.)</returns>
    [MethodImpl]
    public static extern object GetAlignTopWith(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignTopWith XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (The element to align this element's top edge with.)</param>
    [MethodImpl]
    public static extern void SetAlignTopWith(UIElement element, object value);

    /// <summary>Identifies the RelativePanel.AlignRightWith XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.AlignRightWith XAML attached property.</returns>
    public static extern DependencyProperty AlignRightWithProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignRightWith XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignRightWith XAML attached property value of the specified object. (The element to align this element's right edge with.)</returns>
    [MethodImpl]
    public static extern object GetAlignRightWith(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignRightWith XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (The element to align this element's right edge with.)</param>
    [MethodImpl]
    public static extern void SetAlignRightWith(UIElement element, object value);

    /// <summary>Identifies the RelativePanel.AlignBottomWith XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.AlignBottomWith XAML attached property.</returns>
    public static extern DependencyProperty AlignBottomWithProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignBottomWith XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignBottomWith XAML attached property value of the specified object. (The element to align this element's bottom edge with.)</returns>
    [MethodImpl]
    public static extern object GetAlignBottomWith(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignBottomWith XAML attached property for the target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (The element to align this element's bottom edge with.)</param>
    [MethodImpl]
    public static extern void SetAlignBottomWith(UIElement element, object value);

    /// <summary>Identifies the RelativePanel.AlignLeftWithPanel XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.AlignLeftWithPanel XAML attached property.</returns>
    public static extern DependencyProperty AlignLeftWithPanelProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignLeftWithPanel XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignLeftWithPanel XAML attached property value of the specified object. (**true** to align this element's left edge with the panel's left edge; otherwise, **false**.)</returns>
    [MethodImpl]
    public static extern bool GetAlignLeftWithPanel(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignLeftWithPanel XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (**true** to align this element's left edge with the panel's left edge; otherwise, **false**.)</param>
    [MethodImpl]
    public static extern void SetAlignLeftWithPanel(UIElement element, bool value);

    /// <summary>Identifies the RelativePanel.AlignTopWithPanel XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.AlignTopWithPanel XAML attached property.</returns>
    public static extern DependencyProperty AlignTopWithPanelProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignTopWithPanel XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignTopWithPanel XAML attached property value of the specified object. (**true** to align this element's top edge with the panel's top edge; otherwise, **false**.)</returns>
    [MethodImpl]
    public static extern bool GetAlignTopWithPanel(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignTopWithPanel XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (**true** to align this element's top edge with the panel's top edge; otherwise, **false**.)</param>
    [MethodImpl]
    public static extern void SetAlignTopWithPanel(UIElement element, bool value);

    /// <summary>Identifies the RelativePanel.AlignRightWithPanel XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.AlignRightWithPanel XAML attached property.</returns>
    public static extern DependencyProperty AlignRightWithPanelProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignRightWithPanel XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignRightWithPanel XAML attached property value of the specified object. (**true** to align this element's right edge with the panel's right edge; otherwise, **false**.)</returns>
    [MethodImpl]
    public static extern bool GetAlignRightWithPanel(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignRightWithPanel XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (**true** to align this element's right edge with the panel's right edge; otherwise, **false**.)</param>
    [MethodImpl]
    public static extern void SetAlignRightWithPanel(UIElement element, bool value);

    /// <summary>Identifies the RelativePanel.AlignBottomWithPanel XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.AlignBottomWithPanel XAML attached property.</returns>
    public static extern DependencyProperty AlignBottomWithPanelProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignBottomWithPanel XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignBottomWithPanel XAML attached property value of the specified object. (**true** to align this element's bottom edge with the panel's bottom edge; otherwise, **false**.)</returns>
    [MethodImpl]
    public static extern bool GetAlignBottomWithPanel(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignBottomWithPanel XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (**true** to align this element's bottom edge with the panel's bottom edge; otherwise, **false**.)</param>
    [MethodImpl]
    public static extern void SetAlignBottomWithPanel(UIElement element, bool value);

    /// <summary>Identifies the RelativePanel.AlignHorizontalCenterWithPanel XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.AlignHorizontalCenterWithPanel XAML attached property.</returns>
    public static extern DependencyProperty AlignHorizontalCenterWithPanelProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignHorizontalCenterWithPanel XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignHorizontalCenterWithPanel XAML attached property value of the specified object. (**true** to horizontally center this element in the panel; otherwise, **false**.)</returns>
    [MethodImpl]
    public static extern bool GetAlignHorizontalCenterWithPanel(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignHorizontalCenterWithPanel XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (**true** to horizontally center this element in the panel; otherwise, **false**.)</param>
    [MethodImpl]
    public static extern void SetAlignHorizontalCenterWithPanel(UIElement element, bool value);

    /// <summary>Identifies the RelativePanel.AlignVerticalCenterWithPanel XAML attached property.</summary>
    /// <returns>The identifier for the RelativePanel.AlignVerticalCenterWithPanel XAML attached property.</returns>
    public static extern DependencyProperty AlignVerticalCenterWithPanelProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the RelativePanel.AlignVerticalCenterWithPanel XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RelativePanel.AlignVerticalCenterWithPanel XAML attached property value of the specified object. (**true** to vertically center this element in the panel; otherwise, **false**.)</returns>
    [MethodImpl]
    public static extern bool GetAlignVerticalCenterWithPanel(UIElement element);

    /// <summary>Sets the value of the RelativePanel.AlignVerticalCenterWithPanel XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set. (**true** to vertically center this element in the panel; otherwise, **false**.)</param>
    [MethodImpl]
    public static extern void SetAlignVerticalCenterWithPanel(UIElement element, bool value);

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
  }
}
