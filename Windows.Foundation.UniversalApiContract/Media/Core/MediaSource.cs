// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Frames;
using Windows.Media.Playback;
using Windows.Media.Streaming.Adaptive;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  /// <summary>Represents a media source. Provides a common way to reference media from different sources and exposes a common model for accessing media data regardless of the underlying media format.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaSourceStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IMediaSourceStatics4), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaSourceStatics3), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class MediaSource : 
    IMediaSource2,
    IClosable,
    IMediaPlaybackSource,
    IMediaSource3,
    IMediaSource4,
    IMediaSource5
  {
    /// <summary>Occurs when a MediaSource open operation completes.</summary>
    public extern event TypedEventHandler<MediaSource, MediaSourceOpenOperationCompletedEventArgs> OpenOperationCompleted;

    /// <summary>Gets a set of properties that can be used to associate app-specific data with a MediaSource.</summary>
    /// <returns>A set of properties that can be used to associate app-specific data with a MediaSource.</returns>
    public extern ValueSet CustomProperties { [MethodImpl] get; }

    /// <summary>Gets the duration of the content in the MediaSource.</summary>
    /// <returns>The duration of the content in the MediaSource.</returns>
    public extern IReference<TimeSpan> Duration { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the media source is currently open.</summary>
    /// <returns>True if the media source is open; otherwise, false.</returns>
    public extern bool IsOpen { [MethodImpl] get; }

    /// <summary>A collection of external timed text sources associated with the MediaSource.</summary>
    /// <returns>The collection of external timed text sources.</returns>
    public extern IObservableVector<TimedTextSource> ExternalTimedTextSources { [MethodImpl] get; }

    /// <summary>A collection of external timed metadata tracks associated with the MediaSource.</summary>
    /// <returns>The collection of external timed metadata tracks.</returns>
    public extern IObservableVector<TimedMetadataTrack> ExternalTimedMetadataTracks { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Occurs when the current state of the MediaSource changes.</summary>
    public extern event TypedEventHandler<MediaSource, MediaSourceStateChangedEventArgs> StateChanged;

    /// <summary>Gets the current state of the MediaSource.</summary>
    /// <returns>The current state of the MediaSource.</returns>
    public extern MediaSourceState State { [MethodImpl] get; }

    /// <summary>Resets the internal state of the MediaSource.</summary>
    [MethodImpl]
    public extern void Reset();

    /// <summary>Gets the AdaptiveMediaSource associated with the **MediaSource**.</summary>
    /// <returns>The AdaptiveMediaSource associated with the **MediaSource**.</returns>
    public extern AdaptiveMediaSource AdaptiveMediaSource { [MethodImpl] get; }

    /// <summary>Gets the MediaStreamSource associated with the **MediaSource**.</summary>
    /// <returns>The MediaStreamSource associated with the **MediaSource**.</returns>
    public extern MediaStreamSource MediaStreamSource { [MethodImpl] get; }

    /// <summary>Gets the MseStreamSource associated with the **MediaSource**.</summary>
    /// <returns>The MseStreamSource associated with the **MediaSource**.</returns>
    public extern MseStreamSource MseStreamSource { [MethodImpl] get; }

    /// <summary>Gets the URI associated with the **MediaSource**.</summary>
    /// <returns>The URI associated with the **MediaSource**.</returns>
    public extern Uri Uri { [MethodImpl] get; }

    /// <summary>opens the backing data source for the **MediaSource** and reads the metadata and track information.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction OpenAsync();

    /// <summary>Retrieves the DownloadOperation with which the **MediaSource** is associated</summary>
    /// <returns>
    /// </returns>
    public extern DownloadOperation DownloadOperation { [MethodImpl] get; }

    /// <summary>Creates an instance of MediaSource from the provided DownloadOperation.</summary>
    /// <param name="downloadOperation">The DownloadOperation from which the MediaSource is created.</param>
    /// <returns>The new media source.</returns>
    [MethodImpl]
    public static extern MediaSource CreateFromDownloadOperation(
      DownloadOperation downloadOperation);

    /// <summary>Creates an instance of MediaSource from the provided AdaptiveMediaSource.</summary>
    /// <param name="frameSource">The AdaptiveMediaSource from which the MediaSource is created.</param>
    /// <returns>The new media source.</returns>
    [MethodImpl]
    public static extern MediaSource CreateFromMediaFrameSource(
      MediaFrameSource frameSource);

    /// <summary>Creates an instance of MediaSource from the provided MediaBinder.</summary>
    /// <param name="binder">The MediaBinder with which the **MediaSource** is associated.</param>
    /// <returns>The new media source.</returns>
    [MethodImpl]
    public static extern MediaSource CreateFromMediaBinder(MediaBinder binder);

    /// <summary>Creates an instance of MediaSource from the provided AdaptiveMediaSource.</summary>
    /// <param name="mediaSource">The AdaptiveMediaSource from which the MediaSource is created.</param>
    /// <returns>The new media source.</returns>
    [MethodImpl]
    public static extern MediaSource CreateFromAdaptiveMediaSource(
      AdaptiveMediaSource mediaSource);

    /// <summary>Creates an instance of MediaSource from the provided MediaStreamSource.</summary>
    /// <param name="mediaSource">The MediaStreamSource from which the MediaSource is created.</param>
    /// <returns>The new media source.</returns>
    [MethodImpl]
    public static extern MediaSource CreateFromMediaStreamSource(
      MediaStreamSource mediaSource);

    /// <summary>Creates an instance of MediaSource from the provided MseStreamSource.</summary>
    /// <param name="mediaSource">The MediaStreamSource from which the MediaSource is created.</param>
    /// <returns>The new media source.</returns>
    [MethodImpl]
    public static extern MediaSource CreateFromMseStreamSource(
      MseStreamSource mediaSource);

    /// <summary>Creates an instance of MediaSource from the provided IMediaSource.</summary>
    /// <param name="mediaSource">The IMediaSource from which the MediaSource is created.</param>
    /// <returns>The new media source.</returns>
    [MethodImpl]
    public static extern MediaSource CreateFromIMediaSource(IMediaSource mediaSource);

    /// <summary>Creates an instance of MediaSource from the provided IStorageFile.</summary>
    /// <param name="file">The IStorageFile from which the MediaSource is created.</param>
    /// <returns>The new media source.</returns>
    [MethodImpl]
    public static extern MediaSource CreateFromStorageFile(IStorageFile file);

    /// <summary>Creates an instance of MediaSource from the provided IRandomAccessStream.</summary>
    /// <param name="stream">The stream from which the MediaSource is created.</param>
    /// <param name="contentType">The MIME type of the contents of the stream.</param>
    /// <returns>The new media source.</returns>
    [MethodImpl]
    public static extern MediaSource CreateFromStream(
      IRandomAccessStream stream,
      string contentType);

    /// <summary>Creates an instance of MediaSource from the provided IRandomAccessStreamReference.</summary>
    /// <param name="stream">The stream reference from which the MediaSource is created.</param>
    /// <param name="contentType">The MIME type of the contents of the stream.</param>
    /// <returns>The new media source.</returns>
    [MethodImpl]
    public static extern MediaSource CreateFromStreamReference(
      IRandomAccessStreamReference stream,
      string contentType);

    [MethodImpl]
    public static extern MediaSource CreateFromUri(Uri uri);
  }
}
