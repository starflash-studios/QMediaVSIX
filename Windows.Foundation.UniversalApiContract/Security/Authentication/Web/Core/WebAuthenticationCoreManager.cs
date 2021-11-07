// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.System;

namespace Windows.Security.Authentication.Web.Core
{
  /// <summary>Contains core methods for obtaining tokens from web account providers.</summary>
  [Static(typeof (IWebAuthenticationCoreManagerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAuthenticationCoreManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IWebAuthenticationCoreManagerStatics4), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAuthenticationCoreManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class WebAuthenticationCoreManager
  {
    /// <summary>Enumerates all of the accounts that have been added by a user for a particular ID provider.</summary>
    /// <param name="provider">The ID provider that owns the accounts to be retrieved.</param>
    /// <returns>An asynchronous find operation. On successful completion, contains a FindAllAccountsResult object representing the result of the account retrieval.</returns>
    [Overload("FindAllAccountsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FindAllAccountsResult> FindAllAccountsAsync(
      WebAccountProvider provider);

    /// <summary>Enumerates all of the accounts that have been added by a user for a particular ID provider.</summary>
    /// <param name="provider">The ID provider that owns the accounts to be retrieved.</param>
    /// <param name="clientId">The ID of the client application.</param>
    /// <returns>An asynchronous find operation. On successful completion, contains a FindAllAccountsResult object representing the result of the account retrieval.</returns>
    [Overload("FindAllAccountsWithClientIdAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<FindAllAccountsResult> FindAllAccountsAsync(
      WebAccountProvider provider,
      string clientId);

    /// <summary>Asynchronously attempts to find a web account provider for device-wide authentication.</summary>
    /// <param name="webAccountProviderId">The Id of the web account provider to find.</param>
    /// <returns>An asynchronous find operation. On successful completion, contains a WebAccountProvider object representing the found web account provider.</returns>
    [RemoteAsync]
    [Overload("FindSystemAccountProviderAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccountProvider> FindSystemAccountProviderAsync(
      string webAccountProviderId);

    /// <summary>Asynchronously attempts to find a web account provider for device-wide authentication.</summary>
    /// <param name="webAccountProviderId">The Id of the web account provider to find.</param>
    /// <param name="authority">The authority of the web account provider to find.</param>
    /// <returns>An asynchronous find operation. On successful completion, contains a WebAccountProvider object representing the found web account provider.</returns>
    [RemoteAsync]
    [Overload("FindSystemAccountProviderWithAuthorityAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccountProvider> FindSystemAccountProviderAsync(
      string webAccountProviderId,
      string authority);

    /// <summary>Asynchronously attempts to find a web account provider for device-wide authentication.</summary>
    /// <param name="webAccountProviderId">The Id of the web account provider to find.</param>
    /// <param name="authority">The authority of the web account provider to find.</param>
    /// <param name="user">The user associated with the web account provider to find.</param>
    /// <returns>An asynchronous find operation. On successful completion, contains a WebAccountProvider object representing the found web account provider.</returns>
    [RemoteAsync]
    [Overload("FindSystemAccountProviderWithAuthorityForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccountProvider> FindSystemAccountProviderAsync(
      string webAccountProviderId,
      string authority,
      User user);

    [MethodImpl]
    public static extern WebAccountMonitor CreateWebAccountMonitor(
      IIterable<WebAccount> webAccounts);

    /// <summary>Asynchronously attempts to find a web account provider.</summary>
    /// <param name="webAccountProviderId">The Id of the web account provider to find.</param>
    /// <param name="authority">The authority of the web account provider to find.</param>
    /// <param name="user">The user associated with the web account provider to find.</param>
    /// <returns>An asynchronous find operation. On successful completion, contains a WebAccountProvider object representing the found web account provider.</returns>
    [Overload("FindAccountProviderWithAuthorityForUserAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId,
      string authority,
      User user);

    /// <summary>Asynchronously attempts to get a token without showing any UI. The user will never be prompted to enter their credentials.</summary>
    /// <param name="request">The web token request.</param>
    /// <returns>An asynchronous request operation. On successful completion, contains a WebTokenRequestResult object representing the result of the web token request.</returns>
    [RemoteAsync]
    [Overload("GetTokenSilentlyAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> GetTokenSilentlyAsync(
      WebTokenRequest request);

    /// <summary>Asynchronously attempts to get a token without showing any UI. The user will never be prompted to enter their credentials.</summary>
    /// <param name="request">The web token request.</param>
    /// <param name="webAccount">The web account.</param>
    /// <returns>An asynchronous request operation. On successful completion, contains a WebTokenRequestResult object representing the result of the web token request.</returns>
    [Overload("GetTokenSilentlyWithWebAccountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> GetTokenSilentlyAsync(
      WebTokenRequest request,
      WebAccount webAccount);

    /// <summary>Asynchronously requests a token from a web account provider. If necessary, the user is prompted to enter their credentials.</summary>
    /// <param name="request">The web token request.</param>
    /// <returns>An asynchronous request operation. On successful completion, contains a WebTokenRequestResult object representing the result of the web token request.</returns>
    [Overload("RequestTokenAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> RequestTokenAsync(
      WebTokenRequest request);

    /// <summary>Asynchronously requests a token from a web account provider. If necessary, the user is prompted to enter their credentials.</summary>
    /// <param name="request">The web token request.</param>
    /// <param name="webAccount">The web account for the request.</param>
    /// <returns>An asynchronous request operation. On successful completion, contains a WebTokenRequestResult object representing the result of the web token request.</returns>
    [RemoteAsync]
    [Overload("RequestTokenWithWebAccountAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> RequestTokenAsync(
      WebTokenRequest request,
      WebAccount webAccount);

    /// <summary>Asynchronously attempts to find a web account provider.</summary>
    /// <param name="provider">The web account provider for the web account.</param>
    /// <param name="webAccountId">The identifier of the web account.</param>
    /// <returns>An asynchronous find operation. On successful completion, contains a WebAccount object representing the found web account.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> FindAccountAsync(
      WebAccountProvider provider,
      string webAccountId);

    /// <summary>Asynchronously attempts to find a web account provider.</summary>
    /// <param name="webAccountProviderId">The Id of the web account provider to find.</param>
    /// <returns>An asynchronous find operation. On successful completion, contains a WebAccountProvider object representing the found web account provider.</returns>
    [Overload("FindAccountProviderAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId);

    /// <summary>Asynchronously attempts to find a web account provider.</summary>
    /// <param name="webAccountProviderId">The Id of the web account provider to find.</param>
    /// <param name="authority">The authority of the web account provider to find.</param>
    /// <returns>An asynchronous find operation. On successful completion, contains a WebAccountProvider object representing the found web account provider.</returns>
    [Overload("FindAccountProviderWithAuthorityAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId,
      string authority);
  }
}
