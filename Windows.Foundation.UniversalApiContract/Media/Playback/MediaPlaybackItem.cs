// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  /// <summary>Represents a media item that can be played back. This class acts as a wrapper around a MediaSource that exposes the audio tracks, video tracks, and timed metadata tracks included in the media source.</summary>
  [Activatable(typeof (IMediaPlaybackItemFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IMediaPlaybackItemFactory2), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMediaPlaybackItemStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class MediaPlaybackItem : 
    IMediaPlaybackItem,
    IMediaPlaybackSource,
    IMediaPlaybackItem2,
    IMediaPlaybackItem3
  {
    [MethodImpl]
    public extern MediaPlaybackItem(MediaSource source, TimeSpan startTime);

    [MethodImpl]
    public extern MediaPlaybackItem(MediaSource source, TimeSpan startTime, TimeSpan durationLimit);

    /// <summary>Initializes a new instance of the MediaPlaybackItem class.</summary>
    /// <param name="source">The media source from which the MediaPlaybackItem is created.</param>
    [MethodImpl]
    public extern MediaPlaybackItem(MediaSource source);

    /// <summary>Occurs when the list of audio tracks in the MediaSource associated with the MediaPlaybackItem changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> AudioTracksChanged;

    /// <summary>Occurs when the list of video tracks in the MediaSource associated with the MediaPlaybackItem changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> VideoTracksChanged;

    /// <summary>Occurs when the list of timed metadata tracks in the MediaSource associated with the MediaPlaybackItem changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> TimedMetadataTracksChanged;

    /// <summary>Gets the MediaSource object associated with the MediaPlaybackItem.</summary>
    /// <returns>The MediaSource object associated with the MediaPlaybackItem.</returns>
    public extern MediaSource Source { [MethodImpl] get; }

    /// <summary>Gets a read-only list of audio tracks in the MediaSource associated with the MediaPlaybackItem.</summary>
    /// <returns>The read-only list of audio tracks.</returns>
    public extern MediaPlaybackAudioTrackList AudioTracks { [MethodImpl] get; }

    /// <summary>Gets a read-only list of video tracks in the MediaSource associated with the MediaPlaybackItem.</summary>
    /// <returns>The read-only list of video tracks.</returns>
    public extern MediaPlaybackVideoTrackList VideoTracks { [MethodImpl] get; }

    /// <summary>Gets a read-only list of timed metadata tracks in the MediaSource associated with the MediaPlaybackItem.</summary>
    /// <returns>The read-only list of timed metadata tracks.</returns>
    public extern MediaPlaybackTimedMetadataTrackList TimedMetadataTracks { [MethodImpl] get; }

    /// <summary>Gets the MediaBreakSchedule defining the schedule of media breaks for the MediaPlaybackItem.</summary>
    /// <returns>The MediaBreakSchedule defining the schedule of media breaks for the MediaPlaybackItem.</returns>
    public extern MediaBreakSchedule BreakSchedule { [MethodImpl] get; }

    /// <summary>Gets the position within the MediaPlaybackItem where playback should begin.</summary>
    /// <returns>The position within the MediaPlaybackItem where playback should begin.</returns>
    public extern TimeSpan StartTime { [MethodImpl] get; }

    /// <summary>Gets the maximum playback duration of the MediaPlaybackItem.</summary>
    /// <returns>The maximum playback duration of the MediaPlaybackItem.</returns>
    public extern IReference<TimeSpan> DurationLimit { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether the MediaPlaybackItem can be skipped.</summary>
    /// <returns>True if the MediaPlaybackItem can be skipped; otherwise, false.</returns>
    public extern bool CanSkip { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the display properties for a MediaPlaybackItem.</summary>
    /// <returns>The display properties for a MediaPlaybackItem.</returns>
    [MethodImpl]
    public extern MediaItemDisplayProperties GetDisplayProperties();

    /// <summary>Updates the display properties for the MediaPlaybackItem. These properties are used by the System Media Transport Controls to display information about the currently playing media item.</summary>
    /// <param name="value">The display properties to apply to the MediaPlaybackItem.</param>
    [MethodImpl]
    public extern void ApplyDisplayProperties(MediaItemDisplayProperties value);

    /// <summary>Gets or sets a value that specifies whether a MediaPlaybackItem is disabled in a MediaPlaybackList.</summary>
    /// <returns>True if the media playback item is disabled in the playback list; otherwise, false.</returns>
    public extern bool IsDisabledInPlaybackList { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates the proportion of the data for the **MediaPlaybackItem** that is currently downloaded.</summary>
    /// <returns>A value, between 0 and 1.0, that indicates the total download progress of the **MediaPlaybackItem** where 0 means that none of the data has been downloaded and 1.0 means that all of the data has been downloaded.</returns>
    public extern double TotalDownloadProgress { [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies for which types of media content, if any, the system should automatically load metadata to display in the System Media Transport Controls.</summary>
    /// <returns>A value that specifies for which types of media content the system should automatically load and display metadata.</returns>
    public extern AutoLoadedDisplayPropertyKind AutoLoadedDisplayProperties { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Retrieves the MediaPlaybackItem associated with the provided MediaSource.</summary>
    /// <param name="source">The MediaSource associated with the MediaPlaybackItem.</param>
    /// <returns>The MediaPlaybackItem associated with the provided MediaSource.</returns>
    [MethodImpl]
    public static extern MediaPlaybackItem FindFromMediaSource(MediaSource source);
  }
}
