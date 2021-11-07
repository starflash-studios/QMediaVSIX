// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ITimelineStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(2835541326, 61200, 19823, 154, 64, 147, 203, 136, 149, 244, 229)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Timeline))]
  internal interface ITimelineStatics
  {
    bool AllowDependentAnimations { get; set; }

    DependencyProperty AutoReverseProperty { get; }

    DependencyProperty BeginTimeProperty { get; }

    DependencyProperty DurationProperty { get; }

    DependencyProperty SpeedRatioProperty { get; }

    DependencyProperty FillBehaviorProperty { get; }

    DependencyProperty RepeatBehaviorProperty { get; }
  }
}
