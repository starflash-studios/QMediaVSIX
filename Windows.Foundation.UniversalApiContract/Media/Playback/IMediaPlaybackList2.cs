// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackList2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(235517048, 24586, 17012, 161, 75, 11, 103, 35, 208, 244, 139)]
  [ExclusiveTo(typeof (MediaPlaybackList))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IMediaPlaybackList2 : IMediaPlaybackList, IMediaPlaybackSource
  {
    IReference<TimeSpan> MaxPrefetchTime { get; set; }

    MediaPlaybackItem StartingItem { get; set; }

    IVectorView<MediaPlaybackItem> ShuffledItems { get; }

    void SetShuffledItems(IIterable<MediaPlaybackItem> value);
  }
}
