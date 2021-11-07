// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IBarometerReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (BarometerReading))]
  [Guid(4122596070, 7670, 18970, 167, 173, 50, 29, 79, 93, 178, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBarometerReading
  {
    DateTime Timestamp { get; }

    double StationPressureInHectopascals { get; }
  }
}
