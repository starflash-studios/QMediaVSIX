// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SplitView
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
  /// <summary>Represents a container with two views; one view for the main content and another view that is typically used for navigation commands.</summary>
  [Static(typeof (ISplitViewStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (ISplitViewFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISplitViewStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class SplitView : Control, ISplitView, ISplitView2, ISplitView3
  {
    /// <summary>Initializes a new instance of the SplitView class.</summary>
    [MethodImpl]
    public extern SplitView();

    /// <summary>Gets or sets the contents of the main panel of a SplitView.</summary>
    /// <returns>The contents of the main panel of a SplitView. The default is **null**.</returns>
    public extern UIElement Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the contents of the pane of a SplitView.</summary>
    /// <returns>The contents of the pane of a SplitView. The default is **null**.</returns>
    public extern UIElement Pane { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the SplitView pane is expanded to its full width.</summary>
    /// <returns>**true** if the pane is expanded to its full width; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsPaneOpen { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width of the SplitView pane when it's fully expanded.</summary>
    /// <returns>The width of the SplitView pane when it's fully expanded. The default is 320 device-independent pixel (DIP).</returns>
    public extern double OpenPaneLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width of the SplitView pane in its compact display mode.</summary>
    /// <returns>The width of the pane in it's compact display mode. The default is 48 device-independent pixel (DIP) (defined by the **SplitViewCompactPaneThemeLength** resource).</returns>
    public extern double CompactPaneLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the pane is shown on the right or left side of the SplitView.</summary>
    /// <returns>A value of the enumeration that specifies whether the pane is shown on the right or left side of the SplitView. The default is **Left**.</returns>
    public extern SplitViewPanePlacement PanePlacement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets of sets a value that specifies how the pane and content areas of a SplitView are shown.</summary>
    /// <returns>A value of the enumeration that specifies how the pane and content areas of a SplitView are shown. The default is **Overlay**.</returns>
    public extern SplitViewDisplayMode DisplayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as **TemplateBinding** sources when defining templates for a SplitView control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern SplitViewTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Gets or sets the Brush to apply to the background of the Pane area of the control.</summary>
    /// <returns>The Brush to apply to the background of the Pane area of the control.</returns>
    public extern Brush PaneBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the SplitView pane is closing.</summary>
    public extern event TypedEventHandler<SplitView, SplitViewPaneClosingEventArgs> PaneClosing;

    /// <summary>Occurs when the SplitView pane is closed.</summary>
    public extern event TypedEventHandler<SplitView, object> PaneClosed;

    /// <summary>Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.</summary>
    /// <returns>A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.</returns>
    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the SplitView pane is opening.</summary>
    public extern event TypedEventHandler<SplitView, object> PaneOpening;

    /// <summary>Occurs when the SplitView pane is opened.</summary>
    public extern event TypedEventHandler<SplitView, object> PaneOpened;

    /// <summary>Identifies the LightDismissOverlayMode dependency property.</summary>
    /// <returns>The identifier for the LightDismissOverlayMode dependency property.</returns>
    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Content  dependency property.</summary>
    /// <returns>The identifier for the Content  dependency property.</returns>
    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the Pane  dependency property.</summary>
    /// <returns>The identifier for the  Pane dependency property.</returns>
    public static extern DependencyProperty PaneProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsPaneOpen  dependency property.</summary>
    /// <returns>The identifier for the IsPaneOpen  dependency property.</returns>
    public static extern DependencyProperty IsPaneOpenProperty { [MethodImpl] get; }

    /// <summary>Identifies the  OpenPaneLength dependency property.</summary>
    /// <returns>The identifier for the OpenPaneLength  dependency property.</returns>
    public static extern DependencyProperty OpenPaneLengthProperty { [MethodImpl] get; }

    /// <summary>Identifies the CompactPaneLength  dependency property.</summary>
    /// <returns>The identifier for the CompactPaneLength  dependency property.</returns>
    public static extern DependencyProperty CompactPaneLengthProperty { [MethodImpl] get; }

    /// <summary>Identifies the PanePlacement  dependency property.</summary>
    /// <returns>The identifier for the   PanePlacement dependency property.</returns>
    public static extern DependencyProperty PanePlacementProperty { [MethodImpl] get; }

    /// <summary>Identifies the DisplayMode  dependency property.</summary>
    /// <returns>The identifier for the DisplayMode  dependency property.</returns>
    public static extern DependencyProperty DisplayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the TemplateSettings  dependency property.</summary>
    /// <returns>The identifier for the TemplateSettings  dependency property.</returns>
    public static extern DependencyProperty TemplateSettingsProperty { [MethodImpl] get; }

    /// <summary>Identifies the PaneBackground  dependency property.</summary>
    /// <returns>The identifier for the   PaneBackground dependency property.</returns>
    public static extern DependencyProperty PaneBackgroundProperty { [MethodImpl] get; }
  }
}
