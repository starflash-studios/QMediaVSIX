// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAltimeter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3376880633, 10973, 18677, 159, 8, 61, 12, 118, 96, 217, 56)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (Altimeter))]
  internal interface IAltimeter2
  {
    uint ReportLatency { set; get; }

    uint MaxBatchSize { get; }
  }
}
