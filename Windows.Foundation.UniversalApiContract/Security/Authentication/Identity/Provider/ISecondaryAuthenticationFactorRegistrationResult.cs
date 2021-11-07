// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorRegistrationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2768123376, 44515, 18817, 175, 107, 236, 25, 89, 33, 104, 42)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorRegistrationResult))]
  [Deprecated("SecondaryAuthenticationFactorRegistrationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  internal interface ISecondaryAuthenticationFactorRegistrationResult
  {
    SecondaryAuthenticationFactorRegistrationStatus Status { [Deprecated("SecondaryAuthenticationFactorRegistrationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    SecondaryAuthenticationFactorRegistration Registration { [Deprecated("SecondaryAuthenticationFactorRegistrationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
