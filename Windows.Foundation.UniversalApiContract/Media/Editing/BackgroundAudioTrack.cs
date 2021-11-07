// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.BackgroundAudioTrack
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;
using Windows.Storage;

namespace Windows.Media.Editing
{
  /// <summary>Represents a single audio track for accompanying a video clip.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBackgroundAudioTrackStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [GCPressure(amount = GCPressureAmount.High)]
  public sealed class BackgroundAudioTrack : IBackgroundAudioTrack
  {
    /// <summary>The amount of time to trim from the beginning of the background audio track.</summary>
    /// <returns>The trim time must be greater than or equal to 0 and less than the length of the background audio track.</returns>
    public extern TimeSpan TrimTimeFromStart { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The amount of time to trim from the end of the background audio track.</summary>
    /// <returns>The trim time must be greater than or equal to 0 and less than the length of the background audio track.</returns>
    public extern TimeSpan TrimTimeFromEnd { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Original playback time of the background audio track, without the effects of the TrimTimeFromStart and TrimTimeFromEnd properties.</summary>
    /// <returns>The original duration of the background audio track is equal to TrimmedDuration + TrimTimeFromStart + TrimTimeFromEnd.</returns>
    public extern TimeSpan OriginalDuration { [MethodImpl] get; }

    /// <summary>Duration of the background audio track with TrimTimeFromStart and TrimTimeFromEnd applied to playback.</summary>
    /// <returns>The trimmed duration of the background audio track is equal to OriginalDuration - (TrimTimeFromStart + TrimTimeFromEnd ).</returns>
    public extern TimeSpan TrimmedDuration { [MethodImpl] get; }

    /// <summary>An associative collection for storing custom properties associated with the background audio track.</summary>
    /// <returns>The values stored in the IMap must be strings. These values are app-defined and are not used by the operating system. You can use this collection to store, for example, a description of the background audio track.</returns>
    public extern IMap<string, string> UserData { [MethodImpl] get; }

    /// <summary>Specifies how long to wait before starting background audio playback.</summary>
    /// <returns>The length of time between the start of video playback and the start of background audio playback. This value can be negative to start background audio before video playback.</returns>
    public extern TimeSpan Delay { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the volume of the background audio track.</summary>
    /// <returns>A value between 0 and 1 represents a reduction in the volume level of the background audio track where 0 is silence and 1 is normal volume. A value greater than 1 represents a boost in the volume of the background audio track.</returns>
    public extern double Volume { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Creates a BackgroundAudioTrack object that is identical to this instance.</summary>
    /// <returns>A BackgroundAudioTrack object that is a copy of this instance.</returns>
    [MethodImpl]
    public extern BackgroundAudioTrack Clone();

    /// <summary>Gets the AudioEncodingProperties for the background audio track.</summary>
    /// <returns>The AudioEncodingProperties for the background audio track.</returns>
    [MethodImpl]
    public extern AudioEncodingProperties GetAudioEncodingProperties();

    /// <summary>Gets the list of audio effect definitions for processing the background audio track.</summary>
    /// <returns>The list of audio effect definitions for processing the background audio track.</returns>
    public extern IVector<IAudioEffectDefinition> AudioEffectDefinitions { [MethodImpl] get; }

    /// <summary>Creates a background audio track object with audio content copied from an embedded audio track object.</summary>
    /// <param name="embeddedAudioTrack">An embedded audio track to use as the source audio for the background audio track.</param>
    /// <returns>A new background audio track object containing audio content copied from the embedded audio track.</returns>
    [MethodImpl]
    public static extern BackgroundAudioTrack CreateFromEmbeddedAudioTrack(
      EmbeddedAudioTrack embeddedAudioTrack);

    /// <summary>Creates a background audio track from an audio file.</summary>
    /// <param name="file">A StorageFile object representing the source audio file.</param>
    /// <returns>A new background audio track object containing the contents of the audio file.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BackgroundAudioTrack> CreateFromFileAsync(
      IStorageFile file);
  }
}
