// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SettingsFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that provides in-context access to settings that affect the current app. (Not recommended for Universal Windows Platform (UWP) app.)</summary>
  [WebHostHidden]
  [Composable(typeof (ISettingsFlyoutFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISettingsFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class SettingsFlyout : ContentControl, ISettingsFlyout
  {
    /// <summary>Initializes a new instance of the SettingsFlyout class.</summary>
    [MethodImpl]
    public extern SettingsFlyout();

    /// <summary>Gets or sets the title of the SettingsFlyout control when displayed.</summary>
    /// <returns>The title of the SettingsFlyout control. This typically appears in the SettingsFlyout control header area. The default is an empty string.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Brush that fills the background of the SettingsFlyout header.</summary>
    /// <returns>The brush that provides the background of the SettingsFlyout header. The default is a null brush from a pure code perspective, but the default control template for SettingsFlyout applies a theme resource brush (**SettingsFlyoutHeaderBackgroundThemeBrush**) for this in a runtime instance of a SettingsFlyout control.</returns>
    public extern Brush HeaderBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Brush that fills the foreground of the SettingsFlyout header.</summary>
    /// <returns>The brush that provides the foreground of the SettingsFlyout header. The default is a null brush from a pure code perspective, but the default control template for SettingsFlyout applies a theme resource brush (**SettingsFlyoutHeaderForegroundThemeBrush**) for this in a runtime instance of a SettingsFlyout control.</returns>
    public extern Brush HeaderForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the icon image displayed in the SettingsFlyout header.</summary>
    /// <returns>The icon image displayed in the SettingsFlyout header area, typically to the right of the Title. The default is **null**, which results in no displayed image.</returns>
    public extern ImageSource IconSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as **TemplateBinding** sources when defining templates for a SettingsFlyout control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern SettingsFlyoutTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Occurs when the user clicks the back button on a SettingsFlyout control.</summary>
    public extern event BackClickEventHandler BackClick;

    /// <summary>Opens the Settings flyout, and returns the user to the Settings pane after the flyout is dismissed.</summary>
    [MethodImpl]
    public extern void Show();

    /// <summary>Opens the Settings flyout, and returns the user to the app after the flyout is dismissed.</summary>
    [MethodImpl]
    public extern void ShowIndependent();

    /// <summary>Closes the Settings flyout.</summary>
    [MethodImpl]
    public extern void Hide();

    /// <summary>Identifies the Title dependency property.</summary>
    /// <returns>The identifier for the Title dependency property.</returns>
    public static extern DependencyProperty TitleProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderBackground dependency property.</summary>
    /// <returns>The identifier for the HeaderBackground dependency property.</returns>
    public static extern DependencyProperty HeaderBackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderForeground dependency property.</summary>
    /// <returns>The identifier for the HeaderForeground dependency property.</returns>
    public static extern DependencyProperty HeaderForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the IconSource dependency property.</summary>
    /// <returns>The identifier for the IconSource dependency property.</returns>
    public static extern DependencyProperty IconSourceProperty { [MethodImpl] get; }
  }
}
