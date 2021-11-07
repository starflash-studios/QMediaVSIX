// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IPolygon
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3816119321, 11853, 19404, 141, 52, 134, 135, 25, 87, 250, 1)]
  [ExclusiveTo(typeof (Polygon))]
  internal interface IPolygon
  {
    FillRule FillRule { get; set; }

    PointCollection Points { get; set; }
  }
}
