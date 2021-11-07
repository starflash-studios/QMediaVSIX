// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountManagerStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (WebAccountManager))]
  [Guid(1508623058, 63451, 16687, 188, 63, 242, 254, 160, 68, 48, 180)]
  internal interface IWebAccountManagerStatics4
  {
    [RemoteAsync]
    IAsyncAction InvalidateAppCacheForAllAccountsAsync();

    [RemoteAsync]
    IAsyncAction InvalidateAppCacheForAccountAsync(WebAccount webAccount);
  }
}
