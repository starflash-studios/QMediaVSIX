// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.IGlobalSystemMediaTransportControlsSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Control
{
  [Guid(1900595253, 39700, 23266, 171, 133, 220, 155, 28, 20, 225, 168)]
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSession))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IGlobalSystemMediaTransportControlsSession
  {
    string SourceAppUserModelId { get; }

    [RemoteAsync]
    IAsyncOperation<GlobalSystemMediaTransportControlsSessionMediaProperties> TryGetMediaPropertiesAsync();

    GlobalSystemMediaTransportControlsSessionTimelineProperties GetTimelineProperties();

    GlobalSystemMediaTransportControlsSessionPlaybackInfo GetPlaybackInfo();

    [RemoteAsync]
    IAsyncOperation<bool> TryPlayAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryPauseAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryStopAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryRecordAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryFastForwardAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryRewindAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TrySkipNextAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TrySkipPreviousAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryChangeChannelUpAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryChangeChannelDownAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryTogglePlayPauseAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryChangeAutoRepeatModeAsync(
      MediaPlaybackAutoRepeatMode requestedAutoRepeatMode);

    [RemoteAsync]
    IAsyncOperation<bool> TryChangePlaybackRateAsync(double requestedPlaybackRate);

    [RemoteAsync]
    IAsyncOperation<bool> TryChangeShuffleActiveAsync(bool requestedShuffleState);

    [RemoteAsync]
    IAsyncOperation<bool> TryChangePlaybackPositionAsync(
      long requestedPlaybackPosition);

    event TypedEventHandler<GlobalSystemMediaTransportControlsSession, TimelinePropertiesChangedEventArgs> TimelinePropertiesChanged;

    event TypedEventHandler<GlobalSystemMediaTransportControlsSession, PlaybackInfoChangedEventArgs> PlaybackInfoChanged;

    event TypedEventHandler<GlobalSystemMediaTransportControlsSession, MediaPropertiesChangedEventArgs> MediaPropertiesChanged;
  }
}
