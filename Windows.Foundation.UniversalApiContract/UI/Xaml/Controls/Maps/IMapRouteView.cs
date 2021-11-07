// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapRouteView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(1947119301, 47820, 16865, 166, 126, 221, 101, 19, 131, 32, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapRouteView))]
  [WebHostHidden]
  internal interface IMapRouteView
  {
    Color RouteColor { get; set; }

    Color OutlineColor { get; set; }

    MapRoute Route { get; }
  }
}
