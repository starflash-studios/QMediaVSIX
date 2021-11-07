// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (InclinometerDataThreshold))]
  [Guid(4161423235, 31742, 21598, 187, 96, 160, 235, 196, 123, 210, 251)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IInclinometerDataThreshold
  {
    float PitchInDegrees { get; set; }

    float RollInDegrees { get; set; }

    float YawInDegrees { get; set; }
  }
}
