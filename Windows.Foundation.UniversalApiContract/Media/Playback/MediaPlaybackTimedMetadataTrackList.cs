// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackTimedMetadataTrackList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  /// <summary>Represents a read-only list of TimedMetadataTrack objects.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaPlaybackTimedMetadataTrackList : 
    IVectorView<TimedMetadataTrack>,
    IIterable<TimedMetadataTrack>,
    IMediaPlaybackTimedMetadataTrackList
  {
    [MethodImpl]
    public extern TimedMetadataTrack GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(TimedMetadataTrack value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] TimedMetadataTrack[] items);

    [MethodImpl]
    public extern IIterator<TimedMetadataTrack> First();

    /// <summary>Occurs when the presentation mode of the MediaPlaybackTimedMetadataTrackList changes.</summary>
    public extern event TypedEventHandler<MediaPlaybackTimedMetadataTrackList, TimedMetadataPresentationModeChangedEventArgs> PresentationModeChanged;

    /// <summary>Gets the presentation mode of the timed metadata track with the specified index.</summary>
    /// <param name="index">The index of the timed metadata track for which the presentation mode is queried.</param>
    /// <returns>The presentation mode.</returns>
    [MethodImpl]
    public extern TimedMetadataTrackPresentationMode GetPresentationMode(
      uint index);

    /// <summary>Sets the presentation mode of the timed metadata track with the specified index.</summary>
    /// <param name="index">The index of the timed metadata track for which the presentation mode is set.</param>
    /// <param name="value">The presentation mode to set.</param>
    [MethodImpl]
    public extern void SetPresentationMode(uint index, TimedMetadataTrackPresentationMode value);
  }
}
