// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.WebAuthenticationCoreManagerHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;
using Windows.UI.Xaml;

namespace Windows.ApplicationModel.Store.Preview
{
  /// <summary>Provides the ability to host a custom UI to request an authentication token.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IWebAuthenticationCoreManagerHelper), 262144, "Windows.Foundation.UniversalApiContract")]
  public static class WebAuthenticationCoreManagerHelper
  {
    /// <summary>Requests an authentication token using the specified custom UI.</summary>
    /// <param name="request">An object that represents the request to an online identity provider for an authentication token.</param>
    /// <param name="uiElement">The custom UI that is shown to the user to retrieve information needed for the authentication token (such as a user ID or password).</param>
    /// <returns>An asynchronous operation that, on successful completion, returns a WebTokenRequestResult object that represents the results of the web token request.</returns>
    [RemoteAsync]
    [Overload("RequestTokenWithUIElementHostingAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> RequestTokenWithUIElementHostingAsync(
      WebTokenRequest request,
      UIElement uiElement);

    /// <summary>Requests an authentication token for the specified account using the specified custom UI.</summary>
    /// <param name="request">An object that represents the request to an online identity provider for an authentication token.</param>
    /// <param name="webAccount">An object that identifies the account for which to request the authentication token.</param>
    /// <param name="uiElement">The custom UI that is shown to the user to retrieve information needed for the authentication token (such as a user ID or password).</param>
    /// <returns>An asynchronous operation that, on successful completion, returns a WebTokenRequestResult object that represents the results of the web token request.</returns>
    [RemoteAsync]
    [Overload("RequestTokenWithUIElementHostingAndWebAccountAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> RequestTokenWithUIElementHostingAsync(
      WebTokenRequest request,
      WebAccount webAccount,
      UIElement uiElement);
  }
}
