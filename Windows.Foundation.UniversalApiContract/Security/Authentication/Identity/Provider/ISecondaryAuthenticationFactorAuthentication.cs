// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorAuthentication
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(34215653, 27173, 16547, 140, 0, 80, 160, 35, 246, 25, 209)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorAuthentication))]
  internal interface ISecondaryAuthenticationFactorAuthentication
  {
    IBuffer ServiceAuthenticationHmac { [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    IBuffer SessionNonce { [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    IBuffer DeviceNonce { [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    IBuffer DeviceConfigurationData { [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<SecondaryAuthenticationFactorFinishAuthenticationStatus> FinishAuthenticationAsync(
      IBuffer deviceHmac,
      IBuffer sessionHmac);

    [RemoteAsync]
    [Deprecated("SecondaryAuthenticationFactorAuthentication is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction AbortAuthenticationAsync(string errorLogMessage);
  }
}
