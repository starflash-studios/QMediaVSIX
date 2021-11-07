// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationStage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Gets the stage of the companion device authentication.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthenticationStage is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("SecondaryAuthenticationFactorAuthenticationStage is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum SecondaryAuthenticationFactorAuthenticationStage
  {
    /// <summary>Authentication not started.</summary>
    NotStarted,
    /// <summary>Waiting for user confirmation.</summary>
    WaitingForUserConfirmation,
    /// <summary>Collecting credential.</summary>
    CollectingCredential,
    /// <summary>Suspending authentication.</summary>
    SuspendingAuthentication,
    /// <summary>Credential collected</summary>
    CredentialCollected,
    /// <summary>Credential authenticated.</summary>
    CredentialAuthenticated,
    /// <summary>Stopping authentication.</summary>
    StoppingAuthentication,
    /// <summary>Ready for lock.</summary>
    ReadyForLock,
    /// <summary>**Deprecated.** Checking for device presence.</summary>
    /// <deprecated type="deprecate">CheckingDevicePresence is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144), Deprecated("CheckingDevicePresence is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")] CheckingDevicePresence,
  }
}
