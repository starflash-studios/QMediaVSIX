// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpRequestHeaderCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Web.Http.Headers
{
  /// <summary>Provides a collection of the HTTP headers associated with an HTTP request.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpRequestHeaderCollection : 
    IHttpRequestHeaderCollection,
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>,
    IStringable
  {
    /// <summary>Gets the HttpMediaTypeWithQualityHeaderValueCollection of HttpMediaTypeWithQualityHeaderValue objects that represent the value of an **Accept** HTTP header on an HTTP request.</summary>
    /// <returns>The collection of HttpMediaTypeWithQualityHeaderValue objects that represent the value of an **Accept** HTTP header. An empty collection means that the header is absent.</returns>
    public extern HttpMediaTypeWithQualityHeaderValueCollection Accept { [MethodImpl] get; }

    /// <summary>Gets the HttpContentCodingWithQualityHeaderValueCollection of HttpContentCodingWithQualityHeaderValue objects that represent the value of an **Accept-Encoding** HTTP header on an HTTP request.</summary>
    /// <returns>The collection of HttpContentCodingWithQualityHeaderValue objects that represent the value of an **Accept-Encoding** HTTP header. An empty collection means that the header is absent.</returns>
    public extern HttpContentCodingWithQualityHeaderValueCollection AcceptEncoding { [MethodImpl] get; }

    /// <summary>Gets the HttpLanguageRangeWithQualityHeaderValueCollection of HttpLanguageRangeWithQualityHeaderValue objects that represent the value of an **Accept-Language** HTTP header on an HTTP request.</summary>
    /// <returns>The collection of HttpLanguageRangeWithQualityHeaderValue objects that represent the value of an **Accept-Language** HTTP header. An empty collection means that the header is absent.</returns>
    public extern HttpLanguageRangeWithQualityHeaderValueCollection AcceptLanguage { [MethodImpl] get; }

    /// <summary>Gets or sets the HttpCredentialsHeaderValue object that represents the value of an **Authorization** HTTP header on an HTTP request.</summary>
    /// <returns>The value of an **Authorization** HTTP header on an HTTP request. A null value means that the header is absent.</returns>
    public extern HttpCredentialsHeaderValue Authorization { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the HttpCacheDirectiveHeaderValueCollection that represents the value of a **Cache-Control** HTTP header on an HTTP request.</summary>
    /// <returns>The object that represents the value of a **Cache-Control** HTTP header. An empty collection means that the header is absent.</returns>
    public extern HttpCacheDirectiveHeaderValueCollection CacheControl { [MethodImpl] get; }

    /// <summary>Gets the HttpConnectionOptionHeaderValueCollection of HttpConnectionOptionHeaderValue objects that represent the value of a **Connection** HTTP header on an HTTP request.</summary>
    /// <returns>The collection of HttpConnectionOptionHeaderValue objects that represent the HTTP **Connection** header. An empty collection means that the header is absent.</returns>
    public extern HttpConnectionOptionHeaderValueCollection Connection { [MethodImpl] get; }

    /// <summary>Gets the HttpCookiePairHeaderValueCollection of HttpCookiePairHeaderValue objects that represent the value of an **Cookie** HTTP header sent on an HTTP request.</summary>
    /// <returns>The collection of HttpCookiePairHeaderValue objects that represent the HTTP cookies in a **Cookie** HTTP header. An empty collection means that the header is absent.</returns>
    public extern HttpCookiePairHeaderValueCollection Cookie { [MethodImpl] get; }

    /// <summary>Gets or sets the DateTime object that represents the value of a **Date** HTTP header on an HTTP request.</summary>
    /// <returns>The object that represents the value of a **Date** HTTP header on an HTTP request. A null value means that the header is absent.</returns>
    public extern IReference<DateTime> Date { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the HttpExpectationHeaderValueCollection of HttpExpectationHeaderValue objects that represent the value of an **Expect** HTTP header on an HTTP request.</summary>
    /// <returns>The collection of HttpExpectationHeaderValue objects that represent the value of an **Expect** HTTP header on an HTTP request. An empty collection means that the header is absent.</returns>
    public extern HttpExpectationHeaderValueCollection Expect { [MethodImpl] get; }

    /// <summary>Gets or sets the String that represents the value of a **From** HTTP header on an HTTP request.</summary>
    /// <returns>The value of a **From** HTTP header on an HTTP request. An empty string means that the header is absent.</returns>
    public extern string From { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the HostName that represents the value of a **Host** HTTP header on an HTTP request.</summary>
    /// <returns>The HostName that represents the value of a **Host** HTTP header on an HTTP request. A null value means that the header is absent.</returns>
    public extern HostName Host { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DateTime object that represents the value of an **If-Modified-Since** HTTP header on an HTTP request.</summary>
    /// <returns>The DateTime object that represents the value of an **If-Modified-Since** HTTP header on an HTTP request. A null value means that the header is absent.</returns>
    public extern IReference<DateTime> IfModifiedSince { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DateTime object that represents the value of an **If-Unmodified-Since** HTTP header on an HTTP request.</summary>
    /// <returns>The DateTime object that represents the value of an **If-Unmodified-Since** HTTP header on an HTTP request. A null value means that the header is absent.</returns>
    public extern IReference<DateTime> IfUnmodifiedSince { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an integer value that represents the value of a **Max-Forwards** HTTP header on an HTTP request.</summary>
    /// <returns>An integer value that represents the value of a **Max-Forwards** HTTP header on an HTTP request. A null value means that the header is absent.</returns>
    public extern IReference<uint> MaxForwards { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the HttpCredentialsHeaderValue object that represent the value of a **Proxy-Authorization** HTTP header on an HTTP request.</summary>
    /// <returns>The object that represent the value of a **Proxy-Authorization** HTTP header on an HTTP request. A null value means that the header is absent.</returns>
    public extern HttpCredentialsHeaderValue ProxyAuthorization { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Uri that represents the value of a **Referer** HTTP header on an HTTP request.</summary>
    /// <returns>The object that represents the value of a **Referer** HTTP header on an HTTP request. A null value means that the header is absent.</returns>
    public extern Uri Referer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the HttpTransferCodingHeaderValueCollection of HttpTransferCodingHeaderValue objects that represent the value of a **Transfer-Encoding** HTTP header on an HTTP request.</summary>
    /// <returns>The collection of HttpTransferCodingHeaderValue objects that represent the value of a **Transfer-Encoding** HTTP header on an HTTP request. An empty collection means that the header is absent.</returns>
    public extern HttpTransferCodingHeaderValueCollection TransferEncoding { [MethodImpl] get; }

    /// <summary>Gets the HttpProductInfoHeaderValueCollection of HttpProductInfoHeaderValue objects that represent the value of a **User-Agent** HTTP header on an HTTP request.</summary>
    /// <returns>The collection of HttpProductInfoHeaderValue objects that represent the value of a **User-Agent** HTTP header on an HTTP request. An empty collection means that the header is absent.</returns>
    public extern HttpProductInfoHeaderValueCollection UserAgent { [MethodImpl] get; }

    /// <summary>Adds a new item to the end of the HttpRequestHeaderCollection.</summary>
    /// <param name="name">The name of the value to add.</param>
    /// <param name="value">The item value to add.</param>
    [MethodImpl]
    public extern void Append(string name, string value);

    /// <summary>Try to append the specified item to the HttpRequestHeaderCollection without validation.</summary>
    /// <param name="name">The name of the item to append.</param>
    /// <param name="value">The value of the item to append.</param>
    /// <returns>**true** if the item was appended; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool TryAppendWithoutValidation(string name, string value);

    [MethodImpl]
    public extern string Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, string> GetView();

    [MethodImpl]
    public extern bool Insert(string key, string value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, string>> First();

    /// <summary>Returns a string that represents the current HttpRequestHeaderCollection object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
