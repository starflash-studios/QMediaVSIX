// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Casting;

namespace Windows.Media.Playback
{
  [Guid(3993395418, 795, 20459, 189, 155, 146, 224, 160, 168, 210, 153)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlayer3
  {
    event TypedEventHandler<MediaPlayer, object> IsMutedChanged;

    event TypedEventHandler<MediaPlayer, object> SourceChanged;

    double AudioBalance { get; set; }

    bool RealTimePlayback { get; set; }

    StereoscopicVideoRenderMode StereoscopicVideoRenderMode { get; set; }

    MediaBreakManager BreakManager { get; }

    MediaPlaybackCommandManager CommandManager { get; }

    DeviceInformation AudioDevice { get; set; }

    MediaTimelineController TimelineController { get; set; }

    TimeSpan TimelineControllerPositionOffset { get; set; }

    MediaPlaybackSession PlaybackSession { get; }

    void StepForwardOneFrame();

    void StepBackwardOneFrame();

    CastingSource GetAsCastingSource();
  }
}
