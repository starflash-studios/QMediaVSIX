// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaBreakSchedule
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Represents a set of MediaBreak objects associated with a MediaPlaybackItem and the positions within the playback of the item that the media breaks are played.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaBreakSchedule : IMediaBreakSchedule
  {
    /// <summary>Occurs when the MediaBreakSchedule changes.</summary>
    public extern event TypedEventHandler<MediaBreakSchedule, object> ScheduleChanged;

    /// <summary>Adds a MediaBreak to the schedule that will be played at a point during the playback of the MediaPlaybackItem with which the MediaBreakSchedule is associated.</summary>
    /// <param name="mediaBreak">The MediaBreak to add to the schedule.</param>
    [MethodImpl]
    public extern void InsertMidrollBreak(MediaBreak mediaBreak);

    /// <summary>Removes a midroll MediaBreak from the MediaBreakSchedule.</summary>
    /// <param name="mediaBreak">The MediaBreak to remove from the schedule.</param>
    [MethodImpl]
    public extern void RemoveMidrollBreak(MediaBreak mediaBreak);

    /// <summary>Gets the schedule's current list of MediaBreak objects that will be played at a point during the playback of the MediaPlaybackItem with which the MediaBreakSchedule is associated.</summary>
    /// <returns>The schedule's current list of MediaBreak objects that will be played at a position within the playback of the MediaPlaybackItem with which the schedule is associated.</returns>
    public extern IVectorView<MediaBreak> MidrollBreaks { [MethodImpl] get; }

    /// <summary>Gets or sets the MediaBreak to be played before the MediaPlaybackItem associated with the MediaBreakSchedule plays.</summary>
    /// <returns>The MediaBreak to be played before the MediaPlaybackItem associated with the MediaBreakSchedule plays.</returns>
    public extern MediaBreak PrerollBreak { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the MediaBreak to be played after the MediaPlaybackItem associated with the MediaBreakSchedule plays.</summary>
    /// <returns>The MediaBreak to be played after the MediaPlaybackItem associated with the MediaBreakSchedule plays.</returns>
    public extern MediaBreak PostrollBreak { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the MediaPlaybackItem with which the MediaBreakSchedule is associated.</summary>
    /// <returns>The MediaPlaybackItem with which the MediaBreakSchedule is associated.</returns>
    public extern MediaPlaybackItem PlaybackItem { [MethodImpl] get; }
  }
}
