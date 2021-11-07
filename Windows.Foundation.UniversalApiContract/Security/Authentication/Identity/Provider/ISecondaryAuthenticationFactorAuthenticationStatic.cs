// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorAuthenticationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorAuthentication))]
  [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [Guid(1062741590, 10488, 19983, 174, 140, 88, 152, 185, 174, 36, 105)]
  internal interface ISecondaryAuthenticationFactorAuthenticationStatics
  {
    [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction ShowNotificationMessageAsync(
      string deviceName,
      SecondaryAuthenticationFactorAuthenticationMessage message);

    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<SecondaryAuthenticationFactorAuthenticationResult> StartAuthenticationAsync(
      string deviceId,
      IBuffer serviceAuthenticationNonce);

    event EventHandler<SecondaryAuthenticationFactorAuthenticationStageChangedEventArgs> AuthenticationStageChanged;

    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<SecondaryAuthenticationFactorAuthenticationStageInfo> GetAuthenticationStageInfoAsync();
  }
}
