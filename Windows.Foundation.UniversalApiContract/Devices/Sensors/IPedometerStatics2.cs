// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (Pedometer))]
  [Guid(2046150331, 52750, 16691, 180, 126, 134, 39, 234, 114, 246, 119)]
  internal interface IPedometerStatics2
  {
    IVectorView<PedometerReading> GetReadingsFromTriggerDetails(
      SensorDataThresholdTriggerDetails triggerDetails);
  }
}
