// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IScrollProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to a control that acts as a scrollable container for a collection of child objects. The children of this element must implement IScrollItemProvider. Implement IScrollProvider in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Scroll.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(927724929, 30486, 19388, 130, 235, 217, 151, 0, 110, 169, 153)]
  public interface IScrollProvider
  {
    /// <summary>Gets a value that indicates whether the control can scroll horizontally.</summary>
    /// <returns>**true** if the control can scroll horizontally; otherwise, **false**.</returns>
    bool HorizontallyScrollable { get; }

    /// <summary>Gets the current horizontal scroll position.</summary>
    /// <returns>The horizontal scroll position as a percentage of the total content area within the control.</returns>
    double HorizontalScrollPercent { get; }

    /// <summary>Gets the current horizontal view size.</summary>
    /// <returns>The horizontal size of the viewable region as a percentage of the total content area within the control.</returns>
    double HorizontalViewSize { get; }

    /// <summary>Gets a value that indicates whether the control can scroll vertically.</summary>
    /// <returns>**true** if the control can scroll vertically; otherwise, **false**.</returns>
    bool VerticallyScrollable { get; }

    /// <summary>Gets the current vertical scroll position.</summary>
    /// <returns>The vertical scroll position as a percentage of the total content area within the control.</returns>
    double VerticalScrollPercent { get; }

    /// <summary>Gets the vertical view size.</summary>
    /// <returns>The vertical size of the viewable region as a percentage of the total content area within the control.</returns>
    double VerticalViewSize { get; }

    /// <summary>Scrolls the visible region of the content area horizontally, vertically, or both.</summary>
    /// <param name="horizontalAmount">The horizontal increment that is specific to the control. Pass NoScroll if the control cannot be scrolled in this direction.</param>
    /// <param name="verticalAmount">The vertical increment that is specific to the control. Pass NoScroll if the control cannot be scrolled in this direction.</param>
    void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount);

    /// <summary>Sets the horizontal and vertical scroll position as a percentage of the total content area within the control.</summary>
    /// <param name="horizontalPercent">The horizontal position as a percentage of the content area's total range. Pass NoScroll if the control cannot be scrolled in this direction.</param>
    /// <param name="verticalPercent">The vertical position as a percentage of the content area's total range. Pass NoScroll if the control cannot be scrolled in this direction.</param>
    void SetScrollPercent(double horizontalPercent, double verticalPercent);
  }
}
