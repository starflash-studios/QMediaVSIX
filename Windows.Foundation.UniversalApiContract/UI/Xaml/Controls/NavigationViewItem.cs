// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NavigationViewItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the container for an item in a NavigationView control.</summary>
  [Static(typeof (INavigationViewItemStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (INavigationViewItemFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (INavigationViewItemStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class NavigationViewItem : NavigationViewItemBase, INavigationViewItem, INavigationViewItem2
  {
    /// <summary>Initializes a new instance of the NavigationViewItem class.</summary>
    [MethodImpl]
    public extern NavigationViewItem();

    /// <summary>Gets or sets the icon to show next to the menu item text.</summary>
    /// <returns>The icon to show next to the menu item text. The default in **null**.</returns>
    public extern IconElement Icon { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the CompactPaneLength of the NavigationView that hosts this item.</summary>
    /// <returns>The CompactPaneLength of the NavigationView that hosts this item.</returns>
    public extern double CompactPaneLength { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether invoking a navigation menu item also selects it.</summary>
    /// <returns>**true** if invoking a navigation menu item also selects it; otherwise, **false**. The default is **true**.</returns>
    public extern bool SelectsOnInvoked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the SelectsOnInvoked dependency property.</summary>
    /// <returns>The identifier for the SelectsOnInvoked dependency property.</returns>
    public static extern DependencyProperty SelectsOnInvokedProperty { [MethodImpl] get; }

    /// <summary>Identifies the Icon dependency property.</summary>
    /// <returns>The identifier for the Icon dependency property.</returns>
    public static extern DependencyProperty IconProperty { [MethodImpl] get; }

    /// <summary>Identifies the CompactPaneLength dependency property.</summary>
    /// <returns>The identifier for the CompactPaneLength dependency property.</returns>
    public static extern DependencyProperty CompactPaneLengthProperty { [MethodImpl] get; }
  }
}
