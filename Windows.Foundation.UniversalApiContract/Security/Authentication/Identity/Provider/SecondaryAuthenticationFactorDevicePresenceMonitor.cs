// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresenceMonitoringMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>**Deprecated.** Contains values that describe the type of connection that the system uses to monitor the presence of a companion device (such as a wearable device). </summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorDevicePresenceMonitoringMode is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("SecondaryAuthenticationFactorDevicePresenceMonitoringMode is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum SecondaryAuthenticationFactorDevicePresenceMonitoringMode
  {
    /// <summary>Device presence monitoring is not supported.</summary>
    Unsupported,
    /// <summary>The system uses an app that corresponds to the companion device to monitor its presence.</summary>
    AppManaged,
    /// <summary>The system uses classing Bluetooth protocol to monitor the presence of the companion device.</summary>
    SystemManaged,
  }
}
