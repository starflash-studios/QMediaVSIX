// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IPolygonStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [ExclusiveTo(typeof (Polygon))]
  [WebHostHidden]
  [Guid(908757675, 54371, 17254, 158, 26, 190, 186, 114, 129, 15, 183)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPolygonStatics
  {
    DependencyProperty FillRuleProperty { get; }

    DependencyProperty PointsProperty { get; }
  }
}
