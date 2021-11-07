// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistrationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Provides information about the result of a companion device registration.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorRegistrationResult is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Deprecated("SecondaryAuthenticationFactorRegistrationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public sealed class SecondaryAuthenticationFactorRegistrationResult : 
    ISecondaryAuthenticationFactorRegistrationResult
  {
    /// <summary>Gets the status of the registration attempt.</summary>
    /// <returns>A SecondaryAuthenticationFactorRegistrationStatus value describing the result of the registration attempt.</returns>
    public extern SecondaryAuthenticationFactorRegistrationStatus Status { [Deprecated("SecondaryAuthenticationFactorRegistrationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the registration class instance for the intended companion device.</summary>
    /// <returns>A SecondaryAuthenticationFactorRegistration instance handling the registration for a companion device.</returns>
    public extern SecondaryAuthenticationFactorRegistration Registration { [Deprecated("SecondaryAuthenticationFactorRegistrationResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
