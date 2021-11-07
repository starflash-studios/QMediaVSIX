// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.RawGameController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Devices.Haptics;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Gaming.Input.ForceFeedback;
using Windows.System;

namespace Windows.Gaming.Input
{
  /// <summary>Represents any type of game controller.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  [Static(typeof (IRawGameControllerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class RawGameController : 
    IRawGameController,
    IGameController,
    IGameControllerBatteryInfo,
    IRawGameController2
  {
    /// <summary>The number of axes on the raw game controller.</summary>
    /// <returns>The number of axes on the raw game controller.</returns>
    public extern int AxisCount { [MethodImpl] get; }

    /// <summary>The number of buttons on the raw game controller.</summary>
    /// <returns>The number of buttons on the raw game controller.</returns>
    public extern int ButtonCount { [MethodImpl] get; }

    /// <summary>The list of force feedback motors in the raw game controller.</summary>
    /// <returns>The list of force feedback motors in the raw game controller.</returns>
    public extern IVectorView<ForceFeedbackMotor> ForceFeedbackMotors { [MethodImpl] get; }

    /// <summary>The hardware product ID of the raw game controller.</summary>
    /// <returns>The hardware product ID of the raw game controller.</returns>
    public extern ushort HardwareProductId { [MethodImpl] get; }

    /// <summary>The hardware vendor ID of the raw game controller.</summary>
    /// <returns>The hardware vendor ID of the raw game controller.</returns>
    public extern ushort HardwareVendorId { [MethodImpl] get; }

    /// <summary>The number of switches on the raw game controller.</summary>
    /// <returns>The number of switches on the raw game controller.</returns>
    public extern int SwitchCount { [MethodImpl] get; }

    /// <summary>Retrieves the button label for the specified button.</summary>
    /// <param name="buttonIndex">The button for which to retrieve the label.</param>
    /// <returns>The label for the specified button. If the button label is blank or there is no known label for the controller’s button, then **None** is returned.</returns>
    [MethodImpl]
    public extern GameControllerButtonLabel GetButtonLabel(int buttonIndex);

    /// <summary>Gets a snapshot of the raw game controller's state.</summary>
    /// <param name="buttonArray">The button array for the raw game controller to be populated with the current state of each button.</param>
    /// <param name="switchArray">The switch array for the raw game controller to be populated with the current state of each switch.</param>
    /// <param name="axisArray">The axis array for the raw game controller to be populated with the current state of each axis.</param>
    /// <returns>The timestamp of when the reading was retrieved from the raw game controller.</returns>
    [MethodImpl]
    public extern ulong GetCurrentReading(
      [Out] bool[] buttonArray,
      [Out] GameControllerSwitchPosition[] switchArray,
      [Out] double[] axisArray);

    /// <summary>Gets the type of the specified switch on the raw game controller.</summary>
    /// <param name="switchIndex">The index in the raw game controller's switch array of the switch whose type you are querying.</param>
    /// <returns>The type of the given switch on the raw game controller.</returns>
    [MethodImpl]
    public extern GameControllerSwitchKind GetSwitchKind(int switchIndex);

    /// <summary>Signals when a headset is attached to the raw game controller.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    /// <summary>Signals when a headset is disconnected from the raw game controller.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    /// <summary>Signals when the user associated with the raw game controller has changed.</summary>
    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    /// <summary>The audio headset attached to the raw game controller.</summary>
    /// <returns>The audio headset attached to the raw game controller.</returns>
    public extern Headset Headset { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the wireless state of the raw game controller.</summary>
    /// <returns>True if the raw game controller is wireless. Otherwise, false.</returns>
    public extern bool IsWireless { [MethodImpl] get; }

    /// <summary>The user associated with the raw game controller.</summary>
    /// <returns>The user associated with the raw game controller.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets information about the raw game controller's current battery state.</summary>
    /// <returns>Information about the raw game controller's current battery state.</returns>
    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    /// <summary>A collection of SimpleHapticsController objects representing all available haptic feedback motors available on the device.</summary>
    /// <returns>A collection of SimpleHapticsController objects representing all available haptic feedback motors available on the device.</returns>
    public extern IVectorView<SimpleHapticsController> SimpleHapticsControllers { [MethodImpl] get; }

    /// <summary>A unique ID that identifies the controller. As long as the controller is connected, the ID will never change.</summary>
    /// <returns>A unique ID that identifies the controller. As long as the controller is connected, the ID will never change.</returns>
    public extern string NonRoamableId { [MethodImpl] get; }

    /// <summary>The name of the controller, provided by the hardware.</summary>
    /// <returns>The name of the controller, provided by the hardware.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Signals when a new raw game controller is connected.</summary>
    public static extern event EventHandler<RawGameController> RawGameControllerAdded;

    /// <summary>Signals when a raw game controller is disconnected.</summary>
    public static extern event EventHandler<RawGameController> RawGameControllerRemoved;

    /// <summary>The list of all connected raw game controllers.</summary>
    /// <returns>The list of all connected raw game controllers.</returns>
    public static extern IVectorView<RawGameController> RawGameControllers { [MethodImpl] get; }

    /// <summary>Returns the given game controller as a raw game controller.</summary>
    /// <param name="gameController">The game controller to be returned as a raw game controller.</param>
    /// <returns>The raw game controller that was returned from the given game controller.</returns>
    [MethodImpl]
    public static extern RawGameController FromGameController(
      IGameController gameController);
  }
}
