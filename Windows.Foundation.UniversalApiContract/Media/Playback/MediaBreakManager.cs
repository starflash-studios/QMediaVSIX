// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaBreakManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides information about and control over the MediaBreak objects associated with a MediaPlayer. This class provides events for when a media break starts playback, ends playback, is skipped, or is seeked over. You can also use this class to determine the currently playing MediaBreak or to start or skip playback of a MediaBreak.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaBreakManager : IMediaBreakManager
  {
    /// <summary>Occurs when the user seeks the media playback position past one or more pending media breaks.</summary>
    public extern event TypedEventHandler<MediaBreakManager, MediaBreakSeekedOverEventArgs> BreaksSeekedOver;

    /// <summary>Occurs when playback of a MediaBreak starts.</summary>
    public extern event TypedEventHandler<MediaBreakManager, MediaBreakStartedEventArgs> BreakStarted;

    /// <summary>Occurs when a MediaBreak ends playback.</summary>
    public extern event TypedEventHandler<MediaBreakManager, MediaBreakEndedEventArgs> BreakEnded;

    /// <summary>Occurs when a MediaBreak is skipped.</summary>
    public extern event TypedEventHandler<MediaBreakManager, MediaBreakSkippedEventArgs> BreakSkipped;

    /// <summary>Gets the MediaBreak that is currently being played by the MediaPlayer.</summary>
    /// <returns>The MediaBreak that is currently being played by the MediaPlayer.</returns>
    public extern MediaBreak CurrentBreak { [MethodImpl] get; }

    /// <summary>Gets the MediaPlaybackSession associated with the MediaBreakManager.</summary>
    /// <returns>The MediaPlaybackSession associated with the MediaBreakManager.</returns>
    public extern MediaPlaybackSession PlaybackSession { [MethodImpl] get; }

    /// <summary>Directs the MediaPlayer to begin playing the specified MediaBreak immediately.</summary>
    /// <param name="value">The MediaBreak to be played.</param>
    [MethodImpl]
    public extern void PlayBreak(MediaBreak value);

    /// <summary>Directs the MediaPlayer to skip over the current MediaBreak.</summary>
    [MethodImpl]
    public extern void SkipCurrentBreak();
  }
}
