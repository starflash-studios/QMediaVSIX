// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Contains methods for registering companion devices.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISecondaryAuthenticationFactorRegistrationStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class SecondaryAuthenticationFactorRegistration : 
    ISecondaryAuthenticationFactorRegistration
  {
    /// <summary>Finishes registering a companion device.</summary>
    /// <deprecated type="deprecate">SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="deviceConfigurationData">Configuration data for the device. This data is capped at 4KB.</param>
    /// <returns>This method does not return a value.</returns>
    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FinishRegisteringDeviceAsync(
      IBuffer deviceConfigurationData);

    /// <summary>Aborts registering the companion device.</summary>
    /// <deprecated type="deprecate">SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="errorLogMessage">An error message to log.</param>
    /// <returns>This method does not return a value.</returns>
    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AbortRegisteringDeviceAsync(string errorLogMessage);

    /// <summary>**Deprecated.** Registers a companion device for presence monitoring by the main device.</summary>
    /// <deprecated type="deprecate">RegisterDevicePresenceMonitoringAsync is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="deviceId">The unique identifier for the companion device.</param>
    /// <param name="deviceInstancePath">The device instance path string.</param>
    /// <param name="monitoringMode">A SecondaryAuthenticationFactorDevicePresenceMonitoringMode value describing the monitoring mode type that will be used.</param>
    /// <returns>An asynchronous operation with the status of the registration.</returns>
    [RemoteAsync]
    [Deprecated("RegisterDevicePresenceMonitoringAsync is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
    [Overload("RegisterDevicePresenceMonitoringAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> RegisterDevicePresenceMonitoringAsync(
      string deviceId,
      string deviceInstancePath,
      SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode);

    /// <summary>**Deprecated.** Registers a companion device for presence monitoring by the main device. Includes additional information about the companion device.</summary>
    /// <deprecated type="deprecate">RegisterDevicePresenceMonitoringWithNewDeviceAsync is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="deviceId">The unique identifier for the companion device.</param>
    /// <param name="deviceInstancePath">The device instance path string.</param>
    /// <param name="monitoringMode">A SecondaryAuthenticationFactorDevicePresenceMonitoringMode value describing the monitoring mode type that will be used.</param>
    /// <param name="deviceFriendlyName">The friendly name of the device.</param>
    /// <param name="deviceModelNumber">The model number of the device.</param>
    /// <param name="deviceConfigurationData">The device configuration data. This data is capped at 4KB.</param>
    /// <returns>An asynchronous operation with the status of the registration.</returns>
    [Deprecated("RegisterDevicePresenceMonitoringWithNewDeviceAsync is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [Overload("RegisterDevicePresenceMonitoringWithNewDeviceAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> RegisterDevicePresenceMonitoringAsync(
      string deviceId,
      string deviceInstancePath,
      SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode,
      string deviceFriendlyName,
      string deviceModelNumber,
      IBuffer deviceConfigurationData);

    /// <summary>**Deprecated.** Unregisters a companion device from presence monitoring.</summary>
    /// <deprecated type="deprecate">UnregisterDevicePresenceMonitoringAsync is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="deviceId">The unique identifier for the device.</param>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [Deprecated("UnregisterDevicePresenceMonitoringAsync is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncAction UnregisterDevicePresenceMonitoringAsync(
      string deviceId);

    /// <summary>**Deprecated.** Checks whether the main device is able to monitor for the presence of companion devices.</summary>
    /// <deprecated type="deprecate">IsDevicePresenceMonitoringSupported is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <returns>A value of **true** if the device can monitor companion devices, otherwise **false**.</returns>
    [Deprecated("IsDevicePresenceMonitoringSupported is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern bool IsDevicePresenceMonitoringSupported();

    /// <summary>Starts registering a companion device.</summary>
    /// <deprecated type="deprecate">SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="deviceId">The Id of the device.</param>
    /// <param name="capabilities">The device capabilities.</param>
    /// <param name="deviceFriendlyName">The device friendly name.</param>
    /// <param name="deviceModelNumber">The device model number.</param>
    /// <param name="deviceKey">The device key.</param>
    /// <param name="mutualAuthenticationKey">The mutual authentication key.</param>
    /// <returns>An asynchronous operation with a registration result instance.</returns>
    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<SecondaryAuthenticationFactorRegistrationResult> RequestStartRegisteringDeviceAsync(
      string deviceId,
      SecondaryAuthenticationFactorDeviceCapabilities capabilities,
      string deviceFriendlyName,
      string deviceModelNumber,
      IBuffer deviceKey,
      IBuffer mutualAuthenticationKey);

    /// <summary>Returns info on found registered devices.</summary>
    /// <deprecated type="deprecate">SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="queryType">The scope of devices to find.</param>
    /// <returns>When this method completes, it returns device info for the found registered devices.</returns>
    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<SecondaryAuthenticationFactorInfo>> FindAllRegisteredDeviceInfoAsync(
      SecondaryAuthenticationFactorDeviceFindScope queryType);

    /// <summary>Unregisters a companion device.</summary>
    /// <deprecated type="deprecate">SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="deviceId">The Id of the device to unregister.</param>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncAction UnregisterDeviceAsync(string deviceId);

    /// <summary>Updates the configuration data of a companion device.</summary>
    /// <deprecated type="deprecate">SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="deviceId">The Id of the device to update.</param>
    /// <param name="deviceConfigurationData">The updated configuration data. This data is capped at 4KB.</param>
    /// <returns>This method does not return a value.</returns>
    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction UpdateDeviceConfigurationDataAsync(
      string deviceId,
      IBuffer deviceConfigurationData);
  }
}
