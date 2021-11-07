// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MenuFlyoutSubItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a menu item that displays a sub-menu in a MenuFlyout control.</summary>
  [ContentProperty(Name = "Items")]
  [Static(typeof (IMenuFlyoutSubItemStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMenuFlyoutSubItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class MenuFlyoutSubItem : MenuFlyoutItemBase, IMenuFlyoutSubItem, IMenuFlyoutSubItem2
  {
    /// <summary>Initializes a new instance of the MenuFlyoutSubItem class.</summary>
    [MethodImpl]
    public extern MenuFlyoutSubItem();

    /// <summary>Gets the collection used to generate the content of the sub-menu.</summary>
    /// <returns>The collection that is used to generate the content of the sub-menu, if it exists; otherwise, **null**. The default is an empty collection.</returns>
    public extern IVector<MenuFlyoutItemBase> Items { [MethodImpl] get; }

    /// <summary>Gets or sets the text content of a MenuFlyoutSubItem.</summary>
    /// <returns>A string that specifies the text content of this MenuFlyoutSubItem. The default is an empty string.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the graphic content of the menu flyout subitem.</summary>
    /// <returns>The graphic content of the menu flyout subitem.</returns>
    public extern IconElement Icon { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the **Icon** dependency property.</summary>
    /// <returns>The identifier for the **Icon** dependency property</returns>
    public static extern DependencyProperty IconProperty { [MethodImpl] get; }

    /// <summary>Identifies the Text dependency property.</summary>
    /// <returns>The identifier for the Text dependency property.</returns>
    public static extern DependencyProperty TextProperty { [MethodImpl] get; }
  }
}
