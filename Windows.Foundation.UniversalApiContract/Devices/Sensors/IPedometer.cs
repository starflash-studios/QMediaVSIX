// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2585657661, 15768, 17912, 137, 32, 142, 78, 202, 202, 95, 151)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Pedometer))]
  internal interface IPedometer
  {
    string DeviceId { get; }

    double PowerInMilliwatts { get; }

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Pedometer, PedometerReadingChangedEventArgs> ReadingChanged;
  }
}
