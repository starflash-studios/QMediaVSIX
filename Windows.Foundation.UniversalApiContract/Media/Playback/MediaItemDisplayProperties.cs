// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaItemDisplayProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Playback
{
  /// <summary>Defines a set of metadata for a MediaPlaybackItem that is displayed in the System Media Transport Controls while the item is playing.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaItemDisplayProperties : IMediaItemDisplayProperties
  {
    /// <summary>Gets or sets a value indicating the type of media that is represented by the MediaPlaybackItem, such as audio or video.</summary>
    /// <returns>A value indicating the type of media that is represented by the MediaPlaybackItem.</returns>
    public extern MediaPlaybackType Type { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the metadata for a music item that will be displayed by the System Media Transport Controls when the item is played.</summary>
    /// <returns>The display metadata for a music item.</returns>
    public extern MusicDisplayProperties MusicProperties { [MethodImpl] get; }

    /// <summary>Gets the metadata for a video item that will be displayed by the System Media Transport Controls when the item is played.</summary>
    /// <returns>The display metadata for a video item.</returns>
    public extern VideoDisplayProperties VideoProperties { [MethodImpl] get; }

    /// <summary>Gets or sets the thumbnail image for a MediaPlaybackItem that will be displayed by the System Media Transport Controls when the item is played.</summary>
    /// <returns>A stream containing the thumbnail image data for a MediaPlaybackItem.</returns>
    public extern RandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Clears the values of all media item display properties.</summary>
    [MethodImpl]
    public extern void ClearAll();
  }
}
