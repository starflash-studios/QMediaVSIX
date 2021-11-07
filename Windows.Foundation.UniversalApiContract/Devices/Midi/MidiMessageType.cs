// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.MidiMessageType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  /// <summary>Specifies constants used to map MIDI message types into their corresponding byte codes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MidiMessageType
  {
    /// <summary>Specifies no message type.</summary>
    None = 0,
    /// <summary>A MidiNoteOffMessage.</summary>
    NoteOff = 128, // 0x00000080
    /// <summary>A MidiNoteOnMessage.</summary>
    NoteOn = 144, // 0x00000090
    /// <summary>A MidiPolyphonicKeyPressureMessage.</summary>
    PolyphonicKeyPressure = 160, // 0x000000A0
    /// <summary>A MidiControlChangeMessage.</summary>
    ControlChange = 176, // 0x000000B0
    /// <summary>A MidiControlChangeMessage.</summary>
    ProgramChange = 192, // 0x000000C0
    /// <summary>A MidiChannelPressureMessage.</summary>
    ChannelPressure = 208, // 0x000000D0
    /// <summary>A MidiPitchBendChangeMessage.</summary>
    PitchBendChange = 224, // 0x000000E0
    /// <summary>A MidiSystemExclusiveMessage.</summary>
    SystemExclusive = 240, // 0x000000F0
    /// <summary>A MidiTimeCodeMessage.</summary>
    MidiTimeCode = 241, // 0x000000F1
    /// <summary>A MidiSongPositionPointerMessage.</summary>
    SongPositionPointer = 242, // 0x000000F2
    /// <summary>A MidiSongSelectMessage.</summary>
    SongSelect = 243, // 0x000000F3
    /// <summary>A MidiTuneRequestMessage.</summary>
    TuneRequest = 246, // 0x000000F6
    /// <summary>A MidiSystemExclusiveMessage.</summary>
    EndSystemExclusive = 247, // 0x000000F7
    /// <summary>A MidiTimingClockMessage.</summary>
    TimingClock = 248, // 0x000000F8
    /// <summary>A MidiStartMessage.</summary>
    Start = 250, // 0x000000FA
    /// <summary>A MidiContinueMessage.</summary>
    Continue = 251, // 0x000000FB
    /// <summary>A MidiStopMessage.</summary>
    Stop = 252, // 0x000000FC
    /// <summary>A MidiActiveSensingMessage.</summary>
    ActiveSensing = 254, // 0x000000FE
    /// <summary>A SystemResetMessage.</summary>
    SystemReset = 255, // 0x000000FF
  }
}
