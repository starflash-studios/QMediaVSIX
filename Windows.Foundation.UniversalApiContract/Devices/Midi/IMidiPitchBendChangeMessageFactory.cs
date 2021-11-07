// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiPitchBendChangeMessageFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4126072661, 53192, 18726, 179, 14, 163, 98, 35, 147, 48, 108)]
  [ExclusiveTo(typeof (MidiPitchBendChangeMessage))]
  internal interface IMidiPitchBendChangeMessageFactory
  {
    MidiPitchBendChangeMessage CreateMidiPitchBendChangeMessage(
      byte channel,
      ushort bend);
  }
}
