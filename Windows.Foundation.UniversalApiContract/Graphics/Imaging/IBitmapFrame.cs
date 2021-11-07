// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Exposes methods for operating on a single frame of an image.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1923389980, 32897, 17293, 145, 188, 148, 236, 252, 129, 133, 198)]
  public interface IBitmapFrame
  {
    /// <summary>Asynchronously retrieves the thumbnail data for the frame.</summary>
    /// <returns>Object that manages the asynchronous retrieval of the thumbnail data.</returns>
    [RemoteAsync]
    IAsyncOperation<ImageStream> GetThumbnailAsync();

    /// <summary>Returns a read-only view of the metadata within the frame.</summary>
    /// <returns>A read-only view of the metadata within the frame.</returns>
    BitmapPropertiesView BitmapProperties { get; }

    /// <summary>Returns the default pixel format of the frame.</summary>
    /// <returns>The default pixel format of the frame.</returns>
    BitmapPixelFormat BitmapPixelFormat { get; }

    /// <summary>Returns the default alpha mode of the frame.</summary>
    /// <returns>The default alpha mode of the frame.</returns>
    BitmapAlphaMode BitmapAlphaMode { get; }

    /// <summary>Returns the horizontal resolution of the frame in dots per inch.</summary>
    /// <returns>The horizontal resolution of the frame in dots per inch.</returns>
    double DpiX { get; }

    /// <summary>Returns the vertical resolution of the frame in dots per inch.</summary>
    /// <returns>The vertical resolution of the frame in dots per inch.</returns>
    double DpiY { get; }

    /// <summary>Returns the width of the frame in pixels.</summary>
    /// <returns>The width of the frame in pixels.</returns>
    uint PixelWidth { get; }

    /// <summary>Returns the height of the frame in pixels.</summary>
    /// <returns>The height of the frame in pixels.</returns>
    uint PixelHeight { get; }

    /// <summary>Returns the width of the frame in pixels, after any EXIF orientation has been applied to the bitmap.</summary>
    /// <returns>The width of the frame in pixels, after any EXIF orientation has been applied.</returns>
    uint OrientedPixelWidth { get; }

    /// <summary>Returns the height of the frame in pixels, after any EXIF orientation has been applied to the bitmap.</summary>
    /// <returns>The height of the frame in pixels, after any EXIF orientation has been applied.</returns>
    uint OrientedPixelHeight { get; }

    /// <summary>Asynchronously requests the pixel data for the frame. The resulting pixel data array will use the bitmap pixel format and alpha mode specified in the BitmapPixelFormat and BitmapAlphaMode properties. It will also have color management and EXIF orientation applied (see the Remarks section for more information).</summary>
    /// <returns>Object that manages the asynchronous retrieval of the pixel data.</returns>
    [Overload("GetPixelDataAsync")]
    [RemoteAsync]
    IAsyncOperation<PixelDataProvider> GetPixelDataAsync();

    /// <summary>Asynchronously requests the pixel data for the frame using the specified parameters.</summary>
    /// <param name="pixelFormat">The specified pixel format.</param>
    /// <param name="alphaMode">The specified alpha mode.</param>
    /// <param name="transform">The set of transformations to be applied to the frame.</param>
    /// <param name="exifOrientationMode">Indicates whether the EXIF orientation flag should be ignored or respected.</param>
    /// <param name="colorManagementMode">Indicates whether the pixel data should be color managed to the sRGB color space.</param>
    /// <returns>Object that manages the asynchronous retrieval of the pixel data.</returns>
    [Overload("GetPixelDataTransformedAsync")]
    [RemoteAsync]
    IAsyncOperation<PixelDataProvider> GetPixelDataAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      BitmapTransform transform,
      ExifOrientationMode exifOrientationMode,
      ColorManagementMode colorManagementMode);
  }
}
