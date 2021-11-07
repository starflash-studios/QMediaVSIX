// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MenuBarItem
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
  /// <summary>Represents a top-level menu in a MenuBar control.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Composable(typeof (IMenuBarItemFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Items")]
  [Static(typeof (IMenuBarItemStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  public class MenuBarItem : Control, IMenuBarItem
  {
    /// <summary>Initializes a new instance of the MenuBarItem class.</summary>
    [MethodImpl]
    public extern MenuBarItem();

    /// <summary>Gets or sets the text label for a MenuBar menu.</summary>
    /// <returns>The text label for this menu. The default is an empty string.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of commands in a MenuBar menu.</summary>
    /// <returns>The collection of commands in a MenuBar menu.</returns>
    public extern IVector<MenuFlyoutItemBase> Items { [MethodImpl] get; }

    /// <summary>Identifies the Title dependency property.</summary>
    /// <returns>The identifier for the Title dependency property.</returns>
    public static extern DependencyProperty TitleProperty { [MethodImpl] get; }

    /// <summary>Identifies the Items dependency property.</summary>
    /// <returns>The identifier for the Items dependency property.</returns>
    public static extern DependencyProperty ItemsProperty { [MethodImpl] get; }
  }
}
