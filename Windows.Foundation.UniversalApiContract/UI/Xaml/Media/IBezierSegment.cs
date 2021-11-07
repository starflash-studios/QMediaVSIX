// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IBezierSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(2940975598, 35204, 18871, 129, 223, 63, 53, 153, 75, 149, 235)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BezierSegment))]
  [WebHostHidden]
  internal interface IBezierSegment
  {
    Point Point1 { get; set; }

    Point Point2 { get; set; }

    Point Point3 { get; set; }
  }
}
