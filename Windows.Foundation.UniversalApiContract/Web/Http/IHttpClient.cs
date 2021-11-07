// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpClient))]
  [Guid(2144997713, 13684, 18560, 168, 186, 230, 177, 224, 6, 31, 61)]
  internal interface IHttpClient
  {
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> DeleteAsync(
      Uri uri);

    [Overload("GetAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> GetAsync(
      Uri uri);

    [Overload("GetWithOptionAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> GetAsync(
      Uri uri,
      HttpCompletionOption completionOption);

    [RemoteAsync]
    IAsyncOperationWithProgress<IBuffer, HttpProgress> GetBufferAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<IInputStream, HttpProgress> GetInputStreamAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<string, HttpProgress> GetStringAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> PostAsync(
      Uri uri,
      IHttpContent content);

    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> PutAsync(
      Uri uri,
      IHttpContent content);

    [Overload("SendRequestAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request);

    [Overload("SendRequestWithOptionAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request,
      HttpCompletionOption completionOption);

    HttpRequestHeaderCollection DefaultRequestHeaders { get; }
  }
}
