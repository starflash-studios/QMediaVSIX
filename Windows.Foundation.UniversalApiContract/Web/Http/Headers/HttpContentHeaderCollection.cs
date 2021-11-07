// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpContentHeaderCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http.Headers
{
  /// <summary>Provides a collection of the HTTP headers associated with content on an HTTP request or response.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpContentHeaderCollection : 
    IHttpContentHeaderCollection,
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>,
    IStringable
  {
    /// <summary>Initializes a new instance of the HttpContentHeaderCollection class.</summary>
    [MethodImpl]
    public extern HttpContentHeaderCollection();

    /// <summary>Gets or sets the HttpContentDispositionHeaderValue object that represents the value of an HTTP **Content-Disposition** header on the HTTP content.</summary>
    /// <returns>The object that represent the value of HTTP **Content-Disposition** header on the HTTP content. A **null** value means that the header is absent.</returns>
    public extern HttpContentDispositionHeaderValue ContentDisposition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the HttpContentCodingHeaderValueCollection of HttpContentCodingHeaderValue objects that represent the value of an HTTP **Content-Encoding** header on the HTTP content.</summary>
    /// <returns>The collection of HttpContentCodingHeaderValue objects that represent the value of an HTTP **Content-Encoding** header on the HTTP content. An empty collection means that the header is absent.</returns>
    public extern HttpContentCodingHeaderValueCollection ContentEncoding { [MethodImpl] get; }

    /// <summary>Gets the HttpLanguageHeaderValueCollection of objects that represent the value of an HTTP **Content-Language** header on the HTTP content.</summary>
    /// <returns>The collection of objects that represent the value of an HTTP **Content-Language** header on the HTTP content. An empty collection means that the header is absent</returns>
    public extern HttpLanguageHeaderValueCollection ContentLanguage { [MethodImpl] get; }

    /// <summary>Gets or sets the value of the HTTP **Content-Length** header on the HTTP content.</summary>
    /// <returns>The value of the HTTP **Content-Length** header value on the HTTP content. A null value means that the header is absent.</returns>
    public extern IReference<ulong> ContentLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value of the HTTP **Content-Location** header on the HTTP content.</summary>
    /// <returns>The value of the HTTP **Content-Location** header on the HTTP content. A null value means that the header is absent.</returns>
    public extern Uri ContentLocation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value of an HTTP **Content-MD5** header on the HTTP content.</summary>
    /// <returns>The value of the HTTP **Content-MD5** header on the HTTP content. A **null** value means that the header is absent.</returns>
    public extern IBuffer ContentMD5 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the HttpContentRangeHeaderValue object that represent the value of an HTTP **Content-Range** header on the HTTP content.</summary>
    /// <returns>The object that represent the value of the HTTP **Content-Range** header on the HTTP content. A null value means that the header is absent.</returns>
    public extern HttpContentRangeHeaderValue ContentRange { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the HttpMediaTypeHeaderValue object that represent the value of an HTTP **Content-Type** header on the HTTP content.</summary>
    /// <returns>The object that represent the value of an HTTP **Content-Type** header on the HTTP content. A **null** value means that the header is absent.</returns>
    public extern HttpMediaTypeHeaderValue ContentType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DateTime object that represents the value of an HTTP **Expires** header on the HTTP content.</summary>
    /// <returns>The object that represents the value of an HTTP **Expires** header on the HTTP content. A **null** value means that the header is absent.</returns>
    public extern IReference<DateTime> Expires { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DateTime object that represents the value of an HTTP **Last-Modified** header on the HTTP content.</summary>
    /// <returns>The object that represents the value of an HTTP **Last-Modified** header on the HTTP content. A **null** value means that the header is absent.</returns>
    public extern IReference<DateTime> LastModified { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Adds a new item to the end of the HttpContentHeaderCollection.</summary>
    /// <param name="name">The name of the value to add.</param>
    /// <param name="value">The item value to add.</param>
    [MethodImpl]
    public extern void Append(string name, string value);

    /// <summary>Try to append the specified item to the HttpContentHeaderCollection without validation.</summary>
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

    /// <summary>Returns a string that represents the current HttpContentHeaderCollection object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
