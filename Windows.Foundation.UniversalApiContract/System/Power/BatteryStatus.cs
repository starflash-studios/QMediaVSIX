// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.BatteryStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  /// <summary>Indicates the status of the battery.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BatteryStatus
  {
    /// <summary>The battery or battery controller is not present.</summary>
    NotPresent,
    /// <summary>The battery is discharging.</summary>
    Discharging,
    /// <summary>The battery is idle.</summary>
    Idle,
    /// <summary>The battery is charging.</summary>
    Charging,
  }
}
