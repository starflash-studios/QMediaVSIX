// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensorStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (OrientationSensor))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3626821920, 10103, 16639, 159, 89, 214, 84, 176, 133, 241, 47)]
  internal interface IOrientationSensorStatics3
  {
    [Overload("GetDefaultWithSensorReadingType")]
    OrientationSensor GetDefault(SensorReadingType sensorReadingtype);

    [Overload("GetDefaultWithSensorReadingTypeAndSensorOptimizationGoal")]
    OrientationSensor GetDefault(
      SensorReadingType sensorReadingType,
      SensorOptimizationGoal optimizationGoal);
  }
}
