// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.IStorageItemInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage.BulkAccess
{
  /// <summary>Provides synchronous access to the properties of a file or folder in the file system.</summary>
  [Guid(2275789707, 35186, 20288, 141, 224, 216, 111, 177, 121, 216, 250)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageItemInformation
  {
    /// <summary>Gets an object that provides access to the music properties of the item, such as the album name, artist name, bit rate, and so on.</summary>
    /// <returns>The music properties.</returns>
    MusicProperties MusicProperties { get; }

    /// <summary>Gets an object that provides access to the video properties of the item, such as the duration, rating, date released, and so on.</summary>
    /// <returns>The video properties.</returns>
    VideoProperties VideoProperties { get; }

    /// <summary>Gets an object that provides access to the image properties of the item, such as the title, rating, date that the image was taken, and so on.</summary>
    /// <returns>The image properties.</returns>
    ImageProperties ImageProperties { get; }

    /// <summary>Gets an object that provides access to the document properties of the item, such as the title, author name, and so on.</summary>
    /// <returns>The document properties.</returns>
    DocumentProperties DocumentProperties { get; }

    /// <summary>Gets an object that contains the basic properties information of the item.</summary>
    /// <returns>The basic properties object.</returns>
    BasicProperties BasicProperties { get; }

    /// <summary>Gets the thumbnail associated with the item.</summary>
    /// <returns>The thumbnail.</returns>
    StorageItemThumbnail Thumbnail { get; }

    /// <summary>Fires when the item's thumbnail is updated or a better quality thumbnail is available.</summary>
    event TypedEventHandler<IStorageItemInformation, object> ThumbnailUpdated;

    /// <summary>Occurs when one or more of the item's properties is updated.</summary>
    event TypedEventHandler<IStorageItemInformation, object> PropertiesUpdated;
  }
}
