// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IPolyline
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  [ExclusiveTo(typeof (Polyline))]
  [Guid(2447139576, 17075, 18419, 132, 118, 197, 81, 36, 167, 196, 198)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPolyline
  {
    FillRule FillRule { get; set; }

    PointCollection Points { get; set; }
  }
}
