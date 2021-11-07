// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiInPortStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [ExclusiveTo(typeof (MidiInPort))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1153710556, 26623, 19054, 139, 172, 253, 182, 97, 12, 242, 150)]
  internal interface IMidiInPortStatics
  {
    [RemoteAsync]
    IAsyncOperation<MidiInPort> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
