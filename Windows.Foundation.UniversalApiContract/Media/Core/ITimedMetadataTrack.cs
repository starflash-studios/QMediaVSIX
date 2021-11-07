// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataTrack
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2657807774, 63098, 18857, 179, 48, 207, 3, 176, 233, 207, 7)]
  [ExclusiveTo(typeof (TimedMetadataTrack))]
  internal interface ITimedMetadataTrack : IMediaTrack
  {
    event TypedEventHandler<TimedMetadataTrack, MediaCueEventArgs> CueEntered;

    event TypedEventHandler<TimedMetadataTrack, MediaCueEventArgs> CueExited;

    event TypedEventHandler<TimedMetadataTrack, TimedMetadataTrackFailedEventArgs> TrackFailed;

    IVectorView<IMediaCue> Cues { get; }

    IVectorView<IMediaCue> ActiveCues { get; }

    TimedMetadataKind TimedMetadataKind { get; }

    string DispatchType { get; }

    void AddCue(IMediaCue cue);

    void RemoveCue(IMediaCue cue);
  }
}
