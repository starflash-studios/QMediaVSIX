// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.UIElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI.Composition;
using Windows.UI.Input;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml
{
  /// <summary>UIElement is a base class for most of the Windows Runtime UI objects that have visual appearance and can process basic input as part of your app's user interface.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IUIElementStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUIElementStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IUIElementFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUIElementStatics7), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUIElementStatics10), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUIElementStatics6), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUIElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IUIElementStatics8), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IUIElementStatics9), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUIElementStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUIElementStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  public class UIElement : 
    DependencyObject,
    IUIElement,
    IUIElement2,
    IUIElement3,
    IUIElement4,
    IUIElement5,
    IUIElement7,
    IUIElement8,
    IUIElement9,
    IUIElement10,
    IUIElementOverrides,
    IUIElementOverrides7,
    IUIElementOverrides8,
    IUIElementOverrides9,
    IAnimationObject,
    IVisualElement
  {
    /// <summary>Gets the size that this UIElement computed during the measure pass of the layout process.</summary>
    /// <returns>The size that this UIElement computed during the measure pass of the layout process.</returns>
    public extern Size DesiredSize { [MethodImpl] get; }

    /// <summary>Gets or sets a value that determines whether this UIElement can be a drop target for purposes of drag-and-drop operations.</summary>
    /// <returns>**true** if this UIElement can be a drop target for purposes of drag-and-drop operations; otherwise, **false**. The default is **false**.</returns>
    public extern bool AllowDrop { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the degree of the object's opacity.</summary>
    /// <returns>A value between 0 and 1.0 that declares the opacity factor, with 1.0 meaning full opacity and 0 meaning transparent. The default value is 1.0.</returns>
    public extern double Opacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the RectangleGeometry used to define the outline of the contents of a UIElement.</summary>
    /// <returns>The rectangle geometry to be used for clipping area sizing. The default value is **null** (no clipping).</returns>
    public extern RectangleGeometry Clip { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets transform information that affects the rendering position of a UIElement.</summary>
    /// <returns>Describes the specifics of the desired render transform. The default value is null.</returns>
    public extern Transform RenderTransform { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the perspective projection (3-D effect) to apply when rendering this element.</summary>
    /// <returns>A 3-D projection effect applied to the element.</returns>
    public extern Projection Projection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the origin point of any possible render transform declared by RenderTransform, relative to the bounds of the UIElement.</summary>
    /// <returns>The origin point of the render transform. The default value is a Point with value 0,0.</returns>
    public extern Point RenderTransformOrigin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the contained area of this UIElement can return true values for hit testing.</summary>
    /// <returns>**true** if the contained area of this UIElement can be used for hit testing; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsHitTestVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the visibility of a UIElement. A UIElement that is not visible is not rendered and does not communicate its desired size to layout.</summary>
    /// <returns>A value of the enumeration. The default value is **Visible**.</returns>
    public extern Visibility Visibility { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the final render size of a UIElement. Use is not recommended, see Remarks.</summary>
    /// <returns>The rendered size for this object. There is no default value.</returns>
    public extern Size RenderSize { [MethodImpl] get; }

    /// <summary>Gets or sets a value that determines whether rendering for the object and its visual subtree should use rounding behavior that aligns rendering to whole pixels.</summary>
    /// <returns>**true** if rendering and layout should use layout rounding to whole pixels; otherwise, **false**. The default is **true**.</returns>
    public extern bool UseLayoutRounding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of Transition style elements that apply to a UIElement.</summary>
    /// <returns>The strongly typed collection of Transition style elements that apply to a UIElement.</returns>
    public extern TransitionCollection Transitions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates that rendered content should be cached as a composited bitmap when possible.</summary>
    /// <returns>A value that indicates that rendered content should be cached as a composited bitmap when possible. If you specify a value of CacheMode, rendering operations from RenderTransform and Opacity execute on the graphics processing unit (GPU), if available. The default is **null**, which does not enable a cached composition mode.</returns>
    public extern CacheMode CacheMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the Tapped event can originate from that element.</summary>
    /// <returns>**true** if a Tapped event can originate from this element; otherwise, **false**.</returns>
    public extern bool IsTapEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the DoubleTapped event can originate from that element.</summary>
    /// <returns>**true** if a DoubleTapped event can originate from this element; otherwise, **false**.</returns>
    public extern bool IsDoubleTapEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the RightTapped event can originate from that element.</summary>
    /// <returns>**true** if a RightTapped event can originate from this element; otherwise, **false**.</returns>
    public extern bool IsRightTapEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the Holding event can originate from that element.</summary>
    /// <returns>**true** if a Holding event can originate from this element; otherwise, **false**.</returns>
    public extern bool IsHoldingEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the ManipulationModes value used for UIElement behavior and interaction with gestures. Setting this value enables handling the manipulation events from this element in app code.</summary>
    /// <returns>A value or values of the enumeration. The default is typically **System**, but this can vary on specific controls and elements. See Remarks.</returns>
    public extern ManipulationModes ManipulationMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the set of all captured pointers, represented as Pointer values.</summary>
    /// <returns>The collection of captured pointers, each represented as a Pointer object.</returns>
    public extern IVectorView<Pointer> PointerCaptures { [MethodImpl] get; }

    /// <summary>Occurs when a keyboard key is released while the UIElement has focus.</summary>
    public extern event KeyEventHandler KeyUp;

    /// <summary>Occurs when a keyboard key is pressed while the UIElement has focus.</summary>
    public extern event KeyEventHandler KeyDown;

    /// <summary>Occurs when a UIElement receives focus. This event is raised asynchronously, so focus can move again before bubbling is complete.</summary>
    public extern event RoutedEventHandler GotFocus;

    /// <summary>Occurs when a UIElement loses focus. This event is raised asynchronously, so focus can move again before bubbling is complete.</summary>
    public extern event RoutedEventHandler LostFocus;

    /// <summary>Occurs when the input system reports an underlying drag event with this element as the target.</summary>
    public extern event DragEventHandler DragEnter;

    /// <summary>Occurs when the input system reports an underlying drag event with this element as the origin.</summary>
    public extern event DragEventHandler DragLeave;

    /// <summary>Occurs when the input system reports an underlying drag event with this element as the potential drop target.</summary>
    public extern event DragEventHandler DragOver;

    /// <summary>Occurs when the input system reports an underlying drop event with this element as the drop target.</summary>
    public extern event DragEventHandler Drop;

    /// <summary>Occurs when the pointer device initiates a **Press** action within this element.</summary>
    public extern event PointerEventHandler PointerPressed;

    /// <summary>Occurs when a pointer moves while the pointer remains within the hit test area of this element.</summary>
    public extern event PointerEventHandler PointerMoved;

    /// <summary>Occurs when the pointer device that previously initiated a **Press** action is released, while within this element. Note that the end of a **Press** action is not guaranteed to fire a PointerReleased event; other events may fire instead. For more info, see Remarks.</summary>
    public extern event PointerEventHandler PointerReleased;

    /// <summary>Occurs when a pointer enters the hit test area of this element.</summary>
    public extern event PointerEventHandler PointerEntered;

    /// <summary>Occurs when a pointer leaves the hit test area of this element.</summary>
    public extern event PointerEventHandler PointerExited;

    /// <summary>Occurs when pointer capture previously held by this element moves to another element or elsewhere.</summary>
    public extern event PointerEventHandler PointerCaptureLost;

    /// <summary>Occurs when a pointer that made contact abnormally loses contact.</summary>
    public extern event PointerEventHandler PointerCanceled;

    /// <summary>Occurs when the delta value of a pointer wheel changes.</summary>
    public extern event PointerEventHandler PointerWheelChanged;

    /// <summary>Occurs when an otherwise unhandled **Tap** interaction occurs over the hit test area of this element.</summary>
    public extern event TappedEventHandler Tapped;

    /// <summary>Occurs when an otherwise unhandled **DoubleTap** interaction occurs over the hit test area of this element.</summary>
    public extern event DoubleTappedEventHandler DoubleTapped;

    /// <summary>Occurs when an otherwise unhandled **Hold** interaction occurs over the hit test area of this element.</summary>
    public extern event HoldingEventHandler Holding;

    /// <summary>Occurs when a right-tap input stimulus happens while the pointer is over the element.</summary>
    public extern event RightTappedEventHandler RightTapped;

    /// <summary>Occurs when the manipulation processor is first created.</summary>
    public extern event ManipulationStartingEventHandler ManipulationStarting;

    /// <summary>Occurs when the input device loses contact with the UIElement object during a manipulation and inertia begins.</summary>
    public extern event ManipulationInertiaStartingEventHandler ManipulationInertiaStarting;

    /// <summary>Occurs when an input device begins a manipulation on the UIElement.</summary>
    public extern event ManipulationStartedEventHandler ManipulationStarted;

    /// <summary>Occurs when the input device changes position during a manipulation.</summary>
    public extern event ManipulationDeltaEventHandler ManipulationDelta;

    /// <summary>Occurs when a manipulation on the UIElement is complete.</summary>
    public extern event ManipulationCompletedEventHandler ManipulationCompleted;

    /// <summary>Updates the DesiredSize of a UIElement. Typically, objects that implement custom layout for their layout children call this method from their own MeasureOverride implementations to form a recursive layout update.</summary>
    /// <param name="availableSize">The available space that a parent can allocate to a child object. A child object can request a larger space than what is available; the provided size might be accommodated if scrolling or other resize behavior is possible in that particular container.</param>
    [MethodImpl]
    public extern void Measure(Size availableSize);

    /// <summary>Positions child objects and determines a size for a UIElement. Parent objects that implement custom layout for their child elements should call this method from their layout override implementations to form a recursive layout update.</summary>
    /// <param name="finalRect">The final size that the parent computes for the child in layout, provided as a Rect value.</param>
    [MethodImpl]
    public extern void Arrange(Rect finalRect);

    /// <summary>Sets pointer capture to a UIElement. Once captured, only the element that has capture will fire pointer-related events.</summary>
    /// <param name="value">The pointer object reference.</param>
    /// <returns>**true** if the object has pointer capture; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool CapturePointer(Pointer value);

    /// <summary>Releases pointer captures for capture of one specific pointer by this UIElement.</summary>
    /// <param name="value">The pointer reference. Use either saved references from previous captures, or pointer event data, to obtain this reference.</param>
    [MethodImpl]
    public extern void ReleasePointerCapture(Pointer value);

    /// <summary>Releases all pointer captures held by this element.</summary>
    [MethodImpl]
    public extern void ReleasePointerCaptures();

    /// <summary>Adds a routed event handler for a specified routed event, adding the handler to the handler collection on the current element. Specify *handledEventsToo* as **true** to have the provided handler be invoked even if the event is handled elsewhere.</summary>
    /// <param name="routedEvent">An identifier for the routed event to be handled.</param>
    /// <param name="handler">A reference to the handler implementation.</param>
    /// <param name="handledEventsToo">**true** to register the handler such that it is invoked even when the routed event is marked handled in its event data.</param>
    [MethodImpl]
    public extern void AddHandler(RoutedEvent routedEvent, object handler, bool handledEventsToo);

    /// <summary>Removes the specified routed event handler from this UIElement. Typically the handler in question was added by AddHandler.</summary>
    /// <param name="routedEvent">The identifier of the routed event for which the handler is attached.</param>
    /// <param name="handler">The specific handler implementation to remove from the event handler collection on this UIElement.</param>
    [MethodImpl]
    public extern void RemoveHandler(RoutedEvent routedEvent, object handler);

    /// <summary>Returns a transform object that can be used to transform coordinates from the UIElement to the specified object.</summary>
    /// <param name="visual">The object to compare to the current object for purposes of obtaining the transform.</param>
    /// <returns>The transform information as an object. Call methods on this object to get a practical transform.</returns>
    [MethodImpl]
    public extern GeneralTransform TransformToVisual(UIElement visual);

    /// <summary>Invalidates the measurement state (layout) for a UIElement.</summary>
    [MethodImpl]
    public extern void InvalidateMeasure();

    /// <summary>Invalidates the arrange state (layout) for a UIElement. After the invalidation, the UIElement will have its layout updated, which will occur asynchronously.</summary>
    [MethodImpl]
    public extern void InvalidateArrange();

    /// <summary>Ensures that all positions of child objects of a UIElement are properly updated for layout.</summary>
    [MethodImpl]
    public extern void UpdateLayout();

    /// <summary>Gets or sets a property that declares alternate composition and blending modes for the element in its parent layout and window. This is relevant for elements that are involved in a mixed XAML / Microsoft DirectX UI.</summary>
    /// <returns>A value of the enumeration. The default is **Inherit**, but see Remarks.</returns>
    public extern ElementCompositeMode CompositeMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Cancels ongoing direct manipulation processing (system-defined panning/zooming) on any ScrollViewer parent that contains the current UIElement.</summary>
    /// <returns>**true** if a ScrollViewer parent exists and setting the value resulted in canceling the panning/zooming action. **false** if calling the method results in no action.</returns>
    [MethodImpl]
    public extern bool CancelDirectManipulations();

    /// <summary>Gets or sets the 3-D transform effect to apply when rendering this element.</summary>
    /// <returns>The 3-D transform effect to apply when rendering this element. The default is **null**.</returns>
    public extern Transform3D Transform3D { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the element can be dragged as data in a drag-and-drop operation.</summary>
    /// <returns>**true** if the element can be dragged as data in a drag-and-drop operation; otherwise, **false**. The default is **false**.</returns>
    public extern bool CanDrag { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a drag operation is initiated.</summary>
    public extern event TypedEventHandler<UIElement, DragStartingEventArgs> DragStarting;

    /// <summary>Occurs when a drag-and-drop operation with this element as the source is ended.</summary>
    public extern event TypedEventHandler<UIElement, DropCompletedEventArgs> DropCompleted;

    /// <summary>Initiates a drag-and-drop operation.</summary>
    /// <param name="pointerPoint">The coordinates of the pointer where the user interacts with the screen, and where the drag visual is attached.</param>
    /// <returns>A DataPackageOperation value that indicates the type of drag-and-drop operation, and whether the operation was successful.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DataPackageOperation> StartDragAsync(
      PointerPoint pointerPoint);

    /// <summary>Gets or sets the flyout associated with this element.</summary>
    /// <returns>The flyout associated with this element, if any; otherwise, **null**. The default is **null**.</returns>
    public extern FlyoutBase ContextFlyout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the access key display is dismissed when an access key is invoked.</summary>
    /// <returns>**true** to dismiss the access key display when an access key is invoked; otherwise, **false**.</returns>
    public extern bool ExitDisplayModeOnAccessKeyInvoked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether an element defines its own access key scope.</summary>
    /// <returns>**true** if an element defines its own scope; otherwise, **false**.</returns>
    public extern bool IsAccessKeyScope { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a source element that provides the access key scope for this element, even if it's not in the visual tree of the source element.</summary>
    /// <returns>The element that defines the access key scope.</returns>
    public extern DependencyObject AccessKeyScopeOwner { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the access key (mnemonic) for this element.</summary>
    /// <returns>The access key (mnemonic) for this element.</returns>
    public extern string AccessKey { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the user has completed a context input gesture, such as a right-click.</summary>
    public extern event TypedEventHandler<UIElement, ContextRequestedEventArgs> ContextRequested;

    /// <summary>Occurs when a context input gesture continues into a manipulation gesture, to notify the element that the context flyout should not be opened.</summary>
    public extern event TypedEventHandler<UIElement, RoutedEventArgs> ContextCanceled;

    /// <summary>Occurs when the user requests that access keys be displayed.</summary>
    public extern event TypedEventHandler<UIElement, AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested;

    /// <summary>Occurs when access keys should no longer be displayed.</summary>
    public extern event TypedEventHandler<UIElement, AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed;

    /// <summary>Occurs when a user completes an access key sequence.</summary>
    public extern event TypedEventHandler<UIElement, AccessKeyInvokedEventArgs> AccessKeyInvoked;

    /// <summary>Gets the collection of XamlLight objects attached to this element.</summary>
    /// <returns>The collection of XamlLight elements that apply to a UIElement.</returns>
    public extern IVector<XamlLight> Lights { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates where the access key Key Tip is placed in relation to the boundary of the UIElement.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern KeyTipPlacementMode KeyTipPlacementMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how far left or right the Key Tip is placed in relation to the UIElement.</summary>
    /// <returns>The number of pixels to move the Key Tip. Positive values move it right. Negative values move it left.</returns>
    public extern double KeyTipHorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how far up or down the Key Tip is placed in relation to the UI element.</summary>
    /// <returns>The number of pixels to move the Key Tip. Positive values move it down. Negative values move it up.</returns>
    public extern double KeyTipVerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that enables or disables navigation using the keyboard directional arrows.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern XYFocusKeyboardNavigationMode XYFocusKeyboardNavigation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the strategy used to determine the target element of an up navigation.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern XYFocusNavigationStrategy XYFocusUpNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the strategy used to determine the target element of a down navigation.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern XYFocusNavigationStrategy XYFocusDownNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the strategy used to determine the target element of a left navigation.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern XYFocusNavigationStrategy XYFocusLeftNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the strategy used to determine the target element of a right navigation.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern XYFocusNavigationStrategy XYFocusRightNavigationStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the framework automatically adjusts the element's visual properties when high contrast themes are enabled.</summary>
    /// <returns>A value of the enumeration that indicates whether the framework automatically adjusts the element's visual properties when high contrast themes are enabled. The default is **Application**.</returns>
    public extern ElementHighContrastAdjustment HighContrastAdjustment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that modifies how tabbing and TabIndex work for this control.</summary>
    /// <returns>A value of the enumeration. The default is **Local**.</returns>
    public extern KeyboardNavigationMode TabFocusNavigation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs before a UIElement receives focus. This event is raised synchronously to ensure focus isn't moved while the event is bubbling.</summary>
    public extern event TypedEventHandler<UIElement, GettingFocusEventArgs> GettingFocus;

    /// <summary>Occurs before a UIElement loses focus. This event is raised synchronously to ensure focus isn't moved while the event is bubbling.</summary>
    public extern event TypedEventHandler<UIElement, LosingFocusEventArgs> LosingFocus;

    /// <summary>Occurs when a user attempts to move focus (via tab or directional arrows), but focus doesn't move because no focus candidate is found in the direction of movement.</summary>
    public extern event TypedEventHandler<UIElement, NoFocusCandidateFoundEventArgs> NoFocusCandidateFound;

    /// <summary>Initiates a request to the XAML framework to bring the element into view within any scrollable regions it is contained within.</summary>
    [Overload("StartBringIntoView")]
    [MethodImpl]
    public extern void StartBringIntoView();

    /// <summary>Initiates a request to the XAML framework to bring the element into view using the specified options.</summary>
    /// <param name="options">An instance of BringIntoViewOptions.</param>
    [Overload("StartBringIntoViewWithOptions")]
    [MethodImpl]
    public extern void StartBringIntoView(BringIntoViewOptions options);

    /// <summary>Gets the collection of key combinations that invoke an action using the keyboard. </summary>
    /// <returns>The collection of **KeyboardAccelerator** objects.</returns>
    public extern IVector<KeyboardAccelerator> KeyboardAccelerators { [MethodImpl] get; }

    /// <summary>Occurs when a single, composed character is received by the input queue.</summary>
    public extern event TypedEventHandler<UIElement, CharacterReceivedRoutedEventArgs> CharacterReceived;

    /// <summary>Occurs when a keyboard shortcut (or accelerator) is pressed.</summary>
    public extern event TypedEventHandler<UIElement, ProcessKeyboardAcceleratorEventArgs> ProcessKeyboardAccelerators;

    /// <summary>Occurs when a keyboard key is pressed while the UIElement has focus.</summary>
    public extern event KeyEventHandler PreviewKeyDown;

    /// <summary>Occurs when a keyboard key is released while the UIElement has focus.</summary>
    public extern event KeyEventHandler PreviewKeyUp;

    /// <summary>Attempts to invoke a keyboard shortcut (or accelerator) by searching the entire visual tree of the UIElement for the shortcut.</summary>
    /// <param name="args">The ProcessKeyboardAcceleratorEventArgs.</param>
    [MethodImpl]
    public extern void TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args);

    /// <summary>Gets or sets a value that indicates the element targeted by the access key Key Tip.</summary>
    /// <returns>The element targeted by the Key Tip.</returns>
    public extern DependencyObject KeyTipTarget { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the control tooltip that displays the accelerator key combination.</summary>
    /// <returns>The control tooltip that displays the accelerator key combination.</returns>
    public extern DependencyObject KeyboardAcceleratorPlacementTarget { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the control tooltip displays the key combination for it's associated keyboard accelerator.</summary>
    /// <returns>A value of the enumeration. The default is **Auto**.</returns>
    public extern KeyboardAcceleratorPlacementMode KeyboardAcceleratorPlacementMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when StartBringIntoView is called on this element or one of its descendants.</summary>
    public extern event TypedEventHandler<UIElement, BringIntoViewRequestedEventArgs> BringIntoViewRequested;

    /// <summary>Gets or sets a value that indicates whether the UIElement can be a candidate for scroll anchoring.</summary>
    /// <returns>**true** if an element should be considered as a candidate for scroll anchoring; otherwise, **false**. The default is **false**.</returns>
    public extern bool CanBeScrollAnchor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the ScalarTransition that animates changes to the Opacity property.</summary>
    /// <returns>
    /// </returns>
    public extern ScalarTransition OpacityTransition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x, y, and z rendering position of the element.</summary>
    /// <returns>The x, y, and z rendering position of the element.</returns>
    public extern Vector3 Translation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Vector3Transition that animates changes to the Translation property.</summary>
    /// <returns>The Vector3Transition that animates changes to the Translation property.</returns>
    public extern Vector3Transition TranslationTransition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the angle of clockwise rotation, in degrees. Rotates relative to the RotationAxis and the CenterPoint. Affects the rendering position of the element.</summary>
    /// <returns>The angle of clockwise rotation, in degrees.</returns>
    public extern float Rotation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the ScalarTransition that animates changes to the Rotation property.</summary>
    /// <returns>The ScalarTransition that animates changes to the Rotation property.</returns>
    public extern ScalarTransition RotationTransition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the scale of the element. Scales relative to the element's CenterPoint. Affects the rendering position of the element.</summary>
    /// <returns>The scale of the element, relative to the element's CenterPoint.</returns>
    public extern Vector3 Scale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Vector3Transition that animates changes to the Scale property.</summary>
    /// <returns>The Vector3Transition that animates changes to the Scale property.</returns>
    public extern Vector3Transition ScaleTransition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the transformation matrix to apply to the element.</summary>
    /// <returns>The transformation matrix to apply to the element.</returns>
    public extern Matrix4x4 TransformMatrix { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the center point of the element, which is the point about which rotation or scaling occurs. Affects the rendering position of the element.</summary>
    /// <returns>The center point of the element, which is the point about which rotation or scaling occurs.</returns>
    public extern Vector3 CenterPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the axis to rotate the element around.</summary>
    /// <returns>The axis to rotate the element around.</returns>
    public extern Vector3 RotationAxis { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Begins the specified animation on the element.</summary>
    /// <param name="animation">The animation to start.</param>
    [MethodImpl]
    public extern void StartAnimation(ICompositionAnimationBase animation);

    /// <summary>Stops the specified animation on the element.</summary>
    /// <param name="animation">The animation to stop.</param>
    [MethodImpl]
    public extern void StopAnimation(ICompositionAnimationBase animation);

    /// <summary>Gets the position of this UIElement, relative to its parent, computed during the arrange pass of the layout process.</summary>
    /// <returns>The position of this UIElement, relative to its parent, computed during the arrange pass of the layout process.</returns>
    public extern Vector3 ActualOffset { [MethodImpl] get; }

    /// <summary>Gets the size that this UIElement computed during the arrange pass of the layout process.</summary>
    /// <returns>The size that this UIElement computed during the arrange pass of the layout process.</returns>
    public extern Vector2 ActualSize { [MethodImpl] get; }

    /// <summary>Gets or sets the XamlRoot in which this element is being viewed.</summary>
    /// <returns>The XamlRoot in which this element is being viewed. The default is **null**.</returns>
    public extern XamlRoot XamlRoot { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the context identifier for the element.</summary>
    /// <returns>The context identifier for the element.</returns>
    public extern UIContext UIContext { [MethodImpl] get; }

    /// <summary>Gets or sets the shadow effect cast by the element.</summary>
    /// <returns>The shadow effect cast by the element.</returns>
    public extern Shadow Shadow { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern AutomationPeer IUIElementOverrides.OnCreateAutomationPeer();

    [MethodImpl]
    extern void IUIElementOverrides.OnDisconnectVisualChildren();

    [MethodImpl]
    extern IIterable<IIterable<Point>> IUIElementOverrides.FindSubElementsForTouchTargeting(
      Point point,
      Rect boundingRect);

    [MethodImpl]
    extern IIterable<DependencyObject> IUIElementOverrides7.GetChildrenInTabFocusOrder();

    [MethodImpl]
    extern void IUIElementOverrides7.OnProcessKeyboardAccelerators(
      ProcessKeyboardAcceleratorEventArgs args);

    [MethodImpl]
    extern void IUIElementOverrides8.OnKeyboardAcceleratorInvoked(
      KeyboardAcceleratorInvokedEventArgs args);

    [MethodImpl]
    extern void IUIElementOverrides8.OnBringIntoViewRequested(
      BringIntoViewRequestedEventArgs e);

    [MethodImpl]
    extern void IUIElementOverrides9.PopulatePropertyInfoOverride(
      string propertyName,
      AnimationPropertyInfo animationPropertyInfo);

    /// <summary>Defines a property that can be animated.</summary>
    /// <param name="propertyName">The property that can be animated.</param>
    /// <param name="propertyInfo">Information about the property to be animated.</param>
    [MethodImpl]
    public extern void PopulatePropertyInfo(string propertyName, AnimationPropertyInfo propertyInfo);

    /// <summary>Identifies the Shadow dependency property.</summary>
    /// <returns>The identifier for the Shadow dependency property.</returns>
    public static extern DependencyProperty ShadowProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanBeScrollAnchor dependency property.</summary>
    /// <returns>The identifier for the CanBeScrollAnchor dependency property.</returns>
    public static extern DependencyProperty CanBeScrollAnchorProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the BringIntoViewRequested routed event.</summary>
    /// <returns>The identifier for the BringIntoViewRequested routed event.</returns>
    public static extern RoutedEvent BringIntoViewRequestedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the ContextRequested routed event.</summary>
    /// <returns>The identifier for the ContextRequested routed event.</returns>
    public static extern RoutedEvent ContextRequestedEvent { [MethodImpl] get; }

    /// <summary>Identifies the KeyTipTarget dependency property.</summary>
    /// <returns>The identifier for the KeyTipTarget dependency property.</returns>
    public static extern DependencyProperty KeyTipTargetProperty { [MethodImpl] get; }

    /// <summary>Identifies the KeyboardAcceleratorPlacementTarget dependency property.</summary>
    /// <returns>The identifier for the KeyboardAcceleratorPlacementTarget dependency property.</returns>
    public static extern DependencyProperty KeyboardAcceleratorPlacementTargetProperty { [MethodImpl] get; }

    /// <summary>Identifies the KeyboardAcceleratorPlacementMode dependency property.</summary>
    /// <returns>The identifier for the KeyboardAcceleratorPlacementMode dependency property.</returns>
    public static extern DependencyProperty KeyboardAcceleratorPlacementModeProperty { [MethodImpl] get; }

    /// <summary>Registers an element as representing a scrollable viewport.</summary>
    /// <param name="element">The element to register as a scrollable viewport.</param>
    [MethodImpl]
    public static extern void RegisterAsScrollPort(UIElement element);

    /// <summary>Gets the identifier for the PreviewKeyDown routed event.</summary>
    /// <returns>The identifier for the PreviewKeyDown routed event.</returns>
    public static extern RoutedEvent PreviewKeyDownEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the CharacterReceived routed event.</summary>
    /// <returns>The identifier for the CharacterReceived routed event.</returns>
    public static extern RoutedEvent CharacterReceivedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the PreviewKeyUp routed event.</summary>
    /// <returns>The identifier for the PreviewKeyUp routed event.</returns>
    public static extern RoutedEvent PreviewKeyUpEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the GettingFocus routed event.</summary>
    /// <returns>The identifier for the GettingFocus routed event.</returns>
    public static extern RoutedEvent GettingFocusEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the LosingFocus routed event.</summary>
    /// <returns>The identifier for the LosingFocus routed event.</returns>
    public static extern RoutedEvent LosingFocusEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the NoFocusCandidateFound routed event.</summary>
    /// <returns>The identifier for the NoFocusCandidateFound routed event.</returns>
    public static extern RoutedEvent NoFocusCandidateFoundEvent { [MethodImpl] get; }

    /// <summary>Identifies the Lights dependency property.</summary>
    /// <returns>The identifier for the Lights dependency property.</returns>
    public static extern DependencyProperty LightsProperty { [MethodImpl] get; }

    /// <summary>Identifies the KeyTipPlacementMode dependency property.</summary>
    /// <returns>The identifier for the KeyTipPlacementMode dependency property.</returns>
    public static extern DependencyProperty KeyTipPlacementModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the KeyTipHorizontalOffset dependency property.</summary>
    /// <returns>The identifier for the KeyTipHorizontalOffset dependency property.</returns>
    public static extern DependencyProperty KeyTipHorizontalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the KeyTipVerticalOffset dependency property.</summary>
    /// <returns>The identifier for the KeyTipVerticalOffset dependency property.</returns>
    public static extern DependencyProperty KeyTipVerticalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusKeyboardNavigation dependency property.</summary>
    /// <returns>The identifier for the XYFocusKeyboardNavigation dependency property.</returns>
    public static extern DependencyProperty XYFocusKeyboardNavigationProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusUpNavigationStrategy dependency property.</summary>
    /// <returns>The identifier for the XYFocusUpNavigationStrategy dependency property.</returns>
    public static extern DependencyProperty XYFocusUpNavigationStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusDownNavigationStrategy dependency property.</summary>
    /// <returns>The identifier for the XYFocusDownNavigationStrategy dependency property.</returns>
    public static extern DependencyProperty XYFocusDownNavigationStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusLeftNavigationStrategy dependency property.</summary>
    /// <returns>The identifier for the XYFocusLeftNavigationStrategy dependency property.</returns>
    public static extern DependencyProperty XYFocusLeftNavigationStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the XYFocusRightNavigationStrategy dependency property.</summary>
    /// <returns>The identifier for the XYFocusRightNavigationStrategy dependency property.</returns>
    public static extern DependencyProperty XYFocusRightNavigationStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the HighContrastAdjustment dependency property.</summary>
    /// <returns>The identifier for the HighContrastAdjustment dependency property.</returns>
    public static extern DependencyProperty HighContrastAdjustmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the TabFocusNavigation dependency property.</summary>
    /// <returns>The identifier for the TabFocusNavigation dependency property.</returns>
    public static extern DependencyProperty TabFocusNavigationProperty { [MethodImpl] get; }

    /// <summary>Identifies for the ContextFlyout dependency property.</summary>
    /// <returns>The identifier for the ContextFlyout dependency property.</returns>
    public static extern DependencyProperty ContextFlyoutProperty { [MethodImpl] get; }

    /// <summary>Identifies the ExitDisplayModeOnAccessKeyInvoked  dependency property.</summary>
    /// <returns>The identifier for the ExitDisplayModeOnAccessKeyInvoked  dependency property.</returns>
    public static extern DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { [MethodImpl] get; }

    /// <summary>Identifies for the IsAccessKeyScope dependency property.</summary>
    /// <returns>The identifier for the IsAccessKeyScope dependency property.</returns>
    public static extern DependencyProperty IsAccessKeyScopeProperty { [MethodImpl] get; }

    /// <summary>Identifies for the AccessKeyScopeOwner dependency property.</summary>
    /// <returns>The identifier for the AccessKeyScopeOwner dependency property.</returns>
    public static extern DependencyProperty AccessKeyScopeOwnerProperty { [MethodImpl] get; }

    /// <summary>Identifies for the AccessKey dependency property.</summary>
    /// <returns>The identifier for the AccessKey dependency property.</returns>
    public static extern DependencyProperty AccessKeyProperty { [MethodImpl] get; }

    /// <summary>Identifies the Transform3D dependency property.</summary>
    /// <returns>The identifier for the Transform3D dependency property.</returns>
    [IndependentlyAnimatable]
    public static extern DependencyProperty Transform3DProperty { [IndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the CanDrag dependency property.</summary>
    /// <returns>The identifier for the CanDrag dependency property.</returns>
    public static extern DependencyProperty CanDragProperty { [MethodImpl] get; }

    /// <summary>Resumes direct manipulation processing (system-defined panning/zooming) on any ScrollViewer parent that contains the current UIElement.</summary>
    /// <param name="value">The active touch point that initiated the manipulation.</param>
    /// <returns>**true** if a ScrollViewer parent exists and setting the value resulted in resuming the panning/zooming action. **false** if calling the method results in no action.</returns>
    [MethodImpl]
    public static extern bool TryStartDirectManipulation(Pointer value);

    /// <summary>Identifies the CompositeMode dependency property.</summary>
    /// <returns>The identifier for the CompositeMode dependency property.</returns>
    public static extern DependencyProperty CompositeModeProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the KeyDown routed event.</summary>
    /// <returns>The identifier for the KeyDown routed event.</returns>
    public static extern RoutedEvent KeyDownEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the KeyUp routed event.</summary>
    /// <returns>The identifier for the KeyUp routed event.</returns>
    public static extern RoutedEvent KeyUpEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the PointerEntered routed event.</summary>
    /// <returns>The identifier for the PointerEntered routed event.</returns>
    public static extern RoutedEvent PointerEnteredEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the PointerPressed routed event.</summary>
    /// <returns>The identifier for the PointerPressed routed event.</returns>
    public static extern RoutedEvent PointerPressedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the PointerMoved routed event.</summary>
    /// <returns>The identifier for the PointerMoved routed event.</returns>
    public static extern RoutedEvent PointerMovedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the PointerReleased routed event.</summary>
    /// <returns>The identifier for the PointerReleased routed event.</returns>
    public static extern RoutedEvent PointerReleasedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the PointerExited routed event.</summary>
    /// <returns>The identifier for the PointerExited routed event.</returns>
    public static extern RoutedEvent PointerExitedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the PointerCaptureLost routed event.</summary>
    /// <returns>The identifier for the PointerCaptureLost routed event.</returns>
    public static extern RoutedEvent PointerCaptureLostEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the PointerCanceled routed event.</summary>
    /// <returns>The identifier for the PointerCanceled routed event.</returns>
    public static extern RoutedEvent PointerCanceledEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the PointerWheelChanged routed event.</summary>
    /// <returns>The identifier for the PointerWheelChanged routed event.</returns>
    public static extern RoutedEvent PointerWheelChangedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Tapped routed event.</summary>
    /// <returns>The identifier for the Tapped routed event.</returns>
    public static extern RoutedEvent TappedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the DoubleTapped routed event.</summary>
    /// <returns>The identifier for the DoubleTapped routed event.</returns>
    public static extern RoutedEvent DoubleTappedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Holding routed event.</summary>
    /// <returns>The identifier for the Holding routed event.</returns>
    public static extern RoutedEvent HoldingEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the RightTapped routed event.</summary>
    /// <returns>The identifier for the RightTapped routed event.</returns>
    public static extern RoutedEvent RightTappedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the ManipulationStarting routed event.</summary>
    /// <returns>The identifier for the ManipulationStarting routed event.</returns>
    public static extern RoutedEvent ManipulationStartingEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the ManipulationInertiaStarting routed event.</summary>
    /// <returns>The identifier for the ManipulationInertiaStarting routed event.</returns>
    public static extern RoutedEvent ManipulationInertiaStartingEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the ManipulationStarted routed event.</summary>
    /// <returns>The identifier for the ManipulationStarted routed event.</returns>
    public static extern RoutedEvent ManipulationStartedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the ManipulationDelta routed event.</summary>
    /// <returns>The identifier for the ManipulationDelta routed event.</returns>
    public static extern RoutedEvent ManipulationDeltaEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the ManipulationCompleted routed event.</summary>
    /// <returns>The identifier for the ManipulationCompleted routed event.</returns>
    public static extern RoutedEvent ManipulationCompletedEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the DragEnter routed event.</summary>
    /// <returns>The identifier for the DragEnter routed event.</returns>
    public static extern RoutedEvent DragEnterEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the DragLeave routed event.</summary>
    /// <returns>The identifier for the DragLeave routed event.</returns>
    public static extern RoutedEvent DragLeaveEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the DragOver routed event.</summary>
    /// <returns>The identifier for the DragOver routed event.</returns>
    public static extern RoutedEvent DragOverEvent { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Drop routed event.</summary>
    /// <returns>The identifier for the Drop routed event.</returns>
    public static extern RoutedEvent DropEvent { [MethodImpl] get; }

    /// <summary>Identifies the AllowDrop dependency property.</summary>
    /// <returns>The identifier for the AllowDrop dependency property.</returns>
    public static extern DependencyProperty AllowDropProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsHitTestVisible dependency property.</summary>
    /// <returns>The identifier for the IsHitTestVisible dependency property.</returns>
    [IndependentlyAnimatable]
    public static extern DependencyProperty OpacityProperty { [IndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the Clip dependency property.</summary>
    /// <returns>The identifier for the Clip dependency property.</returns>
    [IndependentlyAnimatable]
    public static extern DependencyProperty ClipProperty { [IndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the RenderTransform dependency property.</summary>
    /// <returns>The identifier for the RenderTransform dependency property.</returns>
    [IndependentlyAnimatable]
    public static extern DependencyProperty RenderTransformProperty { [IndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the Projection dependency property.</summary>
    /// <returns>The identifier for the Projection dependency property.</returns>
    [IndependentlyAnimatable]
    public static extern DependencyProperty ProjectionProperty { [IndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the RenderTransformOrigin dependency property.</summary>
    /// <returns>The identifier for the RenderTransformOrigin dependency property.</returns>
    public static extern DependencyProperty RenderTransformOriginProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsHitTestVisible dependency property.</summary>
    /// <returns>The identifier for the IsHitTestVisible dependency property.</returns>
    public static extern DependencyProperty IsHitTestVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the Visibility dependency property.</summary>
    /// <returns>The identifier for the Visibility dependency property.</returns>
    public static extern DependencyProperty VisibilityProperty { [MethodImpl] get; }

    /// <summary>Identifies the UseLayoutRounding dependency property.</summary>
    /// <returns>The identifier for the UseLayoutRounding dependency property.</returns>
    public static extern DependencyProperty UseLayoutRoundingProperty { [MethodImpl] get; }

    /// <summary>Identifies the Transitions dependency property.</summary>
    /// <returns>The identifier for the Transitions dependency property.</returns>
    public static extern DependencyProperty TransitionsProperty { [MethodImpl] get; }

    /// <summary>Identifies the CacheMode dependency property.</summary>
    /// <returns>The identifier for the CacheMode dependency property.</returns>
    public static extern DependencyProperty CacheModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTapEnabled dependency property.</summary>
    /// <returns>The identifier for the IsTapEnabled dependency property.</returns>
    public static extern DependencyProperty IsTapEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsDoubleTapEnabled dependency property.</summary>
    /// <returns>The identifier for the IsDoubleTapEnabled dependency property.</returns>
    public static extern DependencyProperty IsDoubleTapEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsRightTapEnabled dependency property.</summary>
    /// <returns>The identifier for the IsRightTapEnabled dependency property.</returns>
    public static extern DependencyProperty IsRightTapEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsHoldingEnabled dependency property.</summary>
    /// <returns>The identifier for the IsHoldingEnabled dependency property.</returns>
    public static extern DependencyProperty IsHoldingEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the ManipulationMode dependency property.</summary>
    /// <returns>The identifier for the ManipulationMode dependency property.</returns>
    public static extern DependencyProperty ManipulationModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the PointerCaptures dependency property.</summary>
    /// <returns>The identifier for the PointerCaptures dependency property.</returns>
    public static extern DependencyProperty PointerCapturesProperty { [MethodImpl] get; }
  }
}
