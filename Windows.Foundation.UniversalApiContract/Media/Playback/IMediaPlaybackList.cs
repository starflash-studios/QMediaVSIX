// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaPlaybackList))]
  [Guid(2138566300, 56386, 20006, 169, 141, 120, 80, 223, 142, 201, 37)]
  internal interface IMediaPlaybackList : IMediaPlaybackSource
  {
    event TypedEventHandler<MediaPlaybackList, MediaPlaybackItemFailedEventArgs> ItemFailed;

    event TypedEventHandler<MediaPlaybackList, CurrentMediaPlaybackItemChangedEventArgs> CurrentItemChanged;

    event TypedEventHandler<MediaPlaybackList, MediaPlaybackItemOpenedEventArgs> ItemOpened;

    IObservableVector<MediaPlaybackItem> Items { get; }

    bool AutoRepeatEnabled { get; set; }

    bool ShuffleEnabled { get; set; }

    MediaPlaybackItem CurrentItem { get; }

    uint CurrentItemIndex { get; }

    MediaPlaybackItem MoveNext();

    MediaPlaybackItem MovePrevious();

    MediaPlaybackItem MoveTo(uint itemIndex);
  }
}
