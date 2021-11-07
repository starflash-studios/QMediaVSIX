// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.FlyoutBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents the base class for flyout controls, such as Flyout and MenuFlyout.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IFlyoutBaseFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFlyoutBaseStatics5), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IFlyoutBaseStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IFlyoutBaseStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IFlyoutBaseStatics6), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFlyoutBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class FlyoutBase : 
    DependencyObject,
    IFlyoutBase,
    IFlyoutBase2,
    IFlyoutBase3,
    IFlyoutBase4,
    IFlyoutBase5,
    IFlyoutBase6,
    IFlyoutBaseOverrides,
    IFlyoutBaseOverrides4
  {
    /// <summary>Provides base class initialization behavior for FlyoutBase derived classes.</summary>
    [MethodImpl]
    protected extern FlyoutBase();

    /// <summary>Gets or sets the default placement to be used for the flyout, in relation to its placement target.</summary>
    /// <returns>A named constant of the enumeration that indicates where the flyout is placed in relation to its placement target. The default is Top.</returns>
    public extern FlyoutPlacementMode Placement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the flyout is shown.</summary>
    public extern event EventHandler<object> Opened;

    /// <summary>Occurs when the flyout is hidden.</summary>
    public extern event EventHandler<object> Closed;

    /// <summary>Occurs before the flyout is shown.</summary>
    public extern event EventHandler<object> Opening;

    /// <summary>Shows the flyout placed in relation to the specified element.</summary>
    /// <param name="placementTarget">The element to use as the flyout's placement target.</param>
    [MethodImpl]
    public extern void ShowAt(FrameworkElement placementTarget);

    /// <summary>Closes the flyout.</summary>
    [MethodImpl]
    public extern void Hide();

    /// <summary>Gets the element to use as the flyout's placement target.</summary>
    /// <returns>The element to use as the flyout's placement target.</returns>
    public extern FrameworkElement Target { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the element automatically gets focus when the user interacts with it.</summary>
    /// <returns>**true** if the element gets focus when a user interacts with it; otherwise, **false**.</returns>
    public extern bool AllowFocusOnInteraction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.</summary>
    /// <returns>A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.</returns>
    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the control can receive focus when it's disabled.</summary>
    /// <returns>**true** if the control can receive focus when it's disabled; otherwise, **false**.</returns>
    public extern bool AllowFocusWhenDisabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the control's preference for whether it plays sounds.</summary>
    /// <returns>An enumeration value that specifies the control's preference for whether it plays sounds. The default is **Default**.</returns>
    public extern ElementSoundMode ElementSoundMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the flyout starts to be hidden.</summary>
    public extern event TypedEventHandler<FlyoutBase, FlyoutBaseClosingEventArgs> Closing;

    /// <summary>Gets or sets an element that should receive pointer input events even when underneath the flyout's overlay.</summary>
    /// <returns>The element that should receive pointer input events even when underneath the flyout's overlay.</returns>
    public extern DependencyObject OverlayInputPassThroughElement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Attempts to invoke a keyboard shortcut (accelerator).</summary>
    /// <param name="args">The ProcessKeyboardAcceleratorEventArgs.</param>
    [MethodImpl]
    public extern void TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args);

    /// <summary>Gets or sets a value that indicates how a flyout behaves when shown.</summary>
    /// <returns>A value of the enumeration that indicates how a flyout behaves when shown.</returns>
    public extern FlyoutShowMode ShowMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the input device used to open the flyout does not easily open the secondary commands.</summary>
    /// <returns>**true** if the input device used to open the flyout does not easily open the secondary commands; otherwise, **false**.</returns>
    public extern bool InputDevicePrefersPrimaryCommands { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether animations are played when the flyout is opened or closed.</summary>
    /// <returns>**true** if animations are played when the flyout is opened or closed; otherwise, **false**.</returns>
    public extern bool AreOpenCloseAnimationsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the flyout is open.</summary>
    /// <returns>**true** if the flyout is open; otherwise, **false**.</returns>
    public extern bool IsOpen { [MethodImpl] get; }

    /// <summary>Shows the flyout placed in relation to the specified element using the specified options.</summary>
    /// <param name="placementTarget">The element to use as the flyout's placement target.</param>
    /// <param name="showOptions">The options to use when showing the flyout.</param>
    [MethodImpl]
    public extern void ShowAt(DependencyObject placementTarget, FlyoutShowOptions showOptions);

    /// <summary>Gets or sets a value that indicates whether the flyout should be shown within the bounds of the XAML root.</summary>
    /// <returns>**true** if the flyout should be shown within the bounds of the XAML root; otherwise, **false**. The default is **false**.</returns>
    public extern bool ShouldConstrainToRootBounds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the flyout is shown within the bounds of the XAML root.</summary>
    /// <returns>**true** if the flyout is shown within the bounds of the XAML root; otherwise, **false**.</returns>
    public extern bool IsConstrainedToRootBounds { [MethodImpl] get; }

    /// <summary>Gets or sets the XamlRoot in which this flyout is being viewed.</summary>
    /// <returns>The XamlRoot in which this flyout is being viewed. The default is **null**.</returns>
    public extern XamlRoot XamlRoot { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern Control IFlyoutBaseOverrides.CreatePresenter();

    [MethodImpl]
    extern void IFlyoutBaseOverrides4.OnProcessKeyboardAccelerators(
      ProcessKeyboardAcceleratorEventArgs args);

    /// <summary>Identifies the ShouldConstrainToRootBounds dependency property.</summary>
    /// <returns>The identifier for the ShouldConstrainToRootBounds dependency property.</returns>
    public static extern DependencyProperty ShouldConstrainToRootBoundsProperty { [MethodImpl] get; }

    /// <summary>Identifies the Target dependency property.</summary>
    /// <returns>The identifier for the Target dependency property.</returns>
    public static extern DependencyProperty TargetProperty { [MethodImpl] get; }

    /// <summary>Identifies the ShowMode dependency property.</summary>
    /// <returns>The identifier for the ShowMode dependency property.</returns>
    public static extern DependencyProperty ShowModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the InputDevicePrefersPrimaryCommands dependency property.</summary>
    /// <returns>The identifier for the InputDevicePrefersPrimaryCommands dependency property.</returns>
    public static extern DependencyProperty InputDevicePrefersPrimaryCommandsProperty { [MethodImpl] get; }

    /// <summary>Identifies the AreOpenCloseAnimationsEnabled dependency property.</summary>
    /// <returns>The identifier for the AreOpenCloseAnimationsEnabled dependency property.</returns>
    public static extern DependencyProperty AreOpenCloseAnimationsEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsOpen dependency property.</summary>
    /// <returns>The identifier for the IsOpen dependency property.</returns>
    public static extern DependencyProperty IsOpenProperty { [MethodImpl] get; }

    /// <summary>Identifies the **OverlayInputPassThroughElement** dependency property.</summary>
    /// <returns>The identifier for the **OverlayInputPassThroughElement** dependency property.</returns>
    public static extern DependencyProperty OverlayInputPassThroughElementProperty { [MethodImpl] get; }

    /// <summary>Identifies the AllowFocusOnInteraction dependency property.</summary>
    /// <returns>The identifier for the AllowFocusOnInteraction dependency property.</returns>
    public static extern DependencyProperty AllowFocusOnInteractionProperty { [MethodImpl] get; }

    /// <summary>Identifies the LightDismissOverlayMode dependency property.</summary>
    /// <returns>The identifier for the LightDismissOverlayMode dependency property.</returns>
    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the AllowFocusWhenDisabled dependency property.</summary>
    /// <returns>The identifier for the AllowFocusWhenDisabled dependency property.</returns>
    public static extern DependencyProperty AllowFocusWhenDisabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the ElementSoundMode dependency property.</summary>
    /// <returns>The identifier for the ElementSoundMode dependency property.</returns>
    public static extern DependencyProperty ElementSoundModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Placement dependency property.</summary>
    /// <returns>The identifier for the Placement dependency property.</returns>
    public static extern DependencyProperty PlacementProperty { [MethodImpl] get; }

    /// <summary>Identifies the FlyoutBase.AttachedFlyout XAML attached property.</summary>
    /// <returns>The identifier for the FlyoutBase.AttachedFlyout XAML attached property.</returns>
    public static extern DependencyProperty AttachedFlyoutProperty { [MethodImpl] get; }

    /// <summary>Gets the flyout associated with the specified element.</summary>
    /// <param name="element">The element for which to get the associated flyout.</param>
    /// <returns>The flyout attached to the specified element.</returns>
    [MethodImpl]
    public static extern FlyoutBase GetAttachedFlyout(FrameworkElement element);

    /// <summary>Associates the specified flyout with the specified FrameworkElement.</summary>
    /// <param name="element">The element to associate the flyout with.</param>
    /// <param name="value">The flyout to associate with the specified element.</param>
    [MethodImpl]
    public static extern void SetAttachedFlyout(FrameworkElement element, FlyoutBase value);

    /// <summary>Shows the flyout associated with the specified element, if any.</summary>
    /// <param name="flyoutOwner">The element for which to show the associated flyout.</param>
    [MethodImpl]
    public static extern void ShowAttachedFlyout(FrameworkElement flyoutOwner);
  }
}
