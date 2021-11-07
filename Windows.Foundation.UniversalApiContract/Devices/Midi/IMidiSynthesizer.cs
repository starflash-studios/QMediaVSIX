// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiSynthesizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(4040824158, 56208, 16479, 184, 174, 33, 210, 225, 127, 46, 69)]
  [ExclusiveTo(typeof (MidiSynthesizer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiSynthesizer : IMidiOutPort, IClosable
  {
    DeviceInformation AudioDevice { get; }

    double Volume { get; set; }
  }
}
