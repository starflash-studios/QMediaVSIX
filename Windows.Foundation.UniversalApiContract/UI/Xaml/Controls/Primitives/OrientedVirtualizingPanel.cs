// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Adds infrastructure (provides base class) for virtualizing layout containers that support spatial cues, such as VirtualizingStackPanel and WrapGrid.</summary>
  [Composable(typeof (IOrientedVirtualizingPanelFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class OrientedVirtualizingPanel : 
    VirtualizingPanel,
    IOrientedVirtualizingPanel,
    IScrollSnapPointsInfo,
    IInsertionPanel
  {
    /// <summary>Gets or sets a value that determines how the OrientedVirtualizingPanel measures space for child elements for possible scrolling in the vertical dimension.</summary>
    /// <returns>**true** to support a potentially infinite vertical layout dimension. **false** to restrict to available size.</returns>
    public extern bool CanVerticallyScroll { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines how the OrientedVirtualizingPanel measures space for child elements for possible scrolling in the horizontal dimension.</summary>
    /// <returns>**true** to support a potentially infinite horizontal layout dimension. **false** to restrict to available size.</returns>
    public extern bool CanHorizontallyScroll { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the horizontal size of the panel extent.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double ExtentWidth { [MethodImpl] get; }

    /// <summary>Gets the vertical size of the panel extent.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double ExtentHeight { [MethodImpl] get; }

    /// <summary>Gets the horizontal size of the viewport or content area.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double ViewportWidth { [MethodImpl] get; }

    /// <summary>Gets the vertical size of the viewport or content area.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double ViewportHeight { [MethodImpl] get; }

    /// <summary>Gets the horizontal offset of the scrolled content.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double HorizontalOffset { [MethodImpl] get; }

    /// <summary>Gets the vertical offset of the scrolled content.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double VerticalOffset { [MethodImpl] get; }

    /// <summary>Gets or sets a reference to a ScrollViewer that is the scroll host or scroll owner for scrolling behavior of the OrientedVirtualizingPanel.</summary>
    /// <returns>The scroll host or scroll owner for scrolling behavior.</returns>
    public extern object ScrollOwner { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Scrolls content by one line toward the top.</summary>
    [MethodImpl]
    public extern void LineUp();

    /// <summary>Scrolls content by one line toward the bottom.</summary>
    [MethodImpl]
    public extern void LineDown();

    /// <summary>Scrolls content by one line toward the left.</summary>
    [MethodImpl]
    public extern void LineLeft();

    /// <summary>Scrolls content by one line toward the right.</summary>
    [MethodImpl]
    public extern void LineRight();

    /// <summary>Scrolls content by one page toward the top.</summary>
    [MethodImpl]
    public extern void PageUp();

    /// <summary>Scrolls content by one page toward the bottom.</summary>
    [MethodImpl]
    public extern void PageDown();

    /// <summary>Scrolls content by one page toward the left.</summary>
    [MethodImpl]
    public extern void PageLeft();

    /// <summary>Scrolls content by one page toward the right.</summary>
    [MethodImpl]
    public extern void PageRight();

    /// <summary>Scrolls content by one mouse-wheel click toward the top.</summary>
    [MethodImpl]
    public extern void MouseWheelUp();

    /// <summary>Scrolls content by one mouse-wheel click toward the bottom.</summary>
    [MethodImpl]
    public extern void MouseWheelDown();

    /// <summary>Scrolls content by one mouse-wheel click toward the left.</summary>
    [MethodImpl]
    public extern void MouseWheelLeft();

    /// <summary>Scrolls content by one mouse-wheel click toward the right.</summary>
    [MethodImpl]
    public extern void MouseWheelRight();

    /// <summary>Changes the horizontal offset of content within the OrientedVirtualizingPanel viewport.</summary>
    /// <param name="offset">The horizontal offset to set, in pixels.</param>
    [MethodImpl]
    public extern void SetHorizontalOffset(double offset);

    /// <summary>Changes the vertical offset of content within the OrientedVirtualizingPanel viewport.</summary>
    /// <param name="offset">The offset to set, in pixels.</param>
    [MethodImpl]
    public extern void SetVerticalOffset(double offset);

    /// <summary>Changes existing offsets in order to make the provided element visible in the viewport, and returns a Rect measurement of the area.</summary>
    /// <param name="visual">The element to make visible.</param>
    /// <param name="rectangle">A rectangle representing the element's coordinate space.</param>
    /// <returns>A rectangle representing the input *rectangle*Rect transformed using the OrientedVirtualizingPanel coordinate space after scrolling happens. </returns>
    [MethodImpl]
    public extern Rect MakeVisible(UIElement visual, Rect rectangle);

    /// <summary>Gets a value that indicates whether the horizontal snap points for the OrientedVirtualizingPanel are equidistant from each other.</summary>
    /// <returns>**true** if the horizontal snap points for the OrientedVirtualizingPanel are equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreHorizontalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the vertical snap points for the OrientedVirtualizingPanel are equidistant from each other.</summary>
    /// <returns>**true** if the vertical snap points for the OrientedVirtualizingPanel are equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreVerticalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>Fires when the measurements for horizontal snap points change.</summary>
    public extern event EventHandler<object> HorizontalSnapPointsChanged;

    /// <summary>Fires when the measurements for vertical snap points change.</summary>
    public extern event EventHandler<object> VerticalSnapPointsChanged;

    /// <summary>Returns the set of distances between irregular snap points for a specified orientation and alignment.</summary>
    /// <param name="orientation">The orientation for the desired snap point set.</param>
    /// <param name="alignment">The alignment to use when applying the snap points.</param>
    /// <returns>The read-only collection of snap point distances. Returns an empty collection when no snap points are present.</returns>
    [MethodImpl]
    public extern IVectorView<float> GetIrregularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment);

    /// <summary>Gets the distance between regular snap points for a specified orientation and alignment.</summary>
    /// <param name="orientation">The orientation for the desired snap point set.</param>
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
  }
}
