// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IProximitySensorStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (ProximitySensor))]
  [Guid(3421795246, 59850, 16943, 173, 103, 76, 61, 37, 223, 53, 12)]
  internal interface IProximitySensorStatics2
  {
    IVectorView<ProximitySensorReading> GetReadingsFromTriggerDetails(
      SensorDataThresholdTriggerDetails triggerDetails);
  }
}
