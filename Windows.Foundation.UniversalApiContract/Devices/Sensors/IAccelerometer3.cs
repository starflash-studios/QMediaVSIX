// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometer3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Accelerometer))]
  [Guid(2279604778, 60800, 18923, 191, 138, 164, 234, 49, 229, 205, 132)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAccelerometer3
  {
    uint ReportLatency { set; get; }

    uint MaxBatchSize { get; }
  }
}
