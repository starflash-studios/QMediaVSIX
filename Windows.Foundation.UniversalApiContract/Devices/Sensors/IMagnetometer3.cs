// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometer3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Magnetometer))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3197361020, 42533, 18671, 172, 247, 250, 193, 4, 131, 38, 113)]
  internal interface IMagnetometer3
  {
    uint ReportLatency { set; get; }

    uint MaxBatchSize { get; }
  }
}
