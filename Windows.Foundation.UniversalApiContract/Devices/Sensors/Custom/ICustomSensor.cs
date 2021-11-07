// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.ICustomSensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2704734637, 16436, 19277, 153, 221, 83, 26, 172, 100, 156, 9)]
  [ExclusiveTo(typeof (CustomSensor))]
  internal interface ICustomSensor
  {
    CustomSensorReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    string DeviceId { get; }

    event TypedEventHandler<CustomSensor, CustomSensorReadingChangedEventArgs> ReadingChanged;
  }
}
