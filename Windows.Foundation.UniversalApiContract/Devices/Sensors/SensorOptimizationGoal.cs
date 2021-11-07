// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.SensorOptimizationGoal
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Indicates whether power or precision should be optimized for sensors.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum SensorOptimizationGoal
  {
    /// <summary>This sensor will prioritize precision over power efficiency.</summary>
    Precision,
    /// <summary>This sensor will prioritize power efficiency over precision depending on the hardware available.</summary>
    PowerEfficiency,
  }
}
