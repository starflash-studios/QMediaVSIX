// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiNoteOnMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3760343797, 24961, 18141, 175, 162, 65, 0, 4, 192, 87, 170)]
  [ExclusiveTo(typeof (MidiNoteOnMessage))]
  internal interface IMidiNoteOnMessage : IMidiMessage
  {
    byte Channel { get; }

    byte Note { get; }

    byte Velocity { get; }
  }
}
