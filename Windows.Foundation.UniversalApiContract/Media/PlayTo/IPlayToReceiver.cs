// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToReceiver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ExclusiveTo(typeof (PlayToReceiver))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2887110471, 41314, 19110, 175, 27, 58, 163, 95, 59, 144, 105)]
  internal interface IPlayToReceiver
  {
    event TypedEventHandler<PlayToReceiver, object> PlayRequested;

    event TypedEventHandler<PlayToReceiver, object> PauseRequested;

    event TypedEventHandler<PlayToReceiver, SourceChangeRequestedEventArgs> SourceChangeRequested;

    event TypedEventHandler<PlayToReceiver, PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested;

    event TypedEventHandler<PlayToReceiver, CurrentTimeChangeRequestedEventArgs> CurrentTimeChangeRequested;

    event TypedEventHandler<PlayToReceiver, MuteChangeRequestedEventArgs> MuteChangeRequested;

    event TypedEventHandler<PlayToReceiver, VolumeChangeRequestedEventArgs> VolumeChangeRequested;

    event TypedEventHandler<PlayToReceiver, object> TimeUpdateRequested;

    event TypedEventHandler<PlayToReceiver, object> StopRequested;

    void NotifyVolumeChange(double volume, bool mute);

    void NotifyRateChange(double rate);

    void NotifyLoadedMetadata();

    void NotifyTimeUpdate(TimeSpan currentTime);

    void NotifyDurationChange(TimeSpan duration);

    void NotifySeeking();

    void NotifySeeked();

    void NotifyPaused();

    void NotifyPlaying();

    void NotifyEnded();

    void NotifyError();

    void NotifyStopped();

    string FriendlyName { get; set; }

    bool SupportsImage { set; get; }

    bool SupportsAudio { set; get; }

    bool SupportsVideo { set; get; }

    IPropertySet Properties { get; }

    [RemoteAsync]
    IAsyncAction StartAsync();

    [RemoteAsync]
    IAsyncAction StopAsync();
  }
}
