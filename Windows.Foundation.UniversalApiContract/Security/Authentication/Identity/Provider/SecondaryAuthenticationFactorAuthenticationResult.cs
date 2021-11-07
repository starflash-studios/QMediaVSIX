// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Represents the results of authentication with a companion device.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthenticationResult is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [Deprecated("SecondaryAuthenticationFactorAuthenticationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public sealed class SecondaryAuthenticationFactorAuthenticationResult : 
    ISecondaryAuthenticationFactorAuthenticationResult
  {
    /// <summary>Gets the status of the authentication.</summary>
    /// <returns>The status of the authentication.</returns>
    public extern SecondaryAuthenticationFactorAuthenticationStatus Status { [Deprecated("SecondaryAuthenticationFactorAuthenticationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the authentication.</summary>
    /// <returns>The authentication.</returns>
    public extern SecondaryAuthenticationFactorAuthentication Authentication { [Deprecated("SecondaryAuthenticationFactorAuthenticationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
