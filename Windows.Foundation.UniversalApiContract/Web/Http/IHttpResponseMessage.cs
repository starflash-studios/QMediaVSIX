// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpResponseMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [Guid(4276224251, 34404, 17632, 149, 217, 66, 105, 97, 153, 191, 252)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpResponseMessage))]
  internal interface IHttpResponseMessage
  {
    IHttpContent Content { get; set; }

    HttpResponseHeaderCollection Headers { get; }

    bool IsSuccessStatusCode { get; }

    string ReasonPhrase { get; set; }

    HttpRequestMessage RequestMessage { get; set; }

    HttpResponseMessageSource Source { get; set; }

    HttpStatusCode StatusCode { get; set; }

    HttpVersion Version { get; set; }

    HttpResponseMessage EnsureSuccessStatusCode();
  }
}
