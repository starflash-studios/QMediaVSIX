// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FrameworkElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml
{
  /// <summary>Provides a base element class for Windows Runtime UI objects. FrameworkElement defines common API that support UI interaction and the automatic layout system. FrameworkElement  also defines API related to data binding, defining and examining the object tree, and tracking object lifetime.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IFrameworkElementStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IFrameworkElementFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFrameworkElementStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IFrameworkElementStatics6), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFrameworkElementStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IFrameworkElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class FrameworkElement : 
    UIElement,
    IFrameworkElement,
    IFrameworkElement2,
    IFrameworkElement3,
    IFrameworkElement4,
    IFrameworkElement6,
    IFrameworkElement7,
    IFrameworkElementProtected7,
    IFrameworkElementOverrides,
    IFrameworkElementOverrides2
  {
    /// <summary>Provides base class initialization behavior for FrameworkElement -derived classes.</summary>
    [MethodImpl]
    protected extern FrameworkElement();

    /// <summary>Gets the collection of triggers for animations that are defined for a FrameworkElement. Not commonly used. See Remarks.</summary>
    /// <returns>The collection of triggers for animations that are defined for this object.</returns>
    public extern TriggerCollection Triggers { [MethodImpl] get; }

    /// <summary>Gets the locally defined resource dictionary. In XAML, you can establish resource items as child object elements of a `frameworkElement.Resources` property element, through XAML implicit collection syntax.</summary>
    /// <returns>The current locally defined dictionary of resources, where each resource can be accessed by its key.</returns>
    public extern ResourceDictionary Resources { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an arbitrary object value that can be used to store custom information about this object.</summary>
    /// <returns>The intended arbitrary object value. This property has no default value.</returns>
    public extern object Tag { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets localization/globalization language information that applies to a FrameworkElement, and also to all child elements of the current FrameworkElement in the object representation and in UI.</summary>
    /// <returns>A string specifying language and culture that follows the Internet Engineering Task Force (IETF)  BCP 47 standards. For example, U.S. English is "en-US".</returns>
    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the rendered width of a FrameworkElement. See Remarks.</summary>
    /// <returns>The width, in pixels, of the object. The default is 0. The default might be encountered if the object has not been loaded and hasn't yet been involved in a layout pass that renders the UI.</returns>
    public extern double ActualWidth { [MethodImpl] get; }

    /// <summary>Gets the rendered height of a FrameworkElement. See Remarks.</summary>
    /// <returns>The height, in pixels, of the object. The default is 0. The default might be encountered if the object has not been loaded and hasn't yet been involved in a layout pass that renders the UI.</returns>
    public extern double ActualHeight { [MethodImpl] get; }

    /// <summary>Gets or sets the width of a FrameworkElement.</summary>
    /// <returns>The width of the object, in pixels. The default is NaN. Except for the special NaN value, this value must be equal to or greater than 0. </returns>
    public extern double Width { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the suggested height of a FrameworkElement.</summary>
    /// <returns>The height, in pixels, of the object. The default is NaN. Except for the special NaN value, this value must be equal to or greater than 0.</returns>
    public extern double Height { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum width constraint of a FrameworkElement.</summary>
    /// <returns>The minimum width of the object, in pixels. The default is 0. This value can be any value equal to or greater than 0. However, PositiveInfinity is not valid.</returns>
    public extern double MinWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum width constraint of a FrameworkElement.</summary>
    /// <returns>The maximum width of the object, in pixels. The default is PositiveInfinity. This value can be any value equal to or greater than 0. PositiveInfinity is also valid.</returns>
    public extern double MaxWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum height constraint of a FrameworkElement.</summary>
    /// <returns>The minimum height of the object, in pixels. The default is 0. This value can be any value equal to or greater than 0. However, PositiveInfinity is not valid.</returns>
    public extern double MinHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum height constraint of a FrameworkElement.</summary>
    /// <returns>The maximum height of the object, in pixels. The default value is PositiveInfinity. This value can be any value equal to or greater than 0. PositiveInfinity is also valid.</returns>
    public extern double MaxHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the horizontal alignment characteristics that are applied to a FrameworkElement when it is composed in a layout parent, such as a panel or items control.</summary>
    /// <returns>A horizontal alignment setting, as a value of the enumeration. The default is **Stretch**.</returns>
    public extern HorizontalAlignment HorizontalAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the vertical alignment characteristics that are applied to a FrameworkElement when it is composed in a parent object such as a panel or items control.</summary>
    /// <returns>A vertical alignment setting, as a value of the enumeration. The default is **Stretch**.</returns>
    public extern VerticalAlignment VerticalAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the outer margin of a FrameworkElement.</summary>
    /// <returns>Provides margin values for the object. The default value is a default Thickness with all properties (dimensions) equal to 0.</returns>
    public extern Thickness Margin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the identifying name of the object. When a XAML processor creates the object tree from XAML markup, run-time code can refer to the XAML-declared object by this name.</summary>
    /// <returns>The name of the object, which must be a string that is valid in the XamlName grammar (see table in x:Name attribute reference). The default is an empty string.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Uniform Resource Identifier (URI) that represents the base Uniform Resource Identifier (URI) for an XAML-constructed object at XAML load time. This property is useful for Uniform Resource Identifier (URI) resolution at run time.</summary>
    /// <returns>The base Uniform Resource Identifier (URI) for an object at XAML load time.</returns>
    public extern Uri BaseUri { [MethodImpl] get; }

    /// <summary>Gets or sets the data context for a FrameworkElement. A common use of a data context is when a **FrameworkElement** uses the {Binding} markup extension and participates in data binding.</summary>
    /// <returns>The object to use as data context.</returns>
    public extern object DataContext { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an instance Style that is applied for this object during layout and rendering.</summary>
    /// <returns>The applied style for the object, if present; otherwise, **null**. The default for a default-constructed FrameworkElement is **null**.</returns>
    public extern Style Style { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the parent object of this FrameworkElement in the object tree.</summary>
    /// <returns>The parent object of this object in the object tree.</returns>
    public extern DependencyObject Parent { [MethodImpl] get; }

    /// <summary>Gets or sets the direction in which text and other UI elements flow within any parent element that controls their layout. This property can be set to either **LeftToRight** or **RightToLeft**. Setting FlowDirection to **RightToLeft** on any element sets the alignment to the right, the reading order to right-to-left and the layout of the control to flow from right to left.</summary>
    /// <returns>The direction that text and other UI elements flow within their parent element, as a value of the enumeration. The default value is LeftToRight.</returns>
    public extern FlowDirection FlowDirection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a FrameworkElement has been constructed and added to the object tree, and is ready for interaction.</summary>
    public extern event RoutedEventHandler Loaded;

    /// <summary>Occurs when this object is no longer connected to the main object tree.</summary>
    public extern event RoutedEventHandler Unloaded;

    /// <summary>Occurs when either the ActualHeight or the ActualWidth property changes value on a FrameworkElement.</summary>
    public extern event SizeChangedEventHandler SizeChanged;

    /// <summary>Occurs when the layout of the visual tree changes, due to layout-relevant properties changing value or some other action that refreshes the layout.</summary>
    public extern event EventHandler<object> LayoutUpdated;

    /// <summary>Retrieves an object that has the specified identifier name.</summary>
    /// <param name="name">The name of the requested object.</param>
    /// <returns>The requested object. This can be null if no matching object was found in the current XAML namescope.</returns>
    [MethodImpl]
    public extern object FindName(string name);

    /// <summary>Attaches a binding to a FrameworkElement, using the provided binding object.</summary>
    /// <param name="dp">The dependency property identifier of the property that is data bound.</param>
    /// <param name="binding">The binding to use for the property.</param>
    [MethodImpl]
    public extern void SetBinding(DependencyProperty dp, BindingBase binding);

    /// <summary>Gets or sets the UI theme that is used by the UIElement (and its child elements) for resource determination. The UI theme you specify with RequestedTheme can override the app-level RequestedTheme.</summary>
    /// <returns>A value of the enumeration, for example **Light**.</returns>
    public extern ElementTheme RequestedTheme { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the value of the FrameworkElement.DataContext property changes.</summary>
    public extern event TypedEventHandler<FrameworkElement, DataContextChangedEventArgs> DataContextChanged;

    /// <summary>Returns the BindingExpression that represents the binding on the specified property.</summary>
    /// <param name="dp">The identifier for the target dependency property to get the binding from.</param>
    /// <returns>A BindingExpression if the target property has an active binding on this object; otherwise, returns **null**.</returns>
    [MethodImpl]
    public extern BindingExpression GetBindingExpression(DependencyProperty dp);

    /// <summary>Occurs when a FrameworkElement begins to load.</summary>
    public extern event TypedEventHandler<FrameworkElement, object> Loading;

    /// <summary>Gets or sets a value that indicates whether the element automatically gets focus when the user interacts with it.</summary>
    /// <returns>**true** if the element gets focus when a user interacts with it; otherwise, **false**.</returns>
    public extern bool AllowFocusOnInteraction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the outer margin of the focus visual for a FrameworkElement.</summary>
    /// <returns>Provides margin values for the focus visual. The default value is a default Thickness with all properties (dimensions) equal to 0.</returns>
    public extern Thickness FocusVisualMargin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the thickness of the inner border of a HighVisibility focus visual for a FrameworkElement.</summary>
    /// <returns>The thickness of the inner border of a HighVisibility focus visual. The default value is 1.</returns>
    public extern Thickness FocusVisualSecondaryThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the thickness of the outer border of a HighVisibility focus visual for a FrameworkElement.</summary>
    /// <returns>The thickness of the outer border of a HighVisibility focus visual. The default value is 2.</returns>
    public extern Thickness FocusVisualPrimaryThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to draw the inner border of a HighVisibility focus visual for a FrameworkElement.</summary>
    /// <returns>The brush used to draw the inner border of a HighVisibility focus visual.</returns>
    public extern Brush FocusVisualSecondaryBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to draw the outer border of a HighVisibility focus visual for a FrameworkElement.</summary>
    /// <returns>The brush used to draw the outer border of a HighVisibility focus visual.</returns>
    public extern Brush FocusVisualPrimaryBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether a disabled control can receive focus.</summary>
    /// <returns>**true** if a disabled control can receive focus; otherwise, **false**.</returns>
    public extern bool AllowFocusWhenDisabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the UI theme that is currently used by the element, which might be different than the RequestedTheme.</summary>
    /// <returns>A value of the enumeration, for example **Light**.</returns>
    public extern ElementTheme ActualTheme { [MethodImpl] get; }

    /// <summary>Occurs when the ActualTheme property value has changed.</summary>
    public extern event TypedEventHandler<FrameworkElement, object> ActualThemeChanged;

    /// <summary>Gets a value that indicates whether the element has been added to the element tree and is ready for interaction.</summary>
    /// <returns>**true** if the element has been added to the element tree and is ready for interaction; otherwise, **false**.</returns>
    public extern bool IsLoaded { [MethodImpl] get; }

    /// <summary>Occurs when the FrameworkElement 's *effective viewport* changes.</summary>
    public extern event TypedEventHandler<FrameworkElement, EffectiveViewportChangedEventArgs> EffectiveViewportChanged;

    [MethodImpl]
    extern void IFrameworkElementProtected7.InvalidateViewport();

    [MethodImpl]
    extern Size IFrameworkElementOverrides.MeasureOverride(
      Size availableSize);

    [MethodImpl]
    extern Size IFrameworkElementOverrides.ArrangeOverride(
      Size finalSize);

    [MethodImpl]
    extern void IFrameworkElementOverrides.OnApplyTemplate();

    [MethodImpl]
    extern bool IFrameworkElementOverrides2.GoToElementStateCore(
      string stateName,
      bool useTransitions);

    /// <summary>Identifies the ActualTheme dependency property.</summary>
    /// <returns>The identifier for the ActualTheme dependency property.</returns>
    public static extern DependencyProperty ActualThemeProperty { [MethodImpl] get; }

    /// <summary>Removes the specified element from the XAML visual tree in a way that it can be undeferred later.</summary>
    /// <param name="element">The element to remove from the XAML visual tree.</param>
    [MethodImpl]
    public static extern void DeferTree(DependencyObject element);

    /// <summary>Identifies for the AllowFocusOnInteraction dependency property.</summary>
    /// <returns>The identifier for the AllowFocusOnInteraction dependency property.</returns>
    public static extern DependencyProperty AllowFocusOnInteractionProperty { [MethodImpl] get; }

    /// <summary>Identifies the FocusVisualMargin  dependency property.</summary>
    /// <returns>The identifier for the FocusVisualMargin  dependency property.</returns>
    public static extern DependencyProperty FocusVisualMarginProperty { [MethodImpl] get; }

    /// <summary>Identifies the FocusVisualSecondaryThickness  dependency property.</summary>
    /// <returns>The identifier for the FocusVisualSecondaryThickness  dependency property.</returns>
    public static extern DependencyProperty FocusVisualSecondaryThicknessProperty { [MethodImpl] get; }

    /// <summary>Identifies the FocusVisualPrimaryThickness  dependency property.</summary>
    /// <returns>The identifier for the FocusVisualPrimaryThickness  dependency property.</returns>
    public static extern DependencyProperty FocusVisualPrimaryThicknessProperty { [MethodImpl] get; }

    /// <summary>Identifies the FocusVisualSecondaryBrush  dependency property.</summary>
    /// <returns>The identifier for the FocusVisualSecondaryBrush  dependency property.</returns>
    public static extern DependencyProperty FocusVisualSecondaryBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the FocusVisualPrimaryBrush  dependency property.</summary>
    /// <returns>The identifier for the FocusVisualPrimaryBrush  dependency property.</returns>
    public static extern DependencyProperty FocusVisualPrimaryBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the AllowFocusWhenDisabled  dependency property.</summary>
    /// <returns>The identifier for the AllowFocusWhenDisabled  dependency property.</returns>
    public static extern DependencyProperty AllowFocusWhenDisabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the RequestedTheme dependency property.</summary>
    /// <returns>The identifier for the RequestedTheme dependency property.</returns>
    public static extern DependencyProperty RequestedThemeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Tag  dependency property.</summary>
    /// <returns>The identifier for the Tag  dependency property.</returns>
    public static extern DependencyProperty TagProperty { [MethodImpl] get; }

    /// <summary>Identifies the Language dependency property.</summary>
    /// <returns>The identifier for the Language dependency property.</returns>
    public static extern DependencyProperty LanguageProperty { [MethodImpl] get; }

    /// <summary>Identifies the ActualWidth  dependency property. See Remarks.</summary>
    /// <returns>The identifier for the ActualWidth  dependency property.</returns>
    public static extern DependencyProperty ActualWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the ActualHeight  dependency property. See Remarks.</summary>
    /// <returns>The identifier for the ActualHeight  dependency property.</returns>
    public static extern DependencyProperty ActualHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the Width  dependency property.</summary>
    /// <returns>The identifier for the Width  dependency property.</returns>
    public static extern DependencyProperty WidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the Height  dependency property.</summary>
    /// <returns>The identifier for the Height  dependency property.</returns>
    public static extern DependencyProperty HeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinWidth  dependency property.</summary>
    /// <returns>The identifier for the MinWidth  dependency property.</returns>
    public static extern DependencyProperty MinWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxWidth  dependency property.</summary>
    /// <returns>The identifier for the MaxWidth  dependency property.</returns>
    public static extern DependencyProperty MaxWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinHeight  dependency property.</summary>
    /// <returns>The identifier for the MinHeight  dependency property.</returns>
    public static extern DependencyProperty MinHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxHeight  dependency property.</summary>
    /// <returns>The identifier for the MaxHeight  dependency property.</returns>
    public static extern DependencyProperty MaxHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalAlignment  dependency property.</summary>
    /// <returns>The HorizontalAlignment  dependency property identifier.</returns>
    public static extern DependencyProperty HorizontalAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalAlignment  dependency property.</summary>
    /// <returns>The VerticalAlignment  dependency property identifier.</returns>
    public static extern DependencyProperty VerticalAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the Margin  dependency property.</summary>
    /// <returns>The Margin  dependency property identifier.</returns>
    public static extern DependencyProperty MarginProperty { [MethodImpl] get; }

    /// <summary>Identifies the Name  dependency property.</summary>
    /// <returns>The identifier for the Name  dependency property.</returns>
    public static extern DependencyProperty NameProperty { [MethodImpl] get; }

    /// <summary>Identifies the DataContext  dependency property.</summary>
    /// <returns>The DataContext  dependency property identifier.</returns>
    public static extern DependencyProperty DataContextProperty { [MethodImpl] get; }

    /// <summary>Identifies the Style dependency property.</summary>
    /// <returns>The identifier for the Style dependency property.</returns>
    public static extern DependencyProperty StyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the FlowDirection  dependency property.</summary>
    /// <returns>The FlowDirection  dependency property identifier.</returns>
    public static extern DependencyProperty FlowDirectionProperty { [MethodImpl] get; }
  }
}
