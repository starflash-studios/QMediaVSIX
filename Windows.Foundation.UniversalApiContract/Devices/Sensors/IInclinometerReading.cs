// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (InclinometerReading))]
  [Guid(2672095317, 46838, 18815, 177, 39, 26, 119, 94, 80, 20, 88)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInclinometerReading
  {
    DateTime Timestamp { get; }

    float PitchDegrees { get; }

    float RollDegrees { get; }

    float YawDegrees { get; }
  }
}
