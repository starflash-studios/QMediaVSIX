// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackCommandManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlaybackCommandManager))]
  [Guid(1523508646, 23734, 19034, 133, 33, 204, 134, 177, 193, 237, 55)]
  internal interface IMediaPlaybackCommandManager
  {
    bool IsEnabled { get; set; }

    MediaPlayer MediaPlayer { get; }

    MediaPlaybackCommandManagerCommandBehavior PlayBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior PauseBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior NextBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior PreviousBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior FastForwardBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior RewindBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior ShuffleBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior AutoRepeatModeBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior PositionBehavior { get; }

    MediaPlaybackCommandManagerCommandBehavior RateBehavior { get; }

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPlayReceivedEventArgs> PlayReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPauseReceivedEventArgs> PauseReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerNextReceivedEventArgs> NextReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPreviousReceivedEventArgs> PreviousReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerFastForwardReceivedEventArgs> FastForwardReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerRewindReceivedEventArgs> RewindReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerShuffleReceivedEventArgs> ShuffleReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs> AutoRepeatModeReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerPositionReceivedEventArgs> PositionReceived;

    event TypedEventHandler<MediaPlaybackCommandManager, MediaPlaybackCommandManagerRateReceivedEventArgs> RateReceived;
  }
}
