// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.VideoTrack
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  /// <summary>Represents a video track.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class VideoTrack : IMediaTrack, IVideoTrack
  {
    /// <summary>Gets the identifier for the video track.</summary>
    /// <returns>The identifier for the video track.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a string indicating the language of the video track.</summary>
    /// <returns>A string indicating the language of the video track.</returns>
    public extern string Language { [MethodImpl] get; }

    /// <summary>Gets a value indicating the type of data the track contains. For VideoTrack objects, this value is always MediaTrackKind.Video.</summary>
    /// <returns>A value indicating the type of data the track contains.</returns>
    public extern MediaTrackKind TrackKind { [MethodImpl] get; }

    /// <summary>Gets or sets the label for the video track.</summary>
    /// <returns>The label for the video track.</returns>
    public extern string Label { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs when a VideoTrack fails to open.</summary>
    public extern event TypedEventHandler<VideoTrack, VideoTrackOpenFailedEventArgs> OpenFailed;

    /// <summary>Gets the encoding properties for the VideoTrack.</summary>
    /// <returns>The encoding properties for the VideoTrack.</returns>
    [MethodImpl]
    public extern VideoEncodingProperties GetEncodingProperties();

    /// <summary>Gets the MediaPlaybackItem containing the VideoTrack.</summary>
    /// <returns>The MediaPlaybackItem containing the VideoTrack.</returns>
    public extern MediaPlaybackItem PlaybackItem { [MethodImpl] get; }

    /// <summary>Gets the name of the VideoTrack.</summary>
    /// <returns>The name of the VideoTrack.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets support information for the VideoTrack. This information includes the status of the video decoder and the status of the MediaSource with which the video track is associated.</summary>
    /// <returns>The support information for the VideoTrack.</returns>
    public extern VideoTrackSupportInfo SupportInfo { [MethodImpl] get; }
  }
}
