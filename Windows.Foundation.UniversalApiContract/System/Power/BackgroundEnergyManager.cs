// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.BackgroundEnergyManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  /// <summary>Provides information about your app's background energy usage.</summary>
  /// <deprecated type="deprecate">Background Energy Manager has been deprecated. For more info, see MSDN.</deprecated>
  [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBackgroundEnergyManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class BackgroundEnergyManager
  {
    /// <summary>Gets the low usage level, expressed as a percentage of normal energy consumption.</summary>
    /// <returns>The low usage level, expressed as a percentage of normal energy consumption.</returns>
    public static extern uint LowUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the near-maximum acceptable usage level, expressed as a percentage of normal energy usage.</summary>
    /// <returns>The near-maximum acceptable usage level, expressed as a percentage of normal energy usage.</returns>
    public static extern uint NearMaxAcceptableUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the maximum acceptable usage level, expressed as a percentage of normal energy consumption.</summary>
    /// <returns>The maximum acceptable usage level, expressed as a percentage of normal energy consumption.</returns>
    public static extern uint MaxAcceptableUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the excessive usage level, expressed as a percentage of normal energy usage.</summary>
    /// <returns>The excessive usage level, expressed as a percentage of normal energy usage.</returns>
    public static extern uint ExcessiveUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the near-termination usage level, expressed as a percentage of normal energy usage.</summary>
    /// <returns>The near-termination usage level, expressed as a percentage of normal energy usage.</returns>
    public static extern uint NearTerminationUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the termination usage level, expressed as a percentage of normal energy usage.</summary>
    /// <returns>The termination usage level, expressed as a percentage of normal energy usage.</returns>
    public static extern uint TerminationUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the energy usage of the app's background task for the current 30 minute period, expressed as a percentage of normal.</summary>
    /// <returns>The energy usage of the app's background task for the current 30 minute period, expressed as a percentage of normal.</returns>
    public static extern uint RecentEnergyUsage { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the nearest predefined energy level of the app's background task for the current 30 minute period, equal to LowUsageLevel, NearMaxAcceptableUsageLevel, MaxAcceptableUsageLevel, ExcessiveUsageLevel, NearTerminationUsageLevel, or TerminationUsageLevel.</summary>
    /// <returns>The nearest predefined energy level of the app's background task for the current 30 minute period.</returns>
    public static extern uint RecentEnergyUsageLevel { [Deprecated("Background Energy Manager has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Occurs when the background task's energy usage has increased significantly.</summary>
    public static extern event EventHandler<object> RecentEnergyUsageIncreased;

    /// <summary>Occurs when the background task's energy usage has decreased to a low usage level.</summary>
    public static extern event EventHandler<object> RecentEnergyUsageReturnedToLow;
  }
}
