// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.Popup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Displays content on top of existing content, within the bounds of the application window.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPopupStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Child")]
  [Static(typeof (IPopupStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPopupStatics3), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPopupStatics4), 917504, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class Popup : FrameworkElement, IPopup, IPopup2, IPopup3, IPopup4
  {
    /// <summary>Initializes a new instance of the Popup class.</summary>
    [MethodImpl]
    public extern Popup();

    /// <summary>Gets or sets the content to be hosted in the popup.</summary>
    /// <returns>The content to be hosted in the popup.</returns>
    public extern UIElement Child { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the popup is currently displayed on the screen.</summary>
    /// <returns>**true** if the popup is currently displayed; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsOpen { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance between the left side of the application window and the left side of the popup.</summary>
    /// <returns>A measurement in pixels.</returns>
    public extern double HorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance between the top of the application window and the top of the popup.</summary>
    /// <returns>A measurement in pixels.</returns>
    public extern double VerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of Transition style elements that apply to child content of a Popup.</summary>
    /// <returns>The strongly typed collection of Transition style elements.</returns>
    public extern TransitionCollection ChildTransitions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines how the Popup can be dismissed.</summary>
    /// <returns>**true** if *light dismiss* is enabled for this control; otherwise, **false**.</returns>
    public extern bool IsLightDismissEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Fires when the IsOpen property is set to true.</summary>
    public extern event EventHandler<object> Opened;

    /// <summary>Fires when the IsOpen property is set to false.</summary>
    public extern event EventHandler<object> Closed;

    /// <summary>Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.</summary>
    /// <returns>A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.</returns>
    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the popup should be shown within the bounds of the XAML root.</summary>
    /// <returns>**true** if the popup should be shown within the bounds of the XAML root; otherwise, **false**. The default is **true**.</returns>
    public extern bool ShouldConstrainToRootBounds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the popup is shown within the bounds of the XAML root.</summary>
    /// <returns>**true** if the popup is shown within the bounds of the XAML root; otherwise, **false**.</returns>
    public extern bool IsConstrainedToRootBounds { [MethodImpl] get; }

    public extern FrameworkElement PlacementTarget { [MethodImpl] get; [MethodImpl] set; }

    public extern PopupPlacementMode DesiredPlacement { [MethodImpl] get; [MethodImpl] set; }

    public extern PopupPlacementMode ActualPlacement { [MethodImpl] get; }

    public extern event EventHandler<object> ActualPlacementChanged;

    public static extern DependencyProperty PlacementTargetProperty { [MethodImpl] get; }

    public static extern DependencyProperty DesiredPlacementProperty { [MethodImpl] get; }

    /// <summary>Identifies the ShouldConstrainToRootBounds dependency property.</summary>
    /// <returns>The identifier for the ShouldConstrainToRootBounds dependency property.</returns>
    public static extern DependencyProperty ShouldConstrainToRootBoundsProperty { [MethodImpl] get; }

    /// <summary>Identifies the LightDismissOverlayMode dependency property.</summary>
    /// <returns>The identifier for the LightDismissOverlayMode dependency property.</returns>
    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Child dependency property.</summary>
    /// <returns>The identifier for the Child dependency property.</returns>
    public static extern DependencyProperty ChildProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the IsOpen dependency property.</summary>
    /// <returns>The identifier for the IsOpen dependency property.</returns>
    public static extern DependencyProperty IsOpenProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the HorizontalOffset dependency property.</summary>
    /// <returns>The identifier for the HorizontalOffset dependency property.</returns>
    public static extern DependencyProperty HorizontalOffsetProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the VerticalOffset dependency property.</summary>
    /// <returns>The identifier for the VerticalOffset dependency property.</returns>
    public static extern DependencyProperty VerticalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the ChildTransitions dependency property.</summary>
    /// <returns>The identifier for the ChildTransitions dependency property.</returns>
    public static extern DependencyProperty ChildTransitionsProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsLightDismissEnabled dependency property.</summary>
    /// <returns>The identifier for the IsLightDismissEnabled dependency property.</returns>
    public static extern DependencyProperty IsLightDismissEnabledProperty { [MethodImpl] get; }
  }
}
