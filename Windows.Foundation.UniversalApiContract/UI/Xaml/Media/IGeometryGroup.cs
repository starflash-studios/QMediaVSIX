// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGeometryGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(1428314721, 34423, 19596, 142, 70, 238, 61, 195, 85, 17, 75)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GeometryGroup))]
  internal interface IGeometryGroup
  {
    FillRule FillRule { get; set; }

    GeometryCollection Children { get; set; }
  }
}
