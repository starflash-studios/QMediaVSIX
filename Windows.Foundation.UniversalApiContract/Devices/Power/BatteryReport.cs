// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Power.BatteryReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System.Power;

namespace Windows.Devices.Power
{
  /// <summary>Provides properties that indicate the charge, capacity, and status of the battery. For more info, see [Get battery information](https://docs.microsoft.com/previous-versions/windows/apps/dn895210(v=win.10)).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class BatteryReport : IBatteryReport
  {
    /// <summary>Gets the rate that the battery is charging.</summary>
    /// <returns>The rate that the battery is charging in milliwatts (mW). This value is negative when the battery is discharging.</returns>
    public extern IReference<int> ChargeRateInMilliwatts { [MethodImpl] get; }

    /// <summary>Gets the estimated energy capacity of a new battery of this type.</summary>
    /// <returns>The estimated energy capacity of a new battery of this type, in milliwatt-hours (mWh).</returns>
    public extern IReference<int> DesignCapacityInMilliwattHours { [MethodImpl] get; }

    /// <summary>Gets the fully-charged energy capacity of the battery.</summary>
    /// <returns>The fully-charged energy capacity of the battery, in milliwatt-hours (mWh).</returns>
    public extern IReference<int> FullChargeCapacityInMilliwattHours { [MethodImpl] get; }

    /// <summary>Gets the remaining power capacity of the battery.</summary>
    /// <returns>The remaining power capacity of the battery, in milliwatt-hours.</returns>
    public extern IReference<int> RemainingCapacityInMilliwattHours { [MethodImpl] get; }

    /// <summary>Gets a BatteryStatus enumeration that indicates the status of the battery.</summary>
    /// <returns>A BatteryStatus enumeration that indicates the status of the battery.</returns>
    public extern BatteryStatus Status { [MethodImpl] get; }
  }
}
