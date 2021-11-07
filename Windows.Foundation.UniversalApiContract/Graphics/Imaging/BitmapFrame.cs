// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Provides read access to data within a single frame.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BitmapFrame : IBitmapFrame, IBitmapFrameWithSoftwareBitmap
  {
    /// <summary>Asynchronously returns a stream containing the thumbnail image.</summary>
    /// <returns>Object that manages the asynchronous retrieval of the thumbnail data.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ImageStream> GetThumbnailAsync();

    /// <summary>A read-only view of the metadata within the frame.</summary>
    /// <returns>A read-only view of the metadata within the frame.</returns>
    public extern BitmapPropertiesView BitmapProperties { [MethodImpl] get; }

    /// <summary>The pixel format that best fits the frame.</summary>
    /// <returns>The pixel format that best fits the first frame.</returns>
    public extern BitmapPixelFormat BitmapPixelFormat { [MethodImpl] get; }

    /// <summary>The default alpha mode of the frame.</summary>
    /// <returns>The default alpha mode of the frame.</returns>
    public extern BitmapAlphaMode BitmapAlphaMode { [MethodImpl] get; }

    /// <summary>The horizontal resolution of the frame in dots per inch.</summary>
    /// <returns>The horizontal resolution of the frame in dots per inch.</returns>
    public extern double DpiX { [MethodImpl] get; }

    /// <summary>The vertical resolution of the frame in dots per inch.</summary>
    /// <returns>The vertical resolution of the frame in dots per inch.</returns>
    public extern double DpiY { [MethodImpl] get; }

    /// <summary>The width of the frame in pixels.</summary>
    /// <returns>The width of the frame in pixels.</returns>
    public extern uint PixelWidth { [MethodImpl] get; }

    /// <summary>The height of the frame in pixels.</summary>
    /// <returns>The height of the frame in pixels.</returns>
    public extern uint PixelHeight { [MethodImpl] get; }

    /// <summary>The width of the frame in pixels, after any EXIF orientation has been applied to the bitmap.</summary>
    /// <returns>The width of the frame in pixels, after any EXIF orientation has been applied.</returns>
    public extern uint OrientedPixelWidth { [MethodImpl] get; }

    /// <summary>The height of the frame in pixels, after any EXIF orientation has been applied to the bitmap.</summary>
    /// <returns>The height of the frame in pixels, after any EXIF orientation has been applied.</returns>
    public extern uint OrientedPixelHeight { [MethodImpl] get; }

    /// <summary>Asynchronously requests the pixel data for the frame. The resulting pixel data array will use the bitmap pixel format and alpha mode specified in the BitmapPixelFormat and BitmapAlphaMode properties. It will also have color management and EXIF orientation applied (see the Remarks section for more information).</summary>
    /// <returns>Object that manages the asynchronous retrieval of the pixel data.</returns>
    [Overload("GetPixelDataAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PixelDataProvider> GetPixelDataAsync();

    /// <summary>Asynchronously requests the pixel data for the frame using the specified parameters.</summary>
    /// <param name="pixelFormat">The specified pixel format.</param>
    /// <param name="alphaMode">The specified alpha mode.</param>
    /// <param name="transform">The set of transformations to be applied to the frame.</param>
    /// <param name="exifOrientationMode">Indicates whether the EXIF orientation flag should be ignored or respected.</param>
    /// <param name="colorManagementMode">Indicates whether the pixel data should be color managed to the sRGB color space.</param>
    /// <returns>Object that manages the asynchronous retrieval of the pixel data.</returns>
    [Overload("GetPixelDataTransformedAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PixelDataProvider> GetPixelDataAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      BitmapTransform transform,
      ExifOrientationMode exifOrientationMode,
      ColorManagementMode colorManagementMode);

    /// <summary>Asynchronously gets a SoftwareBitmap representation of the bitmap frame.</summary>
    /// <returns>An asynchronous operation that returns a SoftwareBitmap on successful completion.</returns>
    [RemoteAsync]
    [Overload("GetSoftwareBitmapAsync")]
    [MethodImpl]
    public extern IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync();

    /// <summary>Asynchronously gets a SoftwareBitmap representation of the bitmap frame.</summary>
    /// <param name="pixelFormat">The pixel format of the software bitmap.</param>
    /// <param name="alphaMode">The alpha mode of the software bitmap.</param>
    /// <returns>An asynchronous operation that returns a SoftwareBitmap on successful completion.</returns>
    [RemoteAsync]
    [Overload("GetSoftwareBitmapConvertedAsync")]
    [MethodImpl]
    public extern IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode);

    /// <summary>Asynchronously gets a SoftwareBitmap representation of the bitmap frame.</summary>
    /// <param name="pixelFormat">The pixel format of the software bitmap.</param>
    /// <param name="alphaMode">The alpha mode of the software bitmap.</param>
    /// <param name="transform">The transform of the software bitmap.</param>
    /// <param name="exifOrientationMode">The EXIF orientation mode of the software bitmap.</param>
    /// <param name="colorManagementMode">The color management mode of the software bitmap.</param>
    /// <returns>An asynchronous operation that returns a SoftwareBitmap on successful completion.</returns>
    [RemoteAsync]
    [Overload("GetSoftwareBitmapTransformedAsync")]
    [MethodImpl]
    public extern IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      BitmapTransform transform,
      ExifOrientationMode exifOrientationMode,
      ColorManagementMode colorManagementMode);
  }
}
