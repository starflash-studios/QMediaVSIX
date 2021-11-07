// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometer4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Magnetometer))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(3752950017, 15887, 20623, 178, 75, 242, 187, 117, 1, 95, 64)]
  internal interface IMagnetometer4
  {
    MagnetometerDataThreshold ReportThreshold { get; }
  }
}
