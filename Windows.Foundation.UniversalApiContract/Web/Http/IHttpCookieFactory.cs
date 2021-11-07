// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpCookieFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpCookie))]
  [Guid(1778746793, 37660, 19665, 169, 109, 194, 23, 1, 120, 92, 95)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpCookieFactory
  {
    HttpCookie Create(string name, string domain, string path);
  }
}
