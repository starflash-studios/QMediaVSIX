// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3742909768, 10001, 19879, 128, 152, 75, 130, 32, 93, 60, 125)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Accelerometer))]
  internal interface IAccelerometer
  {
    AccelerometerReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs> ReadingChanged;

    event TypedEventHandler<Accelerometer, AccelerometerShakenEventArgs> Shaken;
  }
}
