// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IBarometer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2470737320, 30911, 17711, 176, 23, 240, 32, 156, 230, 218, 180)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Barometer))]
  internal interface IBarometer
  {
    BarometerReading GetCurrentReading();

    string DeviceId { get; }

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Barometer, BarometerReadingChangedEventArgs> ReadingChanged;
  }
}
