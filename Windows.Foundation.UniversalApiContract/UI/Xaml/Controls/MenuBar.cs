// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MenuBar
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
  /// <summary>Represents a specialized container that presents a set of menus in a horizontal row, typically at the top of an app window.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ContentProperty(Name = "Items")]
  [WebHostHidden]
  [Static(typeof (IMenuBarStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IMenuBarFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class MenuBar : Control, IMenuBar
  {
    /// <summary>Initializes a new instance of the MenuBar class.</summary>
    [MethodImpl]
    public extern MenuBar();

    /// <summary>Gets the collection of top-level menu items.</summary>
    /// <returns>The collection of top-level menu items.</returns>
    public extern IVector<MenuBarItem> Items { [MethodImpl] get; }

    /// <summary>Identifies the Items dependency property.</summary>
    /// <returns>The identifier for the Items dependency property.</returns>
    public static extern DependencyProperty ItemsProperty { [MethodImpl] get; }
  }
}
