// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpCacheDirectiveHeaderValueCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents the value of the **Cache-Control** HTTP header on HTTP content associated with an HTTP request or response.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HttpCacheDirectiveHeaderValueCollection : 
    IHttpCacheDirectiveHeaderValueCollection,
    IVector<HttpNameValueHeaderValue>,
    IIterable<HttpNameValueHeaderValue>,
    IStringable
  {
    /// <summary>Gets or sets the value of the **max-age** directive in the **Cache-Control** HTTP header.</summary>
    /// <returns>The value of the max-age directive in the **Cache-Control** HTTP header.</returns>
    public extern IReference<TimeSpan> MaxAge { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value of the **max-stale** directive in the **Cache-Control** HTTP header.</summary>
    /// <returns>the value of the **max-stale** directive in the **Cache-Control** HTTP header.</returns>
    public extern IReference<TimeSpan> MaxStale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value of the **min-fresh** directive in the **Cache-Control** HTTP header.</summary>
    /// <returns>The value of the **min-fresh** directive in the **Cache-Control** HTTP header.</returns>
    public extern IReference<TimeSpan> MinFresh { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value of the **s-maxage** directive in the **Cache-Control** HTTP header.</summary>
    /// <returns>The value of the **s-maxage** directive in the **Cache-Control** HTTP header.</returns>
    public extern IReference<TimeSpan> SharedMaxAge { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Parses and adds an entry to the HttpCacheDirectiveHeaderValueCollection.</summary>
    /// <param name="input">The entry to add.</param>
    [MethodImpl]
    public extern void ParseAdd(string input);

    /// <summary>Tries to parse and add the specified item to the HttpCacheDirectiveHeaderValueCollection.</summary>
    /// <param name="input">The item to parse and add.</param>
    /// <returns>**true** if the item successfully parsed and was added; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool TryParseAdd(string input);

    [MethodImpl]
    public extern HttpNameValueHeaderValue GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<HttpNameValueHeaderValue> GetView();

    [MethodImpl]
    public extern bool IndexOf(HttpNameValueHeaderValue value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, HttpNameValueHeaderValue value);

    [MethodImpl]
    public extern void InsertAt(uint index, HttpNameValueHeaderValue value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(HttpNameValueHeaderValue value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] HttpNameValueHeaderValue[] items);

    [MethodImpl]
    public extern void ReplaceAll(HttpNameValueHeaderValue[] items);

    [MethodImpl]
    public extern IIterator<HttpNameValueHeaderValue> First();

    /// <summary>Returns a string that represents the current HttpCacheDirectiveHeaderValueCollection object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
