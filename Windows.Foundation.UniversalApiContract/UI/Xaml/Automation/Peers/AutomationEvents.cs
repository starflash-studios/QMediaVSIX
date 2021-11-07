// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationEvents
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Specifies the event that is raised by the element through the associated AutomationPeer. Used by RaiseAutomationEvent.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum AutomationEvents
  {
    /// <summary>The event that is raised when a tooltip is opened.</summary>
    ToolTipOpened,
    /// <summary>The event that is raised when a tooltip is closed.</summary>
    ToolTipClosed,
    /// <summary>The event that is raised when a menu is opened.</summary>
    MenuOpened,
    /// <summary>The event that is raised when a menu is closed.</summary>
    MenuClosed,
    /// <summary>The event that is raised when the focus has changed. See SetFocus.</summary>
    AutomationFocusChanged,
    /// <summary>The event that is raised when a control is activated. See Invoke.</summary>
    InvokePatternOnInvoked,
    /// <summary>The event that is raised when an item is added to a collection of selected items. See AddToSelection.</summary>
    SelectionItemPatternOnElementAddedToSelection,
    /// <summary>The event that is raised when an item is removed from a collection of selected items. See RemoveFromSelection.</summary>
    SelectionItemPatternOnElementRemovedFromSelection,
    /// <summary>The event that is raised when a single item is selected (which clears any previous selection). See Select.</summary>
    SelectionItemPatternOnElementSelected,
    /// <summary>The event that is raised when a selection in a container has changed significantly.</summary>
    SelectionPatternOnInvalidated,
    /// <summary>The event that is raised when the text selection is modified.</summary>
    TextPatternOnTextSelectionChanged,
    /// <summary>The event that is raised when textual content is modified.</summary>
    TextPatternOnTextChanged,
    /// <summary>The event that is raised when content is loaded asynchronously.</summary>
    AsyncContentLoaded,
    /// <summary>The event that is raised when a property has changed.</summary>
    PropertyChanged,
    /// <summary>The event that is raised when the UI Automation tree structure is changed.</summary>
    StructureChanged,
    /// <summary>The event that is raised when a drag operation originates from a peer.</summary>
    DragStart,
    /// <summary>The event that is raised when a drag operation is canceled from a peer.</summary>
    DragCancel,
    /// <summary>The event that is raised when a drag operation finishes from a peer.</summary>
    DragComplete,
    /// <summary>The event that is raised when a drag operation targets a peer.</summary>
    DragEnter,
    /// <summary>The event that is raised when a drag operation switches targets away from a peer.</summary>
    DragLeave,
    /// <summary>The event that is raised when a drag operation drops on a peer.</summary>
    Dropped,
    /// <summary>The event that is raised as notification when a live region refreshes its content without having focus.</summary>
    LiveRegionChanged,
    /// <summary>The event that is raised when user input has reached its target.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] InputReachedTarget,
    /// <summary>The event that is raised when user input has reached the other element.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] InputReachedOtherElement,
    /// <summary>The event that is raised when user input has been discarded.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] InputDiscarded,
    /// <summary>The event that is raised when a window is closed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] WindowClosed,
    /// <summary>The event that is raised when a window is opened.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] WindowOpened,
    /// <summary>The event that is raised when the conversion target has changed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ConversionTargetChanged,
    /// <summary>The event that is raised when the text was changed in an edit control.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TextEditTextChanged,
    /// <summary>The event that is raised when the window layout has become invalidated. This event is also used for Auto-suggest accessibility.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] LayoutInvalidated,
  }
}
