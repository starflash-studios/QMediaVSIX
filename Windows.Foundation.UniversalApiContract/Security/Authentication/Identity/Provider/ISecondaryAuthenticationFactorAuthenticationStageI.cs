// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorAuthenticationStageInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorAuthenticationStageInfo))]
  [Deprecated("SecondaryAuthenticationFactorAuthenticationStageInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [Guid(1459536523, 59562, 19471, 142, 76, 165, 89, 231, 58, 221, 136)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ISecondaryAuthenticationFactorAuthenticationStageInfo
  {
    SecondaryAuthenticationFactorAuthenticationStage Stage { [Deprecated("SecondaryAuthenticationFactorAuthenticationStageInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    SecondaryAuthenticationFactorAuthenticationScenario Scenario { [Deprecated("SecondaryAuthenticationFactorAuthenticationStageInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    string DeviceId { [Deprecated("SecondaryAuthenticationFactorAuthenticationStageInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
