// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountScopeManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(1550639996, 4786, 16954, 191, 61, 133, 184, 215, 229, 54, 86)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAccountManager))]
  internal interface IWebAccountScopeManagerStatics
  {
    [RemoteAsync]
    [Overload("AddWebAccountWithScopeAsync")]
    IAsyncOperation<WebAccount> AddWebAccountAsync(
      string webAccountId,
      string webAccountUserName,
      IMapView<string, string> props,
      WebAccountScope scope);

    IAsyncAction SetScopeAsync(WebAccount webAccount, WebAccountScope scope);

    WebAccountScope GetScope(WebAccount webAccount);
  }
}
