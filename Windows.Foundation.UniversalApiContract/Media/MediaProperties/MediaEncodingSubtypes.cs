// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.MediaEncodingSubtypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Provides properties for getting the standard names for media subtypes.</summary>
  [Static(typeof (IMediaEncodingSubtypesStatics6), 655360, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaEncodingSubtypesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaEncodingSubtypesStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaEncodingSubtypesStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaEncodingSubtypesStatics5), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMediaEncodingSubtypesStatics4), 393216, "Windows.Foundation.UniversalApiContract")]
  public static class MediaEncodingSubtypes
  {
    /// <summary>Gets the name for the Presentation Graphic Stream (PGS) format.</summary>
    /// <returns>The name for the Presentation Graphic Stream format.</returns>
    public static extern string Pgs { [MethodImpl] get; }

    /// <summary>Gets the name for the SubRip Text (SRT) format.</summary>
    /// <returns>The name for the SubRip Text format.</returns>
    public static extern string Srt { [MethodImpl] get; }

    /// <summary>Gets the name for the SubStation Alpha Text (SSA) format.</summary>
    /// <returns>The name for the SubStation Alpha Text (SSA) format.</returns>
    public static extern string Ssa { [MethodImpl] get; }

    /// <summary>Gets the name for the VobSub format.</summary>
    /// <returns>The name for the VobSub format.</returns>
    public static extern string VobSub { [MethodImpl] get; }

    /// <summary>Gets the name for High Efficiency Image File (HEIF).</summary>
    /// <returns>The name for HEIF.</returns>
    public static extern string Heif { [MethodImpl] get; }

    /// <summary>Gets the P010, the 10-bit equivalent of NV12 format.</summary>
    /// <returns>The name for the P010.</returns>
    public static extern string P010 { [MethodImpl] get; }

    /// <summary>Gets the name for Apple Lossless Audio Codec (ALAC) audio encoding.</summary>
    /// <returns>The name for Dolby Digital audio (AC-3) for Apple Lossless Audio Codec (ALAC) audio.</returns>
    public static extern string Alac { [MethodImpl] get; }

    /// <summary>Gets the name for Free Lossless Audio Codec (FLAC) audio encoding.</summary>
    /// <returns>The name for Free Lossless Audio Codec (FLAC) audio encoding.</returns>
    public static extern string Flac { [MethodImpl] get; }

    /// <summary>Gets the name for VP9 video encoding.</summary>
    /// <returns>The name for VP9 video encoding.</returns>
    public static extern string Vp9 { [MethodImpl] get; }

    /// <summary>Gets the name for 8-bit luminance-only image encoding.</summary>
    /// <returns>The name for 8-bit luminance-only image encoding.</returns>
    public static extern string L8 { [MethodImpl] get; }

    /// <summary>Gets the name for 16-bit luminance-only image encoding.</summary>
    /// <returns>The name for 16-bit luminance-only image encoding.</returns>
    public static extern string L16 { [MethodImpl] get; }

    /// <summary>Gets the name for 16-bit z-buffer depth image encoding.</summary>
    /// <returns>The name for 16-bit z-buffer depth image encoding.</returns>
    public static extern string D16 { [MethodImpl] get; }

    /// <summary>Gets the name for Advanced Audio Coding (AAC).</summary>
    /// <returns>The name for AAC.</returns>
    public static extern string Aac { [MethodImpl] get; }

    /// <summary>Gets the name for Advanced Audio Coding (AAC) audio in Audio Data Transport Stream (ADTS) format.</summary>
    /// <returns>The name for AAC ADTS.</returns>
    public static extern string AacAdts { [MethodImpl] get; }

    /// <summary>Gets the name for Dolby Digital audio (AC-3).</summary>
    /// <returns>The name for AC-3.</returns>
    public static extern string Ac3 { [MethodImpl] get; }

    /// <summary>Gets the name for Adaptive Multi-Rate (AmrNb).</summary>
    /// <returns>The name of AMR-NB.</returns>
    public static extern string AmrNb { [MethodImpl] get; }

    /// <summary>Gets the name for Adaptive Multi-Rate Wideband.</summary>
    /// <returns>The name for AMR-WB</returns>
    public static extern string AmrWb { [MethodImpl] get; }

    /// <summary>Gets the name for RGB 32 with alpha channel.</summary>
    /// <returns>The name for AGB32.</returns>
    public static extern string Argb32 { [MethodImpl] get; }

    /// <summary>Gets the name for Advanced Systems Format (ASF).</summary>
    /// <returns>The name for ASF.</returns>
    public static extern string Asf { [MethodImpl] get; }

    /// <summary>Gets the name for Audio Video Interleave (AVI).</summary>
    /// <returns>The name for AVI.</returns>
    public static extern string Avi { [MethodImpl] get; }

    /// <summary>Gets the name for BGRA8.</summary>
    /// <returns>The name for BGRA8.</returns>
    public static extern string Bgra8 { [MethodImpl] get; }

    /// <summary>Gets the name for BMP file format.</summary>
    /// <returns>The name from BMP.</returns>
    public static extern string Bmp { [MethodImpl] get; }

    /// <summary>Gets the name Dolby Digital Plus (E-AC-3).</summary>
    /// <returns>Gets the name for E-AC-3.</returns>
    public static extern string Eac3 { [MethodImpl] get; }

    /// <summary>Gets the name for Uncompressed IEEE floating-point audio.</summary>
    /// <returns>Gets the name for float.</returns>
    public static extern string Float { [MethodImpl] get; }

    /// <summary>Gets the name for Graphics Interchange Format (GIF).</summary>
    /// <returns>Gets the name for GIF.</returns>
    public static extern string Gif { [MethodImpl] get; }

    /// <summary>Gets the name for H.263.</summary>
    /// <returns>The name for H.263.</returns>
    public static extern string H263 { [MethodImpl] get; }

    /// <summary>The name for H.264.</summary>
    /// <returns>The name for H.264.</returns>
    public static extern string H264 { [MethodImpl] get; }

    /// <summary>Get the name for H.264Es.</summary>
    /// <returns>The name for H.264Es.</returns>
    public static extern string H264Es { [MethodImpl] get; }

    /// <summary>Gets the name for High Efficiency Video Coding (HEVC).</summary>
    /// <returns>The name for HEVC.</returns>
    public static extern string Hevc { [MethodImpl] get; }

    /// <summary>Gets the name for HEVCES.</summary>
    /// <returns>The name for HEVCES.</returns>
    public static extern string HevcEs { [MethodImpl] get; }

    /// <summary>Gets the name for IYUV.</summary>
    /// <returns>The name for IYUV.</returns>
    public static extern string Iyuv { [MethodImpl] get; }

    /// <summary>Gets the name for JPEG.</summary>
    /// <returns>The name for JPEG.</returns>
    public static extern string Jpeg { [MethodImpl] get; }

    /// <summary>Gets the name for JPEG-XR.</summary>
    /// <returns>The name for JPEG-XR.</returns>
    public static extern string JpegXr { [MethodImpl] get; }

    /// <summary>Gets the name for Motion JPEG (MJPG).</summary>
    /// <returns>The name for MJPG.</returns>
    public static extern string Mjpg { [MethodImpl] get; }

    /// <summary>Gets the name for MPEG.</summary>
    /// <returns>The name for MPEG.</returns>
    public static extern string Mpeg { [MethodImpl] get; }

    /// <summary>Gets the name for MPEG-1.</summary>
    /// <returns>The name for MPEG-1.</returns>
    public static extern string Mpeg1 { [MethodImpl] get; }

    /// <summary>Gets the name for MPEG-2.</summary>
    /// <returns>The name for MPEG-2.</returns>
    public static extern string Mpeg2 { [MethodImpl] get; }

    /// <summary>Gets the name for MPEG Audio Layer-3 (MP3).</summary>
    /// <returns>The name for MP3.</returns>
    public static extern string Mp3 { [MethodImpl] get; }

    /// <summary>Gets the name for MPEG-4.</summary>
    /// <returns>The name for MPEG-4.</returns>
    public static extern string Mpeg4 { [MethodImpl] get; }

    /// <summary>Gets the name for NV12.</summary>
    /// <returns>The name for NV12.</returns>
    public static extern string Nv12 { [MethodImpl] get; }

    /// <summary>Gets the name for PCM.</summary>
    /// <returns>The name for PCM.</returns>
    public static extern string Pcm { [MethodImpl] get; }

    /// <summary>Gets the name for Portable Network Graphics (PNG).</summary>
    /// <returns>Gets the name for PNG.</returns>
    public static extern string Png { [MethodImpl] get; }

    /// <summary>Gets the name RGB 24.</summary>
    /// <returns>The name for RGB 24.</returns>
    public static extern string Rgb24 { [MethodImpl] get; }

    /// <summary>Gets the name for RGB 32.</summary>
    /// <returns>The name for RGB 32.</returns>
    public static extern string Rgb32 { [MethodImpl] get; }

    /// <summary>Gets the name for TIFF.</summary>
    /// <returns>The name for TIFF.</returns>
    public static extern string Tiff { [MethodImpl] get; }

    /// <summary>Gets the name for Waveform Audio File (WAVE).</summary>
    /// <returns>The name for WAVE.</returns>
    public static extern string Wave { [MethodImpl] get; }

    /// <summary>Gets the name for Windows Media Audio 8.</summary>
    /// <returns>Gets the name for WMA 8.</returns>
    public static extern string Wma8 { [MethodImpl] get; }

    /// <summary>Gets the name for Windows Media Audio 8.</summary>
    /// <returns>The name for WMA 9.</returns>
    public static extern string Wma9 { [MethodImpl] get; }

    /// <summary>Gets the name for Windows Media Video 9.</summary>
    /// <returns>Gets the name for WMV3.</returns>
    public static extern string Wmv3 { [MethodImpl] get; }

    /// <summary>Gets the name for Windows Media Video 9 Advanced Profile.</summary>
    /// <returns>Gets the name for WVC1.</returns>
    public static extern string Wvc1 { [MethodImpl] get; }

    /// <summary>Gets the name for YUY2.</summary>
    /// <returns>The name for YUY2.</returns>
    public static extern string Yuy2 { [MethodImpl] get; }

    /// <summary>Gets the name for YV12.</summary>
    /// <returns>The name for YV12.</returns>
    public static extern string Yv12 { [MethodImpl] get; }
  }
}
