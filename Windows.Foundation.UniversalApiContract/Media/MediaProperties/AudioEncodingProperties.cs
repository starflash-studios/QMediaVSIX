// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.AudioEncodingProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Describes the encoding properties of an audio stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IAudioEncodingPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAudioEncodingPropertiesStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AudioEncodingProperties : 
    IAudioEncodingProperties,
    IMediaEncodingProperties,
    IAudioEncodingPropertiesWithFormatUserData,
    IAudioEncodingProperties2,
    IAudioEncodingProperties3
  {
    /// <summary>Creates a new instance of the AudioEncodingProperties class.</summary>
    [MethodImpl]
    public extern AudioEncodingProperties();

    /// <summary>Gets or sets the audio bit rate.</summary>
    /// <returns>The average bit rate of the audio stream, in bits per second.</returns>
    public extern uint Bitrate { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the number of audio channels.</summary>
    /// <returns>The number of audio channels.</returns>
    public extern uint ChannelCount { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets audio sampling rate.</summary>
    /// <returns>The number of audio samples per second.</returns>
    public extern uint SampleRate { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the number of bits per audio sample.</summary>
    /// <returns>The number of bits per audio sample.</returns>
    public extern uint BitsPerSample { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets additional format properties for the audio stream.</summary>
    /// <returns>A property set that contains format properties.</returns>
    public extern MediaPropertySet Properties { [MethodImpl] get; }

    /// <summary>Gets the format type.</summary>
    /// <returns>The format type. For audio streams, the format type is "Audio".</returns>
    public extern string Type { [MethodImpl] get; }

    /// <summary>Gets or sets the subtype of the format.</summary>
    /// <returns>The subtype.</returns>
    public extern string Subtype { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Sets the media format user data.</summary>
    /// <param name="value">The media data to set.</param>
    [MethodImpl]
    public extern void SetFormatUserData(byte[] value);

    /// <summary>Gets the media format user data.</summary>
    /// <param name="value">Receives the media format data.</param>
    [MethodImpl]
    public extern void GetFormatUserData(out byte[] value);

    /// <summary>Gets a value indicating whether the audio is encoded with spatial audio information.</summary>
    /// <returns>True if the audio is encoded with spatial audio information; otherwise, false.</returns>
    public extern bool IsSpatial { [MethodImpl] get; }

    /// <summary>Creates a copy of the **AudioEncodingProperties** object.</summary>
    /// <returns>A copy of the **AudioEncodingProperties** object.</returns>
    [MethodImpl]
    public extern AudioEncodingProperties Copy();

    /// <summary>Creates an instance of AudioEncodingProperties for Apple Lossless Audio Codec (ALAC) audio.</summary>
    /// <param name="sampleRate">The audio sampling rate.</param>
    /// <param name="channelCount">The number of audio channels.</param>
    /// <param name="bitsPerSample">The number of bits per sample.</param>
    /// <returns>The audio encoding properties.</returns>
    [MethodImpl]
    public static extern AudioEncodingProperties CreateAlac(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);

    /// <summary>Creates an instance of AudioEncodingProperties for Free Lossless Audio Codec (FLAC) audio.</summary>
    /// <param name="sampleRate">The audio sampling rate.</param>
    /// <param name="channelCount">The number of audio channels.</param>
    /// <param name="bitsPerSample">The number of bits per sample.</param>
    /// <returns>The audio encoding properties.</returns>
    [MethodImpl]
    public static extern AudioEncodingProperties CreateFlac(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);

    /// <summary>Creates an instance of AudioEncodingProperties for Advanced Audio Coding (AAC) audio.</summary>
    /// <param name="sampleRate">The audio sampling rate.</param>
    /// <param name="channelCount">The number of audio channels.</param>
    /// <param name="bitrate">The audio bit rate.</param>
    /// <returns>The audio encoding properties.</returns>
    [MethodImpl]
    public static extern AudioEncodingProperties CreateAac(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    /// <summary>Creates an instance of AudioEncodingProperties for Advanced Audio Coding (AAC) audio in Audio Data Transport Stream (ADTS) format.</summary>
    /// <param name="sampleRate">The audio sampling rate.</param>
    /// <param name="channelCount">The number of audio channels.</param>
    /// <param name="bitrate">The audio bit rate.</param>
    /// <returns>The audio encoding properties.</returns>
    [MethodImpl]
    public static extern AudioEncodingProperties CreateAacAdts(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    /// <summary>Creates an instance of AudioEncodingProperties for MPEG Audio Layer-3 (MP3) audio.</summary>
    /// <param name="sampleRate">The audio sampling rate.</param>
    /// <param name="channelCount">The number of audio channels.</param>
    /// <param name="bitrate">The audio bit rate.</param>
    /// <returns>The audio encoding properties.</returns>
    [MethodImpl]
    public static extern AudioEncodingProperties CreateMp3(
      uint sampleRate,
      uint channelCount,
      uint bitrate);

    /// <summary>Creates an instance of AudioEncodingProperties for Pulse Code Modulation (PCM) audio.</summary>
    /// <param name="sampleRate">The audio sampling rate.</param>
    /// <param name="channelCount">The number of audio channels.</param>
    /// <param name="bitsPerSample">The audio bit depth.</param>
    /// <returns>The audio encoding properties.</returns>
    [MethodImpl]
    public static extern AudioEncodingProperties CreatePcm(
      uint sampleRate,
      uint channelCount,
      uint bitsPerSample);

    /// <summary>Creates an instance of AudioEncodingProperties for Windows Media Audio (WMA).</summary>
    /// <param name="sampleRate">The audio sampling rate.</param>
    /// <param name="channelCount">The number of audio channels.</param>
    /// <param name="bitrate">The audio bit rate.</param>
    /// <returns>The audio encoding properties.</returns>
    [MethodImpl]
    public static extern AudioEncodingProperties CreateWma(
      uint sampleRate,
      uint channelCount,
      uint bitrate);
  }
}
