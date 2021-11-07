// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiPolyphonicKeyPressureMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  /// <summary>Represents a MIDI message that specifies the polyphonic key pressure.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IMidiPolyphonicKeyPressureMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MidiPolyphonicKeyPressureMessage : 
    IMidiPolyphonicKeyPressureMessage,
    IMidiMessage
  {
    /// <summary>Creates a new MidiPolyphonicKeyPressureMessage object.</summary>
    /// <param name="channel">The channel from 0-15 that this message applies to.</param>
    /// <param name="note">The note which is specified as a value from 0-127.</param>
    /// <param name="pressure">The polyphonic key pressure which is specified as a value from 0-127.</param>
    [MethodImpl]
    public extern MidiPolyphonicKeyPressureMessage(byte channel, byte note, byte pressure);

    /// <summary>Gets the channel from 0-15 that this message applies to.</summary>
    /// <returns>The channel from 0-15 that this message applies to.</returns>
    public extern byte Channel { [MethodImpl] get; }

    /// <summary>Gets the note which is specified as a value from 0-127.</summary>
    /// <returns>The note which is specified as a value from 0-127.</returns>
    public extern byte Note { [MethodImpl] get; }

    /// <summary>Gets the polyphonic key pressure which is specified as a value from 0-127.</summary>
    /// <returns>The polyphonic key pressure which is specified as a value from 0-127.</returns>
    public extern byte Pressure { [MethodImpl] get; }

    /// <summary>Gets the duration from when the MidiInPort was created to the time the message was received. For messages being sent to a MidiOutPort, this value has no meaning.</summary>
    /// <returns>The duration from when the MidiInPort was created to the time the message was received.</returns>
    public extern TimeSpan Timestamp { [MethodImpl] get; }

    /// <summary>Gets the array of bytes associated with the MIDI message, including status byte.</summary>
    /// <returns>The array of bytes associated with the MIDI message.</returns>
    public extern IBuffer RawData { [MethodImpl] get; }

    /// <summary>Gets the type of this MIDI message.</summary>
    /// <returns>The MIDI message type.</returns>
    public extern MidiMessageType Type { [MethodImpl] get; }
  }
}
