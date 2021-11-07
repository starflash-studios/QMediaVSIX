// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2824134065, 65204, 19867, 157, 151, 15, 219, 229, 142, 94, 57)]
  [ExclusiveTo(typeof (MediaBreakManager))]
  internal interface IMediaBreakManager
  {
    event TypedEventHandler<MediaBreakManager, MediaBreakSeekedOverEventArgs> BreaksSeekedOver;

    event TypedEventHandler<MediaBreakManager, MediaBreakStartedEventArgs> BreakStarted;

    event TypedEventHandler<MediaBreakManager, MediaBreakEndedEventArgs> BreakEnded;

    event TypedEventHandler<MediaBreakManager, MediaBreakSkippedEventArgs> BreakSkipped;

    MediaBreak CurrentBreak { get; }

    MediaPlaybackSession PlaybackSession { get; }

    void PlayBreak(MediaBreak value);

    void SkipCurrentBreak();
  }
}
