// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(1580549685, 53099, 19555, 171, 216, 16, 37, 43, 11, 246, 236)]
  [ExclusiveTo(typeof (OrientationSensor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IOrientationSensor
  {
    OrientationSensorReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs> ReadingChanged;
  }
}
