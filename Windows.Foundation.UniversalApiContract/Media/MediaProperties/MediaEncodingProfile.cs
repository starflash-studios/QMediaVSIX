// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.MediaEncodingProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.MediaProperties
{
  /// <summary>Describes the encoding profile for an audio or video file. The encoding profile includes descriptions of the audio and video encoding formats, and a description of the media container.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMediaEncodingProfileStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaEncodingProfileStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IMediaEncodingProfileStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MediaEncodingProfile : 
    IMediaEncodingProfile,
    IMediaEncodingProfile2,
    IMediaEncodingProfile3
  {
    /// <summary>Creates a new instance of the MediaEncodingProfile class.</summary>
    [MethodImpl]
    public extern MediaEncodingProfile();

    /// <summary>Gets or sets the encoding properties for the audio stream.</summary>
    /// <returns>The encoding properties of the audio stream. If the profile does not contain an audio stream, the value is **null**.</returns>
    public extern AudioEncodingProperties Audio { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the encoding properties for the video stream.</summary>
    /// <returns>The encoding properties of the video stream. If the profile does not contain a video stream, the value is **null**.</returns>
    public extern VideoEncodingProperties Video { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the properties of the media container.</summary>
    /// <returns>The properties of the media container.</returns>
    public extern ContainerEncodingProperties Container { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void SetAudioTracks(IIterable<AudioStreamDescriptor> value);

    /// <summary>Retrieves the list of AudioStreamDescriptor objects describing the audio streams included in the **MediaEncodingProfile**.</summary>
    /// <returns>A list of AudioStreamDescriptor objects.</returns>
    [MethodImpl]
    public extern IVector<AudioStreamDescriptor> GetAudioTracks();

    [MethodImpl]
    public extern void SetVideoTracks(IIterable<VideoStreamDescriptor> value);

    /// <summary>Retrieves the list of VideoStreamDescriptor objects describing the video streams included in the **MediaEncodingProfile**.</summary>
    /// <returns>A list of VideoStreamDescriptor objects.</returns>
    [MethodImpl]
    public extern IVector<VideoStreamDescriptor> GetVideoTracks();

    [MethodImpl]
    public extern void SetTimedMetadataTracks(IIterable<TimedMetadataStreamDescriptor> value);

    /// <summary>Retrieves the list of TimedMetadataStreamDescriptor objects describing the timed metadata streams included in the **MediaEncodingProfile**.</summary>
    /// <returns>A list of TimedMetadataStreamDescriptor objects.</returns>
    [MethodImpl]
    public extern IVector<TimedMetadataStreamDescriptor> GetTimedMetadataTracks();

    /// <summary>Creates an instance of MediaEncodingProfile for Apple Lossless Audio Codec (ALAC) audio.</summary>
    /// <param name="quality">The ecoding quality.</param>
    /// <returns>The media encoding profile.</returns>
    [MethodImpl]
    public static extern MediaEncodingProfile CreateAlac(
      AudioEncodingQuality quality);

    /// <summary>Creates an instance of MediaEncodingProfile for Free Lossless Audio Codec (FLAC) audio.</summary>
    /// <param name="quality">The ecoding quality.</param>
    /// <returns>The media encoding profile.</returns>
    [MethodImpl]
    public static extern MediaEncodingProfile CreateFlac(
      AudioEncodingQuality quality);

    /// <summary>Creates an instance of MediaEncodingProfile for High Efficiency Video Coding (HEVC) video, also known as H.265 video.</summary>
    /// <param name="quality">The video quality.</param>
    /// <returns>The media encoding profile.</returns>
    [MethodImpl]
    public static extern MediaEncodingProfile CreateHevc(
      VideoEncodingQuality quality);

    /// <summary>Creates an instance of MediaEncodingProfile for WAV</summary>
    /// <param name="quality">The audio encoding quality.</param>
    /// <returns>The media encoding profile.</returns>
    [MethodImpl]
    public static extern MediaEncodingProfile CreateWav(
      AudioEncodingQuality quality);

    /// <summary>Creates an instance of MediaEncodingProfile for AVI.</summary>
    /// <param name="quality">The video quality.</param>
    /// <returns>The media encoding profile.</returns>
    [MethodImpl]
    public static extern MediaEncodingProfile CreateAvi(
      VideoEncodingQuality quality);

    /// <summary>Creates an encoding profile for AAC audio.</summary>
    /// <param name="quality">Specifies whether to create a profile with a low bit rate, medium bit rate, or high bit rate.</param>
    /// <returns>Returns a media encoding profile.</returns>
    [MethodImpl]
    public static extern MediaEncodingProfile CreateM4a(
      AudioEncodingQuality quality);

    /// <summary>Creates an encoding profile for MP3 (MPEG-1 layer 3) audio.</summary>
    /// <param name="quality">Specifies whether to create a profile with a low bit rate, medium bit rate, or high bit rate.</param>
    /// <returns>Returns a media encoding profile.</returns>
    [MethodImpl]
    public static extern MediaEncodingProfile CreateMp3(
      AudioEncodingQuality quality);

    /// <summary>Creates an encoding profile for Windows Media Audio (WMA).</summary>
    /// <param name="quality">Specifies whether to create a profile with a low bit rate, medium bit rate, or high bit rate.</param>
    /// <returns>Returns a media encoding profile.</returns>
    [MethodImpl]
    public static extern MediaEncodingProfile CreateWma(
      AudioEncodingQuality quality);

    /// <summary>Creates an encoding profile for H.264 video.</summary>
    /// <param name="quality">Specifies the video resolution of the profile.</param>
    /// <returns>Returns a media encoding profile.</returns>
    [MethodImpl]
    public static extern MediaEncodingProfile CreateMp4(
      VideoEncodingQuality quality);

    /// <summary>Creates an encoding profile for Windows Media Video (WMV).</summary>
    /// <param name="quality">Specifies the video resolution of the profile.</param>
    /// <returns>Returns a media encoding profile.</returns>
    [MethodImpl]
    public static extern MediaEncodingProfile CreateWmv(
      VideoEncodingQuality quality);

    /// <summary>Creates an encoding profile from an existing media file.</summary>
    /// <param name="file">The media file from which to create the profile.</param>
    /// <returns>An object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaEncodingProfile> CreateFromFileAsync(
      IStorageFile file);

    /// <summary>Creates an encoding profile from a stream that contains media data.</summary>
    /// <param name="stream">The media stream from which to create the profile.</param>
    /// <returns>An object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaEncodingProfile> CreateFromStreamAsync(
      IRandomAccessStream stream);
  }
}
