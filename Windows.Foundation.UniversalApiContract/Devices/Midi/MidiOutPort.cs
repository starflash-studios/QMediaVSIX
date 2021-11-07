// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiOutPort
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  /// <summary>Represents a port used to send MIDI messages to a MIDI device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMidiOutPortStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MidiOutPort : IMidiOutPort, IClosable
  {
    /// <summary>Send the data in the specified MIDI message to the device associated with this MidiOutPort.</summary>
    /// <param name="midiMessage">The MIDI message to send to the device.</param>
    [MethodImpl]
    public extern void SendMessage(IMidiMessage midiMessage);

    /// <summary>Send the specified data buffer to the device associated with this MidiOutPort.</summary>
    /// <param name="midiData">The data to send to the device.</param>
    [MethodImpl]
    public extern void SendBuffer(IBuffer midiData);

    /// <summary>Gets the id of the device that was used to initialize the MidiOutPort.</summary>
    /// <returns>The ID of the device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a MidiOutPort object for the specified device.</summary>
    /// <param name="deviceId">The device ID, which can be obtained by enumerating the devices on the system Windows.Devices.Enumeration.DeviceInformation.FindAllAsync.</param>
    /// <returns>The asynchronous operation. Upon completion, IAsyncOperation.GetResults returns a MidiOutPort object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IMidiOutPort> FromIdAsync(
      string deviceId);

    /// <summary>Gets a query string that can be used to enumerate all MidiOutPort objects on the system.</summary>
    /// <returns>The query string used to enumerate the MidiOutPort objects on the system.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
