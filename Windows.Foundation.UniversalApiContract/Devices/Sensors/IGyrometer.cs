// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Gyrometer))]
  [Guid(4256803268, 33969, 19618, 151, 99, 155, 88, 149, 6, 199, 12)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGyrometer
  {
    GyrometerReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Gyrometer, GyrometerReadingChangedEventArgs> ReadingChanged;
  }
}
