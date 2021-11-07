// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Provides a base class that exposes the automation peer for an associated owner class to Microsoft UI Automation.</summary>
  [Static(typeof (IAutomationPeerStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IAutomationPeerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IAutomationPeerFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  public class AutomationPeer : 
    DependencyObject,
    IAutomationPeer,
    IAutomationPeer2,
    IAutomationPeer3,
    IAutomationPeer4,
    IAutomationPeer5,
    IAutomationPeer6,
    IAutomationPeer7,
    IAutomationPeer8,
    IAutomationPeer9,
    IAutomationPeerProtected,
    IAutomationPeerOverrides,
    IAutomationPeerOverrides2,
    IAutomationPeerOverrides3,
    IAutomationPeerOverrides4,
    IAutomationPeerOverrides5,
    IAutomationPeerOverrides6,
    IAutomationPeerOverrides8,
    IAutomationPeerOverrides9
  {
    /// <summary>Provides base class initialization behavior for AutomationPeer derived classes.</summary>
    [MethodImpl]
    protected extern AutomationPeer();

    /// <summary>Gets or sets an AutomationPeer that is reported to the automation client as the source for all the events that come from this AutomationPeer. See Remarks.</summary>
    /// <returns>The AutomationPeer that is the source of events.</returns>
    public extern AutomationPeer EventsSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the control pattern that is associated with the specified PatternInterface.</summary>
    /// <param name="patternInterface">A value from the PatternInterface enumeration.</param>
    /// <returns>The object that implements the pattern interface; null if the peer does not support this interface.</returns>
    [MethodImpl]
    public extern object GetPattern(PatternInterface patternInterface);

    /// <summary>Raises an automation event.</summary>
    /// <param name="eventId">The event identifier for the event to raise, as a value of the enumeration. See AutomationEvents.</param>
    [MethodImpl]
    public extern void RaiseAutomationEvent(AutomationEvents eventId);

    /// <summary>Raises an event to notify the automation client of a changed property value.</summary>
    /// <param name="automationProperty">The property that changed.</param>
    /// <param name="oldValue">The previous value of the property.</param>
    /// <param name="newValue">The new value of the property.</param>
    [MethodImpl]
    public extern void RaisePropertyChangedEvent(
      AutomationProperty automationProperty,
      object oldValue,
      object newValue);

    /// <summary>Gets the accelerator key combinations for the object that is associated with the UI Automation peer.</summary>
    /// <returns>The accelerator key.</returns>
    [MethodImpl]
    public extern string GetAcceleratorKey();

    /// <summary>Gets the access key for the element that is associated with the automation peer.</summary>
    /// <returns>The access key.</returns>
    [MethodImpl]
    public extern string GetAccessKey();

    /// <summary>Gets the control type for the element that is associated with the UI Automation peer.</summary>
    /// <returns>The control type.</returns>
    [MethodImpl]
    public extern AutomationControlType GetAutomationControlType();

    /// <summary>Gets the **AutomationId** of the element that is associated with the automation peer.</summary>
    /// <returns>The automation identifier.</returns>
    [MethodImpl]
    public extern string GetAutomationId();

    /// <summary>Gets the Rect object that represents the screen coordinates of the element that is associated with the automation peer.</summary>
    /// <returns>The bounding rectangle.</returns>
    [MethodImpl]
    public extern Rect GetBoundingRectangle();

    /// <summary>Gets the collection of child elements that are represented in the UI Automation tree as immediate child elements of the automation peer.</summary>
    /// <returns>The collection of AutomationPeer objects for child elements.</returns>
    [MethodImpl]
    public extern IVector<AutomationPeer> GetChildren();

    /// <summary>Gets a name that is used with AutomationControlType, to differentiate the control that is represented by this AutomationPeer.</summary>
    /// <returns>The class name.</returns>
    [MethodImpl]
    public extern string GetClassName();

    /// <summary>Gets a point on the element that is associated with the automation peer that responds to a mouse click.</summary>
    /// <returns>A point in the clickable area of the element.</returns>
    [MethodImpl]
    public extern Point GetClickablePoint();

    /// <summary>Gets text that describes the functionality of the control that is associated with the automation peer.</summary>
    /// <returns>The help text.</returns>
    [MethodImpl]
    public extern string GetHelpText();

    /// <summary>Gets text that conveys the visual status of the element that is associated with this automation peer.</summary>
    /// <returns>The item status.</returns>
    [MethodImpl]
    public extern string GetItemStatus();

    /// <summary>Gets a string that describes what kind of item an element represents.</summary>
    /// <returns>The kind of item.</returns>
    [MethodImpl]
    public extern string GetItemType();

    /// <summary>Gets the AutomationPeer for the UIElement that is targeted to the element.</summary>
    /// <returns>The AutomationPeer for the element that is targeted by the UIElement.</returns>
    [MethodImpl]
    public extern AutomationPeer GetLabeledBy();

    /// <summary>Gets a localized string that represents the AutomationControlType value for the control that is associated with this automation peer.</summary>
    /// <returns>The type of the control.</returns>
    [MethodImpl]
    public extern string GetLocalizedControlType();

    /// <summary>Gets text that describes the element that is associated with this automation peer. The Microsoft UI Automation  **Name** value is the primary identifier used by most assistive technology when they represent your app's UI by interacting with the Microsoft UI Automation framework.</summary>
    /// <returns>The name of the element that is the peer's owner, as used by assistive technology and other Microsoft UI Automation clients.</returns>
    [MethodImpl]
    public extern string GetName();

    /// <summary>Gets a value that indicates the explicit control orientation, if any.</summary>
    /// <returns>The orientation of the control as a value of the enumeration.</returns>
    [MethodImpl]
    public extern AutomationOrientation GetOrientation();

    /// <summary>Gets a value that indicates whether the element that is associated with this automation peer currently has keyboard focus.</summary>
    /// <returns>**true** if the element has keyboard focus; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool HasKeyboardFocus();

    /// <summary>Gets a value that indicates whether the element that is associated with this automation peer contains data that is presented to the user.</summary>
    /// <returns>**true** if the element is a content element; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsContentElement();

    /// <summary>Gets a value that indicates whether the element is understood by the user as interactive or as contributing to the logical structure of the control in the GUI.</summary>
    /// <returns>**true** if the element is a control; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsControlElement();

    /// <summary>Gets a value that indicates whether the element associated with this automation peer supports interaction.</summary>
    /// <returns>**true** if the element supports interaction; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsEnabled();

    /// <summary>Gets a value that indicates whether the element can accept keyboard focus.</summary>
    /// <returns>**true** if the element can accept keyboard focus; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsKeyboardFocusable();

    /// <summary>Gets a value that indicates whether an element is off the screen.</summary>
    /// <returns>**true** if the element is not on the screen; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsOffscreen();

    /// <summary>Gets a value that indicates whether the element contains sensitive content.</summary>
    /// <returns>**true** if the element contains sensitive content such as a password; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsPassword();

    /// <summary>Gets a value that indicates whether the element that is associated with this peer must be completed on a form.</summary>
    /// <returns>**true** if the element must be completed; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsRequiredForForm();

    /// <summary>Sets the keyboard focus on the element that is associated with this automation peer.</summary>
    [MethodImpl]
    public extern void SetFocus();

    /// <summary>Gets the AutomationPeer that is the parent of this AutomationPeer.</summary>
    /// <deprecated type="deprecate">Consider using Navigate with AutomationNavigationDirection::Parent, which is an improved version of GetParent. For more info, see MSDN.</deprecated>
    /// <returns>The parent automation peer.</returns>
    [Deprecated("Consider using Navigate with AutomationNavigationDirection::Parent, which is an improved version of GetParent. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AutomationPeer GetParent();

    /// <summary>Triggers recalculation of the main properties of the AutomationPeer and raises the PropertyChanged notification to the automation client if the properties have changed.</summary>
    [MethodImpl]
    public extern void InvalidatePeer();

    /// <summary>Gets an AutomationPeer from the specified point.</summary>
    /// <deprecated type="deprecate">Consider using GetElementFromPoint, which is an improved version of GetPeerFromPoint. For more info, see MSDN.</deprecated>
    /// <param name="point">The relative position of the target UI element in the UI.</param>
    /// <returns>The AutomationPeer for the UI element at the specified point.</returns>
    [Deprecated("Consider using GetElementFromPoint, which is an improved version of GetPeerFromPoint. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AutomationPeer GetPeerFromPoint(Point point);

    /// <summary>Gets the live setting notification behavior information for the object that is associated with the UI Automation peer.</summary>
    /// <returns>A value of the enumeration.</returns>
    [MethodImpl]
    public extern AutomationLiveSetting GetLiveSetting();

    /// <summary>Gets the element in the specified direction within the UI automation tree.</summary>
    /// <param name="direction">The specified direction.</param>
    /// <returns>The element in the specified direction within the UI automation tree.</returns>
    [MethodImpl]
    public extern object Navigate(AutomationNavigationDirection direction);

    /// <summary>Gets an element from the specified point.</summary>
    /// <param name="pointInWindowCoordinates">The specified point.</param>
    /// <returns>The element at the specified point.</returns>
    [MethodImpl]
    public extern object GetElementFromPoint(Point pointInWindowCoordinates);

    /// <summary>Gets the element that currently has the focus.</summary>
    /// <returns>The element that currently has the focus.</returns>
    [MethodImpl]
    public extern object GetFocusedElement();

    /// <summary>Shows the available context menu for the owner element.</summary>
    [MethodImpl]
    public extern void ShowContextMenu();

    /// <summary>Provides the peer's behavior when a Microsoft UI Automation client calls GetControlledPeers or an equivalent Microsoft UI Automation client API such as getting a property value as identified by **UIA_ControllerForPropertyId**.</summary>
    /// <returns>A list of the controlled peers for the current automation peer.</returns>
    [MethodImpl]
    public extern IVectorView<AutomationPeer> GetControlledPeers();

    /// <summary>Gets a reference to the list of UI automation annotations for the current automation peer.</summary>
    /// <returns>The list of UI automation annotations.</returns>
    [MethodImpl]
    public extern IVector<AutomationPeerAnnotation> GetAnnotations();

    /// <summary>Sets the AutomationPeer that is the parent of this AutomationPeer.</summary>
    /// <param name="peer">The parent automation peer.</param>
    [MethodImpl]
    public extern void SetParent(AutomationPeer peer);

    [MethodImpl]
    public extern void RaiseTextEditTextChangedEvent(
      AutomationTextEditChangeType automationTextEditChangeType,
      IVectorView<string> changedData);

    /// <summary>Returns the 1-based integer for the ordinal position in the set for the element that is associated with the automation peer.</summary>
    /// <returns>The 1-based integer for the ordinal position in the set.</returns>
    [MethodImpl]
    public extern int GetPositionInSet();

    /// <summary>Returns the 1-based integer for the size of the set where the element that is associated with the automation peer is located.</summary>
    /// <returns>The 1-based integer for the size of the set.</returns>
    [MethodImpl]
    public extern int GetSizeOfSet();

    /// <summary>Returns the 1-based integer for the level (hierarchy) of the element that is associated with the automation peer.</summary>
    /// <returns>The 1-based integer for the level of the element.</returns>
    [MethodImpl]
    public extern int GetLevel();

    /// <summary>Raises an event to notify the Microsoft UI Automation core that the tree structure has changed.</summary>
    /// <param name="structureChangeType">The type of change that has occurred.</param>
    /// <param name="child">The element to which the change has been made.</param>
    [MethodImpl]
    public extern void RaiseStructureChangedEvent(
      AutomationStructureChangeType structureChangeType,
      AutomationPeer child);

    /// <summary>Gets the landmark type for this automation peer.</summary>
    /// <returns>The landmark type for this automation peer.</returns>
    [MethodImpl]
    public extern AutomationLandmarkType GetLandmarkType();

    /// <summary>Gets a localized string that represents the AutomationLandmarkType value for the element that is associated with this automation peer.</summary>
    /// <returns>The landmark type of the element.</returns>
    [MethodImpl]
    public extern string GetLocalizedLandmarkType();

    /// <summary>Gets a Boolean value that indicates whether the automation element represents peripheral UI.</summary>
    /// <returns>A Boolean value that indicates whether the automation element represents peripheral UI.</returns>
    [MethodImpl]
    public extern bool IsPeripheral();

    /// <summary>Gets a Boolean value that indicates whether the entered or selected value is valid for the form rule associated with the automation element.</summary>
    /// <returns>A Boolean value that indicates whether the entered or selected value is valid for the form rule associated with the automation element. The default return value is **true**.</returns>
    [MethodImpl]
    public extern bool IsDataValidForForm();

    /// <summary>Gets a localized string that describes the actual visual appearance or contents of something such as an image or image control.</summary>
    /// <returns>A localized string that describes the actual visual appearance or contents of something such as an image or image control.</returns>
    [MethodImpl]
    public extern string GetFullDescription();

    /// <summary>Calls GetCultureCore to get the culture value for the element that is associated with the automation peer.</summary>
    /// <returns>The value of the culture property for the element that is associated with the automation peer.</returns>
    [MethodImpl]
    public extern int GetCulture();

    /// <summary>Initiates a notification event.</summary>
    /// <param name="notificationKind">Specifies the type of the notification.</param>
    /// <param name="notificationProcessing">Specifies the order in which to process the notification.</param>
    /// <param name="displayString">A display string describing the event.</param>
    /// <param name="activityId">A unique non-localized string to identify an action or group of actions. Use this to pass additional information to the event handler.</param>
    [MethodImpl]
    public extern void RaiseNotificationEvent(
      AutomationNotificationKind notificationKind,
      AutomationNotificationProcessing notificationProcessing,
      string displayString,
      string activityId);

    /// <summary>Gets the heading level of the UI Automation element that is associated with this automation peer.</summary>
    /// <returns>The text heading level.</returns>
    [MethodImpl]
    public extern AutomationHeadingLevel GetHeadingLevel();

    /// <summary>Gets a value that indicates whether the element associated with this automation peer is a dialog window.</summary>
    /// <returns>**true** if the element is a dialog; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsDialog();

    [MethodImpl]
    extern AutomationPeer IAutomationPeerProtected.PeerFromProvider(
      IRawElementProviderSimple provider);

    [MethodImpl]
    extern IRawElementProviderSimple IAutomationPeerProtected.ProviderFromPeer(
      AutomationPeer peer);

    [MethodImpl]
    extern object IAutomationPeerOverrides.GetPatternCore(
      PatternInterface patternInterface);

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetAcceleratorKeyCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetAccessKeyCore();

    [MethodImpl]
    extern AutomationControlType IAutomationPeerOverrides.GetAutomationControlTypeCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetAutomationIdCore();

    [MethodImpl]
    extern Rect IAutomationPeerOverrides.GetBoundingRectangleCore();

    [MethodImpl]
    extern IVector<AutomationPeer> IAutomationPeerOverrides.GetChildrenCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetClassNameCore();

    [MethodImpl]
    extern Point IAutomationPeerOverrides.GetClickablePointCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetHelpTextCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetItemStatusCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetItemTypeCore();

    [MethodImpl]
    extern AutomationPeer IAutomationPeerOverrides.GetLabeledByCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetLocalizedControlTypeCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides.GetNameCore();

    [MethodImpl]
    extern AutomationOrientation IAutomationPeerOverrides.GetOrientationCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.HasKeyboardFocusCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsContentElementCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsControlElementCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsEnabledCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsKeyboardFocusableCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsOffscreenCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsPasswordCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides.IsRequiredForFormCore();

    [MethodImpl]
    extern void IAutomationPeerOverrides.SetFocusCore();

    [MethodImpl]
    extern AutomationPeer IAutomationPeerOverrides.GetPeerFromPointCore(
      Point point);

    [MethodImpl]
    extern AutomationLiveSetting IAutomationPeerOverrides.GetLiveSettingCore();

    [MethodImpl]
    extern void IAutomationPeerOverrides2.ShowContextMenuCore();

    [MethodImpl]
    extern IVectorView<AutomationPeer> IAutomationPeerOverrides2.GetControlledPeersCore();

    [MethodImpl]
    extern object IAutomationPeerOverrides3.NavigateCore(
      AutomationNavigationDirection direction);

    [MethodImpl]
    extern object IAutomationPeerOverrides3.GetElementFromPointCore(
      Point pointInWindowCoordinates);

    [MethodImpl]
    extern object IAutomationPeerOverrides3.GetFocusedElementCore();

    [MethodImpl]
    extern IVector<AutomationPeerAnnotation> IAutomationPeerOverrides3.GetAnnotationsCore();

    [MethodImpl]
    extern int IAutomationPeerOverrides3.GetPositionInSetCore();

    [MethodImpl]
    extern int IAutomationPeerOverrides3.GetSizeOfSetCore();

    [MethodImpl]
    extern int IAutomationPeerOverrides3.GetLevelCore();

    [MethodImpl]
    extern AutomationLandmarkType IAutomationPeerOverrides4.GetLandmarkTypeCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides4.GetLocalizedLandmarkTypeCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides5.IsPeripheralCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides5.IsDataValidForFormCore();

    [MethodImpl]
    extern string IAutomationPeerOverrides5.GetFullDescriptionCore();

    [MethodImpl]
    extern IIterable<AutomationPeer> IAutomationPeerOverrides5.GetDescribedByCore();

    [MethodImpl]
    extern IIterable<AutomationPeer> IAutomationPeerOverrides5.GetFlowsToCore();

    [MethodImpl]
    extern IIterable<AutomationPeer> IAutomationPeerOverrides5.GetFlowsFromCore();

    [MethodImpl]
    extern int IAutomationPeerOverrides6.GetCultureCore();

    [MethodImpl]
    extern AutomationHeadingLevel IAutomationPeerOverrides8.GetHeadingLevelCore();

    [MethodImpl]
    extern bool IAutomationPeerOverrides9.IsDialogCore();

    /// <summary>Generates a runtime identifier for the element that is associated with the automation peer.</summary>
    /// <returns>The runtime identifier for the element .</returns>
    [MethodImpl]
    public static extern RawElementProviderRuntimeId GenerateRawElementProviderRuntimeId();

    /// <summary>Gets a value that indicates whether Microsoft UI Automation reports that a client is listening for the specified event.</summary>
    /// <param name="eventId">One of the enumeration values.</param>
    /// <returns>**true** if Microsoft UI Automation reports a client is listening for the specified event; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool ListenerExists(AutomationEvents eventId);
  }
}
