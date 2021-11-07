// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpResponseHeaderCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpResponseHeaderCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2056849769, 64063, 16877, 170, 198, 191, 149, 121, 117, 193, 107)]
  internal interface IHttpResponseHeaderCollection
  {
    IReference<TimeSpan> Age { get; set; }

    HttpMethodHeaderValueCollection Allow { get; }

    HttpCacheDirectiveHeaderValueCollection CacheControl { get; }

    HttpConnectionOptionHeaderValueCollection Connection { get; }

    IReference<DateTime> Date { get; set; }

    Uri Location { get; set; }

    HttpChallengeHeaderValueCollection ProxyAuthenticate { get; }

    HttpDateOrDeltaHeaderValue RetryAfter { get; set; }

    HttpTransferCodingHeaderValueCollection TransferEncoding { get; }

    HttpChallengeHeaderValueCollection WwwAuthenticate { get; }

    void Append(string name, string value);

    bool TryAppendWithoutValidation(string name, string value);
  }
}
