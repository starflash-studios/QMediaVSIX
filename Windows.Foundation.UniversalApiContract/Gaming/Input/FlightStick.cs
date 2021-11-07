// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.FlightStick
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
  /// <summary>Represents a flight stick.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IFlightStickStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class FlightStick : IFlightStick, IGameController, IGameControllerBatteryInfo
  {
    /// <summary>The type of hat switch on the flight stick.</summary>
    /// <returns>The type of hat switch on the flight stick.</returns>
    public extern GameControllerSwitchKind HatSwitchKind { [MethodImpl] get; }

    /// <summary>Retrieves the button label for the specified button.</summary>
    /// <param name="button">The button for which to retrieve the label.</param>
    /// <returns>The label for the specified button. If the button label is blank or there is no known label for the controller’s button, then **None** is returned.</returns>
    [MethodImpl]
    public extern GameControllerButtonLabel GetButtonLabel(
      FlightStickButtons button);

    /// <summary>Gets a snapshot of the flight stick state.</summary>
    /// <returns>The current state of the flight stick.</returns>
    [MethodImpl]
    public extern FlightStickReading GetCurrentReading();

    /// <summary>Signals when a headset is attached to the flight stick.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    /// <summary>Signals when a headset is disconnected from the flight stick.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    /// <summary>Signals when the user associated with the flight stick has changed.</summary>
    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    /// <summary>The audio headset attached to the flight stick.</summary>
    /// <returns>The audio headset attached to the flight stick.</returns>
    public extern Headset Headset { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the wireless state of the flight stick.</summary>
    /// <returns>True if the flight stick is wireless. Otherwise, false.</returns>
    public extern bool IsWireless { [MethodImpl] get; }

    /// <summary>The user associated with the flight stick.</summary>
    /// <returns>The user associated with the flight stick.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets information about the flight stick's current battery state.</summary>
    /// <returns>Information about the flight stick's current battery state.</returns>
    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    /// <summary>Signals when a new flight stick is connected.</summary>
    public static extern event EventHandler<FlightStick> FlightStickAdded;

    /// <summary>Signals when a flight stick is disconnected.</summary>
    public static extern event EventHandler<FlightStick> FlightStickRemoved;

    /// <summary>The list of all connected flight sticks.</summary>
    /// <returns>The list of all connected flight sticks.</returns>
    public static extern IVectorView<FlightStick> FlightSticks { [MethodImpl] get; }

    /// <summary>Returns the given game controller as a flight stick.</summary>
    /// <param name="gameController">The game controller to be returned as a flight stick.</param>
    /// <returns>The flight stick that was returned from the given game controller.</returns>
    [MethodImpl]
    public static extern FlightStick FromGameController(IGameController gameController);
  }
}
