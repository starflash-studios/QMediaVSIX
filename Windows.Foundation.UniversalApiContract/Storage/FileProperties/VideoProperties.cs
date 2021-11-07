// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.VideoProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Provides access to the video-related properties of an item (like a file or folder).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VideoProperties : IVideoProperties, IStorageItemExtraProperties
  {
    /// <summary>Gets or sets the rating associated with a video file.</summary>
    /// <returns>The media file rating, as a value between 0 and 99.</returns>
    public extern uint Rating { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of keywords associated with the video.</summary>
    /// <returns>The collection of keywords.</returns>
    public extern IVector<string> Keywords { [MethodImpl] get; }

    /// <summary>Gets the width of the video.</summary>
    /// <returns>The width of the video, in pixels.</returns>
    public extern uint Width { [MethodImpl] get; }

    /// <summary>Gets the height of the video.</summary>
    /// <returns>The height of the video, in pixels.</returns>
    public extern uint Height { [MethodImpl] get; }

    /// <summary>Gets the duration of the video.</summary>
    /// <returns>The duration.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; }

    /// <summary>Gets the latitude coordinate where the video was shot.</summary>
    /// <returns>The latitude coordinate where the video was shot.</returns>
    public extern IReference<double> Latitude { [MethodImpl] get; }

    /// <summary>Gets the longitude coordinate where the video was shot.</summary>
    /// <returns>The longitude coordinate where the photo was taken.</returns>
    public extern IReference<double> Longitude { [MethodImpl] get; }

    /// <summary>Gets or sets the title of the video.</summary>
    /// <returns>The video's title.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the subtitle of the video.</summary>
    /// <returns>The video's subtitle.</returns>
    public extern string Subtitle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the producers of the video.</summary>
    /// <returns>A list of the names of the video's producers.</returns>
    public extern IVector<string> Producers { [MethodImpl] get; }

    /// <summary>Gets or sets the publisher of the video.</summary>
    /// <returns>The name of the video's publisher.</returns>
    public extern string Publisher { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the script writers for the video.</summary>
    /// <returns>A list of the names of the video's script writers.</returns>
    public extern IVector<string> Writers { [MethodImpl] get; }

    /// <summary>Gets or sets the year that the video was shot or released.</summary>
    /// <returns>The video's release year.</returns>
    public extern uint Year { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the sum audio and video bitrate of the video.</summary>
    /// <returns>The video's sum audio and video bitrate.</returns>
    public extern uint Bitrate { [MethodImpl] get; }

    /// <summary>Gets the directors of the video.</summary>
    /// <returns>A list of the names of the video's directors.</returns>
    public extern IVector<string> Directors { [MethodImpl] get; }

    /// <summary>Gets a VideoOrientation value that indicates how the video should be rotated to display it correctly.</summary>
    /// <returns>The value that indicates how the video should be rotated to display it correctly.</returns>
    public extern VideoOrientation Orientation { [MethodImpl] get; }

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
    [RemoteAsync]
    [Overload("SavePropertiesAsyncOverloadDefault")]
    [MethodImpl]
    public extern IAsyncAction SavePropertiesAsync();
  }
}
