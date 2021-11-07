// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AutomationElementIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as automation property identifiers by UI Automation providers and UI Automation clients.</summary>
  [Static(typeof (IAutomationElementIdentifiersStatics4), 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IAutomationElementIdentifiersStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IAutomationElementIdentifiersStatics7), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationElementIdentifiersStatics6), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationElementIdentifiersStatics8), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationElementIdentifiersStatics5), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAutomationElementIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationElementIdentifiersStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AutomationElementIdentifiers : IAutomationElementIdentifiers
  {
    /// <summary>Identifies the Boolean AutomationProperties.IsDialogProperty that indicates whether the automation element is a dialog window.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsDialogProperty { [MethodImpl] get; }

    /// <summary>Identifies the heading level automation property. The heading level property value is returned by the GetHeadingLevel method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty HeadingLevelProperty { [MethodImpl] get; }

    /// <summary>Identifies the Culture property, which contains a locale identifier for the automation element (for example, 0x0409 for "en-US" or English (United States)).</summary>
    /// <returns>The culture property identifier.</returns>
    public static extern AutomationProperty CultureProperty { [MethodImpl] get; }

    /// <summary>Identifies the Boolean automation property that indicates if the automation element represents peripheral UI.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsPeripheralProperty { [MethodImpl] get; }

    /// <summary>Identifies the Boolean automation property that indicates if the data is valid for the form.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsDataValidForFormProperty { [MethodImpl] get; }

    /// <summary>Identifies the full description automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty FullDescriptionProperty { [MethodImpl] get; }

    /// <summary>Identifies the described by automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty DescribedByProperty { [MethodImpl] get; }

    /// <summary>Identifies the "flows to" automation property. The "flows to" property value is returned by the GetFlowsTo method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty FlowsToProperty { [MethodImpl] get; }

    /// <summary>Identifies the "flows from" automation property. The "flows from" property value is returned by the GetFlowsFrom method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty FlowsFromProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the landmark type automation property.</summary>
    /// <returns>The identifier for the landmark type automation property.</returns>
    public static extern AutomationProperty LandmarkTypeProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the localized landmark type automation property.</summary>
    /// <returns>The identifier for the localized landmark type automation property.</returns>
    public static extern AutomationProperty LocalizedLandmarkTypeProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the position in set automation property.</summary>
    /// <returns>The identifier for the position in set automation property.</returns>
    public static extern AutomationProperty PositionInSetProperty { [MethodImpl] get; }

    /// <summary>Gets the identification of the size of set automation property.</summary>
    /// <returns>The identification of the size of set automation property.</returns>
    public static extern AutomationProperty SizeOfSetProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the level automation property.</summary>
    /// <returns>The identifier for the level automation property.</returns>
    public static extern AutomationProperty LevelProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the annotations automation property.</summary>
    /// <returns>The identifier for the annotations automation property.</returns>
    public static extern AutomationProperty AnnotationsProperty { [MethodImpl] get; }

    /// <summary>Identifies the controlled peers automation property. A list of controlled peers is returned by the GetControlledPeers method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ControlledPeersProperty { [MethodImpl] get; }

    /// <summary>Identifies the accelerator key automation property. The accelerator key property value is returned by the GetAcceleratorKey method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty AcceleratorKeyProperty { [MethodImpl] get; }

    /// <summary>Identifies the access key automation property. The access key property value is returned by the GetAccessKey method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty AccessKeyProperty { [MethodImpl] get; }

    /// <summary>Identifies the automation element identifier automation property. The automation element identifier value is returned by the GetAutomationId method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty AutomationIdProperty { [MethodImpl] get; }

    /// <summary>Identifies the bounding rectangle automation property. The bounding rectangle property value is returned by the GetBoundingRectangle method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty BoundingRectangleProperty { [MethodImpl] get; }

    /// <summary>Identifies the class name automation property. The class name property value is returned by the GetClassName method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ClassNameProperty { [MethodImpl] get; }

    /// <summary>Identifies the clickable point automation property. A valid clickable point property value is returned by the GetClickablePoint method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ClickablePointProperty { [MethodImpl] get; }

    /// <summary>Identifies the control type automation property. The control type property value is returned by the GetAutomationControlType method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ControlTypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the keyboard focus automation property. The keyboard focus state is returned by the HasKeyboardFocus method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty HasKeyboardFocusProperty { [MethodImpl] get; }

    /// <summary>Identifies the help text automation property. The help text property value is returned by the GetHelpText method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty HelpTextProperty { [MethodImpl] get; }

    /// <summary>Identifies the content element determination automation property. The content element status indicates whether the element contains content that is valuable to the end user. The current status is returned by the IsContentElement method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsContentElementProperty { [MethodImpl] get; }

    /// <summary>Identifies the control element determination automation property. The control element status indicates whether the element contains user interface components that can be manipulated. The current status is returned by the IsControlElement method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsControlElementProperty { [MethodImpl] get; }

    /// <summary>Identifies the enabled determination automation property. The enabled status indicates whether the item referenced by the automation peer is enabled. The current status is returned by the IsEnabled method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the keyboard-focusable determination automation property. The keyboard focusable status is returned by the IsKeyboardFocusable method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsKeyboardFocusableProperty { [MethodImpl] get; }

    /// <summary>Identifies the offscreen determination automation property. The offscreen status indicates whether the item referenced by the automation peer is off the screen. The current status is returned by the IsOffscreen method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsOffscreenProperty { [MethodImpl] get; }

    /// <summary>Identifies the password determination automation property. The password status indicates whether the item referenced by the automation peer contains a password. The current status is returned by the IsPassword method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsPasswordProperty { [MethodImpl] get; }

    /// <summary>Identifies the form requirement determination automation property. The form requirement status indicates whether the element must be completed on a form. The current status is returned by the IsRequiredForForm method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsRequiredForFormProperty { [MethodImpl] get; }

    /// <summary>Identifies the item status automation property. The current item status is returned by the GetItemStatus method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ItemStatusProperty { [MethodImpl] get; }

    /// <summary>Identifies the item type automation property. The item type value is returned by GetItemType method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ItemTypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the labeled-by peer automation property. The labeling relationship for an automation peer is returned by the GetLabeledBy method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty LabeledByProperty { [MethodImpl] get; }

    /// <summary>Identifies the localized control type automation property which provides a mechanism to alter the control type read by Narrator.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty LocalizedControlTypeProperty { [MethodImpl] get; }

    /// <summary>Identifies the element name automation property. The current name is returned by the GetName method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty NameProperty { [MethodImpl] get; }

    /// <summary>Identifies the orientation automation property. The current orientation value is returned by the GetOrientation method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty OrientationProperty { [MethodImpl] get; }

    /// <summary>Identifies the live settings automation property. The live settings property value is returned by the GetLiveSetting method.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty LiveSettingProperty { [MethodImpl] get; }
  }
}
