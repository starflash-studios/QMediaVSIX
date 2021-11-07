// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISimpleOrientationSensorDeviceId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(4223666891, 15222, 16886, 128, 145, 48, 239, 230, 70, 211, 207)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SimpleOrientationSensor))]
  internal interface ISimpleOrientationSensorDeviceId
  {
    string DeviceId { get; }
  }
}
