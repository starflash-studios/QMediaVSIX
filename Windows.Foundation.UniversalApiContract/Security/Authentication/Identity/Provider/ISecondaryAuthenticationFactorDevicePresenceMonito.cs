// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [Guid(2420742681, 32498, 17699, 149, 28, 164, 23, 162, 74, 207, 147)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorRegistration))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Deprecated("SecondaryAuthenticationFactorDevicePresenceMonitoringRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  internal interface ISecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatics
  {
    [RemoteAsync]
    [Overload("RegisterDevicePresenceMonitoringAsync")]
    [Deprecated("RegisterDevicePresenceMonitoringAsync is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> RegisterDevicePresenceMonitoringAsync(
      string deviceId,
      string deviceInstancePath,
      SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode);

    [RemoteAsync]
    [Overload("RegisterDevicePresenceMonitoringWithNewDeviceAsync")]
    [Deprecated("RegisterDevicePresenceMonitoringWithNewDeviceAsync is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> RegisterDevicePresenceMonitoringAsync(
      string deviceId,
      string deviceInstancePath,
      SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode,
      string deviceFriendlyName,
      string deviceModelNumber,
      IBuffer deviceConfigurationData);

    [Deprecated("UnregisterDevicePresenceMonitoringAsync is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncAction UnregisterDevicePresenceMonitoringAsync(string deviceId);

    [Deprecated("IsDevicePresenceMonitoringSupported is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
    bool IsDevicePresenceMonitoringSupported();
  }
}
