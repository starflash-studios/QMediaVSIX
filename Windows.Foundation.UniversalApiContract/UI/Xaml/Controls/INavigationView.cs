// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4060728853, 14618, 17098, 159, 198, 247, 157, 166, 90, 202, 50)]
  [ExclusiveTo(typeof (NavigationView))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface INavigationView
  {
    bool IsPaneOpen { get; set; }

    double CompactModeThresholdWidth { get; set; }

    double ExpandedModeThresholdWidth { get; set; }

    UIElement PaneFooter { get; set; }

    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    NavigationViewDisplayMode DisplayMode { get; }

    bool IsSettingsVisible { get; set; }

    bool IsPaneToggleButtonVisible { get; set; }

    bool AlwaysShowHeader { get; set; }

    double CompactPaneLength { get; set; }

    double OpenPaneLength { get; set; }

    Style PaneToggleButtonStyle { get; set; }

    object SelectedItem { get; set; }

    IVector<object> MenuItems { get; }

    object MenuItemsSource { get; set; }

    object SettingsItem { get; }

    AutoSuggestBox AutoSuggestBox { get; set; }

    DataTemplate MenuItemTemplate { get; set; }

    DataTemplateSelector MenuItemTemplateSelector { get; set; }

    Style MenuItemContainerStyle { get; set; }

    StyleSelector MenuItemContainerStyleSelector { get; set; }

    object MenuItemFromContainer(DependencyObject container);

    DependencyObject ContainerFromMenuItem(object item);

    event TypedEventHandler<NavigationView, NavigationViewSelectionChangedEventArgs> SelectionChanged;

    event TypedEventHandler<NavigationView, NavigationViewItemInvokedEventArgs> ItemInvoked;

    event TypedEventHandler<NavigationView, NavigationViewDisplayModeChangedEventArgs> DisplayModeChanged;
  }
}
