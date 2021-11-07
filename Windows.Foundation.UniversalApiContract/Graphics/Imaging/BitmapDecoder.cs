// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapDecoder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Imaging
{
  /// <summary>Provides read access to bitmap container data as well as data from the first frame.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBitmapDecoderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBitmapDecoderStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BitmapDecoder : IBitmapDecoder, IBitmapFrame, IBitmapFrameWithSoftwareBitmap
  {
    /// <summary>Provides access to the container bitmap properties.</summary>
    /// <returns>The container bitmap properties.</returns>
    public extern BitmapPropertiesView BitmapContainerProperties { [MethodImpl] get; }

    /// <summary>Information about the bitmap decoder.</summary>
    /// <returns>The bitmap decoder information.</returns>
    public extern BitmapCodecInformation DecoderInformation { [MethodImpl] get; }

    /// <summary>The number of frames within the image file.</summary>
    /// <returns>The number of frames.</returns>
    public extern uint FrameCount { [MethodImpl] get; }

    /// <summary>Asynchronously returns a stream containing the preview image.</summary>
    /// <returns>Object that manages the asynchronous retrieval of the bitmap preview data.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ImageStream> GetPreviewAsync();

    /// <summary>Asynchronously retrieves a frame from the image file.</summary>
    /// <param name="frameIndex">The zero-based index of the frame to be retrieved.</param>
    /// <returns>Object that manages the asynchronous retrieval of the frame.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BitmapFrame> GetFrameAsync(
      uint frameIndex);

    /// <summary>Asynchronously returns a stream containing the thumbnail image.</summary>
    /// <returns>Object that manages the asynchronous retrieval of the thumbnail stream.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ImageStream> GetThumbnailAsync();

    /// <summary>A read-only view of the metadata within the first frame.</summary>
    /// <returns>A read-only view of the metadata within the first frame.</returns>
    public extern BitmapPropertiesView BitmapProperties { [MethodImpl] get; }

    /// <summary>The pixel format that best fits the first frame.</summary>
    /// <returns>The pixel format that best fits the first frame.</returns>
    public extern BitmapPixelFormat BitmapPixelFormat { [MethodImpl] get; }

    /// <summary>The default alpha mode of the first frame.</summary>
    /// <returns>The default alpha mode of the first frame.</returns>
    public extern BitmapAlphaMode BitmapAlphaMode { [MethodImpl] get; }

    /// <summary>The horizontal resolution of the first frame in dots per inch.</summary>
    /// <returns>The horizontal resolution of the first frame in dots per inch.</returns>
    public extern double DpiX { [MethodImpl] get; }

    /// <summary>The vertical resolution of the first frame in dots per inch.</summary>
    /// <returns>The vertical resolution of the first frame in dots per inch.</returns>
    public extern double DpiY { [MethodImpl] get; }

    /// <summary>The width of the first frame in pixels.</summary>
    /// <returns>The width of the first frame in pixels.</returns>
    public extern uint PixelWidth { [MethodImpl] get; }

    /// <summary>The height of the first frame in pixels.</summary>
    /// <returns>The height of the first frame in pixels.</returns>
    public extern uint PixelHeight { [MethodImpl] get; }

    /// <summary>The width of the first frame in pixels, after any EXIF orientation has been applied to the bitmap.</summary>
    /// <returns>The width of the first frame in pixels, after any EXIF orientation has been applied.</returns>
    public extern uint OrientedPixelWidth { [MethodImpl] get; }

    /// <summary>The height of the first frame in pixels, after any EXIF orientation has been applied to the bitmap.</summary>
    /// <returns>The height of the first frame in pixels, after any EXIF orientation has been applied.</returns>
    public extern uint OrientedPixelHeight { [MethodImpl] get; }

    /// <summary>Asynchronously requests the pixel data for the frame.</summary>
    /// <returns>Object that manages the asynchronous retrieval of the pixel data.</returns>
    [RemoteAsync]
    [Overload("GetPixelDataAsync")]
    [MethodImpl]
    public extern IAsyncOperation<PixelDataProvider> GetPixelDataAsync();

    /// <summary>Asynchronously requests the pixel data for the frame using the specified parameters.</summary>
    /// <param name="pixelFormat">The specified pixel format.</param>
    /// <param name="alphaMode">The specified alpha mode.</param>
    /// <param name="transform">The set of transformations to be applied to the frame.</param>
    /// <param name="exifOrientationMode">Indicates whether the EXIF orientation flag should be ignored or respected.</param>
    /// <param name="colorManagementMode">Indicates whether the pixel data should be color managed to the sRGB color space.</param>
    /// <returns>Object that manages the asynchronous retrieval of the pixel data.</returns>
    [RemoteAsync]
    [Overload("GetPixelDataTransformedAsync")]
    [MethodImpl]
    public extern IAsyncOperation<PixelDataProvider> GetPixelDataAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      BitmapTransform transform,
      ExifOrientationMode exifOrientationMode,
      ColorManagementMode colorManagementMode);

    /// <summary>Asynchronously gets a SoftwareBitmap representation of the decoded bitmap.</summary>
    /// <returns>An asynchronous operation that returns a SoftwareBitmap on successful completion.</returns>
    [Overload("GetSoftwareBitmapAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync();

    /// <summary>Asynchronously gets a SoftwareBitmap representation of the decoded bitmap.</summary>
    /// <param name="pixelFormat">The pixel format of the software bitmap.</param>
    /// <param name="alphaMode">The alpha mode of the software bitmap.</param>
    /// <returns>An asynchronous operation that returns a SoftwareBitmap on successful completion.</returns>
    [Overload("GetSoftwareBitmapConvertedAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode);

    /// <summary>Asynchronously gets a SoftwareBitmap representation of the decoded bitmap.</summary>
    /// <param name="pixelFormat">The pixel format of the software bitmap.</param>
    /// <param name="alphaMode">The alpha mode of the software bitmap.</param>
    /// <param name="transform">The transform of the software bitmap.</param>
    /// <param name="exifOrientationMode">The EXIF orientation mode of the software bitmap.</param>
    /// <param name="colorManagementMode">The color management mode of the software bitmap.</param>
    /// <returns>An asynchronous operation that returns a SoftwareBitmap on successful completion.</returns>
    [Overload("GetSoftwareBitmapTransformedAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      BitmapTransform transform,
      ExifOrientationMode exifOrientationMode,
      ColorManagementMode colorManagementMode);

    /// <summary>The unique identifier of the HEIF decoder.</summary>
    /// <returns>The unique identifier of the HEIF decoder.</returns>
    public static extern Guid HeifDecoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the WebP decoder.</summary>
    /// <returns>The unique identifier of the WebP decoder.</returns>
    public static extern Guid WebpDecoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the BMP decoder.</summary>
    /// <returns>The unique identifier of the BMP decoder.</returns>
    public static extern Guid BmpDecoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the JPEG decoder.</summary>
    /// <returns>The unique identifier of the JPEG decoder.</returns>
    public static extern Guid JpegDecoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the PNG decoder.</summary>
    /// <returns>The unique identifier of the PNG decoder.</returns>
    public static extern Guid PngDecoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the TIFF decoder.</summary>
    /// <returns>The unique identifier of the TIFF decoder.</returns>
    public static extern Guid TiffDecoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the GIF decoder.</summary>
    /// <returns>The unique identifier of the GIF decoder.</returns>
    public static extern Guid GifDecoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the JPEG-XR decoder.</summary>
    /// <returns>The unique identifier of the JPEG-XR decoder.</returns>
    public static extern Guid JpegXRDecoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the ICO decoder.</summary>
    /// <returns>The unique identifier of the ICO decoder.</returns>
    public static extern Guid IcoDecoderId { [MethodImpl] get; }

    /// <summary>The bitmap decoders installed on the system and information about them.</summary>
    /// <returns>A list of BitmapCodecInformation objects containing information about each decoder.</returns>
    [MethodImpl]
    public static extern IVectorView<BitmapCodecInformation> GetDecoderInformationEnumerator();

    /// <summary>Asynchronously creates a new BitmapDecoder and initializes it using a stream.</summary>
    /// <param name="stream">The stream containing the image file to be decoded.</param>
    /// <returns>An object that manages the asynchronous creation of a new BitmapDecoder.</returns>
    [Overload("CreateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapDecoder> CreateAsync(
      IRandomAccessStream stream);

    /// <summary>Asynchronously creates a new BitmapDecoder using a specific bitmap codec and initializes it using a stream.</summary>
    /// <param name="decoderId">The unique identifier of the specified bitmap codec.</param>
    /// <param name="stream">The stream containing the image file to be decoded.</param>
    /// <returns>An object that manages the asynchronous creation of a new BitmapDecoder.</returns>
    [RemoteAsync]
    [Overload("CreateWithIdAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapDecoder> CreateAsync(
      Guid decoderId,
      IRandomAccessStream stream);
  }
}
