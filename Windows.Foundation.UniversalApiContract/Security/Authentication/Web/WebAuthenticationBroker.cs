// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.WebAuthenticationBroker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  /// <summary>Starts the authentication operation. You can call the methods of this class multiple times in a single application or across multiple applications at the same time. The Web authentication broker sample in the Samples gallery is an example of how to use the WebAuthenticationBroker class for single sign on (SSO) connections.</summary>
  [Static(typeof (IWebAuthenticationBrokerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAuthenticationBrokerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class WebAuthenticationBroker
  {
    [Overload("AuthenticateAndContinue")]
    [MethodImpl]
    public static extern void AuthenticateAndContinue(Uri requestUri);

    [Overload("AuthenticateWithCallbackUriAndContinue")]
    [MethodImpl]
    public static extern void AuthenticateAndContinue(Uri requestUri, Uri callbackUri);

    [Overload("AuthenticateWithCallbackUriContinuationDataAndOptionsAndContinue")]
    [MethodImpl]
    public static extern void AuthenticateAndContinue(
      Uri requestUri,
      Uri callbackUri,
      ValueSet continuationData,
      WebAuthenticationOptions options);

    [Overload("AuthenticateSilentlyAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAuthenticationResult> AuthenticateSilentlyAsync(
      Uri requestUri);

    [Overload("AuthenticateSilentlyWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAuthenticationResult> AuthenticateSilentlyAsync(
      Uri requestUri,
      WebAuthenticationOptions options);

    [RemoteAsync]
    [Overload("AuthenticateWithCallbackUriAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAuthenticationResult> AuthenticateAsync(
      WebAuthenticationOptions options,
      Uri requestUri,
      Uri callbackUri);

    [RemoteAsync]
    [Overload("AuthenticateWithoutCallbackUriAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAuthenticationResult> AuthenticateAsync(
      WebAuthenticationOptions options,
      Uri requestUri);

    /// <summary>Gets the current application callback URI.</summary>
    /// <returns>The URI of the current application.</returns>
    [MethodImpl]
    public static extern Uri GetCurrentApplicationCallbackUri();
  }
}
