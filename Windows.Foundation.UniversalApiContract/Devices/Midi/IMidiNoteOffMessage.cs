// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiNoteOffMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiNoteOffMessage))]
  [Guid(385714932, 6542, 19855, 166, 84, 211, 5, 162, 147, 84, 143)]
  internal interface IMidiNoteOffMessage : IMidiMessage
  {
    byte Channel { get; }

    byte Note { get; }

    byte Velocity { get; }
  }
}
