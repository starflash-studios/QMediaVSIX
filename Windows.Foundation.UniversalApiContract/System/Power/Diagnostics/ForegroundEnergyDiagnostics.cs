// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.Diagnostics.ForegroundEnergyDiagnostics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power.Diagnostics
{
  /// <summary>Provides debugging APIs for calculating your app's foreground energy usage in real time. We recommend using these APIs only for debugging.</summary>
  /// <deprecated type="deprecate">Foreground Energy Diagnostics has been deprecated. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("Foreground Energy Diagnostics has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IForegroundEnergyDiagnosticsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class ForegroundEnergyDiagnostics
  {
    /// <summary>Gets the device-specific conversion factor used to convert energy usage (mW) to a normalized percentage.</summary>
    /// <returns>The device-specific conversion factor used to convert energy usage (mW) to a normalized percentage</returns>
    public static extern double DeviceSpecificConversionFactor { [Deprecated("Background Energy Diagnostics has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Computes the total cumulative energy usage of the foreground app since the last reset, expressed as a percentage of normal.</summary>
    /// <deprecated type="deprecate">Background Energy Diagnostics has been deprecated. For more info, see MSDN.</deprecated>
    /// <returns>The total cumulative energy usage of the foreground app since the last reset, expressed as a percentage of normal.</returns>
    [Deprecated("Background Energy Diagnostics has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern ulong ComputeTotalEnergyUsage();

    /// <summary>Clears the value that represents the total cumulative energy usage of the foreground app since the last reset.</summary>
    /// <deprecated type="deprecate">Background Energy Diagnostics has been deprecated. For more info, see MSDN.</deprecated>
    [Deprecated("Background Energy Diagnostics has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void ResetTotalEnergyUsage();
  }
}
