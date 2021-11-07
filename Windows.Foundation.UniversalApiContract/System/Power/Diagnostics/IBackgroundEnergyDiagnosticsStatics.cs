// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.Diagnostics.IBackgroundEnergyDiagnosticsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power.Diagnostics
{
  [Guid(3613800194, 54182, 18144, 143, 155, 80, 185, 91, 180, 249, 197)]
  [ExclusiveTo(typeof (BackgroundEnergyDiagnostics))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("Background Energy Diagnostics has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
  internal interface IBackgroundEnergyDiagnosticsStatics
  {
    double DeviceSpecificConversionFactor { [Deprecated("Background Energy Diagnostics has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("Background Energy Diagnostics has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
    ulong ComputeTotalEnergyUsage();

    [Deprecated("Background Energy Diagnostics has been deprecated. For more info, see MSDN.", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract")]
    void ResetTotalEnergyUsage();
  }
}
