// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiTimeCodeMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiTimeCodeMessage))]
  [Guid(200738941, 64099, 18972, 141, 235, 192, 232, 119, 150, 166, 215)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiTimeCodeMessage : IMidiMessage
  {
    byte FrameType { get; }

    byte Values { get; }
  }
}
