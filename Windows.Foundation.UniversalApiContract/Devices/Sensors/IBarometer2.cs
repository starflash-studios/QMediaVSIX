// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IBarometer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Barometer))]
  [Guid(851231768, 16107, 19716, 149, 116, 118, 51, 168, 120, 31, 159)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IBarometer2
  {
    uint ReportLatency { set; get; }

    uint MaxBatchSize { get; }
  }
}
