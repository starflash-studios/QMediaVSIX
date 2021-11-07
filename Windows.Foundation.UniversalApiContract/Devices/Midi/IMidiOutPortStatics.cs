// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Midi.IMidiOutPortStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Midi
{
  [Guid(106742761, 3976, 17547, 155, 100, 169, 88, 38, 198, 91, 143)]
  [ExclusiveTo(typeof (MidiOutPort))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMidiOutPortStatics
  {
    [RemoteAsync]
    IAsyncOperation<IMidiOutPort> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
