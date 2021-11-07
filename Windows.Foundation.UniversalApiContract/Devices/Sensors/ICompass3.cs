// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompass3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Compass))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2753855515, 50666, 19781, 160, 236, 75, 121, 31, 4, 26, 137)]
  internal interface ICompass3
  {
    uint ReportLatency { set; get; }

    uint MaxBatchSize { get; }
  }
}
