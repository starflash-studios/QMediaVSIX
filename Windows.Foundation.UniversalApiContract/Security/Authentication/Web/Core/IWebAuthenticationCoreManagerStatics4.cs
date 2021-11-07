// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebAuthenticationCoreManagerStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.System;

namespace Windows.Security.Authentication.Web.Core
{
  [Guid(1424372734, 38624, 16872, 152, 50, 18, 152, 137, 124, 42, 175)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (WebAuthenticationCoreManager))]
  internal interface IWebAuthenticationCoreManagerStatics4 : IWebAuthenticationCoreManagerStatics
  {
    [RemoteAsync]
    [Overload("FindAllAccountsAsync")]
    IAsyncOperation<FindAllAccountsResult> FindAllAccountsAsync(
      WebAccountProvider provider);

    [RemoteAsync]
    [Overload("FindAllAccountsWithClientIdAsync")]
    IAsyncOperation<FindAllAccountsResult> FindAllAccountsAsync(
      WebAccountProvider provider,
      string clientId);

    [Overload("FindSystemAccountProviderAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccountProvider> FindSystemAccountProviderAsync(
      string webAccountProviderId);

    [Overload("FindSystemAccountProviderWithAuthorityAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccountProvider> FindSystemAccountProviderAsync(
      string webAccountProviderId,
      string authority);

    [Overload("FindSystemAccountProviderWithAuthorityForUserAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccountProvider> FindSystemAccountProviderAsync(
      string webAccountProviderId,
      string authority,
      User user);
  }
}
