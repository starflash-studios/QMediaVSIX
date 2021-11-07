// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (LightSensor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4165732120, 3156, 18350, 146, 46, 120, 159, 87, 251, 3, 160)]
  internal interface ILightSensor
  {
    LightSensorReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<LightSensor, LightSensorReadingChangedEventArgs> ReadingChanged;
  }
}
