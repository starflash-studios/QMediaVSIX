// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.ICustomSensorReading2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (CustomSensorReading))]
  [Guid(574396650, 49011, 18834, 154, 72, 211, 200, 151, 89, 76, 203)]
  internal interface ICustomSensorReading2
  {
    IReference<TimeSpan> PerformanceCount { get; }
  }
}
