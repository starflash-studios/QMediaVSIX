// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Represents a single connection between a Miracast Receiver and a Miracast Transmitter.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class MiracastReceiverConnection : IMiracastReceiverConnection, IClosable
  {
    /// <summary>Closes the connection and immediately disconnects the connected MiracastTransmitter.</summary>
    /// <param name="reason">A value from the MiracastReceiverDisconnectReason enumeration specifying the reason for disconnecting the Miracast Transmitter.</param>
    [Overload("Disconnect")]
    [MethodImpl]
    public extern void Disconnect(MiracastReceiverDisconnectReason reason);

    /// <summary>Closes the connection and immediately disconnects the connected MiracastTransmitter.</summary>
    /// <param name="reason">A value from the MiracastReceiverDisconnectReason enumeration specifying the reason for disconnecting the Miracast Transmitter.</param>
    /// <param name="message">A human-readable message, stating a reason for disconnecting the Miracast Transmitter.</param>
    [Overload("DisconnectWithMessage")]
    [MethodImpl]
    public extern void Disconnect(MiracastReceiverDisconnectReason reason, string message);

    /// <summary>Requests the Miracast Transmitter to pause streaming audio and video data to the Receiver. The connection remains established.</summary>
    [MethodImpl]
    public extern void Pause();

    /// <summary>Asynchronously requests the Miracast Transmitter to pause streaming audio and video data to the Receiver. The connection remains established.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction PauseAsync();

    /// <summary>Requests the Miracast Transmitter to resume streaming audio and video data to the MiracastReceiver.</summary>
    [MethodImpl]
    public extern void Resume();

    /// <summary>Requests the Miracast Transmitter to resume streaming audio and video data to the MiracastReceiver.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ResumeAsync();

    /// <summary>Gets an MiracastTransmitter object representing the Miracast Transmitter that initiated the connection.</summary>
    /// <returns>The Miracast Transmitter.</returns>
    public extern MiracastTransmitter Transmitter { [MethodImpl] get; }

    /// <summary>Gets the devices from which the Miracast Receiver can collect input and transmit to the Miracast Transmitter.</summary>
    /// <returns>A MiracastReceiverInputDevices representing the input devices.</returns>
    public extern MiracastReceiverInputDevices InputDevices { [MethodImpl] get; }

    /// <summary>Gets the channel for transmitting mouse cursor images from a Miracast Transmitter to a Miracast Receiver.</summary>
    /// <returns>The cursor image channel.</returns>
    public extern MiracastReceiverCursorImageChannel CursorImageChannel { [MethodImpl] get; }

    /// <summary>Gets a MiracastReceiverStreamControl object, which is used for controlling properties of the audio and video streams.</summary>
    /// <returns>The **MiracastReceiverStreamControl** object.</returns>
    public extern MiracastReceiverStreamControl StreamControl { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
