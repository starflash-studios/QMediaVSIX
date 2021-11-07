// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NavigationView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a container that enables navigation of app content. It has a header, a view for the main content, and a menu pane for navigation commands.</summary>
  [Composable(typeof (INavigationViewFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Static(typeof (INavigationViewStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (INavigationViewStatics3), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (INavigationViewStatics2), 393216, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class NavigationView : ContentControl, INavigationView, INavigationView2, INavigationView3
  {
    /// <summary>Initializes a new instance of the NavigationView class.</summary>
    [MethodImpl]
    public extern NavigationView();

    /// <summary>Gets or sets a value that specifies whether the NavigationView pane is expanded to its full width.</summary>
    /// <returns>**true** if the pane is expanded to its full width; otherwise, **false**.</returns>
    public extern bool IsPaneOpen { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum window width at which the NavigationView enters Compact display mode.</summary>
    /// <returns>The minimum window width at which the NavigationView enters Compact display mode. The default is 641 pixels.</returns>
    public extern double CompactModeThresholdWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum window width at which the NavigationView enters **Expanded** display mode.</summary>
    /// <returns>The minimum window width at which the NavigationView enters **Expanded** display mode. The default is 1008 pixels.</returns>
    public extern double ExpandedModeThresholdWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content for the pane footer.</summary>
    /// <returns>The content of the pane footer. The default is **null**.</returns>
    public extern UIElement PaneFooter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the header content.</summary>
    /// <returns>The header content for the NavigationView.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the control's header.</summary>
    /// <returns>The DataTemplate used to display the control's header.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that specifies how the pane and content areas of a NavigationView are being shown.</summary>
    /// <returns>A value of the enumeration that specifies how the pane and content areas of a NavigationView are being shown.</returns>
    public extern NavigationViewDisplayMode DisplayMode { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the settings button is shown.</summary>
    /// <returns>**true** if the settings button is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsSettingsVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the menu toggle button is shown.</summary>
    /// <returns>**true** if the menu button is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsPaneToggleButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the header is always visible.</summary>
    /// <returns>**true** if the header is always visible; otherwise, **false**. The default is **true**.</returns>
    public extern bool AlwaysShowHeader { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width of the NavigationView pane in its compact display mode.</summary>
    /// <returns>The width of the pane in its compact display mode. The default is 48 device-independent pixel (DIP).</returns>
    public extern double CompactPaneLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width of the NavigationView pane when it's fully expanded.</summary>
    /// <returns>The width of the NavigationView pane when it's fully expanded. The default is 320 device-independent pixel (DIP).</returns>
    public extern double OpenPaneLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Style that defines the look of the menu toggle button.</summary>
    /// <returns>The Style that defines the look of the menu toggle button. The default is **null**.</returns>
    public extern Style PaneToggleButtonStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the selected item.</summary>
    /// <returns>The selected item. The default is null.</returns>
    public extern object SelectedItem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of menu items displayed in the NavigationMenu.</summary>
    /// <returns>The collection of menu items displayed in the NavigationMenu. The default is an empty collection.</returns>
    public extern IVector<object> MenuItems { [MethodImpl] get; }

    /// <summary>Gets or sets an object source used to generate the content of the NavigationView menu.</summary>
    /// <returns>The object that is used to generate the content of the NavigationView menu. The default is **null**.</returns>
    public extern object MenuItemsSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the navigation item that represents the entry point to app settings.</summary>
    /// <returns>The item that represents the entry point to app settings.</returns>
    public extern object SettingsItem { [MethodImpl] get; }

    /// <summary>Gets or sets an AutoSuggestBox to be displayed in the NavigationView.</summary>
    /// <returns>An AutoSuggestBox box to be displayed in the NavigationView.</returns>
    public extern AutoSuggestBox AutoSuggestBox { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display each menu item.</summary>
    /// <returns>The template that specifies the visualization of the menu data objects. The default is **null**.</returns>
    public extern DataTemplate MenuItemTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a reference to a custom DataTemplateSelector logic class. The DataTemplateSelector referenced by this property returns a template to apply to items.</summary>
    /// <returns>A reference to a custom DataTemplateSelector logic class.</returns>
    public extern DataTemplateSelector MenuItemTemplateSelector { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the style that is used when rendering the menu item containers.</summary>
    /// <returns>The style applied to the item containers. The default is **null**.</returns>
    public extern Style MenuItemContainerStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a reference to a custom StyleSelector logic class. The StyleSelector returns different Style values to use for the item container based on characteristics of the object being displayed.</summary>
    /// <returns>A custom StyleSelector logic class.</returns>
    public extern StyleSelector MenuItemContainerStyleSelector { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns the item that corresponds to the specified, generated container.</summary>
    /// <param name="container">The DependencyObject that corresponds to the item to be returned.</param>
    /// <returns>The contained item, or the container if it does not contain an item.</returns>
    [MethodImpl]
    public extern object MenuItemFromContainer(DependencyObject container);

    /// <summary>Returns the container corresponding to the specified menu item.</summary>
    /// <param name="item">The menu item to retrieve the container for.</param>
    /// <returns>A container that corresponds to the specified menu item, if the item has a container and exists in the collection; otherwise, **null**.</returns>
    [MethodImpl]
    public extern DependencyObject ContainerFromMenuItem(object item);

    /// <summary>Occurs when the currently selected item changes.</summary>
    public extern event TypedEventHandler<NavigationView, NavigationViewSelectionChangedEventArgs> SelectionChanged;

    /// <summary>Occurs when an item in the menu receives an interaction such as a click or tap.</summary>
    public extern event TypedEventHandler<NavigationView, NavigationViewItemInvokedEventArgs> ItemInvoked;

    /// <summary>Occurs when the DisplayMode property changes.</summary>
    public extern event TypedEventHandler<NavigationView, NavigationViewDisplayModeChangedEventArgs> DisplayModeChanged;

    /// <summary>Gets or sets a value that indicates whether the back button is enabled or disabled.</summary>
    /// <returns>A value of the enumeration that specifies the visibility of the NavigationView back button. The default is "Auto".</returns>
    public extern NavigationViewBackButtonVisible IsBackButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the back button is enabled or disabled.</summary>
    /// <returns>**true** if the back button is enabled; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsBackEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the label adjacent to the menu icon when the NavigationView pane is open.</summary>
    /// <returns>The label adjacent to the menu icon when the pane is open. The default is an empty string.</returns>
    public extern string PaneTitle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the back button receives an interaction such as a click or tap.</summary>
    public extern event TypedEventHandler<NavigationView, NavigationViewBackRequestedEventArgs> BackRequested;

    /// <summary>Occurs when the NavigationView pane is closed.</summary>
    public extern event TypedEventHandler<NavigationView, object> PaneClosed;

    /// <summary>Occurs when the NavigationView pane is closing.</summary>
    public extern event TypedEventHandler<NavigationView, NavigationViewPaneClosingEventArgs> PaneClosing;

    /// <summary>Occurs when the NavigationView pane is opened.</summary>
    public extern event TypedEventHandler<NavigationView, object> PaneOpened;

    /// <summary>Occurs when the NavigationView pane is opening.</summary>
    public extern event TypedEventHandler<NavigationView, object> PaneOpening;

    /// <summary>Gets or sets a value that indicates how and where the NavigationView pane is shown.</summary>
    /// <returns>A value of the enumeration that indicates how and where the NavigationView pane is shown. The default is **Auto**.</returns>
    public extern NavigationViewPaneDisplayMode PaneDisplayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content for the pane header.</summary>
    /// <returns>The content of the pane header. The default is **null**.</returns>
    public extern UIElement PaneHeader { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a UI element that is shown in the NavigationView pane.</summary>
    /// <returns>The element that is shown in the NavigationView pane.</returns>
    public extern UIElement PaneCustomContent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a UI element that is shown at the top of the control, below the pane if PaneDisplayMode is Top.</summary>
    /// <returns>The element that is shown at the top of the control.</returns>
    public extern UIElement ContentOverlay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the pane is shown.</summary>
    /// <returns>**true** is the pane is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsPaneVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether item selection changes when keyboard focus changes.</summary>
    /// <returns>A value of the enumeration that indicates whether selection changes when keyboard focus changes. The default is **Disabled**.</returns>
    public extern NavigationViewSelectionFollowsFocus SelectionFollowsFocus { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as **TemplateBinding** sources when defining templates for a NavigationView control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern NavigationViewTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates when gamepad bumpers can be used to navigate the top-level navigation items in a NavigationView.</summary>
    /// <returns>A value of the enumeration that indicates when gamepad bumpers can be used to navigate the top-level navigation items in a NavigationView. The default is **Never**.</returns>
    public extern NavigationViewShoulderNavigationEnabled ShoulderNavigationEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates what text label is shown for the overflow menu.</summary>
    /// <returns>A value of the enumeration that indicates what text label is shown for the overflow menu. The default is **MoreLabel**, which shows the text "More".</returns>
    public extern NavigationViewOverflowLabelMode OverflowLabelMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the PaneDisplayMode dependency property.</summary>
    /// <returns>The identifier for the PaneDisplayMode dependency property.</returns>
    public static extern DependencyProperty PaneDisplayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the PaneHeader dependency property.</summary>
    /// <returns>The identifier for the PaneHeader dependency property.</returns>
    public static extern DependencyProperty PaneHeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the PaneCustomContent dependency property.</summary>
    /// <returns>The identifier for the PaneCustomContent dependency property.</returns>
    public static extern DependencyProperty PaneCustomContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentOverlay dependency property.</summary>
    /// <returns>The identifier for the ContentOverlay dependency property.</returns>
    public static extern DependencyProperty ContentOverlayProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsPaneVisible dependency property.</summary>
    /// <returns>The identifier for the IsPaneVisible dependency property.</returns>
    public static extern DependencyProperty IsPaneVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionFollowsFocus dependency property.</summary>
    /// <returns>The identifier for the SelectionFollowsFocus dependency property.</returns>
    public static extern DependencyProperty SelectionFollowsFocusProperty { [MethodImpl] get; }

    /// <summary>Identifies the TemplateSettings dependency property.</summary>
    /// <returns>The identifier for the TemplateSettings dependency property.</returns>
    public static extern DependencyProperty TemplateSettingsProperty { [MethodImpl] get; }

    /// <summary>Identifies the ShoulderNavigationEnabled dependency property.</summary>
    /// <returns>The identifier for the ShoulderNavigationEnabled dependency property.</returns>
    public static extern DependencyProperty ShoulderNavigationEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the OverflowLabelMode dependency property.</summary>
    /// <returns>The identifier for the OverflowLabelMode dependency property.</returns>
    public static extern DependencyProperty OverflowLabelModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsBackButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsBackButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsBackButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsBackEnabled dependency property.</summary>
    /// <returns>The identifier for the IsBackEnabled dependency property.</returns>
    public static extern DependencyProperty IsBackEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the PaneTitle dependency property.</summary>
    /// <returns>The identifier for the PaneTitle dependency property.</returns>
    public static extern DependencyProperty PaneTitleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsPaneOpen dependency property.</summary>
    /// <returns>The identifier for the IsPaneOpen dependency property.</returns>
    public static extern DependencyProperty IsPaneOpenProperty { [MethodImpl] get; }

    /// <summary>Identifies the CompactModeThresholdWidth dependency property.</summary>
    /// <returns>The identifier for the CompactModeThresholdWidth dependency property.</returns>
    public static extern DependencyProperty CompactModeThresholdWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the ExpandedModeThresholdWidth dependency property.</summary>
    /// <returns>The identifier for the ExpandedModeThresholdWidth dependency property.</returns>
    public static extern DependencyProperty ExpandedModeThresholdWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the PaneFooter dependency property.</summary>
    /// <returns>The identifier for the PaneFooter dependency property.</returns>
    public static extern DependencyProperty PaneFooterProperty { [MethodImpl] get; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the DisplayMode dependency property.</summary>
    /// <returns>The identifier for the DisplayMode dependency property.</returns>
    public static extern DependencyProperty DisplayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSettingsVisible dependency property.</summary>
    /// <returns>The identifier for the IsSettingsVisible dependency property.</returns>
    public static extern DependencyProperty IsSettingsVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsPaneToggleButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsPaneToggleButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsPaneToggleButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the AlwaysShowHeader dependency property.</summary>
    /// <returns>The identifier for the AlwaysShowHeader dependency property.</returns>
    public static extern DependencyProperty AlwaysShowHeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the CompactPaneLength dependency property.</summary>
    /// <returns>The identifier for the CompactPaneLength dependency property.</returns>
    public static extern DependencyProperty CompactPaneLengthProperty { [MethodImpl] get; }

    /// <summary>Identifies the OpenPaneLength dependency property.</summary>
    /// <returns>The identifier for the OpenPaneLength dependency property.</returns>
    public static extern DependencyProperty OpenPaneLengthProperty { [MethodImpl] get; }

    /// <summary>Identifies the PaneToggleButtonStyle dependency property.</summary>
    /// <returns>The identifier for the PaneToggleButtonStyle dependency property.</returns>
    public static extern DependencyProperty PaneToggleButtonStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the MenuItems dependency property.</summary>
    /// <returns>The identifier for the MenuItems dependency property.</returns>
    public static extern DependencyProperty MenuItemsProperty { [MethodImpl] get; }

    /// <summary>Identifies the MenuItemsSource dependency property.</summary>
    /// <returns>The identifier for the MenuItemsSource dependency property.</returns>
    public static extern DependencyProperty MenuItemsSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedItem dependency property.</summary>
    /// <returns>The identifier for the SelectedItem dependency property.</returns>
    public static extern DependencyProperty SelectedItemProperty { [MethodImpl] get; }

    /// <summary>Identifies the SettingsItem dependency property.</summary>
    /// <returns>The identifier for the SettingsItem dependency property.</returns>
    public static extern DependencyProperty SettingsItemProperty { [MethodImpl] get; }

    /// <summary>Identifies the AutoSuggestBox dependency property.</summary>
    /// <returns>The identifier for the AutoSuggestBox dependency property.</returns>
    public static extern DependencyProperty AutoSuggestBoxProperty { [MethodImpl] get; }

    /// <summary>Identifies the MenuItemTemplate dependency property.</summary>
    /// <returns>The identifier for the MenuItemTemplate dependency property.</returns>
    public static extern DependencyProperty MenuItemTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the MenuItemTemplateSelector dependency property.</summary>
    /// <returns>The identifier for the MenuItemTemplateSelector dependency property.</returns>
    public static extern DependencyProperty MenuItemTemplateSelectorProperty { [MethodImpl] get; }

    /// <summary>Identifies the MenuItemContainerStyle dependency property.</summary>
    /// <returns>The identifier for the MenuItemContainerStyle dependency property.</returns>
    public static extern DependencyProperty MenuItemContainerStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the MenuItemContainerStyleSelector dependency property.</summary>
    /// <returns>The identifier for the MenuItemContainerStyleSelector dependency property.</returns>
    public static extern DependencyProperty MenuItemContainerStyleSelectorProperty { [MethodImpl] get; }
  }
}
