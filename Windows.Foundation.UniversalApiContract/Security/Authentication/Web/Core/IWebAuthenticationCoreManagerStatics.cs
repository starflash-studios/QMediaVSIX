// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebAuthenticationCoreManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1791655058, 42369, 17529, 156, 16, 117, 46, 255, 68, 253, 52)]
  [ExclusiveTo(typeof (WebAuthenticationCoreManager))]
  internal interface IWebAuthenticationCoreManagerStatics
  {
    [Overload("GetTokenSilentlyAsync")]
    [RemoteAsync]
    IAsyncOperation<WebTokenRequestResult> GetTokenSilentlyAsync(
      WebTokenRequest request);

    [Overload("GetTokenSilentlyWithWebAccountAsync")]
    [RemoteAsync]
    IAsyncOperation<WebTokenRequestResult> GetTokenSilentlyAsync(
      WebTokenRequest request,
      WebAccount webAccount);

    [RemoteAsync]
    [Overload("RequestTokenAsync")]
    IAsyncOperation<WebTokenRequestResult> RequestTokenAsync(
      WebTokenRequest request);

    [Overload("RequestTokenWithWebAccountAsync")]
    [RemoteAsync]
    IAsyncOperation<WebTokenRequestResult> RequestTokenAsync(
      WebTokenRequest request,
      WebAccount webAccount);

    [RemoteAsync]
    IAsyncOperation<WebAccount> FindAccountAsync(
      WebAccountProvider provider,
      string webAccountId);

    [RemoteAsync]
    [Overload("FindAccountProviderAsync")]
    IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId);

    [Overload("FindAccountProviderWithAuthorityAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccountProvider> FindAccountProviderAsync(
      string webAccountProviderId,
      string authority);
  }
}
