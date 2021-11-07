// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  /// <summary>Represents a MIDI message which is implemented by all MIDI message classes.</summary>
  [Guid(2037807429, 4244, 17027, 155, 224, 40, 159, 192, 238, 131, 52)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMidiMessage
  {
    /// <summary>Gets the duration from when the MidiInPort was created to the time the message was received. For messages being sent to a MidiOutPort, this value has no meaning.</summary>
    /// <returns>The duration from when the MidiInPort was created to the time the message was received.</returns>
    TimeSpan Timestamp { get; }

    /// <summary>Gets the array of bytes associated with the MIDI message, including status byte.</summary>
    /// <returns>The array of bytes associated with the MIDI message.</returns>
    IBuffer RawData { get; }

    /// <summary>Gets the type of this MIDI message.</summary>
    /// <returns>The MIDI message type.</returns>
    MidiMessageType Type { get; }
  }
}
