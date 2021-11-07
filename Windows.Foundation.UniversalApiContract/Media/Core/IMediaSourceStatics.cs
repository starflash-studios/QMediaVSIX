// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Streaming.Adaptive;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaSource))]
  [Guid(4152192932, 18002, 16654, 177, 216, 233, 165, 226, 69, 164, 92)]
  internal interface IMediaSourceStatics
  {
    MediaSource CreateFromAdaptiveMediaSource(AdaptiveMediaSource mediaSource);

    MediaSource CreateFromMediaStreamSource(MediaStreamSource mediaSource);

    MediaSource CreateFromMseStreamSource(MseStreamSource mediaSource);

    MediaSource CreateFromIMediaSource(IMediaSource mediaSource);

    MediaSource CreateFromStorageFile(IStorageFile file);

    MediaSource CreateFromStream(IRandomAccessStream stream, string contentType);

    MediaSource CreateFromStreamReference(
      IRandomAccessStreamReference stream,
      string contentType);

    MediaSource CreateFromUri(Uri uri);
  }
}
