// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Protection;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(923981123, 17899, 16696, 170, 98, 192, 30, 38, 243, 132, 63)]
  [ExclusiveTo(typeof (MediaStreamSource))]
  internal interface IMediaStreamSource : IMediaSource
  {
    event TypedEventHandler<MediaStreamSource, MediaStreamSourceClosedEventArgs> Closed;

    event TypedEventHandler<MediaStreamSource, MediaStreamSourceStartingEventArgs> Starting;

    event TypedEventHandler<MediaStreamSource, object> Paused;

    event TypedEventHandler<MediaStreamSource, MediaStreamSourceSampleRequestedEventArgs> SampleRequested;

    event TypedEventHandler<MediaStreamSource, MediaStreamSourceSwitchStreamsRequestedEventArgs> SwitchStreamsRequested;

    void NotifyError(MediaStreamSourceErrorStatus errorStatus);

    void AddStreamDescriptor(IMediaStreamDescriptor descriptor);

    MediaProtectionManager MediaProtectionManager { set; get; }

    TimeSpan Duration { set; get; }

    bool CanSeek { set; get; }

    TimeSpan BufferTime { set; get; }

    void SetBufferedRange(TimeSpan startOffset, TimeSpan endOffset);

    MusicProperties MusicProperties { get; }

    VideoProperties VideoProperties { get; }

    IRandomAccessStreamReference Thumbnail { set; get; }

    void AddProtectionKey(
      IMediaStreamDescriptor streamDescriptor,
      byte[] keyIdentifier,
      byte[] licenseData);
  }
}
