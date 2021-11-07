// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSource4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;
using Windows.Media.Streaming.Adaptive;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3182406999, 36607, 19555, 133, 166, 132, 222, 10, 227, 228, 242)]
  [ExclusiveTo(typeof (MediaSource))]
  internal interface IMediaSource4 : IMediaSource3, IMediaSource2, IMediaPlaybackSource, IClosable
  {
    AdaptiveMediaSource AdaptiveMediaSource { get; }

    MediaStreamSource MediaStreamSource { get; }

    MseStreamSource MseStreamSource { get; }

    Uri Uri { get; }

    [RemoteAsync]
    IAsyncAction OpenAsync();
  }
}
