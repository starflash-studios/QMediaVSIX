// Decompiled with JetBrains decompiler
// Type: Windows.Media.ISystemMediaTransportControls2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (SystemMediaTransportControls))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3935884022, 32572, 19186, 165, 134, 114, 136, 152, 8, 239, 177)]
  internal interface ISystemMediaTransportControls2
  {
    MediaPlaybackAutoRepeatMode AutoRepeatMode { get; set; }

    bool ShuffleEnabled { get; set; }

    double PlaybackRate { get; set; }

    void UpdateTimelineProperties(
      SystemMediaTransportControlsTimelineProperties timelineProperties);

    event TypedEventHandler<SystemMediaTransportControls, PlaybackPositionChangeRequestedEventArgs> PlaybackPositionChangeRequested;

    event TypedEventHandler<SystemMediaTransportControls, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested;

    event TypedEventHandler<SystemMediaTransportControls, ShuffleEnabledChangeRequestedEventArgs> ShuffleEnabledChangeRequested;

    event TypedEventHandler<SystemMediaTransportControls, AutoRepeatModeChangeRequestedEventArgs> AutoRepeatModeChangeRequested;
  }
}
