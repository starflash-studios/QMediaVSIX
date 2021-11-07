// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiChannelPressureMessageFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(1645800751, 8836, 16682, 148, 207, 16, 251, 4, 132, 44, 108)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiChannelPressureMessage))]
  internal interface IMidiChannelPressureMessageFactory
  {
    MidiChannelPressureMessage CreateMidiChannelPressureMessage(
      byte channel,
      byte pressure);
  }
}
