// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISensorDataThresholdTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2433151415, 59533, 18609, 188, 144, 97, 156, 123, 52, 147, 145)]
  [ExclusiveTo(typeof (SensorDataThresholdTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISensorDataThresholdTriggerDetails
  {
    string DeviceId { get; }

    SensorType SensorType { get; }
  }
}
