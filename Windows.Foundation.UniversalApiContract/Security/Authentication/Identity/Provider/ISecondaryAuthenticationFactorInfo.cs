// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorInfo))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Deprecated("SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [Guid(506177633, 34099, 20430, 131, 155, 236, 183, 36, 16, 172, 20)]
  internal interface ISecondaryAuthenticationFactorInfo
  {
    string DeviceId { [Deprecated("SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    string DeviceFriendlyName { [Deprecated("SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    string DeviceModelNumber { [Deprecated("SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    IBuffer DeviceConfigurationData { [Deprecated("SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
