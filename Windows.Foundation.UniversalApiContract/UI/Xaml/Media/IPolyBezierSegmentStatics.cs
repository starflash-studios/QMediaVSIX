// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPolyBezierSegmentStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (PolyBezierSegment))]
  [Guid(496084698, 5266, 19148, 189, 102, 164, 150, 243, 216, 41, 214)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IPolyBezierSegmentStatics
  {
    DependencyProperty PointsProperty { get; }
  }
}
