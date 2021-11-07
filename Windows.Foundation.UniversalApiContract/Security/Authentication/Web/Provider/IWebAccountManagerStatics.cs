// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Storage.Streams;
using Windows.Web.Http;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAccountManager))]
  [Guid(3001606566, 54426, 16434, 132, 191, 26, 40, 71, 116, 123, 241)]
  internal interface IWebAccountManagerStatics
  {
    IAsyncAction UpdateWebAccountPropertiesAsync(
      WebAccount webAccount,
      string webAccountUserName,
      IMapView<string, string> additionalProperties);

    [RemoteAsync]
    [Overload("AddWebAccountAsync")]
    IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props);

    IAsyncAction DeleteWebAccountAsync(WebAccount webAccount);

    [RemoteAsync]
    IAsyncOperation<IVectorView<WebAccount>> FindAllProviderWebAccountsAsync();

    [RemoteAsync]
    IAsyncAction PushCookiesAsync(Uri uri, IVectorView<HttpCookie> cookies);

    [RemoteAsync]
    IAsyncAction SetViewAsync(WebAccount webAccount, WebAccountClientView view);

    [RemoteAsync]
    IAsyncAction ClearViewAsync(WebAccount webAccount, Uri applicationCallbackUri);

    [RemoteAsync]
    IAsyncOperation<IVectorView<WebAccountClientView>> GetViewsAsync(
      WebAccount webAccount);

    IAsyncAction SetWebAccountPictureAsync(
      WebAccount webAccount,
      IRandomAccessStream webAccountPicture);

    IAsyncAction ClearWebAccountPictureAsync(WebAccount webAccount);
  }
}
