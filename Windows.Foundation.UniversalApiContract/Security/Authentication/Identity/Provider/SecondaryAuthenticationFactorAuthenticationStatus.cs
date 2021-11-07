// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Represents the status of an authentication operation using a companion device.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorAuthenticationStatus is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Deprecated("SecondaryAuthenticationFactorAuthenticationStatus is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public enum SecondaryAuthenticationFactorAuthenticationStatus
  {
    /// <summary>Authentication failed.</summary>
    Failed,
    /// <summary>Authentication started.</summary>
    Started,
    /// <summary>Unknown companion device.</summary>
    UnknownDevice,
    /// <summary>Companion device framework disabled by policy.</summary>
    DisabledByPolicy,
    /// <summary>Not a valid authentication stage.</summary>
    InvalidAuthenticationStage,
  }
}
