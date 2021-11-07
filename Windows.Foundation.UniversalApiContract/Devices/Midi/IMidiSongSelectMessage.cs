// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSongSelectMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiSongSelectMessage))]
  [Guid(1240527487, 28035, 18241, 165, 191, 70, 41, 246, 190, 151, 79)]
  internal interface IMidiSongSelectMessage : IMidiMessage
  {
    byte Song { get; }
  }
}
