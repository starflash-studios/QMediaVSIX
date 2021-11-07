// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometerReading2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(176573090, 5550, 19008, 190, 85, 219, 88, 215, 222, 115, 137)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (AccelerometerReading))]
  internal interface IAccelerometerReading2
  {
    IReference<TimeSpan> PerformanceCount { get; }

    IMapView<string, object> Properties { get; }
  }
}
