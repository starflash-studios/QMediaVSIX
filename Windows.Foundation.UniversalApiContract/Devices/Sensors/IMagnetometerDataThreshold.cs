// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometerDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (MagnetometerDataThreshold))]
  [Guid(3514288897, 36963, 24485, 181, 150, 180, 69, 233, 220, 52, 1)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IMagnetometerDataThreshold
  {
    float XAxisMicroteslas { get; set; }

    float YAxisMicroteslas { get; set; }

    float ZAxisMicroteslas { get; set; }
  }
}
