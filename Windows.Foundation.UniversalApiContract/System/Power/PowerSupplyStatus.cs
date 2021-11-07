// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.PowerSupplyStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  /// <summary>Represents the device's power supply status.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PowerSupplyStatus
  {
    /// <summary>The device has no power supply.</summary>
    NotPresent,
    /// <summary>The device has an inadequate power supply.</summary>
    Inadequate,
    /// <summary>The device has an adequate power supply.</summary>
    Adequate,
  }
}
