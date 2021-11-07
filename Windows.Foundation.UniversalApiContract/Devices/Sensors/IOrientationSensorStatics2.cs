// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensorStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (OrientationSensor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1507462411, 54282, 19569, 146, 118, 138, 39, 42, 10, 102, 25)]
  internal interface IOrientationSensorStatics2
  {
    OrientationSensor GetDefaultForRelativeReadings();
  }
}
