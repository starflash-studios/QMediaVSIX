// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensorStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (OrientationSensor))]
  [Guid(2793401173, 11397, 19240, 160, 254, 88, 196, 178, 4, 149, 245)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IOrientationSensorStatics4
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector(SensorReadingType readingType);

    [Overload("GetDeviceSelectorWithSensorReadingTypeAndSensorOptimizationGoal")]
    string GetDeviceSelector(SensorReadingType readingType, SensorOptimizationGoal optimizationGoal);

    [RemoteAsync]
    IAsyncOperation<OrientationSensor> FromIdAsync(string deviceId);
  }
}
