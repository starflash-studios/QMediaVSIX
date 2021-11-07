// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.AudioTrack
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
  /// <summary>Represents an audio track.</summary>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AudioTrack : IMediaTrack, IAudioTrack
  {
    /// <summary>Gets the identifier for the audio track.</summary>
    /// <returns>The identifier for the audio track.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a string indicating the language of the audio track.</summary>
    /// <returns>A string indicating the language of the audio track.</returns>
    public extern string Language { [MethodImpl] get; }

    /// <summary>Gets a value indicating the type of data the track contains. For AudioTrack objects, this value is always MediaTrackKind.Audio.</summary>
    /// <returns>A value indicating the type of data the track contains.</returns>
    public extern MediaTrackKind TrackKind { [MethodImpl] get; }

    /// <summary>Gets or sets the label for the audio track.</summary>
    /// <returns>The label for the audio track.</returns>
    public extern string Label { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs when an AudioTrack fails to open.</summary>
    public extern event TypedEventHandler<AudioTrack, AudioTrackOpenFailedEventArgs> OpenFailed;

    /// <summary>Gets the audio encoding properties for an AudioTrack.</summary>
    /// <returns>The audio encoding properties of the AudioTrack.</returns>
    [MethodImpl]
    public extern AudioEncodingProperties GetEncodingProperties();

    /// <summary>Gets the MediaPlaybackItem containing the AudioTrack.</summary>
    /// <returns>The MediaPlaybackItem containing the AudioTrack.</returns>
    public extern MediaPlaybackItem PlaybackItem { [MethodImpl] get; }

    /// <summary>Gets the name of the AudioTrack.</summary>
    /// <returns>The name of the AudioTrack.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets support information for the AudioTrack. This information includes the status of the audio decoder, information about any audio degradation applied by the decoder, and the status of the MediaSource with which the audio track is associated.</summary>
    /// <returns>The support information for the AudioTrack.</returns>
    public extern AudioTrackSupportInfo SupportInfo { [MethodImpl] get; }
  }
}
