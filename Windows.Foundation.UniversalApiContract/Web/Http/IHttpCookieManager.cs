// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpCookieManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpCookieManager))]
  [Guid(2051217280, 52559, 20055, 168, 74, 91, 10, 83, 214, 187, 150)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpCookieManager
  {
    [Overload("SetCookie")]
    bool SetCookie(HttpCookie cookie);

    [Overload("SetCookieWithThirdParty")]
    bool SetCookie(HttpCookie cookie, bool thirdParty);

    void DeleteCookie(HttpCookie cookie);

    HttpCookieCollection GetCookies(Uri uri);
  }
}
