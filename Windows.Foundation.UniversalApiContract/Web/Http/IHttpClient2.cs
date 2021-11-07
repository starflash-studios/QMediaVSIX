// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpClient2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [Guid(3453498184, 59575, 19692, 177, 176, 220, 69, 95, 231, 44, 146)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (HttpClient))]
  internal interface IHttpClient2
  {
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TryDeleteAsync(
      Uri uri);

    [Overload("TryGetAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TryGetAsync(
      Uri uri);

    [Overload("TryGetAsync2")]
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TryGetAsync(
      Uri uri,
      HttpCompletionOption completionOption);

    [RemoteAsync]
    IAsyncOperationWithProgress<HttpGetBufferResult, HttpProgress> TryGetBufferAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<HttpGetInputStreamResult, HttpProgress> TryGetInputStreamAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<HttpGetStringResult, HttpProgress> TryGetStringAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TryPostAsync(
      Uri uri,
      IHttpContent content);

    [RemoteAsync]
    IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TryPutAsync(
      Uri uri,
      IHttpContent content);

    [Overload("TrySendRequestAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TrySendRequestAsync(
      HttpRequestMessage request);

    [Overload("TrySendRequestAsync2")]
    [RemoteAsync]
    IAsyncOperationWithProgress<HttpRequestResult, HttpProgress> TrySendRequestAsync(
      HttpRequestMessage request,
      HttpCompletionOption completionOption);
  }
}
