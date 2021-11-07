// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Storage.Streams;
using Windows.System;
using Windows.Web.Http;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Provides methods for managing web accounts.</summary>
  [Static(typeof (IWebAccountManagerStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAccountManagerStatics4), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAccountScopeManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IWebAccountManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IWebAccountMapManagerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAccountManagerStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  public static class WebAccountManager
  {
    /// <summary>Clears the web account manager's token cache for all web accounts.</summary>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction InvalidateAppCacheForAllAccountsAsync();

    /// <summary>Clears the web account manager's token cache for a specific web account.</summary>
    /// <param name="webAccount">The web account for which tokens will be cleared.</param>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction InvalidateAppCacheForAccountAsync(
      WebAccount webAccount);

    /// <summary>Finds all provider web accounts associated with a given user asynchronously (for use with multi-user-aware apps).</summary>
    /// <param name="user">The user associated with the accounts.</param>
    /// <returns>When this method completes, it returns all provider web accounts for the user.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<WebAccount>> FindAllProviderWebAccountsForUserAsync(
      User user);

    [Overload("AddWebAccountForUserAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props);

    [RemoteAsync]
    [Overload("AddWebAccountWithScopeForUserAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope);

    [Overload("AddWebAccountWithScopeAndMapForUserAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope,
      string perUserWebAccountId);

    [Overload("AddWebAccountWithScopeAndMapAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope,
      string perUserWebAccountId);

    /// <summary>Creates a per-app to per-user account link.</summary>
    /// <param name="perAppAccount">The per-app web account.</param>
    /// <param name="perUserWebAccountId">The web account Id of the per-user web account to link.</param>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SetPerAppToPerUserAccountAsync(
      WebAccount perAppAccount,
      string perUserWebAccountId);

    /// <summary>Gets a per-user web account from a per-app web account.</summary>
    /// <param name="perAppAccount">The per-app web account.</param>
    /// <returns>When this method completes, it returns the per-user web account linked to the given per-app account.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> GetPerUserFromPerAppAccountAsync(
      WebAccount perAppAccount);

    /// <summary>Clears the link between per-user and per-app web accounts.</summary>
    /// <param name="perAppAccount">The per-app web account to clear.</param>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ClearPerUserFromPerAppAccountAsync(
      WebAccount perAppAccount);

    [RemoteAsync]
    [Overload("AddWebAccountWithScopeAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope);

    /// <summary>Sets the scope of a web account asynchronously.</summary>
    /// <param name="webAccount">The web account to set scope for.</param>
    /// <param name="scope">The scope to set.</param>
    /// <returns>This method does not return a value.</returns>
    [MethodImpl]
    public static extern IAsyncAction SetScopeAsync(
      WebAccount webAccount,
      WebAccountScope scope);

    /// <summary>Gets the scope of the web account.</summary>
    /// <param name="webAccount">The web account to get scope for.</param>
    /// <returns>The scope of the web account.</returns>
    [MethodImpl]
    public static extern WebAccountScope GetScope(WebAccount webAccount);

    /// <summary>Pulls cookies asynchronously. Use this to enable single sign-on in an app after a user has entered their credentials into a web browser.</summary>
    /// <param name="uriString">The Uri to pull cookies from.</param>
    /// <param name="callerPFN">The caller's package family name.</param>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction PullCookiesAsync(
      string uriString,
      string callerPFN);

    [MethodImpl]
    public static extern IAsyncAction UpdateWebAccountPropertiesAsync(
      WebAccount webAccount,
      string webAccountUserName,
      IMapView<string, string> additionalProperties);

    [RemoteAsync]
    [Overload("AddWebAccountAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props);

    /// <summary>Deletes a web account asynchronously.</summary>
    /// <param name="webAccount">The WebAccount to delete.</param>
    /// <returns>This method does not return a value.</returns>
    [MethodImpl]
    public static extern IAsyncAction DeleteWebAccountAsync(WebAccount webAccount);

    /// <summary>Finds all provider web accounts asynchronously.</summary>
    /// <returns>When this method completes, it returns all provider web accounts.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<WebAccount>> FindAllProviderWebAccountsAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction PushCookiesAsync(
      Uri uri,
      IVectorView<HttpCookie> cookies);

    /// <summary>Sets the view for a web account asynchronously.</summary>
    /// <param name="webAccount">The web account to set the view for.</param>
    /// <param name="view">The view to set.</param>
    /// <returns>This method does not return a value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SetViewAsync(
      WebAccount webAccount,
      WebAccountClientView view);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ClearViewAsync(
      WebAccount webAccount,
      Uri applicationCallbackUri);

    /// <summary>Gets the views for a web account asynchronously.</summary>
    /// <param name="webAccount">The web account to get views for.</param>
    /// <returns>When this method completes, it returns the views for the web account.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<WebAccountClientView>> GetViewsAsync(
      WebAccount webAccount);

    /// <summary>Sets the picture of a web account asynchronously.</summary>
    /// <param name="webAccount">The web account to set the picture for.</param>
    /// <param name="webAccountPicture">The picture to set.</param>
    /// <returns>This method does not return a value.</returns>
    [MethodImpl]
    public static extern IAsyncAction SetWebAccountPictureAsync(
      WebAccount webAccount,
      IRandomAccessStream webAccountPicture);

    /// <summary>Clears a web account picture asynchronously.</summary>
    /// <param name="webAccount">The web account to clear the picture from.</param>
    /// <returns>This method does not return a value.</returns>
    [MethodImpl]
    public static extern IAsyncAction ClearWebAccountPictureAsync(WebAccount webAccount);
  }
}
