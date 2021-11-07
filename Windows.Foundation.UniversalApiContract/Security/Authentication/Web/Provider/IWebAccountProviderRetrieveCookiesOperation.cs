// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderRetrieveCookiesOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1510212673, 4003, 19121, 160, 28, 32, 177, 16, 53, 133, 148)]
  [ExclusiveTo(typeof (WebAccountProviderRetrieveCookiesOperation))]
  internal interface IWebAccountProviderRetrieveCookiesOperation : IWebAccountProviderOperation
  {
    Uri Context { get; }

    IVector<HttpCookie> Cookies { get; }

    Uri Uri { set; get; }

    Uri ApplicationCallbackUri { get; }
  }
}
