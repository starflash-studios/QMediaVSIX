// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiInPort
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(3586251227, 38682, 20143, 162, 61, 234, 25, 254, 96, 127, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MidiInPort))]
  internal interface IMidiInPort : IClosable
  {
    event TypedEventHandler<MidiInPort, MidiMessageReceivedEventArgs> MessageReceived;

    string DeviceId { get; }
  }
}
