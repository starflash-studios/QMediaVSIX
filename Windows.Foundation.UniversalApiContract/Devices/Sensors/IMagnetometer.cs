// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Magnetometer))]
  [Guid(1213162094, 54217, 16657, 179, 246, 44, 241, 250, 164, 24, 213)]
  internal interface IMagnetometer
  {
    MagnetometerReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Magnetometer, MagnetometerReadingChangedEventArgs> ReadingChanged;
  }
}
