// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSongPositionPointerMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(1285885014, 60510, 19172, 161, 21, 136, 220, 87, 204, 43, 121)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiSongPositionPointerMessage))]
  internal interface IMidiSongPositionPointerMessage : IMidiMessage
  {
    ushort Beats { get; }
  }
}
