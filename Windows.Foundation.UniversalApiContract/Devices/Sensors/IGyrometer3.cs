// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometer3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Gyrometer))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1567590613, 36796, 17540, 145, 75, 82, 138, 223, 217, 71, 177)]
  internal interface IGyrometer3
  {
    uint ReportLatency { set; get; }

    uint MaxBatchSize { get; }
  }
}
