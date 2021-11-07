// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorAuthenticationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorAuthenticationResult))]
  [Guid(2629523847, 61293, 19394, 191, 73, 70, 23, 81, 90, 15, 154)]
  [Deprecated("SecondaryAuthenticationFactorAuthenticationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  internal interface ISecondaryAuthenticationFactorAuthenticationResult
  {
    SecondaryAuthenticationFactorAuthenticationStatus Status { [Deprecated("SecondaryAuthenticationFactorAuthenticationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    SecondaryAuthenticationFactorAuthentication Authentication { [Deprecated("SecondaryAuthenticationFactorAuthenticationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
