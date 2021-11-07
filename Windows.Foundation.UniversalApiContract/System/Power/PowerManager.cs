// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.PowerManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  /// <summary>Provides access to information about a device's battery and power supply status.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPowerManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class PowerManager
  {
    /// <summary>Gets the devices's battery saver status, indicating when to save energy.</summary>
    /// <returns>The status of battery saver.</returns>
    public static extern EnergySaverStatus EnergySaverStatus { [MethodImpl] get; }

    /// <summary>Occurs when EnergySaverStatus changes.</summary>
    public static extern event EventHandler<object> EnergySaverStatusChanged;

    /// <summary>Gets the device's battery status.</summary>
    /// <returns>The device's battery status.</returns>
    public static extern BatteryStatus BatteryStatus { [MethodImpl] get; }

    /// <summary>Occurs when BatteryStatus changes.</summary>
    public static extern event EventHandler<object> BatteryStatusChanged;

    /// <summary>Gets the device's power supply status.</summary>
    /// <returns>The device's power supply status.</returns>
    public static extern PowerSupplyStatus PowerSupplyStatus { [MethodImpl] get; }

    /// <summary>Occurs when the PowerSupplyStatus changes.</summary>
    public static extern event EventHandler<object> PowerSupplyStatusChanged;

    /// <summary>Gets the total percentage of charge remaining from all batteries connected to the device.</summary>
    /// <returns>The total percentage of charge remaining from all batteries connected to the device.</returns>
    public static extern int RemainingChargePercent { [MethodImpl] get; }

    /// <summary>Occurs when RemainingChargePercent changes.</summary>
    public static extern event EventHandler<object> RemainingChargePercentChanged;

    /// <summary>Gets the total runtime remaining from all batteries connected to the device.</summary>
    /// <returns>The total runtime remaining from all batteries connected to the device.</returns>
    public static extern TimeSpan RemainingDischargeTime { [MethodImpl] get; }

    /// <summary>Occurs when RemainingDischargeTime changes.</summary>
    public static extern event EventHandler<object> RemainingDischargeTimeChanged;
  }
}
