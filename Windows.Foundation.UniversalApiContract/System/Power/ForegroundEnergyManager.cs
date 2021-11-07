// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.ForegroundEnergyManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  /// <summary>Provides information about your app's foreground energy usage.</summary>
  /// <deprecated type="deprecate">Foreground Energy Manager has been deprecated. For more info, see MSDN.</deprecated>
  [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IForegroundEnergyManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class ForegroundEnergyManager
  {
    /// <summary>Gets the low usage level, expressed as a percentage of normal energy consumption.</summary>
    /// <returns>The low usage level, expressed as a percentage of normal energy consumption.</returns>
    public static extern uint LowUsageLevel { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the near-maximum acceptable usage level, expressed as a percentage of normal energy usage.</summary>
    /// <returns>The near-maximum acceptable usage level, expressed as a percentage of normal energy usage.</returns>
    public static extern uint NearMaxAcceptableUsageLevel { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the maximum acceptable usage level, expressed as a percentage of normal energy consumption.</summary>
    /// <returns>The maximum acceptable usage level, expressed as a percentage of normal energy consumption.</returns>
    public static extern uint MaxAcceptableUsageLevel { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the excessive usage level, expressed as a percentage of normal energy usage.</summary>
    /// <returns>The excessive usage level, expressed as a percentage of normal energy usage.</returns>
    public static extern uint ExcessiveUsageLevel { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the nearest predefined energy level of the foreground app for the current 30 minute period, equal to LowUsageLevel, NearMaxAcceptableUsageLevel, MaxAcceptableUsageLevel, or ExcessiveUsageLevel.</summary>
    /// <returns>The nearest predefined energy level of the foreground app for the current 30 minute period.</returns>
    public static extern uint RecentEnergyUsage { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the nearest predefined energy level of the foreground app for the current 30 minute period, equal to LowUsageLevel, NearMaxAcceptableUsageLevel, MaxAcceptableUsageLevel, or ExcessiveUsageLevel.</summary>
    /// <returns>The nearest predefined energy level of the foreground app for the current 30 minute period.</returns>
    public static extern uint RecentEnergyUsageLevel { [Deprecated("Foreground Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Occurs when the app's foreground energy usage has increased significantly.</summary>
    public static extern event EventHandler<object> RecentEnergyUsageIncreased;

    /// <summary>Occurs when the app's energy usage has decreased to a low usage level.</summary>
    public static extern event EventHandler<object> RecentEnergyUsageReturnedToLow;
  }
}
