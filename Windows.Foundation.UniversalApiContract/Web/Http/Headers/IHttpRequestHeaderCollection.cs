// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpRequestHeaderCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpRequestHeaderCollection))]
  [Guid(2940220059, 46404, 18075, 134, 185, 172, 61, 70, 111, 234, 54)]
  internal interface IHttpRequestHeaderCollection
  {
    HttpMediaTypeWithQualityHeaderValueCollection Accept { get; }

    HttpContentCodingWithQualityHeaderValueCollection AcceptEncoding { get; }

    HttpLanguageRangeWithQualityHeaderValueCollection AcceptLanguage { get; }

    HttpCredentialsHeaderValue Authorization { get; set; }

    HttpCacheDirectiveHeaderValueCollection CacheControl { get; }

    HttpConnectionOptionHeaderValueCollection Connection { get; }

    HttpCookiePairHeaderValueCollection Cookie { get; }

    IReference<DateTime> Date { get; set; }

    HttpExpectationHeaderValueCollection Expect { get; }

    string From { get; set; }

    HostName Host { get; set; }

    IReference<DateTime> IfModifiedSince { get; set; }

    IReference<DateTime> IfUnmodifiedSince { get; set; }

    IReference<uint> MaxForwards { get; set; }

    HttpCredentialsHeaderValue ProxyAuthorization { get; set; }

    Uri Referer { get; set; }

    HttpTransferCodingHeaderValueCollection TransferEncoding { get; }

    HttpProductInfoHeaderValueCollection UserAgent { get; }

    void Append(string name, string value);

    bool TryAppendWithoutValidation(string name, string value);
  }
}
