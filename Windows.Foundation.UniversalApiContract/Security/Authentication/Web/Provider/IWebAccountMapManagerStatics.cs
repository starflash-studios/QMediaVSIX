// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountMapManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(3908715631, 14875, 18596, 142, 144, 30, 89, 202, 111, 84, 219)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (WebAccountManager))]
  internal interface IWebAccountMapManagerStatics
  {
    [Overload("AddWebAccountWithScopeAndMapAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope,
      string perUserWebAccountId);

    [RemoteAsync]
    IAsyncAction SetPerAppToPerUserAccountAsync(
      WebAccount perAppAccount,
      string perUserWebAccountId);

    [RemoteAsync]
    IAsyncOperation<WebAccount> GetPerUserFromPerAppAccountAsync(
      WebAccount perAppAccount);

    [RemoteAsync]
    IAsyncAction ClearPerUserFromPerAppAccountAsync(WebAccount perAppAccount);
  }
}
