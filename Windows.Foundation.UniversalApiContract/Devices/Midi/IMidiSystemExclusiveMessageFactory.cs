// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSystemExclusiveMessageFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiSystemExclusiveMessage))]
  [Guid(138273314, 15220, 17184, 155, 66, 12, 168, 84, 95, 138, 36)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiSystemExclusiveMessageFactory
  {
    MidiSystemExclusiveMessage CreateMidiSystemExclusiveMessage(
      IBuffer rawData);
  }
}
