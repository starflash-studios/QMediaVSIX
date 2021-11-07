// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Protection;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  /// <summary>Represents a media source that delivers media samples directly to the media pipeline.</summary>
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IMediaStreamSourceFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MediaStreamSource : 
    IMediaStreamSource,
    IMediaSource,
    IMediaStreamSource2,
    IMediaStreamSource3,
    IMediaStreamSource4
  {
    /// <summary>Creates an instance of MediaStreamSource from the specified IMediaStreamDescriptor.</summary>
    /// <param name="descriptor">The AudioStreamDescriptor or VideoStreamDescriptor to create the MediaStreamSource from.</param>
    [MethodImpl]
    public extern MediaStreamSource(IMediaStreamDescriptor descriptor);

    /// <summary>Creates an instance of MediaStreamSource from two IMediaStreamDescriptor objects.</summary>
    /// <param name="descriptor">The first AudioStreamDescriptor or VideoStreamDescriptor to create the MediaStreamSource from.</param>
    /// <param name="descriptor2">The second AudioStreamDescriptor or VideoStreamDescriptor to create the MediaStreamSource from.</param>
    [MethodImpl]
    public extern MediaStreamSource(
      IMediaStreamDescriptor descriptor,
      IMediaStreamDescriptor descriptor2);

    /// <summary>Occurs when the MediaStreamSource is shutting down.</summary>
    public extern event TypedEventHandler<MediaStreamSource, MediaStreamSourceClosedEventArgs> Closed;

    /// <summary>Occurs when the MediaStreamSource is ready to start requesting MediaStreamSample objects. The event can specify a position in the media time-line from which the first MediaStreamSample should be delivered.</summary>
    public extern event TypedEventHandler<MediaStreamSource, MediaStreamSourceStartingEventArgs> Starting;

    /// <summary>Occurs when the MediaStreamSource is paused and stops requesting MediaStreamSample objects for an unspecified period of time, but is expected to resume requesting MediaStreamSample objects from the current position.</summary>
    public extern event TypedEventHandler<MediaStreamSource, object> Paused;

    /// <summary>Occurs when the MediaStreamSource request a MediaStreamSample for a specified stream.</summary>
    public extern event TypedEventHandler<MediaStreamSource, MediaStreamSourceSampleRequestedEventArgs> SampleRequested;

    /// <summary>Occurs when the MediaStreamSource will stop requesting MediaStreamSample objects for a certain stream and will start requesting MediaStreamSample objects from a different stream instead.</summary>
    public extern event TypedEventHandler<MediaStreamSource, MediaStreamSourceSwitchStreamsRequestedEventArgs> SwitchStreamsRequested;

    /// <summary>Notifies the MediaStreamSource that an error has occurred which is preventing the application from continuing to deliver data to the MediaStreamSource.</summary>
    /// <param name="errorStatus">The cause of the error.</param>
    [MethodImpl]
    public extern void NotifyError(MediaStreamSourceErrorStatus errorStatus);

    /// <summary>Adds a new stream descriptor to the MediaStreamSource.</summary>
    /// <param name="descriptor">The descriptor to add.</param>
    [MethodImpl]
    public extern void AddStreamDescriptor(IMediaStreamDescriptor descriptor);

    /// <summary>Gets or sets the Digital Rights Management (DRM)MediaProtectionManager used to protect the media.</summary>
    /// <returns>The media protection manager.</returns>
    public extern MediaProtectionManager MediaProtectionManager { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the duration of the media time-line.</summary>
    /// <returns>The duration of the media time-line. The default value is 0.</returns>
    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether or not the application supports changing its position in the media time-line.</summary>
    /// <returns>**true** if the application supports changing its position in the media time-line; otherwise, **false**. The default value is **false**.</returns>
    public extern bool CanSeek { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the amount of data that is buffered by the MediaStreamSource.</summary>
    /// <returns>The duration of the buffer which corresponds to the number of MediaStreamSamples the MediaStreamSource requests. The default value is 3 seconds.</returns>
    public extern TimeSpan BufferTime { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void SetBufferedRange(TimeSpan startOffset, TimeSpan endOffset);

    /// <summary>Gets the music properties which are used for music-related metadata.</summary>
    /// <returns>The music properties.</returns>
    public extern MusicProperties MusicProperties { [MethodImpl] get; }

    /// <summary>Gets the video properties which are used for video related metadata.</summary>
    /// <returns>The video properties.</returns>
    public extern VideoProperties VideoProperties { [MethodImpl] get; }

    /// <summary>Gets or sets the thumbnail which is a reference to a stream for a video thumbnail image or music album art.</summary>
    /// <returns>The reference to the thumbnail stream.</returns>
    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Adds a Digital Rights Management (DRM) protection key which is used by the MediaProtectionManager to encrypt and decrypt the specified stream.</summary>
    /// <param name="streamDescriptor">The stream the key is used to encrypt and decrypt.</param>
    /// <param name="keyIdentifier">The key used to encrypt and decrypt the stream.</param>
    /// <param name="licenseData">The Digital Rights Management (DRM) licence for the media.</param>
    [MethodImpl]
    public extern void AddProtectionKey(
      IMediaStreamDescriptor streamDescriptor,
      byte[] keyIdentifier,
      byte[] licenseData);

    /// <summary>Occurs when a sample from the MediaStreamSource is rendered.</summary>
    public extern event TypedEventHandler<MediaStreamSource, MediaStreamSourceSampleRenderedEventArgs> SampleRendered;

    /// <summary>Gets the maxiumum supported playback rate for the **MediaStreamSource**.</summary>
    /// <returns>The maxiumum supported playback rate for the **MediaStreamSource**.</returns>
    public extern IReference<double> MaxSupportedPlaybackRate { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether the media content being processed is live.</summary>
    /// <returns>True if the media content is live; otherwise false.</returns>
    public extern bool IsLive { [MethodImpl] set; [MethodImpl] get; }
  }
}
