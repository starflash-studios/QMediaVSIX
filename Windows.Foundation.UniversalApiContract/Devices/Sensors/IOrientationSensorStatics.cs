// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (OrientationSensor))]
  [Guid(284133138, 64332, 17034, 137, 139, 39, 101, 228, 9, 230, 105)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IOrientationSensorStatics
  {
    [Overload("GetDefault")]
    OrientationSensor GetDefault();
  }
}
