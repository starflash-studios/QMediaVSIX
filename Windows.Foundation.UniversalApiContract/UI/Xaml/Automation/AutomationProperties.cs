// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AutomationProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Provides support for getting or setting instance-level values of automation properties. These property values are set as attached properties (typically in XAML) and supplement or override automation property values from a control's AutomationPeer.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAutomationPropertiesStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationPropertiesStatics4), 131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationPropertiesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationPropertiesStatics5), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationPropertiesStatics6), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAutomationPropertiesStatics7), 393216, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IAutomationPropertiesStatics9), 917504, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationPropertiesStatics8), 458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class AutomationProperties : IAutomationProperties
  {
    public static extern DependencyProperty AutomationControlTypeProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern AutomationControlType GetAutomationControlType(
      UIElement element);

    [MethodImpl]
    public static extern void SetAutomationControlType(
      UIElement element,
      AutomationControlType value);

    /// <summary>Identifies the AutomationProperties.IsDialog attached property, which is a Boolean value that indicates whether the automation element is a dialog window.</summary>
    /// <returns>The identifier for the AutomationProperties.IsDialog attached property.</returns>
    public static extern DependencyProperty IsDialogProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.IsDialog attached property for the specified DependencyObject.</summary>
    /// <param name="element">The object to check.</param>
    /// <returns>**true** if the specified element is identified as a dialog window; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsDialog(DependencyObject element);

    /// <summary>Sets a Boolean value that indicates whether the specified element should be identified as a dialog window.</summary>
    /// <param name="element">The object to identify as a dialog window.</param>
    /// <param name="value">**true** if the element should be identified as a dialog window; otherwise, **false**.</param>
    [MethodImpl]
    public static extern void SetIsDialog(DependencyObject element, bool value);

    /// <summary>Gets the identifier for the **HeadingLevel** attached property, which indicates the heading level for a UI Automation element.</summary>
    /// <returns>The identifier for the **HeadingLevel** attached property.</returns>
    public static extern DependencyProperty HeadingLevelProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.HeadingLevel property for the specified DependencyObject.</summary>
    /// <param name="element">The specified DependencyObject.</param>
    /// <returns>The value of the AutomationProperties.HeadingLevel property.</returns>
    [MethodImpl]
    public static extern AutomationHeadingLevel GetHeadingLevel(
      DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.HeadingLevel property for the specified DependencyObject.</summary>
    /// <param name="element">The specified DependencyObject.</param>
    /// <param name="value">The value for the heading level.</param>
    [MethodImpl]
    public static extern void SetHeadingLevel(
      DependencyObject element,
      AutomationHeadingLevel value);

    /// <summary>Gets the identifier for the culture attached property which contains a locale identifier for the automation element (for example, 0x0409 for "en-US" or English (United States)).</summary>
    /// <returns>The identifier for the culture attached property.</returns>
    public static extern DependencyProperty CultureProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the CultureProperty attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The value of the culture property for the specified *element*.</returns>
    [MethodImpl]
    public static extern int GetCulture(DependencyObject element);

    /// <summary>Sets the value of the CultureProperty attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the culture property.</param>
    /// <param name="value">The value of the culture property to set for the specified *element*.</param>
    [MethodImpl]
    public static extern void SetCulture(DependencyObject element, int value);

    /// <summary>Identifies the Boolean dependency property that indicates if the automation element represents peripheral UI.</summary>
    /// <returns>The dependency property identifier.</returns>
    public static extern DependencyProperty IsPeripheralProperty { [MethodImpl] get; }

    /// <summary>Gets a Boolean value that indicates whether the specified element represents peripheral UI.</summary>
    /// <param name="element">The element to check for peripheral data.</param>
    /// <returns>A Boolean value that indicates whether the DependencyObject specified by the *element* parameter represents peripheral UI.</returns>
    [MethodImpl]
    public static extern bool GetIsPeripheral(DependencyObject element);

    /// <summary>Sets a Boolean value that indicates whether the specified element represents peripheral UI.</summary>
    /// <param name="element">The element for which to set peripheral data.</param>
    /// <param name="value">A Boolean value that indicates whether the DependencyObject specified by the *element* parameter represents peripheral UI.</param>
    [MethodImpl]
    public static extern void SetIsPeripheral(DependencyObject element, bool value);

    /// <summary>Identifies the Boolean dependency property that indicates if the data is valid for the form.</summary>
    /// <returns>The dependency property identifier.</returns>
    public static extern DependencyProperty IsDataValidForFormProperty { [MethodImpl] get; }

    /// <summary>Gets a Boolean value that indicates whether the entered or selected value is valid for the form rule associated with the specified element.</summary>
    /// <param name="element">The element for which to get data validation.</param>
    /// <returns>A Boolean value that indicates whether the entered or selected value is valid for the form rule associated with the object specified by the *element* parameter.</returns>
    [MethodImpl]
    public static extern bool GetIsDataValidForForm(DependencyObject element);

    /// <summary>Sets a Boolean value that indicates whether the entered or selected value is valid for the form rule associated with the specified element.</summary>
    /// <param name="element">The element for which to set data validation.</param>
    /// <param name="value">A Boolean value that indicates whether the entered or selected data is valid for the form.</param>
    [MethodImpl]
    public static extern void SetIsDataValidForForm(DependencyObject element, bool value);

    /// <summary>Gets the identifier for the full description attached property, which exposes a localized string containing extended description text for an element.</summary>
    /// <returns>The identifier for the full description attached property.</returns>
    public static extern DependencyProperty FullDescriptionProperty { [MethodImpl] get; }

    /// <summary>Gets a localized string that describes the visual appearance or contents of the specified DependencyObject.</summary>
    /// <param name="element">The object for which to get the full description.</param>
    /// <returns>A localized string that describes the visual appearance or contents of the object specified in the *element* parameter.</returns>
    [MethodImpl]
    public static extern string GetFullDescription(DependencyObject element);

    /// <summary>Sets a localized string that describes the visual appearance or contents of the specified DependencyObject.</summary>
    /// <param name="element">The object for which to set the full description.</param>
    /// <param name="value">The localized full description of the object specified in the *element* parameter.</param>
    [MethodImpl]
    public static extern void SetFullDescription(DependencyObject element, string value);

    /// <summary>Identifies the localized control type dependency property, which is a text string describing the type of control that the automation element represents.</summary>
    /// <returns>The dependency property identifier.</returns>
    public static extern DependencyProperty LocalizedControlTypeProperty { [MethodImpl] get; }

    /// <summary>Gets a localized string that indicates the type of the specified control.</summary>
    /// <param name="element">The control for which to retrieve the type.</param>
    /// <returns>A localized string that indicates the type of the control specified by the *element* parameter.</returns>
    [MethodImpl]
    public static extern string GetLocalizedControlType(DependencyObject element);

    /// <summary>Sets a localized string that indicates the type of the specified control.</summary>
    /// <param name="element">The control for which to set the type.</param>
    /// <param name="value">A localized string that indicates the type of the control specified by the *element* parameter.</param>
    [MethodImpl]
    public static extern void SetLocalizedControlType(DependencyObject element, string value);

    /// <summary>Gets the identifier for the described by attached property, which is an array of elements that provide more information about the automation element.</summary>
    /// <returns>The identifier for the described by attached property.</returns>
    public static extern DependencyProperty DescribedByProperty { [MethodImpl] get; }

    /// <summary>Gets a collection of elements that provide more information about the specified automation element.</summary>
    /// <param name="element">The automation element for which to get the described by collection.</param>
    /// <returns>A collection of elements that provide more information about the automation element specified by the *element* parameter.</returns>
    [MethodImpl]
    public static extern IVector<DependencyObject> GetDescribedBy(
      DependencyObject element);

    /// <summary>Gets the identifier for the **FlowsTo** attached property, which is an array of automation elements that suggests the reading order after the current automation element.</summary>
    /// <returns>The identifier for the "flows to" attached property.</returns>
    public static extern DependencyProperty FlowsToProperty { [MethodImpl] get; }

    /// <summary>Gets a list of automation elements that suggests the reading order after the specified automation element.</summary>
    /// <param name="element">The element for which to get the following reading order elements.</param>
    /// <returns>A list of automation elements that suggests the reading order after the automation element specified by the *element* parameter.</returns>
    [MethodImpl]
    public static extern IVector<DependencyObject> GetFlowsTo(
      DependencyObject element);

    /// <summary>Gets the identifier for the **FlowsFrom** attached property, which is an array of automation elements that suggests the reading order before the current automation element.</summary>
    /// <returns>The identifier for the **FlowsFrom** attached property.</returns>
    public static extern DependencyProperty FlowsFromProperty { [MethodImpl] get; }

    /// <summary>Gets a list of automation elements that suggests the reading order before the specified automation element.</summary>
    /// <param name="element">The element for which to get the preceding reading order elements.</param>
    /// <returns>A list of automation elements that suggests the reading order before the automation element specified by the *element* parameter.</returns>
    [MethodImpl]
    public static extern IVector<DependencyObject> GetFlowsFrom(
      DependencyObject element);

    /// <summary>Gets the identifier for the landmark type attached property, which is a Landmark Type Identifier associated with an element.</summary>
    /// <returns>The identifier for the landmark type attached property.</returns>
    public static extern DependencyProperty LandmarkTypeProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the landmark type attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The landmark type of the *element*</returns>
    [MethodImpl]
    public static extern AutomationLandmarkType GetLandmarkType(
      DependencyObject element);

    /// <summary>Sets the value of the landmark type attached property for the specified DependencyObject.</summary>
    /// <param name="element">The specified DependencyObject.</param>
    /// <param name="value">The value of the landmark type property.</param>
    [MethodImpl]
    public static extern void SetLandmarkType(
      DependencyObject element,
      AutomationLandmarkType value);

    /// <summary>Gets the identifier for the localized landmark type attached property, which is a localized text string describing the type of landmark that the automation element represents.</summary>
    /// <returns>The identifier for the localized landmark type attached property.</returns>
    public static extern DependencyProperty LocalizedLandmarkTypeProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the localized landmark type attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The localized string defining the landmark type of the *element*.</returns>
    [MethodImpl]
    public static extern string GetLocalizedLandmarkType(DependencyObject element);

    /// <summary>Sets the value of the localized landmark type attached property for the specified DependencyObject.</summary>
    /// <param name="element">The specified DependencyObject.</param>
    /// <param name="value">The localized string defining the landmark type of the *element*.</param>
    [MethodImpl]
    public static extern void SetLocalizedLandmarkType(DependencyObject element, string value);

    /// <summary>Gets the identifier for the **PositionInSet** attached property, which is a 1-based integer associated with an automation element.</summary>
    /// <returns>The identifier for the **PositionInSet** attached property.</returns>
    public static extern DependencyProperty PositionInSetProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the  property for the specified .</summary>
    /// <param name="element">The specified .</param>
    /// <returns>The value of the  property.</returns>
    [MethodImpl]
    public static extern int GetPositionInSet(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.PositionInSet attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The value of the property.</param>
    [MethodImpl]
    public static extern void SetPositionInSet(DependencyObject element, int value);

    /// <summary>Gets the identifier for the  attached property.</summary>
    /// <returns>The identifier for the  attached property.</returns>
    public static extern DependencyProperty SizeOfSetProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the  property for the specified .</summary>
    /// <param name="element">The specified .</param>
    /// <returns>The value of the  property.</returns>
    [MethodImpl]
    public static extern int GetSizeOfSet(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.SizeOfSet attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The value of the property.</param>
    [MethodImpl]
    public static extern void SetSizeOfSet(DependencyObject element, int value);

    /// <summary>Gets the identifier for the **Level** attached property, which is a 1-based integer associated with an automation element.</summary>
    /// <returns>The identifier for the **Level** attached property.</returns>
    public static extern DependencyProperty LevelProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the  property for the specified .</summary>
    /// <param name="element">The specified .</param>
    /// <returns>The value of the  property.</returns>
    [MethodImpl]
    public static extern int GetLevel(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.Level attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The value of the property.</param>
    [MethodImpl]
    public static extern void SetLevel(DependencyObject element, int value);

    /// <summary>Identifies a dependency property that's used for a list of annotation objects in a document, such as comment, header, footer, and so on.</summary>
    /// <returns>The identifier for the **Annotations** attached property.</returns>
    public static extern DependencyProperty AnnotationsProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.Annotations property for the specified DependencyObject.</summary>
    /// <param name="element">The specified DependencyObject.</param>
    /// <returns>The value of the AutomationProperties.Annotations property.</returns>
    [MethodImpl]
    public static extern IVector<AutomationAnnotation> GetAnnotations(
      DependencyObject element);

    /// <summary>Identifies the AutomationProperties.AccessibilityView attached property. Set this attached property on individual elements in order to change their element visibility to specific modes requested by a UI Automation client.</summary>
    /// <returns>The identifier for the AutomationProperties.AccessibilityView attached property.</returns>
    public static extern DependencyProperty AccessibilityViewProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.AccessibilityView attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The accessibility view setting, as a value of the enumeration.</returns>
    [MethodImpl]
    public static extern AccessibilityView GetAccessibilityView(
      DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.AccessibilityView attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to set the attached property on.</param>
    /// <param name="value">The enumeration value to set.</param>
    [MethodImpl]
    public static extern void SetAccessibilityView(
      DependencyObject element,
      AccessibilityView value);

    /// <summary>Identifies the ControlledPeers attached property, which is used for a collection of automation elements that can be manipulated by the specified automation element.</summary>
    /// <returns>The identifier for the ControlledPeers attached property.</returns>
    public static extern DependencyProperty ControlledPeersProperty { [MethodImpl] get; }

    /// <summary>A static utility method that retrieves the list of controlled peers from a target owner.</summary>
    /// <param name="element">The owner object to retrieve controlled peers from.</param>
    /// <returns>A list containing the peers that the target element controls.</returns>
    [MethodImpl]
    public static extern IVector<UIElement> GetControlledPeers(
      DependencyObject element);

    /// <summary>Identifies the AutomationProperties.AcceleratorKey attached property, which is a string containing the accelerator key (also called shortcut key) combinations for the automation element.</summary>
    /// <returns>The identifier for the AutomationProperties.AcceleratorKey attached property.</returns>
    public static extern DependencyProperty AcceleratorKeyProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.AcceleratorKey attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The accelerator key, as a string.</returns>
    [MethodImpl]
    public static extern string GetAcceleratorKey(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.AcceleratorKey attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The accelerator key value to set.</param>
    [MethodImpl]
    public static extern void SetAcceleratorKey(DependencyObject element, string value);

    /// <summary>Identifies the AutomationProperties.AccessKey attached property, which is a string containing the access key character for the automation element.</summary>
    /// <returns>The identifier for the AutomationProperties.AccessKey attached property.</returns>
    public static extern DependencyProperty AccessKeyProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.AccessKey attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The access key, as a string.</returns>
    [MethodImpl]
    public static extern string GetAccessKey(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.AccessKey attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The access key value to set.</param>
    [MethodImpl]
    public static extern void SetAccessKey(DependencyObject element, string value);

    /// <summary>Identifies the AutomationProperties.AutomationId attached property, which is a string containing the UI Automation identifier (ID) for the automation element.</summary>
    /// <returns>The identifier for the AutomationProperties.AutomationId attached property.</returns>
    public static extern DependencyProperty AutomationIdProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.AutomationId attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The UI Automation identifier for the specified element.</returns>
    [MethodImpl]
    public static extern string GetAutomationId(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.AutomationId attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The UI Automation identifier value to set.</param>
    [MethodImpl]
    public static extern void SetAutomationId(DependencyObject element, string value);

    /// <summary>Identifies the AutomationProperties.HelpText attached property, which is a help text string associated with the automation element.</summary>
    /// <returns>The identifier for the AutomationProperties.HelpText attached property.</returns>
    public static extern DependencyProperty HelpTextProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.HelpText attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The help text for the specified element.</returns>
    [MethodImpl]
    public static extern string GetHelpText(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.HelpText attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The help text.</param>
    [MethodImpl]
    public static extern void SetHelpText(DependencyObject element, string value);

    /// <summary>Identifies the AutomationProperties.IsRequiredForForm attached property, which is a Boolean value that indicates whether the automation element is required to be filled out on a form.</summary>
    /// <returns>The identifier for the AutomationProperties.IsRequiredForForm attached property.</returns>
    public static extern DependencyProperty IsRequiredForFormProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.IsRequiredForForm attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>**true** if the specified element is required for completion of a form; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsRequiredForForm(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.IsRequiredForForm attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">**true** to specify that the element is required to be filled out on a form; otherwise, **false**.</param>
    [MethodImpl]
    public static extern void SetIsRequiredForForm(DependencyObject element, bool value);

    /// <summary>Identifies the ItemStatus attached property, which describes the status of an automation element item.</summary>
    /// <returns>A text string containing an identifier for the ItemStatus attached property.</returns>
    public static extern DependencyProperty ItemStatusProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.ItemStatus attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The item status of the element.</returns>
    [MethodImpl]
    public static extern string GetItemStatus(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.ItemStatus attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The item status.</param>
    [MethodImpl]
    public static extern void SetItemStatus(DependencyObject element, string value);

    /// <summary>Identifies the AutomationProperties.ItemType attached property, which is a text string describing the type of the automation element.</summary>
    /// <returns>The identifier for the AutomationProperties.ItemType dependency property.</returns>
    public static extern DependencyProperty ItemTypeProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.ItemType attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The item type of the element.</returns>
    [MethodImpl]
    public static extern string GetItemType(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.ItemType attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The item type.</param>
    [MethodImpl]
    public static extern void SetItemType(DependencyObject element, string value);

    /// <summary>Identifies the AutomationProperties.LabeledBy attached property, which is an automation element that contains the text label for this element.</summary>
    /// <returns>The identifier for the AutomationProperties.LabeledBy attached property.</returns>
    public static extern DependencyProperty LabeledByProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.LabeledBy attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The element that is targeted by the label.</returns>
    [MethodImpl]
    public static extern UIElement GetLabeledBy(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.LabeledBy attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The UI element that represents the label for *element*.</param>
    [MethodImpl]
    public static extern void SetLabeledBy(DependencyObject element, UIElement value);

    /// <summary>Identifies the AutomationProperties.Name attached property, which is a string that holds the name of the automation element.</summary>
    /// <returns>The identifier for the AutomationProperties.Name attached property.</returns>
    public static extern DependencyProperty NameProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.Name attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The name of the specified element.</returns>
    [MethodImpl]
    public static extern string GetName(DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.Name attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The object name.</param>
    [MethodImpl]
    public static extern void SetName(DependencyObject element, string value);

    /// <summary>Identifies the AutomationProperties.LiveSetting attached property, which is supported by an automation element that represents a live region.</summary>
    /// <returns>The property identifier for the AutomationProperties.LiveSetting attached property.</returns>
    public static extern DependencyProperty LiveSettingProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the AutomationProperties.LiveSetting attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject to check.</param>
    /// <returns>The live setting value for the specified element.</returns>
    [MethodImpl]
    public static extern AutomationLiveSetting GetLiveSetting(
      DependencyObject element);

    /// <summary>Sets the value of the AutomationProperties.LiveSetting attached property for the specified DependencyObject.</summary>
    /// <param name="element">The DependencyObject for which to set the property.</param>
    /// <param name="value">The AutomationLiveSetting value to set.</param>
    [MethodImpl]
    public static extern void SetLiveSetting(DependencyObject element, AutomationLiveSetting value);
  }
}
