// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.PedometerStepKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>The type of step taken according to the pedometer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PedometerStepKind
  {
    /// <summary>An unknown step type.</summary>
    Unknown,
    /// <summary>A walking step.</summary>
    Walking,
    /// <summary>A running step.</summary>
    Running,
  }
}
