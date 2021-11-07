// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiTimeCodeMessageFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiTimeCodeMessage))]
  [Guid(3945830853, 30492, 16606, 185, 97, 23, 90, 116, 137, 168, 94)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiTimeCodeMessageFactory
  {
    MidiTimeCodeMessage CreateMidiTimeCodeMessage(byte frameType, byte values);
  }
}
