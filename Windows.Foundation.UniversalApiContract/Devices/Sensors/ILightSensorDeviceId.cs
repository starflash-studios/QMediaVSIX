// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensorDeviceId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2146322936, 2811, 20305, 135, 240, 108, 38, 55, 92, 233, 79)]
  [ExclusiveTo(typeof (LightSensor))]
  internal interface ILightSensorDeviceId
  {
    string DeviceId { get; }
  }
}
