// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ScrollContentPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Displays the content of a ScrollViewer control.</summary>
  [Static(typeof (IScrollContentPresenterStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ScrollContentPresenter : 
    ContentPresenter,
    IScrollContentPresenter,
    IScrollContentPresenter2
  {
    /// <summary>Initializes a new instance of the ScrollContentPresenter class.</summary>
    [MethodImpl]
    public extern ScrollContentPresenter();

    /// <summary>Gets or sets a value that indicates whether scrolling on the vertical axis is possible.</summary>
    /// <returns>**true** if scrolling is possible; otherwise, **false**.</returns>
    public extern bool CanVerticallyScroll { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether scrolling on the horizontal axis is possible.</summary>
    /// <returns>**true** if scrolling is possible; otherwise, **false**.</returns>
    public extern bool CanHorizontallyScroll { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the horizontal size of all the scrollable content.</summary>
    /// <returns>The horizontal size of all the scrollable content.</returns>
    public extern double ExtentWidth { [MethodImpl] get; }

    /// <summary>Gets the vertical size of all the scrollable content.</summary>
    /// <returns>The vertical size of the all scrollable content.</returns>
    public extern double ExtentHeight { [MethodImpl] get; }

    /// <summary>Gets the horizontal size of the viewable content.</summary>
    /// <returns>The horizontal size of the viewable content.</returns>
    public extern double ViewportWidth { [MethodImpl] get; }

    /// <summary>Gets the vertical size of the viewable content.</summary>
    /// <returns>The vertical size of the viewable content.</returns>
    public extern double ViewportHeight { [MethodImpl] get; }

    /// <summary>Gets the distance the content has been scrolled horizontally.</summary>
    /// <returns>The distance the content has been scrolled horizontally.</returns>
    public extern double HorizontalOffset { [MethodImpl] get; }

    /// <summary>Gets the distance the content has been scrolled vertically.</summary>
    /// <returns>The distance the content has been scrolled vertically.</returns>
    public extern double VerticalOffset { [MethodImpl] get; }

    /// <summary>Gets or sets the ScrollViewer element that controls scrolling behavior.</summary>
    /// <returns>The ScrollViewer element that controls scrolling behavior.</returns>
    public extern object ScrollOwner { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Scrolls the ScrollContentPresenter content upward by one line.</summary>
    [MethodImpl]
    public extern void LineUp();

    /// <summary>Scrolls the ScrollContentPresenter content downward by one line.</summary>
    [MethodImpl]
    public extern void LineDown();

    /// <summary>Scrolls the ScrollContentPresenter content to the left by a predetermined amount.</summary>
    [MethodImpl]
    public extern void LineLeft();

    /// <summary>Scrolls the ScrollContentPresenter content to the right by a predetermined amount.</summary>
    [MethodImpl]
    public extern void LineRight();

    /// <summary>Scrolls up within the content by one page.</summary>
    [MethodImpl]
    public extern void PageUp();

    /// <summary>Scrolls down within the content by one page.</summary>
    [MethodImpl]
    public extern void PageDown();

    /// <summary>Scrolls left within the content by one page.</summary>
    [MethodImpl]
    public extern void PageLeft();

    /// <summary>Scrolls right within the content by one page.</summary>
    [MethodImpl]
    public extern void PageRight();

    /// <summary>Scrolls up within content after a user clicks the wheel button on a mouse.</summary>
    [MethodImpl]
    public extern void MouseWheelUp();

    /// <summary>Scrolls down within content after a user clicks the wheel button on a mouse.</summary>
    [MethodImpl]
    public extern void MouseWheelDown();

    /// <summary>Scrolls left within content after a user clicks the wheel button on a mouse.</summary>
    [MethodImpl]
    public extern void MouseWheelLeft();

    /// <summary>Scrolls right within content after a user clicks the wheel button on a mouse.</summary>
    [MethodImpl]
    public extern void MouseWheelRight();

    /// <summary>Sets the distance the content has been scrolled horizontally.</summary>
    /// <param name="offset">The distance the content has been scrolled horizontally.</param>
    [MethodImpl]
    public extern void SetHorizontalOffset(double offset);

    /// <summary>Sets the distance the content has been scrolled vertically.</summary>
    /// <param name="offset">The distance the content has been scrolled vertically.</param>
    [MethodImpl]
    public extern void SetVerticalOffset(double offset);

    /// <summary>Forces content to scroll until the coordinate space of a visual object is visible.</summary>
    /// <param name="visual">A UIElement that becomes visible.</param>
    /// <param name="rectangle">The bounding rectangle that identifies the coordinate space to make visible.</param>
    /// <returns>A Rect that represents the visible region after scrolling happens.</returns>
    [MethodImpl]
    public extern Rect MakeVisible(UIElement visual, Rect rectangle);

    /// <summary>Gets or sets a value that indicates whether scrolled content can render outside the bounds of the ScrollViewer.</summary>
    /// <returns>**true** if scrolled content can render outside the bounds of the ScrollViewer; otherwise, **false**. The default is **false**.</returns>
    public extern bool CanContentRenderOutsideBounds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether, when used in the ControlTemplate for a ScrollViewer, the presenter restricts the size of its Content to the owning ScrollViewer size.</summary>
    /// <returns>**true** if the presenter restricts its Content size to the owning ScrollViewer size; otherwise, **false**. The default is **false**.</returns>
    public extern bool SizesContentToTemplatedParent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the CanContentRenderOutsideBounds dependency property.</summary>
    /// <returns>The identifier for the CanContentRenderOutsideBounds dependency property.</returns>
    public static extern DependencyProperty CanContentRenderOutsideBoundsProperty { [MethodImpl] get; }

    /// <summary>Identifies the SizesContentToTemplatedParent dependency property.</summary>
    /// <returns>The identifier for the SizesContentToTemplatedParent dependency property.</returns>
    public static extern DependencyProperty SizesContentToTemplatedParentProperty { [MethodImpl] get; }
  }
}
