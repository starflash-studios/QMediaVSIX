// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundAccessStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>This enumeration specifies an app's ability to perform background activity.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BackgroundAccessStatus
  {
    /// <summary>The app cannot perform background activity in this state.</summary>
    Unspecified,
    /// <summary>The app can set up background tasks, and, if it has the capability, can use the real-time connectivity (RTC) broker. This means that the app can function while the device is in the connected standby state.</summary>
    /// <deprecated type="deprecate">Use AlwaysAllowed or AllowedSubjectToSystemPolicy instead of AllowedWithAlwaysOnRealTimeConnectivity. For more info, see MSDN.</deprecated>
    [Deprecated("Use AlwaysAllowed or AllowedSubjectToSystemPolicy instead of AllowedWithAlwaysOnRealTimeConnectivity. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] AllowedWithAlwaysOnRealTimeConnectivity,
    /// <summary>The app can set up background tasks, but it cannot use the real-time connectivity (RTC) broker. This means that the app might not function while the device is in connected standby. Note that apps that do not specify RTC in their manifest will always demonstrate this behavior.</summary>
    /// <deprecated type="deprecate">Use AlwaysAllowed or AllowedSubjectToSystemPolicy instead of AllowedMayUseActiveRealTimeConnectivity. For more info, see MSDN.</deprecated>
    [Deprecated("Use AlwaysAllowed or AllowedSubjectToSystemPolicy instead of AllowedMayUseActiveRealTimeConnectivity. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] AllowedMayUseActiveRealTimeConnectivity,
    /// <summary>This value is deprecated in Windows 10, version 1607.</summary>
    /// <deprecated type="deprecate">Use DeniedByUser or DeniedBySystemPolicy instead of Denied. For more info, see MSDN.</deprecated>
    [Deprecated("Use DeniedByUser or DeniedBySystemPolicy instead of Denied. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] Denied,
    /// <summary>On devices that have a battery, the user has given the app permission in the battery use settings to always allow background access. Introduced in Windows 10, version 1607.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] AlwaysAllowed,
    /// <summary>The user has selected Balanced or System Managed in the battery use settings. Introduced in Windows 10, version 1607.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] AllowedSubjectToSystemPolicy,
    /// <summary>On devices that have a battery, the user has selected Battery Optimized in the battery use settings and the system has chosen not to allow this application to run in the background based on system resources. Introduced in Windows 10, version 1607.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DeniedBySystemPolicy,
    /// <summary>On devices that have a battery, the user has disabled the app from running in the background in the battery use settings. Introduced in Windows 10, version 1607.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DeniedByUser,
  }
}
