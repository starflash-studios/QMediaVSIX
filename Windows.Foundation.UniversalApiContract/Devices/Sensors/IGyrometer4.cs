// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometer4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Gyrometer))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(103327244, 19531, 20630, 148, 230, 195, 86, 223, 104, 190, 247)]
  internal interface IGyrometer4
  {
    GyrometerDataThreshold ReportThreshold { get; }
  }
}
