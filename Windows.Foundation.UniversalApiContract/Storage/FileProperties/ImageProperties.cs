// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.ImageProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Provides access to the image-related properties of an item (like a file or folder).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ImageProperties : IImageProperties, IStorageItemExtraProperties
  {
    /// <summary>Gets or sets the rating associated with an image file.</summary>
    /// <returns>The media file rating, as a value between 0 and 99.</returns>
    public extern uint Rating { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of keywords associated with the image.</summary>
    /// <returns>The collection of keywords.</returns>
    public extern IVector<string> Keywords { [MethodImpl] get; }

    /// <summary>Gets or sets the date when the image was taken.</summary>
    /// <returns>The date when the image was taken.</returns>
    public extern DateTime DateTaken { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the width of the image.</summary>
    /// <returns>The width of the image</returns>
    public extern uint Width { [MethodImpl] get; }

    /// <summary>Gets the height of the image.</summary>
    /// <returns>The height of the image, in pixels.</returns>
    public extern uint Height { [MethodImpl] get; }

    /// <summary>Gets or sets the title of the image.</summary>
    /// <returns>The image title.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the latitude coordinate where the photo was taken.</summary>
    /// <returns>The latitude coordinate where the photo was taken.</returns>
    public extern IReference<double> Latitude { [MethodImpl] get; }

    /// <summary>Gets the longitude coordinate where the photo was taken.</summary>
    /// <returns>The longitude coordinate where the photo was taken.</returns>
    public extern IReference<double> Longitude { [MethodImpl] get; }

    /// <summary>Gets or sets the manufacturer of the camera that took the photo.</summary>
    /// <returns>The manufacturer of the camera that took the photo.</returns>
    public extern string CameraManufacturer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the model of the camera that took the photo.</summary>
    /// <returns>The model of the camera that took the photo.</returns>
    public extern string CameraModel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the Exchangeable Image File (EXIF) orientation flag of the photo.</summary>
    /// <returns>The photo's Exchangeable Image File (EXIF) orientation flag.</returns>
    public extern PhotoOrientation Orientation { [MethodImpl] get; }

    /// <summary>Gets the names of people who are tagged in the photo.</summary>
    /// <returns>A list of the names of people who are tagged in the photo.</returns>
    public extern IVectorView<string> PeopleNames { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync(
      IIterable<string> propertiesToRetrieve);

    [Overload("SavePropertiesAsync")]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync(
      [HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);

    /// <summary>Saves all properties associated with the item.</summary>
    /// <returns>No object or value is returned when this method completes.</returns>
    [Overload("SavePropertiesAsyncOverloadDefault")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync();
  }
}
