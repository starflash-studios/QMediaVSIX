// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISimpleOrientationSensorStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2224004223, 45368, 19985, 137, 16, 162, 162, 163, 181, 109, 131)]
  [ExclusiveTo(typeof (SimpleOrientationSensor))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ISimpleOrientationSensorStatics2
  {
    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<SimpleOrientationSensor> FromIdAsync(
      string deviceId);
  }
}
