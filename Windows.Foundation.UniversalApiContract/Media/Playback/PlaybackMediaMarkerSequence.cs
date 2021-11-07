// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.PlaybackMediaMarkerSequence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>An ordered collection of PlaybackMediaMarker objects.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlaybackMediaMarkerSequence : 
    IPlaybackMediaMarkerSequence,
    IIterable<PlaybackMediaMarker>
  {
    /// <summary>Returns the number of items in the sequence.</summary>
    /// <returns>The number of items in the sequence.</returns>
    public extern uint Size { [MethodImpl] get; }

    /// <summary>Adds a PlaybackMediaMarker to the sequence in it's ordered position.</summary>
    /// <param name="value">The media marker to insert into the sequence.</param>
    [MethodImpl]
    public extern void Insert(PlaybackMediaMarker value);

    /// <summary>Removes all elements from the sequence.</summary>
    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<PlaybackMediaMarker> First();
  }
}
