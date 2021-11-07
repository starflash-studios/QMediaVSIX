// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IActivitySensorTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(748578322, 47562, 18039, 178, 99, 36, 50, 151, 247, 157, 58)]
  [ExclusiveTo(typeof (ActivitySensorTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IActivitySensorTriggerDetails
  {
    IVectorView<ActivitySensorReadingChangeReport> ReadReports();
  }
}
