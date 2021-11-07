// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ScrollViewer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a scrollable area that can contain other visible elements.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IScrollViewerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IScrollViewerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IScrollViewerStatics4), 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ScrollViewer : 
    ContentControl,
    IScrollViewer,
    IScrollViewer2,
    IScrollViewer3,
    IScrollViewer4,
    IScrollAnchorProvider
  {
    /// <summary>Initializes a new instance of the ScrollViewer class.</summary>
    [MethodImpl]
    public extern ScrollViewer();

    /// <summary>Gets or sets a value that indicates whether a horizontal ScrollBar should be displayed.</summary>
    /// <returns>A ScrollBarVisibility value that indicates whether a horizontal ScrollBar should be displayed. The default value is **Disabled**.</returns>
    public extern ScrollBarVisibility HorizontalScrollBarVisibility { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a vertical ScrollBar should be displayed.</summary>
    /// <returns>A ScrollBarVisibility value that indicates whether a vertical ScrollBar should be displayed. The default value is **Visible**.</returns>
    public extern ScrollBarVisibility VerticalScrollBarVisibility { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the scroll rail is enabled for the horizontal axis.</summary>
    /// <returns>**True** to enable the horizontal scroll rail; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsHorizontalRailEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the scroll rail is enabled for the vertical axis.</summary>
    /// <returns>**True** to enable the vertical scroll rail; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsVerticalRailEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether scroll chaining is enabled from this child to its parent, for the horizontal axis.</summary>
    /// <returns>**true** to enable horizontal scroll chaining from child to parent; otherwise, **false**.</returns>
    public extern bool IsHorizontalScrollChainingEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether scroll chaining is enabled from this child to its parent, for the vertical axis.</summary>
    /// <returns>**true** to enable vertical scroll chaining from child to parent; otherwise, **false**.</returns>
    public extern bool IsVerticalScrollChainingEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether zoom chaining is enabled from this child to its parent.</summary>
    /// <returns>**true** to enable zoom chaining from child to parent; otherwise, **false**.</returns>
    public extern bool IsZoomChainingEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether scroll actions should include inertia in their behavior and value.</summary>
    /// <returns>**true** if scroll actions should include inertia in their behavior and value; otherwise, **false**.</returns>
    public extern bool IsScrollInertiaEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether zoom actions should include inertia in their behavior and value.</summary>
    /// <returns>**true** if zoom actions should include inertia in their behavior and value; otherwise, **false**.</returns>
    public extern bool IsZoomInertiaEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines how manipulation input influences scrolling behavior on the horizontal axis.</summary>
    /// <returns>A value of the enumeration. The typical default (as set through the default template, not class initialization) is **Enabled**.</returns>
    public extern ScrollMode HorizontalScrollMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines how manipulation input influences scrolling behavior on the vertical axis.</summary>
    /// <returns>A value of the enumeration. The typical default (as set through the default template, not class initialization) is **Enabled**.</returns>
    public extern ScrollMode VerticalScrollMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether zoom behavior in the ScrollViewer content is enabled.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern ZoomMode ZoomMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the existing snap points are horizontally aligned versus the initial viewport.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern SnapPointsAlignment HorizontalSnapPointsAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the existing snap points are vertically aligned versus the initial viewport.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern SnapPointsAlignment VerticalSnapPointsAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that declares how manipulation behavior reacts to the snap points along the horizontal axis.</summary>
    /// <returns>A value of the enumeration. The default is **None** but might be set through a control template.</returns>
    public extern SnapPointsType HorizontalSnapPointsType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that declares how manipulation behavior reacts to the snap points along the vertical axis.</summary>
    /// <returns>A value of the enumeration. The default is **None** but might be set through a control template.</returns>
    public extern SnapPointsType VerticalSnapPointsType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how zoom snap points are processed for interaction input.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern SnapPointsType ZoomSnapPointsType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the distance the content has been scrolled horizontally.</summary>
    /// <returns>The distance the content has been scrolled horizontally.</returns>
    public extern double HorizontalOffset { [MethodImpl] get; }

    /// <summary>Gets the horizontal size of the viewable content.</summary>
    /// <returns>The horizontal size of the viewable content.</returns>
    public extern double ViewportWidth { [MethodImpl] get; }

    /// <summary>Gets a value that represents the horizontal size of the area that can be scrolled; the difference between the width of the extent and the width of the viewport.</summary>
    /// <returns>The horizontal size of the area that can be scrolled. This property has no default value.</returns>
    public extern double ScrollableWidth { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the horizontal ScrollBar is visible.</summary>
    /// <returns>A Visibility that indicates whether the horizontal scroll bar is visible. The default value is **Hidden**.</returns>
    public extern Visibility ComputedHorizontalScrollBarVisibility { [MethodImpl] get; }

    /// <summary>Gets the horizontal size of all the scrollable content in the ScrollViewer.</summary>
    /// <returns>The horizontal size of all the scrollable content in the ScrollViewer.</returns>
    public extern double ExtentWidth { [MethodImpl] get; }

    /// <summary>Gets the distance the content has been scrolled vertically.</summary>
    /// <returns>The distance the content has been scrolled vertically.</returns>
    public extern double VerticalOffset { [MethodImpl] get; }

    /// <summary>Gets the vertical size of the viewable content.</summary>
    /// <returns>The vertical size of the viewable content.</returns>
    public extern double ViewportHeight { [MethodImpl] get; }

    /// <summary>Gets a value that represents the vertical size of the area that can be scrolled; the difference between the height of the extent and the height of the viewport.</summary>
    /// <returns>The vertical size of the area that can be scrolled. This property has no default value.</returns>
    public extern double ScrollableHeight { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the vertical ScrollBar is visible.</summary>
    /// <returns>A Visibility that indicates whether the vertical scroll bar is visible. The default value is **Visible**.</returns>
    public extern Visibility ComputedVerticalScrollBarVisibility { [MethodImpl] get; }

    /// <summary>Gets the vertical size of all the scrollable content in the ScrollViewer.</summary>
    /// <returns>The vertical size of all the scrollable content in the ScrollViewer.</returns>
    public extern double ExtentHeight { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates the minimum permitted run-time value of ZoomFactor.</summary>
    /// <returns>The minimum permitted run-time value of ZoomFactor. The default is 0.1.</returns>
    public extern float MinZoomFactor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the maximum permitted run-time value of ZoomFactor.</summary>
    /// <returns>The maximum permitted run-time value of ZoomFactor. The default is 10.</returns>
    public extern float MaxZoomFactor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates the current zoom factor engaged for content scaling.</summary>
    /// <returns>The current zoom factor engaged for content scaling. The default is 1.0, where 1.0 indicates no additional scaling.</returns>
    public extern float ZoomFactor { [MethodImpl] get; }

    /// <summary>Gets the observable collection of zoom snap point factors that are held by the ScrollViewer.</summary>
    /// <returns>A collection of Single values that represent zoom factors as snap points.</returns>
    public extern IVector<float> ZoomSnapPoints { [MethodImpl] get; }

    /// <summary>Occurs when manipulations such as scrolling and zooming have caused the view to change.</summary>
    public extern event EventHandler<ScrollViewerViewChangedEventArgs> ViewChanged;

    /// <summary>Scrolls the content that is within the ScrollViewer to the specified horizontal offset position.</summary>
    /// <deprecated type="deprecate">ScrollToHorizontalOffset may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.</deprecated>
    /// <param name="offset">The position that the content scrolls to.</param>
    [Deprecated("ScrollToHorizontalOffset may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void ScrollToHorizontalOffset(double offset);

    /// <summary>Scrolls the content that is within the ScrollViewer to the specified vertical offset position.</summary>
    /// <deprecated type="deprecate">ScrollToVerticalOffset may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.</deprecated>
    /// <param name="offset">The position that the content scrolls to.</param>
    [Deprecated("ScrollToVerticalOffset may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void ScrollToVerticalOffset(double offset);

    /// <summary>Sets the effective value of ZoomFactor.</summary>
    /// <deprecated type="deprecate">ZoomToFactor may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.</deprecated>
    /// <param name="factor">The zoom factor to set. The factors are based on a norm of 1.0, which represents no zoom applied. The values you can set are also influenced by current values for MinZoomFactor and MaxZoomFactor.</param>
    [Deprecated("ZoomToFactor may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void ZoomToFactor(float factor);

    /// <summary>Called when the value of properties that describe the size and location of the scroll area change.</summary>
    [MethodImpl]
    public extern void InvalidateScrollInfo();

    /// <summary>Gets or sets a value that determines the deferred scrolling behavior for a ScrollViewer.</summary>
    /// <returns>**true** if deferred scrolling should occur; otherwise, **false**.</returns>
    public extern bool IsDeferredScrollingEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the ScrollViewer uses a bring-into-view scroll behavior when an item in the view gets focus.</summary>
    /// <returns>**true** to use a behavior that brings focused items into view. **false** to use a behavior that focused items do not automatically scroll into view. The default is **true**.</returns>
    public extern bool BringIntoViewOnFocusChange { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content of the top, left header.</summary>
    /// <returns>The content of the top, left header.</returns>
    public extern UIElement TopLeftHeader { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content of the left header.</summary>
    /// <returns>The content of the left header.</returns>
    public extern UIElement LeftHeader { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content of the top header.</summary>
    /// <returns>The content of the top header.</returns>
    public extern UIElement TopHeader { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when manipulations such as scrolling and zooming cause the view to change.</summary>
    public extern event EventHandler<ScrollViewerViewChangingEventArgs> ViewChanging;

    [Overload("ChangeView")]
    [MethodImpl]
    public extern bool ChangeView(
      IReference<double> horizontalOffset,
      IReference<double> verticalOffset,
      IReference<float> zoomFactor);

    [Overload("ChangeViewWithOptionalAnimation")]
    [MethodImpl]
    public extern bool ChangeView(
      IReference<double> horizontalOffset,
      IReference<double> verticalOffset,
      IReference<float> zoomFactor,
      bool disableAnimation);

    /// <summary>Occurs when any direct manipulation of the ScrollViewer begins.</summary>
    public extern event EventHandler<object> DirectManipulationStarted;

    /// <summary>Occurs when any direct manipulation of the ScrollViewer finishes.</summary>
    public extern event EventHandler<object> DirectManipulationCompleted;

    /// <summary>Gets or sets a value that indicates whether the ScrollViewer should try to adjust its content to keep it visible when a docked CoreInputView occludes part of it.</summary>
    /// <returns>**true** if the ScrollViewer should try to adjust its content; otherwise, **false**. The default is **false**.</returns>
    public extern bool ReduceViewportForCoreInputViewOcclusions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Determines the horizontal position of the ScrollViewer's *anchor point* with respect to the viewport. By default, the ScrollViewer selects an element as its CurrentAnchor by identifying the element in its viewport nearest to the anchor point.</summary>
    /// <returns>A normalized value (0.0 to 1.0). The default is 0.0.</returns>
    public extern double HorizontalAnchorRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Determines the vertical position of the ScrollViewer's *anchor point* with respect to the viewport. By default, the ScrollViewer selects an element as its CurrentAnchor by identifying the element in its viewport nearest to the anchor point.</summary>
    /// <returns>A normalized value (0.0 to 1.0). The default is 0.0.</returns>
    public extern double VerticalAnchorRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether scrolled content can render outside the bounds of the ScrollViewer.</summary>
    /// <returns>**true** if scrolled content can render outside the bounds of the ScrollViewer; otherwise, **false**. The default is **false**.</returns>
    public extern bool CanContentRenderOutsideBounds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when an anchor is requested at the beginning of the Arrange pass. Handle this event to override the ScrollViewer's default logic to select an anchor element as part of *scroll anchoring*.</summary>
    public extern event TypedEventHandler<ScrollViewer, AnchorRequestedEventArgs> AnchorRequested;

    /// <summary>The currently chosen anchor element to use for scroll anchoring.</summary>
    /// <returns>The most recently chosen UIElement for scroll anchoring after a layout pass, or **null**.</returns>
    public extern UIElement CurrentAnchor { [MethodImpl] get; }

    /// <summary>Registers a UIElement as a potential scroll anchor.</summary>
    /// <param name="element">A UIElement within the subtree of the ScrollViewer.</param>
    [MethodImpl]
    public extern void RegisterAnchorCandidate(UIElement element);

    /// <summary>Unregisters a UIElement as a potential scroll anchor.</summary>
    /// <param name="element">A UIElement within the subtree of the ScrollViewer.</param>
    [MethodImpl]
    public extern void UnregisterAnchorCandidate(UIElement element);

    /// <summary>Identifies the ReduceViewportForCoreInputViewOcclusions dependency property.</summary>
    /// <returns>The identifier for the ReduceViewportForCoreInputViewOcclusions dependency property.</returns>
    public static extern DependencyProperty ReduceViewportForCoreInputViewOcclusionsProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalAnchorRatio dependency property.</summary>
    /// <returns>The identifier for the HorizontalAnchorRatio dependency property.</returns>
    public static extern DependencyProperty HorizontalAnchorRatioProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalAnchorRatio dependency property.</summary>
    /// <returns>The identifier for the VerticalAnchorRatio dependency property.</returns>
    public static extern DependencyProperty VerticalAnchorRatioProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanContentRenderOutsideBounds dependency property.</summary>
    /// <returns>The identifier for the CanContentRenderOutsideBounds dependency property.</returns>
    public static extern DependencyProperty CanContentRenderOutsideBoundsProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the CanContentRenderOutsideBounds dependency property / `ScrollViewer.CanContentRenderOutsideBounds` XAML attached property on a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern bool GetCanContentRenderOutsideBounds(DependencyObject element);

    /// <summary>Sets the value of the CanContentRenderOutsideBounds dependency property / `ScrollViewer.CanContentRenderOutsideBounds` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="canContentRenderOutsideBounds">The value to set.</param>
    [MethodImpl]
    public static extern void SetCanContentRenderOutsideBounds(
      DependencyObject element,
      bool canContentRenderOutsideBounds);

    /// <summary>Identifies the TopLeftHeader dependency property.</summary>
    /// <returns>The identifier for the TopLeftHeader dependency property.</returns>
    public static extern DependencyProperty TopLeftHeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the LeftHeader dependency property.</summary>
    /// <returns>The identifier for the LeftHeader dependency property.</returns>
    public static extern DependencyProperty LeftHeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the TopHeader dependency property.</summary>
    /// <returns>The identifier for the TopHeader dependency property.</returns>
    public static extern DependencyProperty TopHeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalSnapPointsAlignment dependency property.</summary>
    /// <returns>The identifier for the HorizontalSnapPointsAlignment dependency property.</returns>
    public static extern DependencyProperty HorizontalSnapPointsAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalSnapPointsAlignment dependency property.</summary>
    /// <returns>The identifier for the VerticalSnapPointsAlignment dependency property.</returns>
    public static extern DependencyProperty VerticalSnapPointsAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalSnapPointsType dependency property.</summary>
    /// <returns>The identifier for the HorizontalSnapPointsType dependency property.</returns>
    public static extern DependencyProperty HorizontalSnapPointsTypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalSnapPointsType dependency property.</summary>
    /// <returns>The identifier for the VerticalSnapPointsType dependency property.</returns>
    public static extern DependencyProperty VerticalSnapPointsTypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the ZoomSnapPointsType dependency property.</summary>
    /// <returns>The identifier for the ZoomSnapPointsType dependency property.</returns>
    public static extern DependencyProperty ZoomSnapPointsTypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalOffset  dependency property.</summary>
    /// <returns>The identifier for the HorizontalOffset  dependency property.</returns>
    public static extern DependencyProperty HorizontalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the ViewportWidth dependency property.</summary>
    /// <returns>The identifier for the ViewportWidth dependency property.</returns>
    public static extern DependencyProperty ViewportWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the ScrollableWidth  dependency property.</summary>
    /// <returns>The identifier for the ScrollableWidth  dependency property.</returns>
    public static extern DependencyProperty ScrollableWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the ComputedHorizontalScrollBarVisibility dependency property.</summary>
    /// <returns>The identifier for the ComputedHorizontalScrollBarVisibility  dependency property.</returns>
    public static extern DependencyProperty ComputedHorizontalScrollBarVisibilityProperty { [MethodImpl] get; }

    /// <summary>Identifier for the ExtentWidth dependency property.</summary>
    /// <returns>The identifier for the ExtentWidth dependency property.</returns>
    public static extern DependencyProperty ExtentWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalOffset  dependency property.</summary>
    /// <returns>The identifier for the VerticalOffset  dependency property.</returns>
    public static extern DependencyProperty VerticalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the ViewportHeight  dependency property.</summary>
    /// <returns>The identifier for the ViewportHeight dependency property.</returns>
    public static extern DependencyProperty ViewportHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the ScrollableHeight  dependency property.</summary>
    /// <returns>The identifier for the ScrollableHeight  dependency property.</returns>
    public static extern DependencyProperty ScrollableHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the ComputedVerticalScrollBarVisibility  dependency property.</summary>
    /// <returns>The identifier for the ComputedVerticalScrollBarVisibility  dependency property.</returns>
    public static extern DependencyProperty ComputedVerticalScrollBarVisibilityProperty { [MethodImpl] get; }

    /// <summary>Identifier for the ExtentHeight dependency property.</summary>
    /// <returns>The identifier for the ExtentHeight dependency property.</returns>
    public static extern DependencyProperty ExtentHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinZoomFactor dependency property.</summary>
    /// <returns>The identifier for the MinZoomFactor dependency property.</returns>
    public static extern DependencyProperty MinZoomFactorProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxZoomFactor dependency property.</summary>
    /// <returns>The identifier for the MaxZoomFactor dependency property.</returns>
    public static extern DependencyProperty MaxZoomFactorProperty { [MethodImpl] get; }

    /// <summary>Identifies the ZoomFactor dependency property.</summary>
    /// <returns>The identifier for the ZoomFactor dependency property.</returns>
    public static extern DependencyProperty ZoomFactorProperty { [MethodImpl] get; }

    /// <summary>Identifies the ZoomSnapPoints dependency property.</summary>
    /// <returns>The identifier for the ZoomSnapPoints dependency property.</returns>
    public static extern DependencyProperty ZoomSnapPointsProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalScrollBarVisibility  dependency property.</summary>
    /// <returns>The identifier for the HorizontalScrollBarVisibility  dependency property.</returns>
    public static extern DependencyProperty HorizontalScrollBarVisibilityProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the HorizontalScrollBarVisibility dependency property / `ScrollViewer.HorizontalScrollBarVisibility` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern ScrollBarVisibility GetHorizontalScrollBarVisibility(
      DependencyObject element);

    /// <summary>Sets the value of the HorizontalScrollBarVisibility dependency property / `ScrollViewer.HorizontalScrollBarVisibility` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="horizontalScrollBarVisibility">The value to set.</param>
    [MethodImpl]
    public static extern void SetHorizontalScrollBarVisibility(
      DependencyObject element,
      ScrollBarVisibility horizontalScrollBarVisibility);

    /// <summary>Identifies the VerticalScrollBarVisibility  dependency property.</summary>
    /// <returns>The identifier for the VerticalScrollBarVisibility  dependency property.</returns>
    public static extern DependencyProperty VerticalScrollBarVisibilityProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the VerticalScrollBarVisibility dependency property / `ScrollViewer.VerticalScrollBarVisibility` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern ScrollBarVisibility GetVerticalScrollBarVisibility(
      DependencyObject element);

    /// <summary>Sets the value of the VerticalScrollBarVisibility dependency property / `ScrollViewer.VerticalScrollBarVisibility` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="verticalScrollBarVisibility">The value to set.</param>
    [MethodImpl]
    public static extern void SetVerticalScrollBarVisibility(
      DependencyObject element,
      ScrollBarVisibility verticalScrollBarVisibility);

    /// <summary>Identifies the IsHorizontalRailEnabled dependency property.</summary>
    /// <returns>The identifier for the IsHorizontalRailEnabled dependency property.</returns>
    public static extern DependencyProperty IsHorizontalRailEnabledProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the IsHorizontalRailEnabled dependency property / `ScrollViewer.IsHorizontalRailEnabled` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern bool GetIsHorizontalRailEnabled(DependencyObject element);

    /// <summary>Sets the value of the IsHorizontalRailEnabled dependency property / `ScrollViewer.IsHorizontalRailEnabled` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="isHorizontalRailEnabled">The value to set.</param>
    [MethodImpl]
    public static extern void SetIsHorizontalRailEnabled(
      DependencyObject element,
      bool isHorizontalRailEnabled);

    /// <summary>Identifies the IsVerticalRailEnabled dependency property.</summary>
    /// <returns>The identifier for the IsVerticalRailEnabled dependency property.</returns>
    public static extern DependencyProperty IsVerticalRailEnabledProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the IsVerticalRailEnabled dependency property / `ScrollViewer.IsVerticalRailEnabled` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern bool GetIsVerticalRailEnabled(DependencyObject element);

    /// <summary>Sets the value of the IsVerticalRailEnabled dependency property / `ScrollViewer.IsVerticalRailEnabled` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="isVerticalRailEnabled">The value to set.</param>
    [MethodImpl]
    public static extern void SetIsVerticalRailEnabled(
      DependencyObject element,
      bool isVerticalRailEnabled);

    /// <summary>Identifies the IsHorizontalScrollChainingEnabled dependency property.</summary>
    /// <returns>The identifier for the IsHorizontalScrollChainingEnabled dependency property.</returns>
    public static extern DependencyProperty IsHorizontalScrollChainingEnabledProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the IsHorizontalScrollChainingEnabled dependency property / `ScrollViewer.IsHorizontalScrollChainingEnabled` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern bool GetIsHorizontalScrollChainingEnabled(DependencyObject element);

    /// <summary>Sets the value of the IsHorizontalScrollChainingEnabled dependency property / `ScrollViewer.IsHorizontalScrollChainingEnabled` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="isHorizontalScrollChainingEnabled">The value to set.</param>
    [MethodImpl]
    public static extern void SetIsHorizontalScrollChainingEnabled(
      DependencyObject element,
      bool isHorizontalScrollChainingEnabled);

    /// <summary>Identifies the IsVerticalScrollChainingEnabled dependency property.</summary>
    /// <returns>The identifier for the IsVerticalScrollChainingEnabled dependency property.</returns>
    public static extern DependencyProperty IsVerticalScrollChainingEnabledProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the IsVerticalScrollChainingEnabled dependency property / `ScrollViewer.IsVerticalScrollChainingEnabled` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern bool GetIsVerticalScrollChainingEnabled(DependencyObject element);

    /// <summary>Sets the value of the IsVerticalScrollChainingEnabled dependency property / `ScrollViewer.IsVerticalScrollChainingEnabled` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="isVerticalScrollChainingEnabled">The value to set.</param>
    [MethodImpl]
    public static extern void SetIsVerticalScrollChainingEnabled(
      DependencyObject element,
      bool isVerticalScrollChainingEnabled);

    /// <summary>Identifies the IsZoomChainingEnabled dependency property.</summary>
    /// <returns>The identifier for the IsZoomChainingEnabled dependency property.</returns>
    public static extern DependencyProperty IsZoomChainingEnabledProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the IsZoomChainingEnabled dependency property / `ScrollViewer.IsZoomChainingEnabled` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern bool GetIsZoomChainingEnabled(DependencyObject element);

    /// <summary>Sets the value of the IsZoomChainingEnabled dependency property / `ScrollViewer.IsZoomChainingEnabled` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="isZoomChainingEnabled">The value to set.</param>
    [MethodImpl]
    public static extern void SetIsZoomChainingEnabled(
      DependencyObject element,
      bool isZoomChainingEnabled);

    /// <summary>Identifies the IsScrollInertiaEnabled dependency property.</summary>
    /// <returns>The identifier for the IsScrollInertiaEnabled dependency property.</returns>
    public static extern DependencyProperty IsScrollInertiaEnabledProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the IsScrollInertiaEnabled dependency property / `ScrollViewer.IsScrollInertiaEnabled` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern bool GetIsScrollInertiaEnabled(DependencyObject element);

    /// <summary>Sets the value of the IsScrollInertiaEnabled dependency property / `ScrollViewer.IsScrollInertiaEnabled` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="isScrollInertiaEnabled">The value to set.</param>
    [MethodImpl]
    public static extern void SetIsScrollInertiaEnabled(
      DependencyObject element,
      bool isScrollInertiaEnabled);

    /// <summary>Identifies the IsZoomInertiaEnabled dependency property.</summary>
    /// <returns>The identifier for the IsZoomInertiaEnabled dependency property.</returns>
    public static extern DependencyProperty IsZoomInertiaEnabledProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the IsZoomInertiaEnabled dependency property / `ScrollViewer.IsZoomInertiaEnabled` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern bool GetIsZoomInertiaEnabled(DependencyObject element);

    /// <summary>Sets the value of the IsZoomInertiaEnabled dependency property / `ScrollViewer.IsZoomInertiaEnabled` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="isZoomInertiaEnabled">The value to set.</param>
    [MethodImpl]
    public static extern void SetIsZoomInertiaEnabled(
      DependencyObject element,
      bool isZoomInertiaEnabled);

    /// <summary>Identifies the HorizontalScrollMode dependency property.</summary>
    /// <returns>The identifier for the HorizontalScrollMode dependency property.</returns>
    public static extern DependencyProperty HorizontalScrollModeProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the HorizontalScrollMode dependency property / `ScrollViewer.HorizontalScrollMode` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern ScrollMode GetHorizontalScrollMode(DependencyObject element);

    /// <summary>Sets the value of the HorizontalScrollMode dependency property / `ScrollViewer.HorizontalScrollMode` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="horizontalScrollMode">The value to set.</param>
    [MethodImpl]
    public static extern void SetHorizontalScrollMode(
      DependencyObject element,
      ScrollMode horizontalScrollMode);

    /// <summary>Identifies the VerticalScrollMode dependency property.</summary>
    /// <returns>The identifier for the VerticalScrollMode dependency property.</returns>
    public static extern DependencyProperty VerticalScrollModeProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the VerticalScrollMode dependency property / `ScrollViewer.VerticalScrollMode` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern ScrollMode GetVerticalScrollMode(DependencyObject element);

    /// <summary>Sets the value of the VerticalScrollMode dependency property / `ScrollViewer.VerticalScrollMode` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="verticalScrollMode">The value to set.</param>
    [MethodImpl]
    public static extern void SetVerticalScrollMode(
      DependencyObject element,
      ScrollMode verticalScrollMode);

    /// <summary>Identifies the ZoomMode dependency property.</summary>
    /// <returns>The identifier for the ZoomMode dependency property.</returns>
    public static extern DependencyProperty ZoomModeProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the ZoomMode dependency property / `ScrollViewer.ZoomMode` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern ZoomMode GetZoomMode(DependencyObject element);

    /// <summary>Sets the value of the ZoomMode dependency property / `ScrollViewer.ZoomMode` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="zoomMode">The value to set.</param>
    [MethodImpl]
    public static extern void SetZoomMode(DependencyObject element, ZoomMode zoomMode);

    /// <summary>Identifies the IsDeferredScrollingEnabled dependency property.</summary>
    /// <returns>The identifier for the IsDeferredScrollingEnabled dependency property.</returns>
    public static extern DependencyProperty IsDeferredScrollingEnabledProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the IsDeferredScrollingEnabled dependency property / `ScrollViewer.IsDeferredScrollingInertiaEnabled` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern bool GetIsDeferredScrollingEnabled(DependencyObject element);

    /// <summary>Sets the value of the IsDeferredScrollingEnabled dependency property / `ScrollViewer.IsDeferredScrollingEnabled` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="isDeferredScrollingEnabled">The value to set.</param>
    [MethodImpl]
    public static extern void SetIsDeferredScrollingEnabled(
      DependencyObject element,
      bool isDeferredScrollingEnabled);

    /// <summary>Identifies the BringIntoViewOnFocusChange dependency property.</summary>
    /// <returns>The identifier for the BringIntoViewOnFocusChange dependency property.</returns>
    public static extern DependencyProperty BringIntoViewOnFocusChangeProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the BringIntoViewOnFocusChange dependency property / `ScrollViewer.BringIntoViewOnFocusChange` XAML attached property from a specified element.</summary>
    /// <param name="element">The element from which the property value is read.</param>
    /// <returns>The value of the property, as obtained from the property store.</returns>
    [MethodImpl]
    public static extern bool GetBringIntoViewOnFocusChange(DependencyObject element);

    /// <summary>Sets the value of the BringIntoViewOnFocusChange dependency property / `ScrollViewer.BringIntoViewOnFocusChange` XAML attached property on a specified element.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="bringIntoViewOnFocusChange">The value to set.</param>
    [MethodImpl]
    public static extern void SetBringIntoViewOnFocusChange(
      DependencyObject element,
      bool bringIntoViewOnFocusChange);
  }
}
