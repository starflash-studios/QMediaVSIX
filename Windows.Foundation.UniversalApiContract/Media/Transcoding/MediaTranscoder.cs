// Decompiled with JetBrains decompiler
// Type: Windows.Media.Transcoding.MediaTranscoder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Transcoding
{
  /// <summary>Transcodes audio and video files.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class MediaTranscoder : IMediaTranscoder, IMediaTranscoder2
  {
    /// <summary>Creates a new instance of the MediaTranscoder class.</summary>
    [MethodImpl]
    public extern MediaTranscoder();

    /// <summary>Gets or sets the time interval to trim from the start of the output.</summary>
    /// <returns>A TimeSpan structure that contains the time interval.</returns>
    public extern TimeSpan TrimStartTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the time interval to trim from the end of the output.</summary>
    /// <returns>A TimeSpan structure that contains the time interval.</returns>
    public extern TimeSpan TrimStopTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Specifies whether the media transcoder always re-encodes the source.</summary>
    /// <returns>**true** if the media transcoder always re-encodes the source; otherwise **false**. The default value is **false**.</returns>
    public extern bool AlwaysReencode { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Specifies whether hardware acceleration is enabled.</summary>
    /// <returns>Set to **true** if enabled, otherwise **false**.</returns>
    public extern bool HardwareAccelerationEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Adds the specified audio effect.</summary>
    /// <param name="activatableClassId">The identifier of the audio effect.</param>
    [Overload("AddAudioEffect")]
    [MethodImpl]
    public extern void AddAudioEffect(string activatableClassId);

    /// <summary>Adds the specified audio effect with configuration properties, and indicates whether the effect is required.</summary>
    /// <param name="activatableClassId">The identifier of the audio effect.</param>
    /// <param name="effectRequired">Indicates whether the audio effect is required.</param>
    /// <param name="configuration">Configuration properties for the audio effect.</param>
    [Overload("AddAudioEffectWithSettings")]
    [MethodImpl]
    public extern void AddAudioEffect(
      string activatableClassId,
      bool effectRequired,
      IPropertySet configuration);

    /// <summary>Adds the specified video effect.</summary>
    /// <param name="activatableClassId">The identifier of the video effect.</param>
    [Overload("AddVideoEffect")]
    [MethodImpl]
    public extern void AddVideoEffect(string activatableClassId);

    /// <summary>Adds the specified video effect with configuration properties and indicates whether the effect is required.</summary>
    /// <param name="activatableClassId">The identifier of the video effect.</param>
    /// <param name="effectRequired">Indicates whether the video effect is required.</param>
    /// <param name="configuration">Configuration properties for the video effect.</param>
    [Overload("AddVideoEffectWithSettings")]
    [MethodImpl]
    public extern void AddVideoEffect(
      string activatableClassId,
      bool effectRequired,
      IPropertySet configuration);

    /// <summary>Removes all audio and video effects from the transcode session.</summary>
    [MethodImpl]
    public extern void ClearEffects();

    /// <summary>Asynchronously initializes the trancode operation on the specified file and returns a PrepareTranscodeResult object which can be used to start the transcode operation.</summary>
    /// <param name="source">The source file.</param>
    /// <param name="destination">The destination file.</param>
    /// <param name="profile">The profile to use for the operation.</param>
    /// <returns>When this method completes, a PrepareTranscodeResult object is returned which can be used to start the transcode.</returns>
    [MethodImpl]
    public extern IAsyncOperation<PrepareTranscodeResult> PrepareFileTranscodeAsync(
      IStorageFile source,
      IStorageFile destination,
      MediaEncodingProfile profile);

    /// <summary>Asynchronously initializes the trancode operation on the specified stream and returns a PrepareTranscodeResult object which can be used to start the transcode operation.</summary>
    /// <param name="source">The source stream.</param>
    /// <param name="destination">The destination stream.</param>
    /// <param name="profile">The profile to use for the operation.</param>
    /// <returns>When this method completes, a PrepareTranscodeResult object is returned which can be used to start the transcode.</returns>
    [MethodImpl]
    public extern IAsyncOperation<PrepareTranscodeResult> PrepareStreamTranscodeAsync(
      IRandomAccessStream source,
      IRandomAccessStream destination,
      MediaEncodingProfile profile);

    /// <summary>Asynchronously initializes the trancode operation on the specified media source and returns a PrepareTranscodeResult object which can be used to start the transcode operation.</summary>
    /// <param name="source">The media source to perform the transcode operation on.</param>
    /// <param name="destination">The destination stream for the transcoded media data.</param>
    /// <param name="profile">The profile to use for the operation.</param>
    /// <returns>When this method completes, a PrepareTranscodeResult object is returned which can be used to start the transcode.</returns>
    [MethodImpl]
    public extern IAsyncOperation<PrepareTranscodeResult> PrepareMediaStreamSourceTranscodeAsync(
      IMediaSource source,
      IRandomAccessStream destination,
      MediaEncodingProfile profile);

    /// <summary>Gets or sets the video processing algorithm which will be used for transcoding.</summary>
    /// <returns>The video processing algorithm.</returns>
    public extern MediaVideoProcessingAlgorithm VideoProcessingAlgorithm { [MethodImpl] set; [MethodImpl] get; }
  }
}
