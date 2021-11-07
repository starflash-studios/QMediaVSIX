// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.RacingWheel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Gaming.Input.ForceFeedback;
using Windows.System;

namespace Windows.Gaming.Input
{
  /// <summary>Represents a racing wheel.</summary>
  [Static(typeof (IRacingWheelStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRacingWheelStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class RacingWheel : IRacingWheel, IGameController, IGameControllerBatteryInfo
  {
    /// <summary>Boolean indicating whether the racing wheel has a clutch.</summary>
    /// <returns>Boolean indicating whether the racing wheel has a clutch.</returns>
    public extern bool HasClutch { [MethodImpl] get; }

    /// <summary>Boolean indicating whether the racing wheel has a handbrake.</summary>
    /// <returns>Boolean indicating whether the racing wheel has a handbrake.</returns>
    public extern bool HasHandbrake { [MethodImpl] get; }

    /// <summary>Boolean indicating whether the racing wheel has a pattern shifter.</summary>
    /// <returns>Boolean indicating whether the racing wheel has a pattern shifter.</returns>
    public extern bool HasPatternShifter { [MethodImpl] get; }

    /// <summary>The highest gear of the shifter.</summary>
    /// <returns>The highest gear of the shifter.</returns>
    public extern int MaxPatternShifterGear { [MethodImpl] get; }

    /// <summary>The maximum angle, in degrees, of the racing wheel.</summary>
    /// <returns>The maximum angle, in degrees, of the racing wheel.</returns>
    public extern double MaxWheelAngle { [MethodImpl] get; }

    /// <summary>The force feedback motor for the racing wheel.</summary>
    /// <returns>The force feedback motor for the racing wheel. If the controller does not support force feedback, this property will be **null**.</returns>
    public extern ForceFeedbackMotor WheelMotor { [MethodImpl] get; }

    /// <summary>Retrieves the button label for the specified button.</summary>
    /// <param name="button">The button for which to retrieve the label.</param>
    /// <returns>Returns the button label for the specified button. If the button label is blank or there is no known label for the controller’s button, then **None** is returned.</returns>
    [MethodImpl]
    public extern GameControllerButtonLabel GetButtonLabel(
      RacingWheelButtons button);

    /// <summary>Gets a snapshot of the racing wheel's state.</summary>
    /// <returns>The current state of the racing wheel.</returns>
    [MethodImpl]
    public extern RacingWheelReading GetCurrentReading();

    /// <summary>Signals when a headset is attached to the racing wheel.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    /// <summary>Signals when a headset is disconnected from the racing wheel.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    /// <summary>Signals when the user associated with the racing wheel has changed.</summary>
    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    /// <summary>The audio headset attached to the racing wheel.</summary>
    /// <returns>The audio headset attached to the racing wheel.</returns>
    public extern Headset Headset { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the wireless state of the racing wheel.</summary>
    /// <returns>True if the gamepad is wireless. Otherwise, false.</returns>
    public extern bool IsWireless { [MethodImpl] get; }

    /// <summary>The user associated with the racing wheel.</summary>
    /// <returns>The user associated with the racing wheel.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets information about the racing wheel's current battery state.</summary>
    /// <returns>Information about the racing wheel's current battery state.</returns>
    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    /// <summary>Returns the given game controller as a racing wheel.</summary>
    /// <param name="gameController">The game controller to be returned as a racing wheel.</param>
    /// <returns>The racing wheel that was returned from the given game controller.</returns>
    [MethodImpl]
    public static extern RacingWheel FromGameController(IGameController gameController);

    /// <summary>Signals when a new racing wheel is connected.</summary>
    public static extern event EventHandler<RacingWheel> RacingWheelAdded;

    /// <summary>Signals when a racing wheel is disconnected.</summary>
    public static extern event EventHandler<RacingWheel> RacingWheelRemoved;

    /// <summary>The list of all connected racing wheels.</summary>
    /// <returns>The list of all connected racing wheels.</returns>
    public static extern IVectorView<RacingWheel> RacingWheels { [MethodImpl] get; }
  }
}
