// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebTokenRequestStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  /// <summary>Represents the status of a web token request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebTokenRequestStatus
  {
    /// <summary>The request was successful.</summary>
    Success,
    /// <summary>The request was cancelled by the user.</summary>
    UserCancel,
    /// <summary>The account associated with the request has switched. This status occurs when you attempt to use one web account, but the user indicates they wish to use a different web account instead.</summary>
    AccountSwitch,
    /// <summary>User interaction is required to complete the request. This option is only applicable to requests made with GetTokenSilentlyAsync. If this status is returned, repeat the request with RequestTokenAsync.</summary>
    UserInteractionRequired,
    /// <summary>The account provider was not available.</summary>
    AccountProviderNotAvailable,
    /// <summary>There was a provider error. For information on how to handle this error, consult the provider's documentation.</summary>
    ProviderError,
  }
}
