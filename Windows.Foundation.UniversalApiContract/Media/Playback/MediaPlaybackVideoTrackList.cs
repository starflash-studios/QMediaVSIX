// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackVideoTrackList
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
  /// <summary>Represents a read-only list of VideoTrack objects, of which a single track can be selected at one time.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaPlaybackVideoTrackList : 
    IVectorView<VideoTrack>,
    IIterable<VideoTrack>,
    ISingleSelectMediaTrackList
  {
    [MethodImpl]
    public extern VideoTrack GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(VideoTrack value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] VideoTrack[] items);

    [MethodImpl]
    public extern IIterator<VideoTrack> First();

    /// <summary>Occurs when the index of the currently selected video track changes.</summary>
    public extern event TypedEventHandler<ISingleSelectMediaTrackList, object> SelectedIndexChanged;

    /// <summary>Gets or sets the index of the currently selected video track in the list.</summary>
    /// <returns>The index of the currently selected video track in the list.</returns>
    public extern int SelectedIndex { [MethodImpl] set; [MethodImpl] get; }
  }
}
