// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.Storage.Streams;
using Windows.Web.Http;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Represents the source of adaptive streaming content.</summary>
  [Static(typeof (IAdaptiveMediaSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AdaptiveMediaSource : 
    IAdaptiveMediaSource,
    IMediaSource,
    IAdaptiveMediaSource2,
    IAdaptiveMediaSource3,
    IClosable
  {
    /// <summary>Gets a value that indicates whether the media source is live.</summary>
    /// <returns>A value that indicates whether playback of the adaptive streaming object is live. **true** if live; otherwise, **false**.</returns>
    public extern bool IsLive { [MethodImpl] get; }

    /// <summary>Gets or sets the desired offset of live playback from the end of the known media content that has been downloaded.</summary>
    /// <returns>The desired offset for the live playback of the streaming media. This value must be greater than MinLiveOffset. If the specified value is less than the minimum value, it is automatically clamped to the allowed range.</returns>
    public extern TimeSpan DesiredLiveOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the initial bit rate to use for playback of the media source.</summary>
    /// <returns>The initial bit rate to use for playback.</returns>
    public extern uint InitialBitrate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating the current download bitrate for the media source.</summary>
    /// <returns>The current download bitrate for the media source.</returns>
    public extern uint CurrentDownloadBitrate { [MethodImpl] get; }

    /// <summary>Gets a value indicating the current playback bitrate for the media source.</summary>
    /// <returns>The current playback bitrate for the media source.</returns>
    public extern uint CurrentPlaybackBitrate { [MethodImpl] get; }

    /// <summary>Gets the available adaptive bit rates of the adaptive streaming manifest that is the source of the adaptive streaming object.</summary>
    /// <returns>The list of available adaptive bit rates of the adaptive streaming manifest.</returns>
    public extern IVectorView<uint> AvailableBitrates { [MethodImpl] get; }

    /// <summary>Gets or sets the desired minimum bitrate for the media source.</summary>
    /// <returns>The desired minimum bitrate for the streaming media.</returns>
    public extern IReference<uint> DesiredMinBitrate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the desired maximum bitrate for the media source.</summary>
    /// <returns>The desired maximum bitrate for the streaming media.</returns>
    public extern IReference<uint> DesiredMaxBitrate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating if the content streamed by the media source contains only audio.</summary>
    /// <returns>True if the content only contains audio; otherwise, false.</returns>
    public extern bool AudioOnlyPlayback { [MethodImpl] get; }

    /// <summary>Gets a value indicating the inbound bits per second statistic over the time window specified by the InboundBitsPerSecondWindow property.</summary>
    /// <returns>The inbound bits per second over the InboundBitsPerSecondWindow time span.</returns>
    public extern ulong InboundBitsPerSecond { [MethodImpl] get; }

    /// <summary>Gets or sets the time span over which the InboundBitsPerSecond property is calculated.</summary>
    /// <returns>The time span over which the InboundBitsPerSecond property is calculated.</returns>
    public extern TimeSpan InboundBitsPerSecondWindow { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the CurrentDownloadBitrate changes.</summary>
    public extern event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadBitrateChangedEventArgs> DownloadBitrateChanged;

    /// <summary>Occurs when the CurrentPlaybackBitrate changes.</summary>
    public extern event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourcePlaybackBitrateChangedEventArgs> PlaybackBitrateChanged;

    /// <summary>Occurs when a resource download operation is requested.</summary>
    public extern event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadRequestedEventArgs> DownloadRequested;

    /// <summary>Occurs when a resource download operation completes</summary>
    public extern event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadCompletedEventArgs> DownloadCompleted;

    /// <summary>Occurs when a resource download operation fails.</summary>
    public extern event TypedEventHandler<AdaptiveMediaSource, AdaptiveMediaSourceDownloadFailedEventArgs> DownloadFailed;

    /// <summary>Gets the advanced settings for the adaptive media source.</summary>
    /// <returns>The advanced settings for the adaptive media source.</returns>
    public extern AdaptiveMediaSourceAdvancedSettings AdvancedSettings { [MethodImpl] get; }

    /// <summary>Gets the minimum offset of live playback from the end of the known media content that has been downloaded.</summary>
    /// <returns>The minimum offset of live playback from the end of the known media content that has been downloaded.</returns>
    public extern IReference<TimeSpan> MinLiveOffset { [MethodImpl] get; }

    /// <summary>Gets the maximum time window within which the user can seek within the streaming media.</summary>
    /// <returns>The maximum time window within which the user can seek within the streaming media.</returns>
    public extern IReference<TimeSpan> MaxSeekableWindowSize { [MethodImpl] get; }

    /// <summary>Gets or sets the requested maximum size of the time window within which the user can seek within the streaming media.</summary>
    /// <returns>The requested maximum size of the time window in which the user can seek within the streaming media. This value must be between zero and the value of MaxSeekableWindowSize. If the specified value is greater than the maximum value, the system automatically clamps to the allowed range, but when you retrieve the property it will return the unclamped value.</returns>
    public extern IReference<TimeSpan> DesiredSeekableWindowSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides an event that is raised when diagnostic information about the adaptive media source is available.</summary>
    /// <returns>An object that provides an event that is raised when diagnostic information about the adaptive media source is available.</returns>
    public extern AdaptiveMediaSourceDiagnostics Diagnostics { [MethodImpl] get; }

    /// <summary>Gets an object that provides timing information that is correlated between timestamps in the media or date/time information from the manifest with the presentation clock timeline.</summary>
    /// <returns>An object that provides correlated timing information for the adaptive media source.</returns>
    [MethodImpl]
    public extern AdaptiveMediaSourceCorrelatedTimes GetCorrelatedTimes();

    [MethodImpl]
    public extern void Close();

    /// <summary>Determines whether the content type of the source is supported.</summary>
    /// <param name="contentType">A string that identifies the content type of the source. Can be a Http Live Streaming (HLS) or Dynamic Adaptive Streaming over HTTP (DASH) content type.</param>
    /// <returns>Returns a value that indicates whether the content type of the source is supported. **true** if supported; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool IsContentTypeSupported(string contentType);

    [Overload("CreateFromUriAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromUriAsync(
      Uri uri);

    [RemoteAsync]
    [Overload("CreateFromUriWithDownloaderAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromUriAsync(
      Uri uri,
      HttpClient httpClient);

    [RemoteAsync]
    [Overload("CreateFromStreamAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromStreamAsync(
      IInputStream stream,
      Uri uri,
      string contentType);

    [Overload("CreateFromStreamWithDownloaderAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AdaptiveMediaSourceCreationResult> CreateFromStreamAsync(
      IInputStream stream,
      Uri uri,
      string contentType,
      HttpClient httpClient);
  }
}
