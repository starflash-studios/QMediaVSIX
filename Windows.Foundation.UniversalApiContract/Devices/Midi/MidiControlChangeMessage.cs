// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiControlChangeMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  /// <summary>Represents a MIDI message that specifies a control change.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IMidiControlChangeMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MidiControlChangeMessage : IMidiControlChangeMessage, IMidiMessage
  {
    /// <summary>Creates a new MidiControlChangeMessage object.</summary>
    /// <param name="channel">The channel from 0-15 that this message applies to.</param>
    /// <param name="controller">The controller from 0-127 to receive this message.</param>
    /// <param name="controlValue">The value from 0-127 to apply to the controller.</param>
    [MethodImpl]
    public extern MidiControlChangeMessage(byte channel, byte controller, byte controlValue);

    /// <summary>Gets the channel from 0-15 that this message applies to.</summary>
    /// <returns>The channel from 0-15 that this message applies to.</returns>
    public extern byte Channel { [MethodImpl] get; }

    /// <summary>Gets controller from 0-127 to receive this message.</summary>
    /// <returns>The controller from 0-127 to receive this message.</returns>
    public extern byte Controller { [MethodImpl] get; }

    /// <summary>Gets the value from 0-127 to apply to the controller.</summary>
    /// <returns>The value from 0-127 to apply to the controller.</returns>
    public extern byte ControlValue { [MethodImpl] get; }

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
