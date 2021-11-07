// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  [Guid(1899232481, 5993, 20473, 167, 193, 56, 210, 196, 212, 35, 96)]
  internal interface IMediaPlaybackItemFactory
  {
    MediaPlaybackItem Create(MediaSource source);
  }
}
