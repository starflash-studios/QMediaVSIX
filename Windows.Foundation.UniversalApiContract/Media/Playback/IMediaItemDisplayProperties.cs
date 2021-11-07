﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaItemDisplayProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaItemDisplayProperties))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(507255624, 28823, 17284, 162, 23, 193, 41, 29, 250, 140, 22)]
  internal interface IMediaItemDisplayProperties
  {
    MediaPlaybackType Type { get; set; }

    MusicDisplayProperties MusicProperties { get; }

    VideoDisplayProperties VideoProperties { get; }

    RandomAccessStreamReference Thumbnail { get; set; }

    void ClearAll();
  }
}