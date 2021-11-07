// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaSource))]
  [Guid(783683656, 25951, 19511, 184, 19, 180, 228, 93, 250, 10, 190)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaSource2 : IMediaPlaybackSource, IClosable
  {
    event TypedEventHandler<MediaSource, MediaSourceOpenOperationCompletedEventArgs> OpenOperationCompleted;

    ValueSet CustomProperties { get; }

    IReference<TimeSpan> Duration { get; }

    bool IsOpen { get; }

    IObservableVector<TimedTextSource> ExternalTimedTextSources { get; }

    IObservableVector<TimedMetadataTrack> ExternalTimedMetadataTracks { get; }
  }
}
