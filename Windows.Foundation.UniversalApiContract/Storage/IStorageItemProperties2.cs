// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageItemProperties2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage
{
  /// <summary>Provides access to methods that get a scaled image as a thumbnail.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2391189841, 1209, 19410, 146, 157, 254, 243, 247, 22, 33, 208)]
  public interface IStorageItemProperties2 : IStorageItemProperties
  {
    /// <summary>Gets a scaled image as a thumbnail, determined by the purpose of the thumbnail.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [Overload("GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [RemoteAsync]
    IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode);

    /// <summary>Gets a scaled image as a thumbnail, determined by the purpose of the thumbnail and the requested size.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [RemoteAsync]
    [Overload("GetScaledImageAsThumbnailAsyncOverloadDefaultOptions")]
    IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    /// <summary>Gets a scaled image as a thumbnail, determined by the purpose of the thumbnail, the requested size, and the specified options</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <param name="options">The enum value that describes the desired behavior to use to retrieve the thumbnail image. The specified behavior might affect the size and/or quality of the image and how quickly the thumbnail image is retrieved.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [Overload("GetScaledImageAsThumbnailAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);
  }
}
