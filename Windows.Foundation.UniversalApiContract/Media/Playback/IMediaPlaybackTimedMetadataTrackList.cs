// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackTimedMetadataTrackList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlaybackTimedMetadataTrackList))]
  [Guid(1924403993, 48123, 18083, 147, 114, 156, 156, 116, 75, 148, 56)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlaybackTimedMetadataTrackList
  {
    event TypedEventHandler<MediaPlaybackTimedMetadataTrackList, TimedMetadataPresentationModeChangedEventArgs> PresentationModeChanged;

    TimedMetadataTrackPresentationMode GetPresentationMode(
      uint index);

    void SetPresentationMode(uint index, TimedMetadataTrackPresentationMode value);
  }
}
