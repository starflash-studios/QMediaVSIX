// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedMetadataTrack
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  /// <summary>Represents a timed metadata track. The track contains a list of IMediaCue objects and raises events at the beginning and end of the time window of each cue.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ITimedMetadataTrackFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TimedMetadataTrack : ITimedMetadataTrack, IMediaTrack, ITimedMetadataTrack2
  {
    /// <summary>Initializes a new instance of the TimedMetadataTrack class.</summary>
    /// <param name="id">An identifier for the new timed metadata track.</param>
    /// <param name="language">A string indicating the language of the new timed metadata track.</param>
    /// <param name="kind">A value indicating the kind of metadata contained in the new track.</param>
    [MethodImpl]
    public extern TimedMetadataTrack(string id, string language, TimedMetadataKind kind);

    /// <summary>Occurs when a media time window of a media cue is entered. The time window is defined by the StartTime and Duration of the cue.</summary>
    public extern event TypedEventHandler<TimedMetadataTrack, MediaCueEventArgs> CueEntered;

    /// <summary>Occurs when a media time window of a media cue is exited. The time window is defined by the StartTime and Duration of the cue.</summary>
    public extern event TypedEventHandler<TimedMetadataTrack, MediaCueEventArgs> CueExited;

    /// <summary>Raised when an error occurs with the TimedMetadataTrack.</summary>
    public extern event TypedEventHandler<TimedMetadataTrack, TimedMetadataTrackFailedEventArgs> TrackFailed;

    /// <summary>Gets a read-only list of the media cues in the TimedMetadataTrack.</summary>
    /// <returns>A read-only list of the media cues in the timed metadata track.</returns>
    public extern IVectorView<IMediaCue> Cues { [MethodImpl] get; }

    /// <summary>Gets the list of media cues in the TimedMetadataTrack that are currently active. A cue is considered active after its StartTime has been reached until its Duration has been exceeded.</summary>
    /// <returns>The list of media cues in the TimedMetadataTrack that are currently active.</returns>
    public extern IVectorView<IMediaCue> ActiveCues { [MethodImpl] get; }

    /// <summary>Gets a value indicating the kind of metadata contained in the track.</summary>
    /// <returns>A value indicating the kind of metadata contained in the track.</returns>
    public extern TimedMetadataKind TimedMetadataKind { [MethodImpl] get; }

    /// <summary>Gets the custom string value containing routing information for cues.</summary>
    /// <returns>The custom string value containing routing information for cues.</returns>
    public extern string DispatchType { [MethodImpl] get; }

    /// <summary>Adds the specified media cue to the TimedMetadataTrack.</summary>
    /// <param name="cue">The media cue to add.</param>
    [MethodImpl]
    public extern void AddCue(IMediaCue cue);

    /// <summary>Removes the specified media cue from the TimedMetadataTrack.</summary>
    /// <param name="cue">The media cue to remove.</param>
    [MethodImpl]
    public extern void RemoveCue(IMediaCue cue);

    /// <summary>Gets the identifier for the timed metadata track.</summary>
    /// <returns>The identifier for the track.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a string indicating the language of the timed metadata track.</summary>
    /// <returns>A string indicating the language of the timed metadata track.</returns>
    public extern string Language { [MethodImpl] get; }

    /// <summary>Gets a value specifying the type of the media track. For TimedMetadataTrack this value will always be MediaTrackKind.TimedMetadata.</summary>
    /// <returns>A value specifying the type of the media track.</returns>
    public extern MediaTrackKind TrackKind { [MethodImpl] get; }

    /// <summary>Gets or sets the label for the timed metadata track.</summary>
    /// <returns>The label for the timed metadata track.</returns>
    public extern string Label { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the MediaPlaybackItem containing the TimedMetadataTrack.</summary>
    /// <returns>The MediaPlaybackItem containing the TimedMetadataTrack.</returns>
    public extern MediaPlaybackItem PlaybackItem { [MethodImpl] get; }

    /// <summary>Gets the name of the TimedMetadataTrack.</summary>
    /// <returns>The name of the TimedMetadataTrack.</returns>
    public extern string Name { [MethodImpl] get; }
  }
}
