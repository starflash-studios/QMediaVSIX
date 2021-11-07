// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ITimeline
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Timeline))]
  [WebHostHidden]
  [Guid(197420508, 48717, 19725, 149, 73, 34, 8, 183, 21, 244, 13)]
  internal interface ITimeline
  {
    bool AutoReverse { get; set; }

    IReference<TimeSpan> BeginTime { get; set; }

    Duration Duration { get; set; }

    double SpeedRatio { get; set; }

    FillBehavior FillBehavior { get; set; }

    RepeatBehavior RepeatBehavior { get; set; }

    event EventHandler<object> Completed;
  }
}
