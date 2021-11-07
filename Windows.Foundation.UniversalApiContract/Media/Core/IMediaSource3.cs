// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSource3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [Guid(3047099803, 19310, 16877, 187, 180, 124, 117, 9, 169, 148, 173)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (MediaSource))]
  internal interface IMediaSource3 : IMediaSource2, IMediaPlaybackSource, IClosable
  {
    event TypedEventHandler<MediaSource, MediaSourceStateChangedEventArgs> StateChanged;

    MediaSourceState State { get; }

    void Reset();
  }
}
