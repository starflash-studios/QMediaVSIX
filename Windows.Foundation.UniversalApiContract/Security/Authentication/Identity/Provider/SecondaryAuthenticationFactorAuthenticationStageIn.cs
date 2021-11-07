// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationStageInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Provides information about the stage of a companion device authentication.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthenticationStageInfo is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Deprecated("SecondaryAuthenticationFactorAuthenticationStageInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public sealed class SecondaryAuthenticationFactorAuthenticationStageInfo : 
    ISecondaryAuthenticationFactorAuthenticationStageInfo
  {
    /// <summary>Gets the stage of the authentication.</summary>
    /// <returns>The stage of the authentication.</returns>
    public extern SecondaryAuthenticationFactorAuthenticationStage Stage { [Deprecated("SecondaryAuthenticationFactorAuthenticationStageInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the authentication scenario (sign in versus credential prompt).</summary>
    /// <returns>The authentication scenario.</returns>
    public extern SecondaryAuthenticationFactorAuthenticationScenario Scenario { [Deprecated("SecondaryAuthenticationFactorAuthenticationStageInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the device Id.</summary>
    /// <returns>The device Id.</returns>
    public extern string DeviceId { [Deprecated("SecondaryAuthenticationFactorAuthenticationStageInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
