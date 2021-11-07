// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>**Deprecated.** Contains values that describe the status of the registration of a companion device for presence monitoring.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus
  {
    /// <summary>Presence monitoring is not supported on this device.</summary>
    Unsupported,
    /// <summary>The device was registered for presence monitoring successfully.</summary>
    Succeeded,
    /// <summary>Presence monitoring registration was prevented by a policy setting on the device.</summary>
    DisabledByPolicy,
  }
}
