// Decompiled with JetBrains decompiler
// Type: Windows.Media.MusicDisplayProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Provides properties for music information that is displayed by the SystemMediaTransportControlsDisplayUpdater class.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MusicDisplayProperties : 
    IMusicDisplayProperties,
    IMusicDisplayProperties2,
    IMusicDisplayProperties3
  {
    /// <summary>Gets or set the title of the song.</summary>
    /// <returns>The title of the song.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of the album artist.</summary>
    /// <returns>The name of the album artist.</returns>
    public extern string AlbumArtist { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or set the name of the song artist.</summary>
    /// <returns>The name of the song artist.</returns>
    public extern string Artist { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the album title.</summary>
    /// <returns>The album title.</returns>
    public extern string AlbumTitle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the track number.</summary>
    /// <returns>The track number.</returns>
    public extern uint TrackNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a modifiable list of strings representing genre names.</summary>
    /// <returns>A modifiable list of strings representing genre names.</returns>
    public extern IVector<string> Genres { [MethodImpl] get; }

    /// <summary>Gets or sets the album track count.</summary>
    /// <returns>The album track count.</returns>
    public extern uint AlbumTrackCount { [MethodImpl] get; [MethodImpl] set; }
  }
}
