// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverGameControllerDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Represents a Game Controller input device for use with Miracast, such as a gamepad, joystick, or steering wheel.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class MiracastReceiverGameControllerDevice : IMiracastReceiverGameControllerDevice
  {
    /// <summary>Controls if the Miracast Receiver offers to transmit game controller input to the Miracast Transmitter.</summary>
    /// <returns>True if the Miracast Receiver offers to transmit game controller input to the Miracast Transmitter.</returns>
    public extern bool TransmitInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates if the Miracast Transmitter is willing to receive input from a game controller device.</summary>
    /// <returns>True if the Miracast Transmitter is willing to receive input from a game controller device.</returns>
    public extern bool IsRequestedByTransmitter { [MethodImpl] get; }

    /// <summary>Indicates if the Miracast Receiver is currently transmitting input from a game controller device to the Miracast Transmitter.</summary>
    /// <returns>True if the Miracast Receiver is currently transmitting input from a game controller device to the Miracast Transmitter.</returns>
    public extern bool IsTransmittingInput { [MethodImpl] get; }

    /// <summary>Specifies how game controller input is being used when transmitted to a Miracast Transmitter. Game controller input can be transmitted as-is, or it can be mapped to mouse and keyboard input.</summary>
    /// <returns>The current MiracastReceiverGameControllerDeviceUsageMode value.</returns>
    public extern MiracastReceiverGameControllerDeviceUsageMode Mode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>An event which is raised when any of the properties on the MiracastReceiverGameControllerDevice has changed.</summary>
    public extern event TypedEventHandler<MiracastReceiverGameControllerDevice, object> Changed;
  }
}
