// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiTimeCodeMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  /// <summary>Represents a MIDI message that specifies a time code.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IMidiTimeCodeMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class MidiTimeCodeMessage : IMidiTimeCodeMessage, IMidiMessage
  {
    /// <summary>Creates a new MidiTimeCodeMessage object.</summary>
    /// <param name="frameType">The frame type from 0-7.</param>
    /// <param name="values">The time code from 0-32.</param>
    [MethodImpl]
    public extern MidiTimeCodeMessage(byte frameType, byte values);

    /// <summary>Gets the value of the frame type from 0-7.</summary>
    /// <returns>The value of the frame type from 0-7.</returns>
    public extern byte FrameType { [MethodImpl] get; }

    /// <summary>Gets the time code value from 0-32.</summary>
    /// <returns>The time code value from 0-32.</returns>
    public extern byte Values { [MethodImpl] get; }

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
