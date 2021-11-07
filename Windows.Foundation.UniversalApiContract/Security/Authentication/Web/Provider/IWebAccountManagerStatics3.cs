// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.System;

namespace Windows.Security.Authentication.Web.Provider
{
  [ExclusiveTo(typeof (WebAccountManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3712295846, 35407, 19106, 177, 94, 3, 245, 80, 175, 19, 89)]
  internal interface IWebAccountManagerStatics3
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<WebAccount>> FindAllProviderWebAccountsForUserAsync(
      User user);

    [RemoteAsync]
    [Overload("AddWebAccountForUserAsync")]
    IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props);

    [Overload("AddWebAccountWithScopeForUserAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope);

    [RemoteAsync]
    [Overload("AddWebAccountWithScopeAndMapForUserAsync")]
    IAsyncOperation<WebAccount> AddWebAccountForUserAsync(
      User user,
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope,
      string perUserWebAccountId);
  }
}
