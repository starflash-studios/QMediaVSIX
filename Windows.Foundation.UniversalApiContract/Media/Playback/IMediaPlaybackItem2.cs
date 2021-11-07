// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackItem2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(3629764977, 55279, 19329, 172, 31, 244, 4, 147, 203, 176, 145)]
  [ExclusiveTo(typeof (MediaPlaybackItem))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlaybackItem2 : IMediaPlaybackItem, IMediaPlaybackSource
  {
    MediaBreakSchedule BreakSchedule { get; }

    TimeSpan StartTime { get; }

    IReference<TimeSpan> DurationLimit { get; }

    bool CanSkip { get; set; }

    MediaItemDisplayProperties GetDisplayProperties();

    void ApplyDisplayProperties(MediaItemDisplayProperties value);
  }
}
