// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http.Filters;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  /// <summary>Sends HTTP requests and receives HTTP responses from a resource identified by a URI. For programming guidance for the **HttpClient** class, and code examples, see the HttpClient conceptual topic.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpClientFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpClient : IHttpClient, IHttpClient2, IClosable, IStringable
  {
    /// <summary>Initializes a new instance of the HttpClient class with a specific filter for handling HTTP response messages. For programming guidance for the HttpClient class, and code examples, see the HttpClient conceptual topic.</summary>
    /// <param name="filter">The HTTP filter to use for handling response messages.</param>
    [MethodImpl]
    public extern HttpClient(IHttpFilter filter);

    /// <summary>Initializes a new instance of the HttpClient class. For programming guidance for the HttpClient class, and code examples, see the HttpClient conceptual topic.</summary>
    [MethodImpl]
    public extern HttpClient();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> DeleteAsync(
      Uri uri);

    [RemoteAsync]
    [Overload("GetAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> GetAsync(
      Uri uri);

    [Overload("GetWithOptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> GetAsync(
      Uri uri,
      HttpCompletionOption completionOption);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IBuffer, HttpProgress> GetBufferAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IInputStream, HttpProgress> GetInputStreamAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<string, HttpProgress> GetStringAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> PostAsync(
      Uri uri,
      IHttpContent content);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> PutAsync(
      Uri uri,
      IHttpContent content);

    /// <summary>Send an HTTP request as an asynchronous operation. For programming guidance for the HttpClient class, and code examples, see the HttpClient conceptual topic.</summary>
    /// <param name="request">The HTTP request message to send.</param>
    /// <returns>The object representing the asynchronous operation.</returns>
    [Overload("SendRequestAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request);

    /// <summary>Send an HTTP request with an HTTP completion option as an asynchronous operation. For programming guidance for the HttpClient class, and code examples, see the HttpClient conceptual topic.</summary>
    /// <param name="request">The HTTP request message to send.</param>
    /// <param name="completionOption">A value that indicates whether the HttpClient operation is considered completed when all of the response is read, or when just the headers are read.</param>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("SendRequestWithOptionAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request,
      HttpCompletionOption completionOption);

    /// <summary>Gets a collection of headers that should be sent with each request. For programming guidance for the HttpClient class, and code examples, see the HttpClient conceptual topic.</summary>
    /// <returns>The headers that should be sent with each request.</returns>
    public extern HttpRequestHeaderCollection DefaultRequestHeaders { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TryDeleteAsync(
      Uri uri);

    [Overload("TryGetAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TryGetAsync(
      Uri uri);

    [RemoteAsync]
    [Overload("TryGetAsync2")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TryGetAsync(
      Uri uri,
      HttpCompletionOption completionOption);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpGetBufferResult, HttpProgress> TryGetBufferAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpGetInputStreamResult, HttpProgress> TryGetInputStreamAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpGetStringResult, HttpProgress> TryGetStringAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TryPostAsync(
      Uri uri,
      IHttpContent content);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TryPutAsync(
      Uri uri,
      IHttpContent content);

    /// <summary>Sends an HTTP request to the specified Uri as an asynchronous operation. For programming guidance for the HttpClient class, and code examples, see the HttpClient conceptual topic.</summary>
    /// <param name="request">The HTTP request message to send.</param>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("TrySendRequestAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TrySendRequestAsync(
      HttpRequestMessage request);

    /// <summary>Sends an HTTP request with a completion option to the specified Uri as an asynchronous operation. For programming guidance for the HttpClient class, and code examples, see the HttpClient conceptual topic.</summary>
    /// <param name="request">The HTTP request message to send.</param>
    /// <param name="completionOption">A value that indicates whether the HttpClient operation is considered completed when all of the response is read, or when just the headers are read.</param>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("TrySendRequestAsync2")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TrySendRequestAsync(
      HttpRequestMessage request,
      HttpCompletionOption completionOption);

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns a string that represents the current HttpClient object. For programming guidance for the HttpClient class, and code examples, see the HttpClient conceptual topic.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
