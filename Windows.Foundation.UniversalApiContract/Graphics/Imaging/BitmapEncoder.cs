// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapEncoder
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
  /// <summary>Contains methods to create, edit and save images.</summary>
  [Static(typeof (IBitmapEncoderStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBitmapEncoderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BitmapEncoder : IBitmapEncoder, IBitmapEncoderWithSoftwareBitmap
  {
    /// <summary>Information about the bitmap encoder.</summary>
    /// <returns>An object containing information about the bitmap encoder.</returns>
    public extern BitmapCodecInformation EncoderInformation { [MethodImpl] get; }

    /// <summary>The metadata for the selected frame.</summary>
    /// <returns>A BitmapProperties object that provides both read and write access to the metadata for the selected frame.</returns>
    public extern BitmapProperties BitmapProperties { [MethodImpl] get; }

    /// <summary>The metadata for the container.</summary>
    /// <returns>A BitmapProperties object that provides both read and write access to the metadata for the container.</returns>
    public extern BitmapProperties BitmapContainerProperties { [MethodImpl] get; }

    /// <summary>Indicates whether or not a new thumbnail is automatically generated.</summary>
    /// <returns>A value that indicates whether or not the bitmap encoder will automatically generate a new thumbnail. The default value is False.</returns>
    public extern bool IsThumbnailGenerated { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The width, in pixels, of any generated thumbnail.</summary>
    /// <returns>The width of the thumbnail, in pixels. The default value is 160 pixels.</returns>
    public extern uint GeneratedThumbnailWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The height, in pixels, of any generated thumbnail.</summary>
    /// <returns>The height of the thumbnail, in pixels. The default value is 120 pixels.</returns>
    public extern uint GeneratedThumbnailHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A BitmapTransform object that is used to specify how the frame bitmap is to be transformed.</summary>
    /// <returns>A BitmapTransform object that is used to specify how the frame bitmap is to be transformed.</returns>
    public extern BitmapTransform BitmapTransform { [MethodImpl] get; }

    /// <summary>Sets pixel data on the frame.</summary>
    /// <param name="pixelFormat">The pixel format of the pixel data.</param>
    /// <param name="alphaMode">The alpha mode of the pixel data.</param>
    /// <param name="width">The width, in pixels, of the pixel data.</param>
    /// <param name="height">The height, in pixels, of the pixel data.</param>
    /// <param name="dpiX">The horizontal resolution, in dots per inch, of the pixel data.</param>
    /// <param name="dpiY">The vertical resolution, in dots per inch, of the pixel data.</param>
    /// <param name="pixels">The pixel data.</param>
    [MethodImpl]
    public extern void SetPixelData(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      uint width,
      uint height,
      double dpiX,
      double dpiY,
      [Range(0, 2147483647)] byte[] pixels);

    /// <summary>Asynchronously commits the current frame data and appends a new empty frame to be edited.</summary>
    /// <returns>An object that manages the asynchronous operation of committing the current frame data and appending a new empty frame to be edited.</returns>
    [Overload("GoToNextFrameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction GoToNextFrameAsync();

    [Overload("GoToNextFrameWithEncodingOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction GoToNextFrameAsync(
      IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);

    /// <summary>Asynchronously commits and flushes all of the image data.</summary>
    /// <returns>An object that manages the asynchronous flush operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FlushAsync();

    /// <summary>Sets the image data of the current frame using the specified SoftwareBitmap.</summary>
    /// <param name="bitmap">The software bitmap containing the image data.</param>
    [MethodImpl]
    public extern void SetSoftwareBitmap(SoftwareBitmap bitmap);

    /// <summary>The unique identifier of the built-in HEIF encoder.</summary>
    /// <returns>The unique identifier of the built-in HEIF encoder.</returns>
    public static extern Guid HeifEncoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the built-in BMP encoder.</summary>
    /// <returns>The unique identifier of the built-in BMP encoder.</returns>
    public static extern Guid BmpEncoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the built-in JPEG encoder.</summary>
    /// <returns>The unique identifier of the built-in JPEG encoder.</returns>
    public static extern Guid JpegEncoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the built-in PNG encoder.</summary>
    /// <returns>The unique identifier of the built-in PNG encoder.</returns>
    public static extern Guid PngEncoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the built-in TIFF encoder.</summary>
    /// <returns>The unique identifier of the built-in TIFF encoder.</returns>
    public static extern Guid TiffEncoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the built-in GIF encoder.</summary>
    /// <returns>The unique identifier of the built-in GIF encoder.</returns>
    public static extern Guid GifEncoderId { [MethodImpl] get; }

    /// <summary>The unique identifier of the built-in JPEG-XR encoder.</summary>
    /// <returns>The unique identifier of the built-in JPEG-XR encoder.</returns>
    public static extern Guid JpegXREncoderId { [MethodImpl] get; }

    /// <summary>A list of the bitmap encoders installed on the system and information about them.</summary>
    /// <returns>A list of BitmapCodecInformation objects containing information about each encoder.</returns>
    [MethodImpl]
    public static extern IVectorView<BitmapCodecInformation> GetEncoderInformationEnumerator();

    /// <summary>Asynchronously creates a new BitmapEncoder.</summary>
    /// <param name="encoderId">The unique identifier of the specified encoder.</param>
    /// <param name="stream">The output stream.</param>
    /// <returns>An object that manages the asynchronous creation of a new BitmapEncoder.</returns>
    [RemoteAsync]
    [Overload("CreateAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapEncoder> CreateAsync(
      Guid encoderId,
      IRandomAccessStream stream);

    [Overload("CreateWithEncodingOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapEncoder> CreateAsync(
      Guid encoderId,
      IRandomAccessStream stream,
      IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);

    /// <summary>Asynchronously creates a new BitmapEncoder and initializes it using data from an existing BitmapDecoder.</summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="bitmapDecoder">A BitmapDecoder containing the image data to be copied.</param>
    /// <returns>An object that manages the asynchronous creation of a new BitmapEncoder using data from an existing BitmapDecoder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapEncoder> CreateForTranscodingAsync(
      IRandomAccessStream stream,
      BitmapDecoder bitmapDecoder);

    /// <summary>Asynchronously creates a new BitmapEncoder for in-place property and metadata editing. The new encoder can only edit bitmap properties in-place and will fail for any other uses.</summary>
    /// <param name="bitmapDecoder">A BitmapDecoder containing the image data to be edited. This parameter must be created on a stream with an access mode of ReadWrite.</param>
    /// <returns>An object that manages the asynchronous initialization of a new BitmapEncoder using data from an existing BitmapDecoder.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BitmapEncoder> CreateForInPlacePropertyEncodingAsync(
      BitmapDecoder bitmapDecoder);
  }
}
