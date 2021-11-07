// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiPitchBendChangeMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiPitchBendChangeMessage))]
  [Guid(702500017, 11935, 20399, 140, 43, 156, 184, 42, 144, 121, 202)]
  internal interface IMidiPitchBendChangeMessage : IMidiMessage
  {
    byte Channel { get; }

    ushort Bend { get; }
  }
}
