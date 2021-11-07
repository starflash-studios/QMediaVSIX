// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.ICustomSensor2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (CustomSensor))]
  [Guid(551235857, 60504, 19871, 191, 189, 231, 120, 37, 8, 133, 16)]
  internal interface ICustomSensor2
  {
    uint ReportLatency { set; get; }

    uint MaxBatchSize { get; }
  }
}
