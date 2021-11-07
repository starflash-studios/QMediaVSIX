// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverInputDevices
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>The devices from which the Miracast Receiver can collect input and transmit to the Miracast Transmitter.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MiracastReceiverInputDevices : IMiracastReceiverInputDevices
  {
    /// <summary>Returns a Keyboard input device for use with Miracast.</summary>
    /// <returns>The Keyboard input device.</returns>
    public extern MiracastReceiverKeyboardDevice Keyboard { [MethodImpl] get; }

    /// <summary>Returns a Game Controller input device for use with Miracast, such as a gamepad, joystick, or steering wheel.</summary>
    /// <returns>The Game Controller input device.</returns>
    public extern MiracastReceiverGameControllerDevice GameController { [MethodImpl] get; }
  }
}
