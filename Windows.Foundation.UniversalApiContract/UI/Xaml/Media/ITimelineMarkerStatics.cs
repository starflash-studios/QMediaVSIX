// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITimelineMarkerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(3299799238, 5795, 18507, 135, 245, 101, 40, 184, 240, 74, 71)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TimelineMarker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimelineMarkerStatics
  {
    DependencyProperty TimeProperty { get; }

    DependencyProperty TypeProperty { get; }

    DependencyProperty TextProperty { get; }
  }
}
