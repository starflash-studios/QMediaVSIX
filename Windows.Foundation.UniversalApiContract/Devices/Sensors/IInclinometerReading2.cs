// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerReading2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (InclinometerReading))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1326860161, 59659, 18008, 137, 21, 1, 3, 224, 138, 128, 90)]
  internal interface IInclinometerReading2
  {
    IReference<TimeSpan> PerformanceCount { get; }

    IMapView<string, object> Properties { get; }
  }
}
