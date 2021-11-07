// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverKeyboardDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>A Keyboard input device for use with Miracast.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [DualApiPartition(version = 1)]
  public sealed class MiracastReceiverKeyboardDevice : IMiracastReceiverKeyboardDevice
  {
    /// <summary>Controls if the Miracast Receiver offers to transmit keyboard input to the Miracast Transmitter.</summary>
    /// <returns>True if the Miracast Receiver offers to transmit keyboard input to the Miracast Transmitter.</returns>
    public extern bool TransmitInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates if the Miracast Transmitter is willing to receive input from a keyboard device.</summary>
    /// <returns>True if the Miracast Transmitter is willing to receive input from a keyboard device.</returns>
    public extern bool IsRequestedByTransmitter { [MethodImpl] get; }

    /// <summary>Indicates if the Miracast Receiver is currently transmitting input from a keyboard device to the Miracast Transmitter.</summary>
    /// <returns>True if the Miracast Receiver is currently transmitting input from a keyboard device to the Miracast Transmitter.</returns>
    public extern bool IsTransmittingInput { [MethodImpl] get; }

    /// <summary>An event which is raised when any of the properties on the MiracastReceiverKeyboardDevice has changed.</summary>
    public extern event TypedEventHandler<MiracastReceiverKeyboardDevice, object> Changed;
  }
}
