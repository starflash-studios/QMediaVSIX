// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensorStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (LightSensor))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(247506512, 56774, 16555, 172, 227, 236, 51, 89, 212, 44, 81)]
  internal interface ILightSensorStatics2
  {
    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<LightSensor> FromIdAsync(string deviceId);
  }
}
