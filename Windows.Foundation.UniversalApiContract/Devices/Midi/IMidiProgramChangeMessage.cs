// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiProgramChangeMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiProgramChangeMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2629516408, 31294, 17191, 170, 152, 32, 184, 228, 72, 90, 248)]
  internal interface IMidiProgramChangeMessage : IMidiMessage
  {
    byte Channel { get; }

    byte Program { get; }
  }
}
