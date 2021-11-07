// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IBezierSegmentStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Guid(3223878572, 5136, 17712, 132, 82, 28, 157, 10, 209, 243, 65)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BezierSegment))]
  internal interface IBezierSegmentStatics
  {
    DependencyProperty Point1Property { get; }

    DependencyProperty Point2Property { get; }

    DependencyProperty Point3Property { get; }
  }
}
