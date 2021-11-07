// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaTimelineController2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MediaTimelineController))]
  [Guid(4017416760, 40562, 19961, 131, 85, 110, 144, 200, 27, 186, 221)]
  internal interface IMediaTimelineController2
  {
    IReference<TimeSpan> Duration { get; set; }

    bool IsLoopingEnabled { get; set; }

    event TypedEventHandler<MediaTimelineController, MediaTimelineControllerFailedEventArgs> Failed;

    event TypedEventHandler<MediaTimelineController, object> Ended;
  }
}
