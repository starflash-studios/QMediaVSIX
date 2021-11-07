// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiPolyphonicKeyPressureMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiPolyphonicKeyPressureMessage))]
  [Guid(527644670, 44264, 18592, 134, 142, 124, 219, 242, 15, 4, 214)]
  internal interface IMidiPolyphonicKeyPressureMessage : IMidiMessage
  {
    byte Channel { get; }

    byte Note { get; }

    byte Pressure { get; }
  }
}
