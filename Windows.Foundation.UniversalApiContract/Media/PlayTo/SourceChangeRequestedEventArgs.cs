// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.SourceChangeRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.PlayTo
{
  /// <summary>Provides information about the SourceChangeRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SourceChangeRequestedEventArgs : ISourceChangeRequestedEventArgs
  {
    /// <summary>Gets the media stream for the Play To receiver.</summary>
    /// <returns>The media stream for the Play To receiver.</returns>
    public extern IRandomAccessStreamWithContentType Stream { [MethodImpl] get; }

    /// <summary>Gets the title of the content in the media stream.</summary>
    /// <returns>The title of the content in the media stream.</returns>
    public extern string Title { [MethodImpl] get; }

    /// <summary>Gets the author of the content in the media stream.</summary>
    /// <returns>The author of the content in the media stream.</returns>
    public extern string Author { [MethodImpl] get; }

    /// <summary>Gets the name of the album that contains the song in the audio stream.</summary>
    /// <returns>The name of the album that contains the song in the audio stream.</returns>
    public extern string Album { [MethodImpl] get; }

    /// <summary>Gets the names of the genres that the content in the media stream belongs to.</summary>
    /// <returns>Gets the names of the genres that the content in the media stream belongs to.</returns>
    public extern string Genre { [MethodImpl] get; }

    /// <summary>Gets the description of the content in the media stream.</summary>
    /// <returns>The description of the content in the media stream.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets the date that the content in the media stream was published.</summary>
    /// <returns>The date that the content in the media stream was published.</returns>
    public extern IReference<DateTime> Date { [MethodImpl] get; }

    /// <summary>Gets the thumbnail image for the content in the media stream.</summary>
    /// <returns>The thumbnail image for the content in the media stream.</returns>
    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; }

    /// <summary>Gets the rating for the content in the media stream.</summary>
    /// <returns>The rating for the content in the media stream.</returns>
    public extern IReference<uint> Rating { [MethodImpl] get; }

    /// <summary>Gets custom property names and values for the content in the media stream.</summary>
    /// <returns>Custom property names and values for the content in the media stream.</returns>
    public extern IMapView<string, object> Properties { [MethodImpl] get; }
  }
}
