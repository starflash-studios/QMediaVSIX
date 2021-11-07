// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.CodecSubtypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides properties for most supported media subtypes that return the string representation of the GUID for the subtype. Use these property values to filter a query performed with CodecQuery.FindAllAsync. You can also compare the values returned by these properties to the values in the Subtypes collection of a CodecInfo object to determine if a codec supports a particular media subtype.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (ICodecSubtypesStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class CodecSubtypes
  {
    /// <summary>Gets the string representation of the GUID for the DVCPRO 25 (525-60 or 625-50) video subtype.</summary>
    /// <returns>The string representation of the GUID for the DVCPRO 25 (525-60 or 625-50) video subtype.</returns>
    public static extern string VideoFormatDV25 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the DVCPRO 50 (525-60 or 625-50) video subtype.</summary>
    /// <returns>The string representation of the GUID for the DVCPRO 50 (525-60 or 625-50) video subtype.</returns>
    public static extern string VideoFormatDV50 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the DVC/DV Video video subtype.</summary>
    /// <returns>The string representation of the GUID for the DVC/DV Video video subtype.</returns>
    public static extern string VideoFormatDvc { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the DVCPRO 100 (1080/60i, 1080/50i, or 720/60P) video subtype.</summary>
    /// <returns>The string representation of the GUID for the DVCPRO 100 (1080/60i, 1080/50i, or 720/60P) video subtype.</returns>
    public static extern string VideoFormatDvh1 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the HD-DVCR (1125-60 or 1250-50) video subtype.</summary>
    /// <returns>The string representation of the GUID for the HD-DVCR (1125-60 or 1250-50) video subtype.</returns>
    public static extern string VideoFormatDvhD { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the SDL-DVCR (525-60 or 625-50) video subtype.</summary>
    /// <returns>The string representation of the GUID for the SDL-DVCR (525-60 or 625-50) video subtype.</returns>
    public static extern string VideoFormatDvsd { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the SD-DVCR (525-60 or 625-50) video subtype.</summary>
    /// <returns>The string representation of the GUID for the SD-DVCR (525-60 or 625-50) video subtype.</returns>
    public static extern string VideoFormatDvsl { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the H.263 video subtype.</summary>
    /// <returns>The string representation of the GUID for the H.263 video subtype.</returns>
    public static extern string VideoFormatH263 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the H.264 video subtype.</summary>
    /// <returns>The string representation of the GUID for the H.264 video subtype.</returns>
    public static extern string VideoFormatH264 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the H.265 video subtype.</summary>
    /// <returns>The string representation of the GUID for the H.265 video subtype.</returns>
    public static extern string VideoFormatH265 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the H.264 elementary stream video subtype.</summary>
    /// <returns>The string representation of the GUID for the H.264 elementary stream video subtype.</returns>
    public static extern string VideoFormatH264ES { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the High Efficiency Video Coding (HEVC) Main profile and Main Still Picture profile video subtype.</summary>
    /// <returns>The string representation of the GUID for the High Efficiency Video Coding (HEVC) Main profile and Main Still Picture profile video subtype.</returns>
    public static extern string VideoFormatHevc { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the High Efficiency Video Coding Elementary Stream (HEVC-ES) profile video subtype.</summary>
    /// <returns>The string representation of the GUID for the High Efficiency Video Coding Elementary Stream (HEVC-ES) profile video subtype.</returns>
    public static extern string VideoFormatHevcES { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the MPEG-4 part 2 video subtype.</summary>
    /// <returns>The string representation of the GUID for the MPEG-4 part 2 video subtype.</returns>
    public static extern string VideoFormatM4S2 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Motion JPEG video subtype.</summary>
    /// <returns>The string representation of the GUID for the Motion JPEG video subtype.</returns>
    public static extern string VideoFormatMjpg { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Microsoft MPEG 4 codec version 3 video subtype.</summary>
    /// <returns>The string representation of the GUID for the Microsoft MPEG 4 codec version 3 video subtype.</returns>
    public static extern string VideoFormatMP43 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the ISO MPEG 4 codec version 1 video subtype.</summary>
    /// <returns>The string representation of the GUID for the ISO MPEG 4 codec version 1 video subtype.</returns>
    public static extern string VideoFormatMP4S { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the MPEG-4 part 2 video subtype.</summary>
    /// <returns>The string representation of the GUID for the MPEG-4 part 2 video subtype.</returns>
    public static extern string VideoFormatMP4V { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the MPEG-2 video subtype.</summary>
    /// <returns>The string representation of the GUID for the MPEG-2 video subtype.</returns>
    public static extern string VideoFormatMpeg2 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the VP8 video subtype.</summary>
    /// <returns>The string representation of the GUID for the VP8 video subtype.</returns>
    public static extern string VideoFormatVP80 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the VP9 video subtype.</summary>
    /// <returns>The string representation of the GUID for the VP9 video subtype.</returns>
    public static extern string VideoFormatVP90 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the MPEG-1 video subtype.</summary>
    /// <returns>The string representation of the GUID for the MPEG-1 video subtype.</returns>
    public static extern string VideoFormatMpg1 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Windows Media Screen codec version 1 video subtype.</summary>
    /// <returns>The string representation of the GUID for the Windows Media Screen codec version 1 video subtype.</returns>
    public static extern string VideoFormatMss1 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Windows Media Video 9 Screen codec video subtype.</summary>
    /// <returns>The string representation of the GUID for the Windows Media Video 9 Screen codec video subtype.</returns>
    public static extern string VideoFormatMss2 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Windows Media Video codec version 7 video subtype.</summary>
    /// <returns>The string representation of the GUID for the Windows Media Video codec version 7 video subtype.</returns>
    public static extern string VideoFormatWmv1 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Windows Media Video 8 video subtype.</summary>
    /// <returns>The string representation of the GUID for the Windows Media Video 8 video subtype.</returns>
    public static extern string VideoFormatWmv2 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Windows Media Video 9 video subtype.</summary>
    /// <returns>The string representation of the GUID for the Windows Media Video 9 video subtype.</returns>
    public static extern string VideoFormatWmv3 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the SMPTE 421M (VC-1). video subtype.</summary>
    /// <returns>The string representation of the GUID for the SMPTE 421M (VC-1). video subtype.</returns>
    public static extern string VideoFormatWvc1 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the 8-bit per channel planar YUV 4:2:0 video subtype.</summary>
    /// <returns>The string representation of the GUID for the 8-bit per channel planar YUV 4:2:0 video subtype.</returns>
    public static extern string VideoFormat420O { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Advanced Audio Coding (AAC) audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Advanced Audio Coding (AAC) audio subtype.</returns>
    public static extern string AudioFormatAac { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Audio Data Transport Stream (ADTS) audio subtype.</summary>
    /// <returns>Tne string representation of the GUID for the Audio Data Transport Stream (ADTS) audio subtype.</returns>
    public static extern string AudioFormatAdts { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Apple Lossless Audio Codec (ALAC) audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Apple Lossless Audio Codec (ALAC) audio subtype.</returns>
    public static extern string AudioFormatAlac { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Adaptive Multi-Rate (AMR-NB) audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Adaptive Multi-Rate (AMR-NB) audio subtype.</returns>
    public static extern string AudioFormatAmrNB { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Adaptive Multi-Rate Wideband (AMR-WB) audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Adaptive Multi-Rate Wideband (AMR-WB) audio subtype.</returns>
    public static extern string AudioFormatAmrWB { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Adaptive Multi-Rate (AMR-WP) audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Adaptive Multi-Rate (AMR-WP) audio subtype.</returns>
    public static extern string AudioFormatAmrWP { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Dolby Digital Audio Coding 3 (AC-3) audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Dolby Digital Audio Coding 3 (AC-3) audio subtype.</returns>
    public static extern string AudioFormatDolbyAC3 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Dolby AC-3 audio over Sony/Philips Digital Interface (S/PDIF) audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Dolby AC-3 audio over Sony/Philips Digital Interface (S/PDIF) audio subtype.</returns>
    public static extern string AudioFormatDolbyAC3Spdif { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Dolby Digital Plus (DD Plus) audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Dolby Digital Plus (DD Plus) audio subtype.</returns>
    public static extern string AudioFormatDolbyDDPlus { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the encrypted audio data used with secure audio path audio subtype.</summary>
    /// <returns>The string representation of the GUID for the encrypted audio data used with secure audio path audio subtype.</returns>
    public static extern string AudioFormatDrm { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Digital Theater Systems (DTS) audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Digital Theater Systems (DTS) audio subtype.</returns>
    public static extern string AudioFormatDts { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Free Lossless Audio Codec (FLAC) audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Free Lossless Audio Codec (FLAC) audio subtype.</returns>
    public static extern string AudioFormatFlac { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the uncompressed IEEE floating-point audio subtype.</summary>
    /// <returns>The string representation of the GUID for the uncompressed IEEE floating-point audio subtype.</returns>
    public static extern string AudioFormatFloat { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the MPEG Audio Layer-3 (MP3) audio subtype.</summary>
    /// <returns>The string representation of the GUID for the MPEG Audio Layer-3 (MP3) audio subtype.</returns>
    public static extern string AudioFormatMP3 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the MPEG-1 audio subtype.</summary>
    /// <returns>The string representation of the GUID for the MPEG-1 audio subtype.</returns>
    public static extern string AudioFormatMPeg { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Windows Media Audio 9 Voice codec audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Windows Media Audio 9 Voice codec audio subtype.</returns>
    public static extern string AudioFormatMsp1 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Opus audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Opus audio subtype.</returns>
    public static extern string AudioFormatOpus { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the uncompressed PCM audio subtype.</summary>
    /// <returns>The string representation of the GUID for the uncompressed PCM audio subtype.</returns>
    public static extern string AudioFormatPcm { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Windows Media Audio 9 Professional codec over S/PDIF audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Windows Media Audio 9 Professional codec over S/PDIF audio subtype.</returns>
    public static extern string AudioFormatWmaSpdif { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Windows Media Audio 9 Lossless codec or Windows Media Audio 9.1 audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Windows Media Audio 9 Lossless codec or Windows Media Audio 9.1 Lossless codec audio subtype.</returns>
    public static extern string AudioFormatWMAudioLossless { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Windows Media Audio 8 codec, Windows Media Audio 9 codec, or Windows Media Audio 9.1 codec audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Windows Media Audio 8 codec, Windows Media Audio 9 codec, or Windows Media Audio 9.1 codec audio subtype.</returns>
    public static extern string AudioFormatWMAudioV8 { [MethodImpl] get; }

    /// <summary>Gets the string representation of the GUID for the Windows Media Audio 9 Professional codec or Windows Media Audio 9.1 Professional codec audio subtype.</summary>
    /// <returns>The string representation of the GUID for the Windows Media Audio 9 Professional codec or Windows Media Audio 9.1 Professional codec audio subtype.</returns>
    public static extern string AudioFormatWMAudioV9 { [MethodImpl] get; }
  }
}
