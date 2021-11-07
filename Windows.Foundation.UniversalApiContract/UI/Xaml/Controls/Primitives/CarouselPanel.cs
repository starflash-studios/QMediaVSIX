// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.CarouselPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents a panel that arranges its items in a line and circles around to the first item when the last item is reached.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ICarouselPanelFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class CarouselPanel : VirtualizingPanel, ICarouselPanel, IScrollSnapPointsInfo
  {
    /// <summary>Initializes a new instance of the CarouselPanel class.</summary>
    [MethodImpl]
    public extern CarouselPanel();

    /// <summary>Not intended for general use. Gets or sets a value that indicates whether scrolling on the vertical axis is possible.</summary>
    /// <returns>**true** if scrolling is possible; otherwise, **false**.</returns>
    public extern bool CanVerticallyScroll { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Not intended for general use. Gets or sets a value that indicates whether scrolling on the horizontal axis is possible.</summary>
    /// <returns>**true** if scrolling is possible; otherwise, **false**.</returns>
    public extern bool CanHorizontallyScroll { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the horizontal size of the panel extent.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double ExtentWidth { [MethodImpl] get; }

    /// <summary>Gets the vertical size of the panel extent.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double ExtentHeight { [MethodImpl] get; }

    /// <summary>Gets the horizontal size of the viewport/content area.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double ViewportWidth { [MethodImpl] get; }

    /// <summary>Gets the vertical size of the viewport/content area.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double ViewportHeight { [MethodImpl] get; }

    /// <summary>Gets the horizontal offset of the scrolled content.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double HorizontalOffset { [MethodImpl] get; }

    /// <summary>Gets the vertical offset of the scrolled content.</summary>
    /// <returns>A value in pixels.</returns>
    public extern double VerticalOffset { [MethodImpl] get; }

    /// <summary>Gets or sets a reference to a ScrollViewer that is the scroll host or scroll owner for scrolling behavior of the CarouselPanel.</summary>
    /// <returns>The scroll host or scroll owner for scrolling behavior.</returns>
    public extern object ScrollOwner { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Scrolls content by one line towards the top.</summary>
    [MethodImpl]
    public extern void LineUp();

    /// <summary>Scrolls content by one line towards the bottom.</summary>
    [MethodImpl]
    public extern void LineDown();

    /// <summary>Scrolls content by one line towards the left.</summary>
    [MethodImpl]
    public extern void LineLeft();

    /// <summary>Scrolls content by one line towards the right.</summary>
    [MethodImpl]
    public extern void LineRight();

    /// <summary>Scrolls content by one page towards the top.</summary>
    [MethodImpl]
    public extern void PageUp();

    /// <summary>Scrolls content by one page towards the bottom.</summary>
    [MethodImpl]
    public extern void PageDown();

    /// <summary>Scrolls content by one page towards the left.</summary>
    [MethodImpl]
    public extern void PageLeft();

    /// <summary>Scrolls content by one page towards the left.</summary>
    [MethodImpl]
    public extern void PageRight();

    /// <summary>Scrolls content by one mousewheel click towards the top.</summary>
    [MethodImpl]
    public extern void MouseWheelUp();

    /// <summary>Scrolls content by one mousewheel click towards the bottom.</summary>
    [MethodImpl]
    public extern void MouseWheelDown();

    /// <summary>Scrolls content by one mousewheel click towards the left.</summary>
    [MethodImpl]
    public extern void MouseWheelLeft();

    /// <summary>Scrolls content by one mousewheel click towards the right.</summary>
    [MethodImpl]
    public extern void MouseWheelRight();

    /// <summary>Changes the horizontal offset of content within the CarouselPanel viewport.</summary>
    /// <param name="offset">The horizontal offset to set, in pixels.</param>
    [MethodImpl]
    public extern void SetHorizontalOffset(double offset);

    /// <summary>Changes the vertical offset of content within the CarouselPanel viewport.</summary>
    /// <param name="offset">The vertical offset to set, in pixels.</param>
    [MethodImpl]
    public extern void SetVerticalOffset(double offset);

    /// <summary>Changes existing offsets in order to make the provided element visible in the viewport, and returns a Rect measurement and position of the area.</summary>
    /// <param name="visual">The element to make visible.</param>
    /// <param name="rectangle">A rectangle representing the element's coordinate space.</param>
    /// <returns>A rectangle that represents the input *rectangle*  Rect transformed by using the CarouselPanel coordinate space.</returns>
    [MethodImpl]
    public extern Rect MakeVisible(UIElement visual, Rect rectangle);

    /// <summary>Gets a value that indicates whether the horizontal snap points for the CarouselPanel are equidistant from each other.</summary>
    /// <returns>**true** if the horizontal snap points for the CarouselPanel are equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreHorizontalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the vertical snap points for the CarouselPanel are equidistant from each other.</summary>
    /// <returns>**true** if the vertical snap points for the CarouselPanel are equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreVerticalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>Occurs when the measurements for horizontal snap points change.</summary>
    public extern event EventHandler<object> HorizontalSnapPointsChanged;

    /// <summary>Occurs when the measurements for vertical snap points change.</summary>
    public extern event EventHandler<object> VerticalSnapPointsChanged;

    /// <summary>Returns the set of distances between irregular snap points for a specified orientation and alignment.</summary>
    /// <param name="orientation">The orientation/dimension for the desired snap point set.</param>
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
  }
}
