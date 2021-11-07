// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.LoopingSelectorAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes LoopingSelector types to Microsoft UI Automation.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class LoopingSelectorAutomationPeer : 
    FrameworkElementAutomationPeer,
    ILoopingSelectorAutomationPeer,
    ISelectionProvider,
    IItemContainerProvider,
    IExpandCollapseProvider,
    IScrollProvider
  {
    /// <summary>Gets a value that indicates whether the control allows more than one child element to be selected concurrently.</summary>
    /// <returns>**true** if multiple selection is allowed; otherwise, **false**.</returns>
    public extern bool CanSelectMultiple { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the control requires at least one child element to be selected.</summary>
    /// <returns>**true** if selection is required; otherwise, **false**.</returns>
    public extern bool IsSelectionRequired { [MethodImpl] get; }

    /// <summary>Retrieves a Microsoft UI Automation provider for each child element that is selected.</summary>
    /// <returns>A generic list of Microsoft UI Automation providers.</returns>
    [MethodImpl]
    public extern IRawElementProviderSimple[] GetSelection();

    /// <summary>Retrieves an element by the specified property value.</summary>
    /// <param name="startAfter">The item in the container after which to begin the search.</param>
    /// <param name="automationProperty">The property that contains the value to retrieve.</param>
    /// <param name="value">The value to retrieve.</param>
    /// <returns>The first item that matches the search criterion if such an item exists; otherwise, **null**.</returns>
    [MethodImpl]
    public extern IRawElementProviderSimple FindItemByProperty(
      IRawElementProviderSimple startAfter,
      AutomationProperty automationProperty,
      object value);

    /// <summary>Gets the state, expanded or collapsed, of the control.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern ExpandCollapseState ExpandCollapseState { [MethodImpl] get; }

    /// <summary>Hides all nodes, controls, or content that are descendants of the control.</summary>
    [MethodImpl]
    public extern void Collapse();

    /// <summary>Displays all child nodes, controls, or content of the control.</summary>
    [MethodImpl]
    public extern void Expand();

    /// <summary>Gets a value that indicates whether the control can scroll horizontally.</summary>
    /// <returns>**true** if the control can scroll horizontally; otherwise, **false**.</returns>
    public extern bool HorizontallyScrollable { [MethodImpl] get; }

    /// <summary>Gets the current horizontal scroll position.</summary>
    /// <returns>The horizontal scroll position as a percentage of the total content area within the control.</returns>
    public extern double HorizontalScrollPercent { [MethodImpl] get; }

    /// <summary>Gets the current horizontal view size.</summary>
    /// <returns>The horizontal size of the viewable region as a percentage of the total content area within the control.</returns>
    public extern double HorizontalViewSize { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the control can scroll vertically.</summary>
    /// <returns>**true** if the control can scroll vertically; otherwise, **false**.</returns>
    public extern bool VerticallyScrollable { [MethodImpl] get; }

    /// <summary>Gets the current vertical scroll position.</summary>
    /// <returns>The vertical scroll position as a percentage of the total content area within the control.</returns>
    public extern double VerticalScrollPercent { [MethodImpl] get; }

    /// <summary>Gets the current vertical view size.</summary>
    /// <returns>The vertical size of the viewable region as a percentage of the total content area within the control.</returns>
    public extern double VerticalViewSize { [MethodImpl] get; }

    /// <summary>Scrolls the visible region of the content area horizontally, vertically, or both.</summary>
    /// <param name="horizontalAmount">The horizontal increment that is specific to the control. Pass NoScroll if the control cannot be scrolled in this direction.</param>
    /// <param name="verticalAmount">The vertical increment that is specific to the control. Pass NoScroll if the control cannot be scrolled in this direction.</param>
    [MethodImpl]
    public extern void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount);

    /// <summary>Sets the horizontal and vertical scroll position as a percentage of the total content area within the control.</summary>
    /// <param name="horizontalPercent">The horizontal position as a percentage of the content area's total range. Pass NoScroll if the control cannot be scrolled in this direction.</param>
    /// <param name="verticalPercent">The vertical position as a percentage of the content area's total range. Pass NoScroll if the control cannot be scrolled in this direction.</param>
    [MethodImpl]
    public extern void SetScrollPercent(double horizontalPercent, double verticalPercent);
  }
}
