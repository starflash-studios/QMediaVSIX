// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistrationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Represents the status of a companion device registration.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorRegistrationStatus is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Deprecated("SecondaryAuthenticationFactorRegistrationStatus is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public enum SecondaryAuthenticationFactorRegistrationStatus
  {
    /// <summary>Registration failed.</summary>
    Failed,
    /// <summary>Registration started.</summary>
    Started,
    /// <summary>Registration cancelled by the user.</summary>
    CanceledByUser,
    /// <summary>PIN setup is required before registration can occur.</summary>
    PinSetupRequired,
    /// <summary>Registration is disabled by policy.</summary>
    DisabledByPolicy,
  }
}
