// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageItemProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage
{
  /// <summary>Provides access to common and content properties on items (like files and folders).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2254849144, 32809, 18174, 167, 137, 28, 47, 62, 47, 251, 92)]
  public interface IStorageItemProperties
  {
    /// <summary>Retrieves an adjusted thumbnail image for the item, determined by the purpose of the thumbnail.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [RemoteAsync]
    IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode);

    /// <summary>Retrieves an adjusted thumbnail image for the item, determined by the purpose of the thumbnail and the requested size.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [Overload("GetThumbnailAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    /// <summary>Retrieves an adjusted thumbnail image for the item, determined by the purpose of the thumbnail, the requested size, and the specified options.</summary>
    /// <param name="mode">The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.</param>
    /// <param name="options">The enum value that describes the desired behavior to use to retrieve the thumbnail image. The specified behavior might affect the size and/or quality of the image and how quickly the thumbnail image is retrieved.</param>
    /// <returns>When this method completes successfully, it returns a StorageItemThumbnail that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.</returns>
    [RemoteAsync]
    [Overload("GetThumbnailAsync")]
    IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

    /// <summary>Gets the user-friendly name of the item.</summary>
    /// <returns>Gets the user-friendly name of the item.</returns>
    string DisplayName { get; }

    /// <summary>Gets the user-friendly type of the item.</summary>
    /// <returns>The user-friendly type of the item.</returns>
    string DisplayType { get; }

    /// <summary>Gets an identifier for the current item. This ID is unique for the query result or StorageFolder that contains the item and can be used to distinguish between items that have the same name.</summary>
    /// <returns>The identifier for the item within the query result or StorageFolder.</returns>
    string FolderRelativeId { get; }

    /// <summary>Gets an object that provides access to the content-related properties of the item.</summary>
    /// <returns>The object that provides access to the content-related properties of the item.</returns>
    StorageItemContentProperties Properties { get; }
  }
}
