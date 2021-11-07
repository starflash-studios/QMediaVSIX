// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IActivitySensorReadingChangeReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(1329342741, 55611, 18365, 150, 10, 242, 15, 178, 243, 34, 185)]
  [ExclusiveTo(typeof (ActivitySensorReadingChangeReport))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IActivitySensorReadingChangeReport
  {
    ActivitySensorReading Reading { get; }
  }
}
