// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Represents a wheel input device or accessory such as the Surface Dial.</summary>
  [Static(typeof (IRadialControllerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RadialController : IRadialController, IRadialController2
  {
    /// <summary>Gets a reference to the menu associated with the RadialController object.</summary>
    /// <returns>The integrated menu of contextual app commands associated with the RadialController object.</returns>
    public extern RadialControllerMenu Menu { [MethodImpl] get; }

    /// <summary>Gets or sets the minimum rotational value required for the RadialController object to fire a RotationChanged event.</summary>
    /// <returns>The minimum rotational value required to fire a RotationChanged event.</returns>
    public extern double RotationResolutionInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether haptic feedback is enabled on the wheel device for each RotationChanged event fired by the RadialController.</summary>
    /// <returns>**true** if haptic feedback is enabled; otherwise **false**.</returns>
    public extern bool UseAutomaticHapticFeedback { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when initial contact is detected between a wheel device and the digitizer surface, and a custom RadialController tool is active.</summary>
    public extern event TypedEventHandler<RadialController, RadialControllerScreenContactStartedEventArgs> ScreenContactStarted;

    /// <summary>Occurs when a wheel device that is in contact with the digitizer surface is removed (or is no longer detected), and a custom RadialController tool is active.</summary>
    public extern event TypedEventHandler<RadialController, object> ScreenContactEnded;

    /// <summary>Occurs only when the wheel device is moved while in contact with the digitizer surface, and a custom RadialController tool is active.</summary>
    public extern event TypedEventHandler<RadialController, RadialControllerScreenContactContinuedEventArgs> ScreenContactContinued;

    /// <summary>Occurs while a custom RadialController tool (defined by an app) is active, and either the app associated with the RadialController object is sent to the background, or the user activates the RadialController menu.</summary>
    public extern event TypedEventHandler<RadialController, object> ControlLost;

    /// <summary>Occurs when the wheel device is rotated while a custom RadialController tool is active.</summary>
    public extern event TypedEventHandler<RadialController, RadialControllerRotationChangedEventArgs> RotationChanged;

    /// <summary>Occurs when the wheel device is pressed and then released while a custom RadialController tool is active.</summary>
    public extern event TypedEventHandler<RadialController, RadialControllerButtonClickedEventArgs> ButtonClicked;

    /// <summary>Occurs when a custom RadialController tool (defined by an app) is selected from the menu, or when an app associated with the RadialController object is brought to the foreground while a custom RadialController tool is active.</summary>
    public extern event TypedEventHandler<RadialController, RadialControllerControlAcquiredEventArgs> ControlAcquired;

    /// <summary>Occurs when the wheel device is pressed.</summary>
    public extern event TypedEventHandler<RadialController, RadialControllerButtonPressedEventArgs> ButtonPressed;

    /// <summary>Occurs when the user presses and holds down the wheel device.</summary>
    public extern event TypedEventHandler<RadialController, RadialControllerButtonHoldingEventArgs> ButtonHolding;

    /// <summary>Occurs when the wheel device is pressed and then released.</summary>
    public extern event TypedEventHandler<RadialController, RadialControllerButtonReleasedEventArgs> ButtonReleased;

    /// <summary>Retrieves a value that indicates whether wheel devices are supported by the system.</summary>
    /// <returns>**true** if wheel devices are supported by the system; otherwise **false**.</returns>
    [MethodImpl]
    public static extern bool IsSupported();

    /// <summary>Instantiates a RadialController object for the wheel device and binds it to the active application.</summary>
    /// <returns>The RadialController object to bind to the active application.</returns>
    [MethodImpl]
    public static extern RadialController CreateForCurrentView();
  }
}
