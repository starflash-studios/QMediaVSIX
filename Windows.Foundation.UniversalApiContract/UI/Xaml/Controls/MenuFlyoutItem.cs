// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MenuFlyoutItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a command in a MenuFlyout control.</summary>
  [Static(typeof (IMenuFlyoutItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IMenuFlyoutItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMenuFlyoutItemStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Text")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IMenuFlyoutItemStatics3), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class MenuFlyoutItem : 
    MenuFlyoutItemBase,
    IMenuFlyoutItem,
    IMenuFlyoutItem2,
    IMenuFlyoutItem3
  {
    /// <summary>Initializes a new instance of the MenuFlyoutItem class.</summary>
    [MethodImpl]
    public extern MenuFlyoutItem();

    /// <summary>Gets or sets the text content of a MenuFlyoutItem.</summary>
    /// <returns>A string that specifies the text content of this MenuFlyoutItem. The default is an empty string.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the command to invoke when the item is pressed.</summary>
    /// <returns>The command to invoke when the item is pressed. The default is **null**.</returns>
    public extern ICommand Command { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the parameter to pass to the Command property.</summary>
    /// <returns>The parameter to pass to the Command property. The default is **null**.</returns>
    public extern object CommandParameter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a menu item is clicked.</summary>
    public extern event RoutedEventHandler Click;

    /// <summary>Gets or sets the graphic content of the menu flyout item.</summary>
    /// <returns>The graphic content of the menu flyout item.</returns>
    public extern IconElement Icon { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that overrides the default key combination string associated with a keyboard accelerator.</summary>
    /// <returns>The string to replace the default key combination string. The default is null.</returns>
    public extern string KeyboardAcceleratorTextOverride { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as {TemplateBinding} markup extension sources when defining templates for a MenuFlyoutItem control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern MenuFlyoutItemTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Identifies the MenuFlyoutItem.KeyboardAcceleratorTextOverride dependency property.</summary>
    /// <returns>The identifier for the MenuFlyoutItem.KeyboardAcceleratorTextOverride dependency property.</returns>
    public static extern DependencyProperty KeyboardAcceleratorTextOverrideProperty { [MethodImpl] get; }

    /// <summary>Identifies the **Icon** dependency property.</summary>
    /// <returns>The identifier for the **Icon** dependency property.</returns>
    public static extern DependencyProperty IconProperty { [MethodImpl] get; }

    /// <summary>Identifies the Text dependency property.</summary>
    /// <returns>The identifier for the Text dependency property.</returns>
    public static extern DependencyProperty TextProperty { [MethodImpl] get; }

    /// <summary>Identifies the Command dependency property.</summary>
    /// <returns>The identifier for the Command dependency property.</returns>
    public static extern DependencyProperty CommandProperty { [MethodImpl] get; }

    /// <summary>Identifies the CommandParameter dependency property.</summary>
    /// <returns>The identifier for the CommandParameter dependency property.</returns>
    public static extern DependencyProperty CommandParameterProperty { [MethodImpl] get; }
  }
}
