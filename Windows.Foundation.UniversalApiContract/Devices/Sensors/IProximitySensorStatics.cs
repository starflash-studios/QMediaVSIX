// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IProximitySensorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (ProximitySensor))]
  [Guid(689464905, 25193, 20055, 165, 173, 130, 190, 128, 129, 51, 146)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProximitySensorStatics
  {
    string GetDeviceSelector();

    ProximitySensor FromId(string sensorId);
  }
}
