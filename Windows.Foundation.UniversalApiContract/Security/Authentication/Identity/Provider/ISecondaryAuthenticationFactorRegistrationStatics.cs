// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorRegistrationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorRegistration))]
  [Guid(450826085, 58295, 16725, 153, 127, 183, 86, 239, 101, 190, 186)]
  internal interface ISecondaryAuthenticationFactorRegistrationStatics
  {
    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<SecondaryAuthenticationFactorRegistrationResult> RequestStartRegisteringDeviceAsync(
      string deviceId,
      SecondaryAuthenticationFactorDeviceCapabilities capabilities,
      string deviceFriendlyName,
      string deviceModelNumber,
      IBuffer deviceKey,
      IBuffer mutualAuthenticationKey);

    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<SecondaryAuthenticationFactorInfo>> FindAllRegisteredDeviceInfoAsync(
      SecondaryAuthenticationFactorDeviceFindScope queryType);

    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction UnregisterDeviceAsync(string deviceId);

    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorRegistration is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction UpdateDeviceConfigurationDataAsync(
      string deviceId,
      IBuffer deviceConfigurationData);
  }
}
