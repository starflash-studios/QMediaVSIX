// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpResponseMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  /// <summary>Represents an HTTP response message including headers, the status code, and data.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpResponseMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HttpResponseMessage : IHttpResponseMessage, IClosable, IStringable
  {
    /// <summary>Initializes a new instance of the HttpResponseMessage class with a specific HttpStatusCode.</summary>
    /// <param name="statusCode">The status code of the HTTP response.</param>
    [MethodImpl]
    public extern HttpResponseMessage(HttpStatusCode statusCode);

    /// <summary>Initializes a new instance of the HttpResponseMessage class.</summary>
    [MethodImpl]
    public extern HttpResponseMessage();

    /// <summary>Gets or sets the content of the HTTP response message on the HttpResponseMessage object.</summary>
    /// <returns>The content of the HTTP response message on the HttpResponseMessage object.</returns>
    public extern IHttpContent Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of HTTP response headers associated with the HttpResponseMessage that were sent by the server.</summary>
    /// <returns>The collection of HTTP response headers.</returns>
    public extern HttpResponseHeaderCollection Headers { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the HTTP response was successful.</summary>
    /// <returns>A value that indicates if the HTTP response was successful. true if HttpStatusCode was in the **Successful** range (200-299); otherwise false.</returns>
    public extern bool IsSuccessStatusCode { [MethodImpl] get; }

    /// <summary>Gets or sets the reason phrase which typically is sent by servers together with the status code.</summary>
    /// <returns>The reason phrase sent by the server.</returns>
    public extern string ReasonPhrase { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the request message that led to this response message.</summary>
    /// <returns>The request message that led to this response message.</returns>
    public extern HttpRequestMessage RequestMessage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the source of the data received in the HttpResponseMessage.</summary>
    /// <returns>The source of the data received in the HttpResponseMessage.</returns>
    public extern HttpResponseMessageSource Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the status code of the HTTP response.</summary>
    /// <returns>The status code of the HTTP response.</returns>
    public extern HttpStatusCode StatusCode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the HTTP protocol version used on the HttpResponseMessage object.</summary>
    /// <returns>The HTTP protocol version. The default is 1.1.</returns>
    public extern HttpVersion Version { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Throws an exception if the IsSuccessStatusCode property for the HTTP response is false.</summary>
    /// <returns>The HTTP response if the request was successful.</returns>
    [MethodImpl]
    public extern HttpResponseMessage EnsureSuccessStatusCode();

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns a string that represents the current HttpResponseMessage object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
