// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Control
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the base class for UI elements that use a ControlTemplate to define their appearance. Parent class for ContentControl, UserControl, ItemsControl and several practical controls.</summary>
  [Static(typeof (IControlStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IControlStatics7), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IControlStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IControlStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IControlFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IControlStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class Control : 
    FrameworkElement,
    IControl,
    IControl2,
    IControl3,
    IControl4,
    IControl5,
    IControl7,
    IControlProtected,
    IControlOverrides,
    IControlOverrides6
  {
    /// <summary>Provides base class initialization behavior for Control derived classes.</summary>
    [MethodImpl]
    protected extern Control();

    /// <summary>Gets or sets the size of the text in this control.</summary>
    /// <returns>The size of the text in the Control, in pixels.</returns>
    public extern double FontSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font used to display text in the control.</summary>
    /// <returns>The font used to display text in the control.</returns>
    public extern FontFamily FontFamily { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the thickness of the specified font.</summary>
    /// <returns>One of the values that specifies the thickness of the specified font. The default is Normal.</returns>
    public extern FontWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the style in which the text is rendered.</summary>
    /// <returns>One of the values that specifies the style in which the text is rendered. The default is **Normal**.</returns>
    public extern FontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the degree to which a font is condensed or expanded on the screen.</summary>
    /// <returns>One of the values that specifies the degree to which a font is condensed or expanded on the screen. The default is **Normal**.</returns>
    public extern FontStretch FontStretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the uniform spacing between characters, in units of 1/1000 of an em.</summary>
    /// <returns>The uniform spacing between characters, in units of 1/1000 of an em. The default is 0. Positive values increase tracking and loosen character spacing. Negative values decrease tracking and tighten the character spacing.</returns>
    public extern int CharacterSpacing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that describes the foreground color.</summary>
    /// <returns>The brush that paints the foreground of the control. The default value is a SolidColorBrush with color of Black.</returns>
    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a control is included in tab navigation.</summary>
    /// <returns>**true** if the control is included in tab navigation; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsTabStop { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether the user can interact with the control.</summary>
    /// <returns>**true** if the user can interact with the control; otherwise, **false**.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines the order in which elements receive focus when the user navigates through controls by pressing the Tab key.</summary>
    /// <returns>A value that determines the order of logical navigation for a device. The default value is MaxValue.</returns>
    public extern int TabIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that modifies how tabbing and TabIndex work for this control.</summary>
    /// <returns>A value of the enumeration. The default is **Local**.</returns>
    public extern KeyboardNavigationMode TabNavigation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a control template. The control template defines the visual appearance of a control in UI, and is defined in XAML markup.</summary>
    /// <returns>The template that defines the appearance of the Control. The ControlTemplate must have exactly one root element as its content.</returns>
    public extern ControlTemplate Template { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the padding inside a control.</summary>
    /// <returns>The amount of space between the content of a Control and its Margin or Border. The default is a Thickness with values of 0 on all four sides.</returns>
    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the horizontal alignment of the control's content.</summary>
    /// <returns>One of the HorizontalAlignment values. The default is **Left**.</returns>
    public extern HorizontalAlignment HorizontalContentAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the vertical alignment of the control's content.</summary>
    /// <returns>One of the VerticalAlignment values. The default is **Top**.</returns>
    public extern VerticalAlignment VerticalContentAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the background of the control.</summary>
    /// <returns>The brush that provides the background of the control. The default is **null**, (a null brush) which is evaluated as Transparent for rendering.</returns>
    public extern Brush Background { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the border thickness of a control.</summary>
    /// <returns>The border thickness of a control, as a Thickness value.</returns>
    public extern Thickness BorderThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that describes the border fill of a control.</summary>
    /// <returns>The brush that is used to fill the control's border. The default is **null**, (a null brush) which is evaluated as Transparent for rendering.</returns>
    public extern Brush BorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that specifies whether this control has focus, and the mode by which focus was obtained.</summary>
    /// <returns>A value of the enumeration. A value of **Unfocused** indicates that the control does not have focus.</returns>
    public extern FocusState FocusState { [MethodImpl] get; }

    /// <summary>Occurs when the IsEnabled property changes.</summary>
    public extern event DependencyPropertyChangedEventHandler IsEnabledChanged;

    /// <summary>Loads the relevant control template so that its parts can be referenced.</summary>
    /// <returns>A value that indicates whether the visual tree was rebuilt by this call. **True** if the tree was rebuilt; **false** if the previous visual tree was retained.</returns>
    [MethodImpl]
    public extern bool ApplyTemplate();

    /// <summary>Attempts to set the focus on the control.</summary>
    /// <param name="value">Specifies how focus was set, as a value of the enumeration.</param>
    /// <returns>**true** if focus was set to the control, or focus was already on the control. **false** if the control is not focusable.</returns>
    [MethodImpl]
    public extern bool Focus(FocusState value);

    /// <summary>Gets or sets whether automatic text enlargement, to reflect the system text size setting, is enabled.</summary>
    /// <returns>**true** if automatic text enlargement is enabled; otherwise, **false**.</returns>
    public extern bool IsTextScaleFactorEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the control uses focus visuals that are drawn by the system or those defined in the control template.</summary>
    /// <returns>**true** if the control uses focus visuals drawn by the system; **false** if the control uses focus visuals defined in the ControlTemplate. The default is **false**; see Remarks.</returns>
    public extern bool UseSystemFocusVisuals { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or sets a value that indicates whether focus can be constrained within the control boundaries (for game pad/remote interaction).</summary>
    /// <returns>**true** if focus can be constrained within the control boundaries; otherwise, **false**.</returns>
    public extern bool IsFocusEngagementEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or sets a value that indicates whether focus is constrained within the control boundaries (for game pad/remote interaction).</summary>
    /// <returns>**true** if focus is constrained within the control boundaries; otherwise, **false**.</returns>
    public extern bool IsFocusEngaged { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether a UI element supports mouse mode, which emulates pointer interaction experiences with non-pointer input devices such as an Xbox gamepad or remote control.</summary>
    /// <returns>The pointer emulation mode. The default is **Never**.</returns>
    public extern RequiresPointer RequiresPointer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (D-pad) left.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (D-pad) left.</returns>
    public extern DependencyObject XYFocusLeft { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (D-pad) right.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (D-pad) right.</returns>
    public extern DependencyObject XYFocusRight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (D-pad) up.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (D-pad) up.</returns>
    public extern DependencyObject XYFocusUp { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the object that gets focus when a user presses the Directional Pad (D-pad) down.</summary>
    /// <returns>The object that gets focus when a user presses the Directional Pad (D-pad) down.</returns>
    public extern DependencyObject XYFocusDown { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or sets a value that specifies a control's preference for whether sounds are played.</summary>
    /// <returns>A value of the enumeration that specifies a control's preference for whether sounds are played. The default is **Auto**.</returns>
    public extern ElementSoundMode ElementSoundMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when focus is constrained within the control boundaries (for game pad/remote interaction).</summary>
    public extern event TypedEventHandler<Control, FocusEngagedEventArgs> FocusEngaged;

    /// <summary>Occurs when focus is released from the control boundaries (for game pad/remote interaction).</summary>
    public extern event TypedEventHandler<Control, FocusDisengagedEventArgs> FocusDisengaged;

    /// <summary>Releases focus from the control boundaries for a control that has focus engagement (for game pad/remote interaction).</summary>
    [MethodImpl]
    public extern void RemoveFocusEngagement();

    /// <summary>Gets or sets the path to the resource file that contains the default style for the control.</summary>
    /// <returns>The path to the resource file that contains the default style for the control.</returns>
    public extern Uri DefaultStyleResourceUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how far the background extends in relation to this element's border.</summary>
    /// <returns>A value of the enumeration that indicates how far the background extends. The default is **InnerBorderEdge**.</returns>
    public extern BackgroundSizing BackgroundSizing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the radius for the corners of the control's border.</summary>
    /// <returns>The degree to which the corners are rounded, expressed as values of the CornerRadius structure.</returns>
    public extern CornerRadius CornerRadius { [MethodImpl] get; [MethodImpl] set; }

    extern object IControlProtected.DefaultStyleKey { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern DependencyObject IControlProtected.GetTemplateChild(
      string childName);

    [MethodImpl]
    extern void IControlOverrides.OnPointerEntered(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerPressed(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerMoved(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerReleased(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerExited(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerCaptureLost(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerCanceled(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnPointerWheelChanged(PointerRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnTapped(TappedRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnDoubleTapped(DoubleTappedRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnHolding(HoldingRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnRightTapped(RightTappedRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnManipulationStarting(
      ManipulationStartingRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnManipulationInertiaStarting(
      ManipulationInertiaStartingRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnManipulationStarted(
      ManipulationStartedRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnManipulationDelta(
      ManipulationDeltaRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnManipulationCompleted(
      ManipulationCompletedRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnKeyUp(KeyRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnKeyDown(KeyRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnGotFocus(RoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnLostFocus(RoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnDragEnter(DragEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnDragLeave(DragEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnDragOver(DragEventArgs e);

    [MethodImpl]
    extern void IControlOverrides.OnDrop(DragEventArgs e);

    [MethodImpl]
    extern void IControlOverrides6.OnPreviewKeyDown(KeyRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides6.OnPreviewKeyUp(KeyRoutedEventArgs e);

    [MethodImpl]
    extern void IControlOverrides6.OnCharacterReceived(
      CharacterReceivedRoutedEventArgs e);

    /// <summary>Identifies the BackgroundSizing dependency property.</summary>
    /// <returns>The identifier for the BackgroundSizing dependency property.</returns>
    public static extern DependencyProperty BackgroundSizingProperty { [MethodImpl] get; }

    /// <summary>Identifies the CornerRadius dependency property.</summary>
    /// <returns>The identifier for the CornerRadius dependency property.</returns>
    public static extern DependencyProperty CornerRadiusProperty { [MethodImpl] get; }

    /// <summary>Identifies the **DefaultStyleResourceUri** dependency property.</summary>
    /// <returns>The identifier for the **DefaultStyleResourceUri** dependency property.</returns>
    public static extern DependencyProperty DefaultStyleResourceUriProperty { [MethodImpl] get; }

    /// <summary>Identifies the Control.IsTemplateKeyTipTarget  XAML attached property.</summary>
    /// <returns>The identifier for the Control.IsTemplateKeyTipTarget XAML attached property.</returns>
    public static extern DependencyProperty IsTemplateKeyTipTargetProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the Control.IsTemplateKeyTipTarget  XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The Control.IsTemplateKeyTipTarget XAML attached property value of the specified object.</returns>
    [MethodImpl]
    public static extern bool GetIsTemplateKeyTipTarget(DependencyObject element);

    /// <summary>Sets the value of the Control.IsTemplateKeyTipTarget XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetIsTemplateKeyTipTarget(DependencyObject element, bool value);

    /// <summary>Identifies the IsFocusEngagementEnabled dependency property.</summary>
    /// <returns>The identifier for the IsFocusEngagementEnabled dependency property.</returns>
    public static extern DependencyProperty IsFocusEngagementEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFocusEngaged dependency property.</summary>
    /// <returns>The identifier for the IsFocusEngaged dependency property.</returns>
    public static extern DependencyProperty IsFocusEngagedProperty { [MethodImpl] get; }

    /// <summary>Identifies the RequiresPointer dependency property.</summary>
    /// <returns>The identifier for the RequiresPointer dependency property.</returns>
    public static extern DependencyProperty RequiresPointerProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusLeft dependency property.</summary>
    /// <returns>The identifier for the XYFocusLeft dependency property.</returns>
    public static extern DependencyProperty XYFocusLeftProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusRight dependency property.</summary>
    /// <returns>The identifier for the XYFocusRight dependency property.</returns>
    public static extern DependencyProperty XYFocusRightProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusUp dependency property.</summary>
    /// <returns>The identifier for the XYFocusUp dependency property.</returns>
    public static extern DependencyProperty XYFocusUpProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusDown dependency property.</summary>
    /// <returns>The identifier for the XYFocusDown dependency property.</returns>
    public static extern DependencyProperty XYFocusDownProperty { [MethodImpl] get; }

    /// <summary>Identifies the ElementSoundMode dependency property.</summary>
    /// <returns>The identifier for the ElementSoundMode dependency property.</returns>
    public static extern DependencyProperty ElementSoundModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the UseSystemFocusVisuals dependency property.</summary>
    /// <returns>The identifier for the UseSystemFocusVisuals dependency property.</returns>
    public static extern DependencyProperty UseSystemFocusVisualsProperty { [MethodImpl] get; }

    /// <summary>Identifies the Control.IsTemplateFocusTarget XAML attached property.</summary>
    /// <returns>The identifier for the Control.IsTemplateFocusTarget XAML attached property.</returns>
    public static extern DependencyProperty IsTemplateFocusTargetProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the Control.IsTemplateFocusTarget XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The Control.IsTemplateFocusTarget XAML attached property value of the specified object.</returns>
    [MethodImpl]
    public static extern bool GetIsTemplateFocusTarget(FrameworkElement element);

    /// <summary>Sets the value of the Control.IsTemplateFocusTarget XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetIsTemplateFocusTarget(FrameworkElement element, bool value);

    /// <summary>Identifies the IsTextScaleFactorEnabled  dependency property.</summary>
    /// <returns>The identifier for the IsTextScaleFactorEnabled dependency property.</returns>
    public static extern DependencyProperty IsTextScaleFactorEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontSize dependency property.</summary>
    /// <returns>The identifier for the FontSize dependency property.</returns>
    public static extern DependencyProperty FontSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontFamily dependency property.</summary>
    /// <returns>The identifier for the FontFamily dependency property.</returns>
    public static extern DependencyProperty FontFamilyProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontWeight dependency property.</summary>
    /// <returns>The identifier for the FontWeight dependency property.</returns>
    public static extern DependencyProperty FontWeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontStyle dependency property.</summary>
    /// <returns>The identifier for the FontStyle dependency property.</returns>
    public static extern DependencyProperty FontStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontStretch dependency property.</summary>
    /// <returns>The identifier for the FontStretch dependency property.</returns>
    public static extern DependencyProperty FontStretchProperty { [MethodImpl] get; }

    /// <summary>Identifies the CharacterSpacing dependency property.</summary>
    /// <returns>The identifier for the CharacterSpacing dependency property.</returns>
    public static extern DependencyProperty CharacterSpacingProperty { [MethodImpl] get; }

    /// <summary>Identifies the Foreground dependency property.</summary>
    /// <returns>The identifier for the Foreground dependency property.</returns>
    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTabStop  dependency property.</summary>
    /// <returns>The identifier for the IsTabStop  dependency property.</returns>
    public static extern DependencyProperty IsTabStopProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsEnabled dependency property.</summary>
    /// <returns>The identifier for the IsEnabled dependency property.</returns>
    public static extern DependencyProperty IsEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the TabIndex  dependency property.</summary>
    /// <returns>The identifier for the TabIndex  dependency property.</returns>
    public static extern DependencyProperty TabIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the TabNavigation  dependency property.</summary>
    /// <returns>The identifier for the TabNavigation  dependency property.</returns>
    public static extern DependencyProperty TabNavigationProperty { [MethodImpl] get; }

    /// <summary>Identifies the Template  dependency property.</summary>
    /// <returns>The identifier for the Template  dependency property.</returns>
    public static extern DependencyProperty TemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the Padding dependency property.</summary>
    /// <returns>The identifier for the Padding dependency property.</returns>
    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalContentAlignment dependency property.</summary>
    /// <returns>The identifier for the HorizontalContentAlignment dependency property.</returns>
    public static extern DependencyProperty HorizontalContentAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalContentAlignment dependency property.</summary>
    /// <returns>The identifier for the VerticalContentAlignment dependency property.</returns>
    public static extern DependencyProperty VerticalContentAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the Background dependency property.</summary>
    /// <returns>The identifier for the Background dependency property.</returns>
    public static extern DependencyProperty BackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the BorderThickness dependency property.</summary>
    /// <returns>The identifier for the BorderThickness dependency property.</returns>
    public static extern DependencyProperty BorderThicknessProperty { [MethodImpl] get; }

    /// <summary>Identifies the BorderBrush dependency property.</summary>
    /// <returns>The identifier for the BorderBrush dependency property.</returns>
    public static extern DependencyProperty BorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the DefaultStyleKey dependency property.</summary>
    /// <returns>The identifier for the DefaultStyleKey dependency property.</returns>
    public static extern DependencyProperty DefaultStyleKeyProperty { [MethodImpl] get; }

    /// <summary>Identifies the FocusState dependency property.</summary>
    /// <returns>The identifier for the FocusState dependency property.</returns>
    public static extern DependencyProperty FocusStateProperty { [MethodImpl] get; }
  }
}
