// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.VideoEncodingProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Describes the encoding properties of a video stream.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IVideoEncodingPropertiesStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IVideoEncodingPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VideoEncodingProperties : 
    IVideoEncodingProperties,
    IMediaEncodingProperties,
    IVideoEncodingProperties2,
    IVideoEncodingProperties3,
    IVideoEncodingProperties4,
    IVideoEncodingProperties5
  {
    /// <summary>Creates a new instance of the VideoEncodingProperties class.</summary>
    [MethodImpl]
    public extern VideoEncodingProperties();

    /// <summary>Gets or sets the video bit rate.</summary>
    /// <returns>The average bit rate of the video stream, in bits per second.</returns>
    public extern uint Bitrate { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the video image width.</summary>
    /// <returns>The width of the video image, in pixels.</returns>
    public extern uint Width { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the video image height.</summary>
    /// <returns>The height of the video image, in pixels.</returns>
    public extern uint Height { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the video frame rate.</summary>
    /// <returns>The frame rate, in frames per second.</returns>
    public extern MediaRatio FrameRate { [MethodImpl] get; }

    /// <summary>Gets or sets the pixel aspect ratio.</summary>
    /// <returns>The pixel aspect ratio.</returns>
    public extern MediaRatio PixelAspectRatio { [MethodImpl] get; }

    /// <summary>Gets additional format properties for the video stream.</summary>
    /// <returns>A property set that contains format properties.</returns>
    public extern MediaPropertySet Properties { [MethodImpl] get; }

    /// <summary>Gets the format type.</summary>
    /// <returns>The format type. For video streams, the format type is "Video".</returns>
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

    /// <summary>Gets or sets the media format profile.</summary>
    /// <returns>The media format profile.</returns>
    public extern int ProfileId { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a value indicating the stereoscopic video packing mode of the video stream.</summary>
    /// <returns>The stereoscopic video packing mode of the video stream.</returns>
    public extern StereoscopicVideoPackingMode StereoscopicVideoPackingMode { [MethodImpl] get; }

    /// <summary>Gets a value that specifies the spherical video format of a video frame.</summary>
    /// <returns>The spherical video format of a video frame.</returns>
    public extern SphericalVideoFrameFormat SphericalVideoFrameFormat { [MethodImpl] get; }

    /// <summary>Creates a copy of the **VideoEncodingProperties** object.</summary>
    /// <returns>A copy of the **VideoEncodingProperties** object.</returns>
    [MethodImpl]
    public extern VideoEncodingProperties Copy();

    /// <summary>Creates an instance of VideoEncodingProperties for High Efficiency Video Coding (HEVC).</summary>
    /// <returns>The video encoding properties.</returns>
    [MethodImpl]
    public static extern VideoEncodingProperties CreateHevc();

    /// <summary>Creates an instance of VideoEncodingProperties for a H.263 video.</summary>
    /// <returns>The video encoding properties.</returns>
    [MethodImpl]
    public static extern VideoEncodingProperties CreateH264();

    /// <summary>Creates an instance of VideoEncodingProperties for a MPEG-2 video.</summary>
    /// <returns>The video encoding properties.</returns>
    [MethodImpl]
    public static extern VideoEncodingProperties CreateMpeg2();

    /// <summary>Creates an instance of VideoEncodingProperties for a uncompressed video.</summary>
    /// <param name="subtype">The media subtype of the format.</param>
    /// <param name="width">The video image width.</param>
    /// <param name="height">The video image height.</param>
    /// <returns>The video encoding properties.</returns>
    [MethodImpl]
    public static extern VideoEncodingProperties CreateUncompressed(
      string subtype,
      uint width,
      uint height);
  }
}
