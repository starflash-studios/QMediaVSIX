// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IQuadraticBezierSegmentStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (QuadraticBezierSegment))]
  [Guid(1774682744, 15371, 19279, 183, 162, 240, 3, 222, 212, 27, 176)]
  internal interface IQuadraticBezierSegmentStatics
  {
    DependencyProperty Point1Property { get; }

    DependencyProperty Point2Property { get; }
  }
}
