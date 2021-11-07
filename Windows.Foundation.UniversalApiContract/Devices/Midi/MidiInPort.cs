// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiInPort
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  /// <summary>Represents a port used to receive MIDI messages from a MIDI device.</summary>
  [Static(typeof (IMidiInPortStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class MidiInPort : IMidiInPort, IClosable
  {
    /// <summary>Occurs when the MidiInPort receives data.</summary>
    public extern event TypedEventHandler<MidiInPort, MidiMessageReceivedEventArgs> MessageReceived;

    /// <summary>Gets the id of the device that was used to initialize the MidiInPort.</summary>
    /// <returns>The ID of the device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a MidiInPort object for the specified device.</summary>
    /// <param name="deviceId">The device ID, which can be obtained by enumerating the devices on the system Windows.Devices.Enumeration.DeviceInformation.FindAllAsync.</param>
    /// <returns>The asynchronous operation. Upon completion, IAsyncOperation.GetResults returns a MidiInPort object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MidiInPort> FromIdAsync(
      string deviceId);

    /// <summary>Gets a query string that can be used to enumerate all MidiInPort objects on the system.</summary>
    /// <returns>The query string used to enumerate the MidiInPort objects on the system.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
