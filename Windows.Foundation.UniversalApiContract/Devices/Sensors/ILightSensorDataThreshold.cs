// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensorDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (LightSensorDataThreshold))]
  [Guid(2975903697, 34703, 21650, 159, 44, 51, 220, 58, 229, 132, 163)]
  internal interface ILightSensorDataThreshold
  {
    float LuxPercentage { get; set; }

    float AbsoluteLux { get; set; }
  }
}
