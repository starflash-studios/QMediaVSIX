// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItemFactory2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3615285050, 47431, 18802, 179, 93, 173, 251, 147, 26, 113, 230)]
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  internal interface IMediaPlaybackItemFactory2 : IMediaPlaybackItemFactory
  {
    MediaPlaybackItem CreateWithStartTime(MediaSource source, TimeSpan startTime);

    MediaPlaybackItem CreateWithStartTimeAndDurationLimit(
      MediaSource source,
      TimeSpan startTime,
      TimeSpan durationLimit);
  }
}
