// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiSynthesizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  /// <summary>Represents the Microsoft GS wavetable software synthesizer, included in Windows. This synthesizer provides a Roland GS sound set, which includes and extends the General MIDI sound set.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IMidiSynthesizerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MidiSynthesizer : IMidiSynthesizer, IMidiOutPort, IClosable
  {
    /// <summary>Gets the audio output device being used by this instance of the Microsoft MIDI synthesizer.</summary>
    /// <returns>An object that represents the audio output device. Use the methods and properties of this object to further identify the device.</returns>
    public extern DeviceInformation AudioDevice { [MethodImpl] get; }

    /// <summary>Gets or sets the output volume of this instance of the Microsoft MIDI synthesizer.</summary>
    /// <returns>The synthesizer's output volume, a number between 0 and 1, inclusive.</returns>
    public extern double Volume { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Sends a MIDI message through the Microsoft MIDI synthesizer's out port.</summary>
    /// <param name="midiMessage">The MIDI message to send.</param>
    [MethodImpl]
    public extern void SendMessage(IMidiMessage midiMessage);

    /// <summary>Sends an array of bytes through the synthesizer's out port. This enables you to send your data as a byte array instead of as a defined MIDI message.</summary>
    /// <param name="midiData">The array of bytes to send.</param>
    [MethodImpl]
    public extern void SendBuffer(IBuffer midiData);

    /// <summary>Gets the device ID of the Microsoft MIDI synthesizer. Note that all instances of the synthesizer have the same ID.</summary>
    /// <returns>The device ID of this instance of the Microsoft MIDI synthesizer.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a new instance of the Microsoft MIDI synthesizer that uses the system's default audio output device.</summary>
    /// <returns>An instance of the Windows MIDI synthesizer.</returns>
    [Overload("CreateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MidiSynthesizer> CreateAsync();

    /// <summary>Creates a new instance of the Microsoft MIDI synthesizer with a specified audio output device.</summary>
    /// <param name="audioDevice">The audio output device.</param>
    /// <returns>An instance of the Microsoft MIDI synthesizer.</returns>
    [Overload("CreateFromAudioDeviceAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MidiSynthesizer> CreateAsync(
      DeviceInformation audioDevice);

    /// <summary>Determines whether a particular device is an instance of the Microsoft MIDI synthesizer. When all MIDI out ports on the system are enumerated, this method can be used to identify which of them is the Microsoft MIDI synthesizer.</summary>
    /// <param name="midiDevice">An object that represents the device in question.</param>
    /// <returns>**True** if the device is the Microsoft MIDI synthesizer; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool IsSynthesizer(DeviceInformation midiDevice);
  }
}
