// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.MediaClip
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.UI;

namespace Windows.Media.Editing
{
  /// <summary>Represents a single media object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaClipStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [GCPressure(amount = GCPressureAmount.High)]
  [Static(typeof (IMediaClipStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaClip : IMediaClip
  {
    /// <summary>The amount of time to trim from the beginning of the media clip.</summary>
    /// <returns>The trim time must be greater than or equal to 0 and less than the length of the media clip.</returns>
    public extern TimeSpan TrimTimeFromStart { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The amount of time to trim from the end of the media clip.</summary>
    /// <returns>The trim time must be greater than or equal to 0 and less than the length of the media clip.</returns>
    public extern TimeSpan TrimTimeFromEnd { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Original playback time of the media clip, without the effects of TrimTimeFromStart and TrimTimeFromEnd properties.</summary>
    /// <returns>The original duration of the media clip is equal to TrimmedDuration + TrimTimeFromStart + TrimTimeFromEnd.</returns>
    public extern TimeSpan OriginalDuration { [MethodImpl] get; }

    /// <summary>Duration of the media clip with TrimTimeFromStart and TrimTimeFromEnd applied to playback.</summary>
    /// <returns>The trimmed duration of the media clip is equal to OriginalDuration - (TrimTimeFromStart + TrimTimeFromEnd ).</returns>
    public extern TimeSpan TrimmedDuration { [MethodImpl] get; }

    /// <summary>An associative collection for storing custom properties associated with the media clip.</summary>
    /// <returns>The values stored in the IMap must be strings. These values are app-defined and are not used by the operating system. You can use this collection to store, for example, a clip name, an application-related clip identifier, or a clip description.</returns>
    public extern IMap<string, string> UserData { [MethodImpl] get; }

    /// <summary>Creates a MediaClip object that is identical to this instance.</summary>
    /// <returns>A MediaClip object that is a copy of this instance.</returns>
    [MethodImpl]
    public extern MediaClip Clone();

    /// <summary>The time when the media clip starts playing within a MediaComposition.</summary>
    /// <returns>Time is measured relative to the beginning of the media clip.</returns>
    public extern TimeSpan StartTimeInComposition { [MethodImpl] get; }

    /// <summary>The time when the media clip stops playing within a MediaComposition.</summary>
    /// <returns>Time is measured relative to the beginning of the media clip.</returns>
    public extern TimeSpan EndTimeInComposition { [MethodImpl] get; }

    /// <summary>The list of embedded audio tracks in this media clip.</summary>
    /// <returns>Each member in the list is an EmbeddedAudioTrack object.</returns>
    public extern IVectorView<EmbeddedAudioTrack> EmbeddedAudioTracks { [MethodImpl] get; }

    /// <summary>The index of the audio track within the media clip that is used for playback.</summary>
    /// <returns>The default value of 0 selects the first audio track within the media clip.</returns>
    public extern uint SelectedEmbeddedAudioTrackIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the volume of the media clip.</summary>
    /// <returns>A value between 0 and 1 represents a reduction in the volume level of the media clip where 0 is silence and 1 is normal volume. A value greater than 1 represents a boost in the volume of the media clip.</returns>
    public extern double Volume { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the VideoEncodingProperties for the media clip.</summary>
    /// <returns>The VideoEncodingProperties for the media clip.</returns>
    [MethodImpl]
    public extern VideoEncodingProperties GetVideoEncodingProperties();

    /// <summary>Gets the list of audio effect definitions for processing the media clip.</summary>
    /// <returns>The list of audio effect definitions for processing the media clip.</returns>
    public extern IVector<IAudioEffectDefinition> AudioEffectDefinitions { [MethodImpl] get; }

    /// <summary>Gets the list of video effect definitions for processing the media clip.</summary>
    /// <returns>The list of video effect definitions for processing the media clip.</returns>
    public extern IVector<IVideoEffectDefinition> VideoEffectDefinitions { [MethodImpl] get; }

    [MethodImpl]
    public static extern MediaClip CreateFromSurface(
      IDirect3DSurface surface,
      TimeSpan originalDuration);

    [MethodImpl]
    public static extern MediaClip CreateFromColor(Color color, TimeSpan originalDuration);

    /// <summary>Creates a video clip from a video file.</summary>
    /// <param name="file">A StorageFile object representing the source video file.</param>
    /// <returns>A new media clip object containing a video clip of the video file.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaClip> CreateFromFileAsync(
      IStorageFile file);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaClip> CreateFromImageFileAsync(
      IStorageFile file,
      TimeSpan originalDuration);
  }
}
