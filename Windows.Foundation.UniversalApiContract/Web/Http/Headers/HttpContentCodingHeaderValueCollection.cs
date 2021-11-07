// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpContentCodingHeaderValueCollection
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
  /// <summary>Represents the value of the **Content-Encoding** HTTP header on HTTP content in a request or a response.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpContentCodingHeaderValueCollection : 
    IHttpContentCodingHeaderValueCollection,
    IVector<HttpContentCodingHeaderValue>,
    IIterable<HttpContentCodingHeaderValue>,
    IStringable
  {
    /// <summary>Parses and adds an entry to the HttpContentCodingHeaderValueCollection.</summary>
    /// <param name="input">The entry to add.</param>
    [MethodImpl]
    public extern void ParseAdd(string input);

    /// <summary>Tries to parse and add the specified item to the HttpContentCodingHeaderValueCollection.</summary>
    /// <param name="input">The item to parse and add.</param>
    /// <returns>**true** if the item successfully parsed and was added; otherwise **false**.</returns>
    [MethodImpl]
    public extern bool TryParseAdd(string input);

    [MethodImpl]
    public extern HttpContentCodingHeaderValue GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<HttpContentCodingHeaderValue> GetView();

    [MethodImpl]
    public extern bool IndexOf(HttpContentCodingHeaderValue value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, HttpContentCodingHeaderValue value);

    [MethodImpl]
    public extern void InsertAt(uint index, HttpContentCodingHeaderValue value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(HttpContentCodingHeaderValue value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] HttpContentCodingHeaderValue[] items);

    [MethodImpl]
    public extern void ReplaceAll(HttpContentCodingHeaderValue[] items);

    [MethodImpl]
    public extern IIterator<HttpContentCodingHeaderValue> First();

    /// <summary>Returns a string that represents the current HttpContentCodingHeaderValueCollection object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
