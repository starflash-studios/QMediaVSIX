// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorFinishAuthenticationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Represents the status of finishing authentication with a companion device.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorFinishAuthenticationStatus is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("SecondaryAuthenticationFactorFinishAuthenticationStatus is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum SecondaryAuthenticationFactorFinishAuthenticationStatus
  {
    /// <summary>The operation failed.</summary>
    Failed,
    /// <summary>The operation completed.</summary>
    Completed,
    /// <summary>The nonce expired.</summary>
    NonceExpired,
  }
}
