// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackList3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(3710172073, 48199, 17507, 170, 144, 193, 139, 126, 95, 253, 225)]
  [ExclusiveTo(typeof (MediaPlaybackList))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMediaPlaybackList3 : 
    IMediaPlaybackList2,
    IMediaPlaybackList,
    IMediaPlaybackSource
  {
    IReference<uint> MaxPlayedItemsToKeepOpen { get; set; }
  }
}
