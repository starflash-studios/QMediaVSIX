// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSongPositionPointerMessageFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiSongPositionPointerMessage))]
  [Guid(2617305494, 61707, 20458, 179, 149, 245, 214, 207, 128, 246, 78)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiSongPositionPointerMessageFactory
  {
    MidiSongPositionPointerMessage CreateMidiSongPositionPointerMessage(
      ushort beats);
  }
}
