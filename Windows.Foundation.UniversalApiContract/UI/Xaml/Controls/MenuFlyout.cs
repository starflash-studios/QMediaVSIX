// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MenuFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a flyout that displays a menu of commands.</summary>
  [WebHostHidden]
  [ContentProperty(Name = "Items")]
  [Composable(typeof (IMenuFlyoutFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMenuFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class MenuFlyout : FlyoutBase, IMenuFlyout, IMenuFlyout2
  {
    /// <summary>Initializes a new instance of the MenuFlyout class.</summary>
    [MethodImpl]
    public extern MenuFlyout();

    /// <summary>Gets the collection used to generate the content of the menu.</summary>
    /// <returns>The collection that is used to generate the content of the menu, if it exists; otherwise, **null**. The default is an empty collection.</returns>
    public extern IVector<MenuFlyoutItemBase> Items { [MethodImpl] get; }

    /// <summary>Gets or sets the style that is used when rendering the MenuFlyout.</summary>
    /// <returns>The style that is used when rendering the MenuFlyout.</returns>
    public extern Style MenuFlyoutPresenterStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Shows the flyout placed at the specified offset in relation to the specified target element.</summary>
    /// <param name="targetElement">The element to use as the flyout's placement target.</param>
    /// <param name="point">The point at which to offset the flyout from the specified target element.</param>
    [MethodImpl]
    public extern void ShowAt(UIElement targetElement, Point point);

    /// <summary>Identifies the MenuFlyoutPresenterStyle dependency property.</summary>
    /// <returns>The identifier for the MenuFlyoutPresenterStyle dependency property.</returns>
    public static extern DependencyProperty MenuFlyoutPresenterStyleProperty { [MethodImpl] get; }
  }
}
