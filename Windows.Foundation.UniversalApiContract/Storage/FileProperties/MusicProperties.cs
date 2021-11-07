// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.MusicProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Provides access to the music-related properties of an item (like a file or folder).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MusicProperties : IMusicProperties, IStorageItemExtraProperties
  {
    /// <summary>Gets or sets the name of the album that contains the song.</summary>
    /// <returns>The album name.</returns>
    public extern string Album { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the artists that contributed to the song.</summary>
    /// <returns>The names of the song's artists.</returns>
    public extern string Artist { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the names of music genres that the song belongs to.</summary>
    /// <returns>The collection of music genre names.</returns>
    public extern IVector<string> Genre { [MethodImpl] get; }

    /// <summary>Gets or sets the track number of the song on the song's album.</summary>
    /// <returns>The track number.</returns>
    public extern uint TrackNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the title of the song</summary>
    /// <returns>The song title.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rating associated with a music file.</summary>
    /// <returns>The media file rating, as a value between 0 and 99.</returns>
    public extern uint Rating { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the duration of the song in milliseconds.</summary>
    /// <returns>The duration in milliseconds.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; }

    /// <summary>Gets the bit rate of the song file.</summary>
    /// <returns>The bit rate, in bits per second.</returns>
    public extern uint Bitrate { [MethodImpl] get; }

    /// <summary>Gets or sets the name of the album artist of the song.</summary>
    /// <returns>The name of the song's album artist.</returns>
    public extern string AlbumArtist { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the composers of the song.</summary>
    /// <returns>A list of the names of the song's composers.</returns>
    public extern IVector<string> Composers { [MethodImpl] get; }

    /// <summary>Gets the conductors of the song.</summary>
    /// <returns>A list of the names of the song's conductors.</returns>
    public extern IVector<string> Conductors { [MethodImpl] get; }

    /// <summary>Gets or sets the subtitle of the song.</summary>
    /// <returns>The song's subtitle.</returns>
    public extern string Subtitle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the producers of the song.</summary>
    /// <returns>A list of the names of the song's producers.</returns>
    public extern IVector<string> Producers { [MethodImpl] get; }

    /// <summary>Gets or sets the publisher of the song.</summary>
    /// <returns>The name of the song's publisher.</returns>
    public extern string Publisher { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the songwriters.</summary>
    /// <returns>A list of the names of the songwriters.</returns>
    public extern IVector<string> Writers { [MethodImpl] get; }

    /// <summary>Gets or sets the year that the song was released.</summary>
    /// <returns>The song's release year.</returns>
    public extern uint Year { [MethodImpl] get; [MethodImpl] set; }

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
