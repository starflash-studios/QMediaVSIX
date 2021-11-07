// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Gamepad
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Gaming.Input
{
  /// <summary>Represents a gamepad.</summary>
  [Static(typeof (IGamepadStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGamepadStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class Gamepad : IGamepad, IGameController, IGamepad2, IGameControllerBatteryInfo
  {
    /// <summary>Describes the gamepad motor speed.</summary>
    /// <returns>Describes the gamepad motor speed.</returns>
    public extern GamepadVibration Vibration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a snapshot of the gamepad state.</summary>
    /// <returns>The current state of the gamepad.</returns>
    [MethodImpl]
    public extern GamepadReading GetCurrentReading();

    /// <summary>Signals when a headset is attached to the gamepad.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    /// <summary>Signals when a headset is disconnected from the gamepad.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    /// <summary>Signals when the user associated with the gamepad has changed.</summary>
    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    /// <summary>The audio headset attached to the gamepad.</summary>
    /// <returns>The audio headset attached to the gamepad.</returns>
    public extern Headset Headset { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the wireless state of the gamepad.</summary>
    /// <returns>True if the gamepad is wireless. Otherwise, false.</returns>
    public extern bool IsWireless { [MethodImpl] get; }

    /// <summary>The user associated with the gamepad.</summary>
    /// <returns>The user associated with the gamepad.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Retrieves the button label for the specified button.</summary>
    /// <param name="button">The button for which to retrieve the label.</param>
    /// <returns>The label for the specified button. If the button label is blank or there is no known label for the controller’s button, then **None** is returned.</returns>
    [MethodImpl]
    public extern GameControllerButtonLabel GetButtonLabel(
      GamepadButtons button);

    /// <summary>Gets information about the gamepad's current battery state.</summary>
    /// <returns>Information about the gamepad's current battery state.</returns>
    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    /// <summary>Returns the given game controller as a gamepad.</summary>
    /// <param name="gameController">The game controller to be returned as a gamepad.</param>
    /// <returns>The gamepad that was returned from the given game controller.</returns>
    [MethodImpl]
    public static extern Gamepad FromGameController(IGameController gameController);

    /// <summary>Signals when a new gamepad is connected.</summary>
    public static extern event EventHandler<Gamepad> GamepadAdded;

    /// <summary>Signals when a gamepad is disconnected.</summary>
    public static extern event EventHandler<Gamepad> GamepadRemoved;

    /// <summary>The list of all connected gamepads.</summary>
    /// <returns>The list of all connected gamepads.</returns>
    public static extern IVectorView<Gamepad> Gamepads { [MethodImpl] get; }
  }
}
