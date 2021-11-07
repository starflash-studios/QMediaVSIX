// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompassDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3512423091, 54173, 24264, 178, 228, 241, 147, 230, 171, 52, 237)]
  [ExclusiveTo(typeof (CompassDataThreshold))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface ICompassDataThreshold
  {
    double Degrees { get; set; }
  }
}
