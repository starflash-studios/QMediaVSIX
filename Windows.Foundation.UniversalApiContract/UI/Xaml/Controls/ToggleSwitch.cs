// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ToggleSwitch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a switch that can be toggled between two states.</summary>
  [WebHostHidden]
  [Static(typeof (IToggleSwitchStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "Header")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ToggleSwitch : Control, IToggleSwitch, IToggleSwitchOverrides
  {
    /// <summary>Initializes a new instance of the ToggleSwitch class.</summary>
    [MethodImpl]
    public extern ToggleSwitch();

    /// <summary>Gets or sets a value that declares whether the state of the ToggleSwitch is "On".</summary>
    /// <returns>**true** if the state is "On"; **false** if the state is "Off".</returns>
    public extern bool IsOn { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the header content.</summary>
    /// <returns>The header content for the ToggleSwitch.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the control's header.</summary>
    /// <returns>The DataTemplate used to display the control's header.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Provides the object content that should be displayed using the OnContentTemplate when this ToggleSwitch has state of "On".</summary>
    /// <returns>The object content. In some cases this is a string, in other cases it is a single element that provides a root for further composition content. Probably the most common "set" usage is to place a binding here.</returns>
    public extern object OnContent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the control's content while in "On" state.</summary>
    /// <returns>The DataTemplate that displays the control's content while in "On" state.</returns>
    public extern DataTemplate OnContentTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Provides the object content that should be displayed using the OffContentTemplate when this ToggleSwitch has state of "Off".</summary>
    /// <returns>The object content. In some cases this is a string, in other cases it is a single element that provides a root for further composition content. Probably the most common "set" usage is to place a binding here.</returns>
    public extern object OffContent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the control's content while in "Off" state.</summary>
    /// <returns>The DataTemplate that displays the control's content while in "Off" state.</returns>
    public extern DataTemplate OffContentTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as **TemplateBinding** sources when defining templates for a ToggleSwitch control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern ToggleSwitchTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Occurs when "On"/"Off" state changes for this ToggleSwitch.</summary>
    public extern event RoutedEventHandler Toggled;

    [MethodImpl]
    extern void IToggleSwitchOverrides.OnToggled();

    [MethodImpl]
    extern void IToggleSwitchOverrides.OnOnContentChanged(
      object oldContent,
      object newContent);

    [MethodImpl]
    extern void IToggleSwitchOverrides.OnOffContentChanged(
      object oldContent,
      object newContent);

    [MethodImpl]
    extern void IToggleSwitchOverrides.OnHeaderChanged(
      object oldContent,
      object newContent);

    /// <summary>Identifies the IsOn dependency property.</summary>
    /// <returns>The identifier for the IsOn dependency property.</returns>
    public static extern DependencyProperty IsOnProperty { [MethodImpl] get; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the OnContent dependency property.</summary>
    /// <returns>The identifier for the OnContent dependency property.</returns>
    public static extern DependencyProperty OnContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the OnContentTemplate dependency property.</summary>
    /// <returns>The identifier for the OnContentTemplate dependency property.</returns>
    public static extern DependencyProperty OnContentTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the OffContent dependency property.</summary>
    /// <returns>The identifier for the OffContent dependency property.</returns>
    public static extern DependencyProperty OffContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the OffContentTemplate dependency property.</summary>
    /// <returns>The identifier for the OffContentTemplate dependency property.</returns>
    public static extern DependencyProperty OffContentTemplateProperty { [MethodImpl] get; }
  }
}
