// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiOutPort
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  /// <summary>Represents a single MIDI out port.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2468179359, 22434, 19002, 173, 184, 70, 64, 136, 111, 102, 147)]
  public interface IMidiOutPort : IClosable
  {
    /// <summary>Send the data in the specified MIDI message to the device associated with this MidiOutPort.</summary>
    /// <param name="midiMessage">The MIDI message to send to the device.</param>
    void SendMessage(IMidiMessage midiMessage);

    /// <summary>Sends the contents of the buffer through the MIDI out port.</summary>
    /// <param name="midiData">The data to send to the device.</param>
    void SendBuffer(IBuffer midiData);

    /// <summary>Gets the ID of the device that contains the MIDI out port.</summary>
    /// <returns>The device ID.</returns>
    string DeviceId { get; }
  }
}
