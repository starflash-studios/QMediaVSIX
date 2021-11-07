// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakSchedule
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2711246867, 39094, 16856, 131, 218, 249, 113, 210, 43, 123, 186)]
  [ExclusiveTo(typeof (MediaBreakSchedule))]
  internal interface IMediaBreakSchedule
  {
    event TypedEventHandler<MediaBreakSchedule, object> ScheduleChanged;

    void InsertMidrollBreak(MediaBreak mediaBreak);

    void RemoveMidrollBreak(MediaBreak mediaBreak);

    IVectorView<MediaBreak> MidrollBreaks { get; }

    MediaBreak PrerollBreak { set; get; }

    MediaBreak PostrollBreak { set; get; }

    MediaPlaybackItem PlaybackItem { get; }
  }
}
