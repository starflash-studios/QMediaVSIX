// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  [Guid(1260120052, 17221, 16444, 138, 103, 245, 222, 145, 223, 76, 134)]
  internal interface IMediaPlaybackItemStatics
  {
    MediaPlaybackItem FindFromMediaSource(MediaSource source);
  }
}
