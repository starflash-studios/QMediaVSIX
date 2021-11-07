// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Contains properties that provide information about a companion device.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [Deprecated("SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SecondaryAuthenticationFactorInfo : 
    ISecondaryAuthenticationFactorInfo,
    ISecondaryAuthenticationFactorInfo2
  {
    /// <summary>Gets the device Id.</summary>
    /// <returns>The device Id.</returns>
    public extern string DeviceId { [Deprecated("SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the device friendly name.</summary>
    /// <returns>The device friendly name.</returns>
    public extern string DeviceFriendlyName { [Deprecated("SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the device model number.</summary>
    /// <returns>The device model number.</returns>
    public extern string DeviceModelNumber { [Deprecated("SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the device configuration data.</summary>
    /// <returns>The device configuration data.</returns>
    public extern IBuffer DeviceConfigurationData { [Deprecated("SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>**Deprecated.** Gets the presence monitoring mode of the companion device (the mechanism by which the main device checks the presence of the companion device).</summary>
    /// <returns>A SecondaryAuthenticationFactorDevicePresenceMonitoringMode value describing the monitoring mode.</returns>
    public extern SecondaryAuthenticationFactorDevicePresenceMonitoringMode PresenceMonitoringMode { [Deprecated("PresenceMonitoringMode is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>**Deprecated.** Manually assigns a presence state to a device.</summary>
    /// <deprecated type="deprecate">UpdateDevicePresenceAsync is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="presenceState">A SecondaryAuthenticationFactorDevicePresence value indicating the device's presence state.</param>
    /// <returns>An asynchronous action for the operation.</returns>
    [RemoteAsync]
    [Deprecated("UpdateDevicePresenceAsync is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncAction UpdateDevicePresenceAsync(
      SecondaryAuthenticationFactorDevicePresence presenceState);

    /// <summary>**Deprecated.** Checks whether the companion device supports some kind of user authentication function.</summary>
    /// <returns>**True** if the device supports authentication, otherwise **false**.</returns>
    public extern bool IsAuthenticationSupported { [Deprecated("IsAuthenticationSupported is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
