// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AppBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the container control that holds app UI components for commanding and experiences. For Windows 10, see Remarks.</summary>
  [WebHostHidden]
  [Static(typeof (IAppBarStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAppBarStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAppBarStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IAppBarFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class AppBar : 
    ContentControl,
    IAppBar,
    IAppBar2,
    IAppBar3,
    IAppBar4,
    IAppBarOverrides,
    IAppBarOverrides3
  {
    /// <summary>Initializes a new instance of the AppBar class.</summary>
    [MethodImpl]
    public extern AppBar();

    /// <summary>Gets or sets a value that indicates whether the AppBar is open.</summary>
    /// <returns>**true** if the app bar is open; otherwise, **false**.</returns>
    public extern bool IsOpen { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the AppBar does not close on light dismiss.</summary>
    /// <returns>**true** if the AppBar does not close on light dismiss. **false** if the AppBar is hidden on light dismiss.</returns>
    public extern bool IsSticky { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the AppBar changes from hidden to visible.</summary>
    public extern event EventHandler<object> Opened;

    /// <summary>Occurs when the AppBar changes from visible to hidden.</summary>
    public extern event EventHandler<object> Closed;

    /// <summary>Gets or sets a value that indicates whether icon buttons are displayed when the app bar is not completely open.</summary>
    /// <returns>A value that indicates whether icon buttons are displayed when the app bar is not completely open.</returns>
    public extern AppBarClosedDisplayMode ClosedDisplayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as {TemplateBinding} markup extension sources when defining templates for an AppBar control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern AppBarTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Occurs when the AppBar starts to change from hidden to visible.</summary>
    public extern event EventHandler<object> Opening;

    /// <summary>Occurs when the AppBar starts to change from visible to hidden.</summary>
    public extern event EventHandler<object> Closing;

    /// <summary>Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.</summary>
    /// <returns>A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.</returns>
    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern void IAppBarOverrides.OnClosed(object e);

    [MethodImpl]
    extern void IAppBarOverrides.OnOpened(object e);

    [MethodImpl]
    extern void IAppBarOverrides3.OnClosing(object e);

    [MethodImpl]
    extern void IAppBarOverrides3.OnOpening(object e);

    /// <summary>Identifies the LightDismissOverlayMode dependency property.</summary>
    /// <returns>The identifier for the LightDismissOverlayMode dependency property.</returns>
    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the ClosedDisplayMode dependency property.</summary>
    /// <returns>The identifier for the ClosedDisplayMode dependency property.</returns>
    public static extern DependencyProperty ClosedDisplayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsOpen dependency property.</summary>
    /// <returns>The identifier for the IsOpen dependency property.</returns>
    public static extern DependencyProperty IsOpenProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSticky dependency property.</summary>
    /// <returns>The identifier for the IsSticky dependency property.</returns>
    public static extern DependencyProperty IsStickyProperty { [MethodImpl] get; }
  }
}
