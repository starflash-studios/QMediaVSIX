// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IBarometerReading2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (BarometerReading))]
  [Guid(2242004203, 37061, 18549, 137, 28, 56, 101, 180, 195, 87, 231)]
  internal interface IBarometerReading2
  {
    IReference<TimeSpan> PerformanceCount { get; }

    IMapView<string, object> Properties { get; }
  }
}
