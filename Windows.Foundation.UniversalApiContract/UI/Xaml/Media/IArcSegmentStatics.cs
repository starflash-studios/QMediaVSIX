// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IArcSegmentStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (ArcSegment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2184482670, 35433, 16900, 156, 18, 114, 7, 223, 49, 118, 67)]
  [WebHostHidden]
  internal interface IArcSegmentStatics
  {
    DependencyProperty PointProperty { get; }

    DependencyProperty SizeProperty { get; }

    DependencyProperty RotationAngleProperty { get; }

    DependencyProperty IsLargeArcProperty { get; }

    DependencyProperty SweepDirectionProperty { get; }
  }
}
