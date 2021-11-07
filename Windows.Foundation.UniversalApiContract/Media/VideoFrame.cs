// Decompiled with JetBrains decompiler
// Type: Windows.Media.VideoFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Imaging;

namespace Windows.Media
{
  /// <summary>Represents a single frame of video data.</summary>
  [Static(typeof (IVideoFrameStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [GCPressure(amount = GCPressureAmount.High)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IVideoFrameFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VideoFrame : IVideoFrame, IMediaFrame, IClosable, IVideoFrame2
  {
    /// <summary>Initializes a new instance of the VideoFrame class.</summary>
    /// <param name="format">The pixel format of the video frame.</param>
    /// <param name="width">The width of the video frame, in pixels.</param>
    /// <param name="height">The height of the video frame, in pixels.</param>
    [MethodImpl]
    public extern VideoFrame(BitmapPixelFormat format, int width, int height);

    /// <summary>Initializes a new instance of the VideoFrame class.</summary>
    /// <param name="format">The pixel format of the video frame.</param>
    /// <param name="width">The width of the video frame, in pixels.</param>
    /// <param name="height">The height of the video frame, in pixels.</param>
    /// <param name="alpha">The alpha mode of the video frame.</param>
    [MethodImpl]
    public extern VideoFrame(
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);

    /// <summary>Gets the SoftwareBitmap object containing the pixel data of the video frame, when one is present.</summary>
    /// <returns>The SoftwareBitmap object containing the pixel data of the video frame.</returns>
    public extern SoftwareBitmap SoftwareBitmap { [MethodImpl] get; }

    /// <summary>Copies the current VideoFrame into a provided VideoFrame object.</summary>
    /// <param name="frame">The target video frame into which the current frame will be copied.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CopyToAsync(VideoFrame frame);

    /// <summary>Gets the IDirect3DSurface object containing the pixel data of the video frame, when one is present.</summary>
    /// <returns>The IDirect3DSurface object containing the pixel data of the video frame.</returns>
    public extern IDirect3DSurface Direct3DSurface { [MethodImpl] get; }

    /// <summary>Gets a string indicating the type of video data the video frame contains.</summary>
    /// <returns>A string indicating the type of video data the video frame contains.</returns>
    public extern string Type { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the video frame is read-only.</summary>
    /// <returns>True if the video frame is read-only; otherwise, false.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; }

    /// <summary>Gets or sets the relative time of the frame within the video stream.</summary>
    /// <returns>The relative time of the frame within the video stream.</returns>
    public extern IReference<TimeSpan> RelativeTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a timestamp that is relative to the system and is correlatable across multiple media sources on the same device.</summary>
    /// <returns>A timestamp relative to the system.</returns>
    public extern IReference<TimeSpan> SystemRelativeTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the duration of the video frame.</summary>
    /// <returns>The duration of the video frame.</returns>
    public extern IReference<TimeSpan> Duration { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether an video frame is the first frame after a gap in the stream.</summary>
    /// <returns>True if the video frame is the first frame after a gap in the stream; otherwise, false.</returns>
    public extern bool IsDiscontinuous { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the extended property set which enables getting and setting properties on the media frame.</summary>
    /// <returns>The extended properties map.</returns>
    public extern IPropertySet ExtendedProperties { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    [Overload("CopyToWithBoundsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CopyToAsync(
      VideoFrame frame,
      IReference<BitmapBounds> sourceBounds,
      IReference<BitmapBounds> destinationBounds);

    /// <summary>Creates a new instance of the VideoFrame class for which the image data is stored in an IDXGISurface allocated by the default Direct3D device.</summary>
    /// <param name="format">A value from the DirectXPixelFormat enumeration, specifying the pixel format of the created **VideoFrame**. Not all pixel formats are supported. See the Remarks section for more information.</param>
    /// <param name="width">The width, in pixels, of the created **VideoFrame**.</param>
    /// <param name="height">The height, in pixels, of the created **VideoFrame**.</param>
    /// <returns>A **VideoFrame**.</returns>
    [Overload("CreateAsDirect3D11SurfaceBacked")]
    [MethodImpl]
    public static extern VideoFrame CreateAsDirect3D11SurfaceBacked(
      DirectXPixelFormat format,
      int width,
      int height);

    /// <summary>Creates a new instance of the VideoFrame class for which the image data is stored in an IDXGISurface allocated by the supplied Direct3D device.</summary>
    /// <param name="format">A value from the DirectXPixelFormat enumeration, specifying the pixel format of the created **VideoFrame**. Not all pixel formats are supported. See the Remarks section for more information.</param>
    /// <param name="width">The width, in pixels, of the created **VideoFrame**.</param>
    /// <param name="height">The height, in pixels, of the created **VideoFrame**.</param>
    /// <param name="device">An IDirect3DDevice that is used to allocate the backing surface of the video frame.</param>
    /// <returns>A **VideoFrame**.</returns>
    [Overload("CreateAsDirect3D11SurfaceBackedWithDevice")]
    [MethodImpl]
    public static extern VideoFrame CreateAsDirect3D11SurfaceBacked(
      DirectXPixelFormat format,
      int width,
      int height,
      IDirect3DDevice device);

    /// <summary>Creates a new instance of the VideoFrame class from the provided SoftwareBitmap.</summary>
    /// <param name="bitmap">The SoftwareBitmap from which the **VideoFrame** is created.</param>
    /// <returns>A **VideoFrame**.</returns>
    [MethodImpl]
    public static extern VideoFrame CreateWithSoftwareBitmap(SoftwareBitmap bitmap);

    /// <summary>Creates a new instance of the VideoFrame class for which the image data is stored in the provided IDXGISurface.</summary>
    /// <param name="surface">The IDXGISurface in which the image data is stored.</param>
    /// <returns>A **VideoFrame**.</returns>
    [MethodImpl]
    public static extern VideoFrame CreateWithDirect3D11Surface(IDirect3DSurface surface);
  }
}
