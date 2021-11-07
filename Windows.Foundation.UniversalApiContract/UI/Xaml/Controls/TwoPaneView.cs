// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TwoPaneView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a container with two views that size and position content in the available space, either side-by-side or top-bottom.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ITwoPaneViewFactory), CompositionType.Public, 524288, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Static(typeof (ITwoPaneViewStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  public class TwoPaneView : Control, ITwoPaneView
  {
    /// <summary>Initializes a new instance of the TwoPaneView class.</summary>
    [MethodImpl]
    public extern TwoPaneView();

    /// <summary>Gets or sets the content of pane 1.</summary>
    /// <returns>The content of pane 1.</returns>
    public extern UIElement Pane1 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content of pane 2.</summary>
    /// <returns>The content of pane 2.</returns>
    public extern UIElement Pane2 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the calculated width (in wide mode) or height (in tall mode) of pane 1, or sets the GridLength value of pane 1.</summary>
    /// <returns>The GridLength that represents the width or height of the pane.</returns>
    public extern GridLength Pane1Length { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the calculated width (in wide mode) or height (in tall mode) of pane 2, or sets the GridLength value of pane 2.</summary>
    /// <returns>The GridLength that represents the width or height of the pane.</returns>
    public extern GridLength Pane2Length { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates which pane has priority.</summary>
    /// <returns>An enumeration value that indicates which pane has priority.</returns>
    public extern TwoPaneViewPriority PanePriority { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates how panes are shown.</summary>
    /// <returns>An enumeration value that indicates how panes are shown.</returns>
    public extern TwoPaneViewMode Mode { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates how panes are shown in wide mode.</summary>
    /// <returns>An enumeration value that indicates how panes are shown in wide mode.</returns>
    public extern TwoPaneViewWideModeConfiguration WideModeConfiguration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how panes are shown in tall mode.</summary>
    /// <returns>An enumeration value that indicates how panes are shown in tall mode.</returns>
    public extern TwoPaneViewTallModeConfiguration TallModeConfiguration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum width at which panes are shown in wide mode.</summary>
    /// <returns>The minimum width at which panes are shown in wide mode.</returns>
    public extern double MinWideModeWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum height at which panes are shown in tall mode.</summary>
    /// <returns>The minimum height at which panes are shown in tall mode.</returns>
    public extern double MinTallModeHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the Mode of the TwoPaneView has changed.</summary>
    public extern event TypedEventHandler<TwoPaneView, object> ModeChanged;

    /// <summary>Identifies the Pane1 dependency property.</summary>
    /// <returns>The identifier for the Pane1 dependency property.</returns>
    public static extern DependencyProperty Pane1Property { [MethodImpl] get; }

    /// <summary>Identifies the Pane2 dependency property.</summary>
    /// <returns>The identifier for the Pane2 dependency property.</returns>
    public static extern DependencyProperty Pane2Property { [MethodImpl] get; }

    /// <summary>Identifies the Pane1Length dependency property.</summary>
    /// <returns>The identifier for the Pane1Length dependency property.</returns>
    public static extern DependencyProperty Pane1LengthProperty { [MethodImpl] get; }

    /// <summary>Identifies the Pane2Length dependency property.</summary>
    /// <returns>The identifier for the Pane2Length dependency property.</returns>
    public static extern DependencyProperty Pane2LengthProperty { [MethodImpl] get; }

    /// <summary>Identifies the PanePriority dependency property.</summary>
    /// <returns>The identifier for the PanePriority dependency property.</returns>
    public static extern DependencyProperty PanePriorityProperty { [MethodImpl] get; }

    /// <summary>Identifies the Mode dependency property.</summary>
    /// <returns>The identifier for the Mode dependency property.</returns>
    public static extern DependencyProperty ModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the WideModeConfiguration dependency property.</summary>
    /// <returns>The identifier for the WideModeConfiguration dependency property.</returns>
    public static extern DependencyProperty WideModeConfigurationProperty { [MethodImpl] get; }

    /// <summary>Identifies the TallModeConfiguration dependency property.</summary>
    /// <returns>The identifier for the TallModeConfiguration dependency property.</returns>
    public static extern DependencyProperty TallModeConfigurationProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinWideModeWidth dependency property.</summary>
    /// <returns>The identifier for the MinWideModeWidth dependency property.</returns>
    public static extern DependencyProperty MinWideModeWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinTallModeHeight dependency property.</summary>
    /// <returns>The identifier for the MinTallModeHeight dependency property.</returns>
    public static extern DependencyProperty MinTallModeHeightProperty { [MethodImpl] get; }
  }
}
