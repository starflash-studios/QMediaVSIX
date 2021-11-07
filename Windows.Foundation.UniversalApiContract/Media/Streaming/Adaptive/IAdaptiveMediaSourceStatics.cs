// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Http;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSource))]
  [Guid(1353104733, 26351, 19667, 149, 121, 158, 102, 5, 7, 220, 63)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdaptiveMediaSourceStatics
  {
    bool IsContentTypeSupported(string contentType);

    [RemoteAsync]
    [Overload("CreateFromUriAsync")]
    IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromUriAsync(
      Uri uri);

    [Overload("CreateFromUriWithDownloaderAsync")]
    [RemoteAsync]
    IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromUriAsync(
      Uri uri,
      HttpClient httpClient);

    [Overload("CreateFromStreamAsync")]
    [RemoteAsync]
    IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromStreamAsync(
      IInputStream stream,
      Uri uri,
      string contentType);

    [RemoteAsync]
    [Overload("CreateFromStreamWithDownloaderAsync")]
    IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromStreamAsync(
      IInputStream stream,
      Uri uri,
      string contentType,
      HttpClient httpClient);
  }
}
