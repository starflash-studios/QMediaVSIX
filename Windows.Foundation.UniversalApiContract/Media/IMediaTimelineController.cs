// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaTimelineController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (MediaTimelineController))]
  [Guid(2396217843, 2936, 17248, 191, 113, 12, 132, 25, 153, 234, 27)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaTimelineController
  {
    void Start();

    void Resume();

    void Pause();

    TimeSpan Position { get; set; }

    double ClockRate { get; set; }

    MediaTimelineControllerState State { get; }

    event TypedEventHandler<MediaTimelineController, object> PositionChanged;

    event TypedEventHandler<MediaTimelineController, object> StateChanged;
  }
}
