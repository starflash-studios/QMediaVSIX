// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpResponseHeaderCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Provides a collection of the HTTP headers associated with an HTTP response.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpResponseHeaderCollection : 
    IHttpResponseHeaderCollection,
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>,
    IStringable
  {
    /// <summary>Gets or sets the TimeSpan object that represents the value of an **Age** HTTP header on an HTTP response.</summary>
    /// <returns>The object that represents the value of an **Age** HTTP header on an HTTP response. A **null** value means that the header is absent.</returns>
    public extern IReference<TimeSpan> Age { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the HttpMethodHeaderValueCollection of HttpMethod objects that represent the value of an **Allow** HTTP header on an HTTP response.</summary>
    /// <returns>The collection of HttpMethod objects that represent the value of an **Allow** HTTP header on an HTTP response. An empty collection means that the header is absent.</returns>
    public extern HttpMethodHeaderValueCollection Allow { [MethodImpl] get; }

    /// <summary>Gets the HttpCacheDirectiveHeaderValueCollection of objects that represent the value of a **Cache-Control** HTTP header on an HTTP response.</summary>
    /// <returns>The collection of objects that represent the value of a **Cache-Control** HTTP header on an HTTP response. An empty collection means that the header is absent.</returns>
    public extern HttpCacheDirectiveHeaderValueCollection CacheControl { [MethodImpl] get; }

    /// <summary>Gets the HttpConnectionOptionHeaderValueCollection of HttpConnectionOptionHeaderValue objects that represent the value of a **Connection** HTTP header on an HTTP response.</summary>
    /// <returns>The collection of HttpConnectionOptionHeaderValue objects that represent the value of a **Connection** HTTP header. An empty collection means that the header is absent.</returns>
    public extern HttpConnectionOptionHeaderValueCollection Connection { [MethodImpl] get; }

    /// <summary>Gets or sets the DateTime object that represents the value of a **Date** HTTP header on an HTTP response.</summary>
    /// <returns>The object that represents the value of a **Date** HTTP header on an HTTP request. A **null** value means that the header is absent.</returns>
    public extern IReference<DateTime> Date { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Uri that represents the value or a **Location** HTTP header on an HTTP response.</summary>
    /// <returns>The object that represents the value of a **Location** HTTP header on an HTTP response. A **null** value means that the header is absent.</returns>
    public extern Uri Location { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the HttpChallengeHeaderValueCollection of HttpChallengeHeaderValue objects that represent the value of a **Proxy-Authenticate** HTTP header on an HTTP response.</summary>
    /// <returns>The collection of HttpChallengeHeaderValue objects that represent the value of a **Proxy-Authenticate** HTTP header on an HTTP response. An empty collection means that the header is absent.</returns>
    public extern HttpChallengeHeaderValueCollection ProxyAuthenticate { [MethodImpl] get; }

    /// <summary>Gets or sets the HttpDateOrDeltaHeaderValue object that represent the value of a **Retry-After** HTTP header on an HTTP response.</summary>
    /// <returns>The object that represents the value of a **Retry-After** HTTP header on an HTTP response. A **null** value means that the header is absent.</returns>
    public extern HttpDateOrDeltaHeaderValue RetryAfter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the HttpTransferCodingHeaderValueCollection of HttpTransferCodingHeaderValue objects that represent the value of a **Transfer-Encoding** HTTP header on an HTTP response.</summary>
    /// <returns>The collection of HttpTransferCodingHeaderValue objects that represent the value of a **Transfer-Encoding** HTTP header on an HTTP response. An empty collection means that the header is absent.</returns>
    public extern HttpTransferCodingHeaderValueCollection TransferEncoding { [MethodImpl] get; }

    /// <summary>Gets the HttpChallengeHeaderValueCollection of HttpChallengeHeaderValue objects that represent the value of a **WWW-Authenticate** HTTP header on an HTTP response.</summary>
    /// <returns>The collection of HttpChallengeHeaderValue objects that represent the value of a **WWW-Authenticate** HTTP header on an HTTP response. An empty collection means that the header is absent.</returns>
    public extern HttpChallengeHeaderValueCollection WwwAuthenticate { [MethodImpl] get; }

    /// <summary>Adds a new item to the end of the HttpResponseHeaderCollection.</summary>
    /// <param name="name">The name of the value to add.</param>
    /// <param name="value">The item value to add.</param>
    [MethodImpl]
    public extern void Append(string name, string value);

    /// <summary>Try to append the specified item to the HttpResponseHeaderCollection without validation.</summary>
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

    /// <summary>Returns a string that represents the current HttpResponseHeaderCollection object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
