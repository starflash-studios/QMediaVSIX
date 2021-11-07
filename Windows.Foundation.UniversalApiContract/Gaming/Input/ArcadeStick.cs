// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ArcadeStick
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
  /// <summary>Represents an arcade stick.</summary>
  [Static(typeof (IArcadeStickStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IArcadeStickStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class ArcadeStick : IArcadeStick, IGameController, IGameControllerBatteryInfo
  {
    /// <summary>Retrieves the button label for the specified button.</summary>
    /// <param name="button">The button for which to retrieve the label.</param>
    /// <returns>Returns the label for the specified button. If the button label is blank or there is no known label for the controller’s button, then **None** is returned.</returns>
    [MethodImpl]
    public extern GameControllerButtonLabel GetButtonLabel(
      ArcadeStickButtons button);

    /// <summary>Gets a snapshot of the arcade stick state.</summary>
    /// <returns>The current state of the arcade stick.</returns>
    [MethodImpl]
    public extern ArcadeStickReading GetCurrentReading();

    /// <summary>Signals when a headset is attached to the arcade stick.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    /// <summary>Signals when a headset is disconnected from the arcade stick.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    /// <summary>Signals when the user associated with the arcade stick has changed.</summary>
    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    /// <summary>The audio headset attached to the arcade stick.</summary>
    /// <returns>The audio headset attached to the arcade stick.</returns>
    public extern Headset Headset { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the wireless state of the arcade stick.</summary>
    /// <returns>True if the arcade stick is wireless. Otherwise, false.</returns>
    public extern bool IsWireless { [MethodImpl] get; }

    /// <summary>The user associated with the arcade stick.</summary>
    /// <returns>The user associated with the arcade stick.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets information about the arcade stick's current battery state.</summary>
    /// <returns>Information about the arcade stick's current battery state.</returns>
    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    /// <summary>Returns the given game controller as an arcade stick.</summary>
    /// <param name="gameController">The game controller to be returned as an arcade stick.</param>
    /// <returns>The arcade stick that was returned from the given game controller.</returns>
    [MethodImpl]
    public static extern ArcadeStick FromGameController(IGameController gameController);

    /// <summary>Signals when a new arcade stick is connected.</summary>
    public static extern event EventHandler<ArcadeStick> ArcadeStickAdded;

    /// <summary>Signals when an arcade stick is disconnected.</summary>
    public static extern event EventHandler<ArcadeStick> ArcadeStickRemoved;

    /// <summary>The list of all connected arcade sticks.</summary>
    /// <returns>The list of all connected arcade sticks.</returns>
    public static extern IVectorView<ArcadeStick> ArcadeSticks { [MethodImpl] get; }
  }
}
