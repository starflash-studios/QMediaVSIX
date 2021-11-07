// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.LicenseRefreshOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  /// <summary>Defines values that can be used with the LicenseManager.RefreshLicensesAsync method to specify which app licenses to refresh on the current device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum LicenseRefreshOption
  {
    /// <summary>Refreshes only the licenses for currently running apps.</summary>
    RunningLicenses,
    /// <summary>Refreshes all app licenses on the device.</summary>
    AllLicenses,
  }
}
