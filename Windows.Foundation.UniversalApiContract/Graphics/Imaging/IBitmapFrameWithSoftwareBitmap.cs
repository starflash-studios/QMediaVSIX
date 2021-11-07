// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapFrameWithSoftwareBitmap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Exposes methods for obtaining a SoftwareBitmap representation of an BitmapFrame.</summary>
  [Guid(4264066202, 16908, 18787, 135, 173, 105, 20, 54, 224, 131, 131)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBitmapFrameWithSoftwareBitmap : IBitmapFrame
  {
    /// <summary>Asynchronously retrieves a SoftwareBitmap representation of an BitmapFrame.</summary>
    /// <returns>An asynchronous operation that returns a SoftwareBitmap on successful completion.</returns>
    [RemoteAsync]
    [Overload("GetSoftwareBitmapAsync")]
    IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync();

    /// <summary>Asynchronously retrieves a SoftwareBitmap representation of an BitmapFrame.</summary>
    /// <param name="pixelFormat">The pixel format of the software bitmap.</param>
    /// <param name="alphaMode">The alpha mode of the software bitmap.</param>
    /// <returns>An asynchronous operation that returns a SoftwareBitmap on successful completion.</returns>
    [RemoteAsync]
    [Overload("GetSoftwareBitmapConvertedAsync")]
    IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode);

    /// <summary>Asynchronously retrieves a SoftwareBitmap representation of an BitmapFrame.</summary>
    /// <param name="pixelFormat">The pixel format of the software bitmap.</param>
    /// <param name="alphaMode">The alpha mode of the software bitmap.</param>
    /// <param name="transform">The transform of the software bitmap.</param>
    /// <param name="exifOrientationMode">The EXIF orientation mode of the software bitmap.</param>
    /// <param name="colorManagementMode">The color management mode of the software bitmap.</param>
    /// <returns>An asynchronous operation that returns a SoftwareBitmap on successful completion.</returns>
    [RemoteAsync]
    [Overload("GetSoftwareBitmapTransformedAsync")]
    IAsyncOperation<SoftwareBitmap> GetSoftwareBitmapAsync(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      BitmapTransform transform,
      ExifOrientationMode exifOrientationMode,
      ColorManagementMode colorManagementMode);
  }
}
