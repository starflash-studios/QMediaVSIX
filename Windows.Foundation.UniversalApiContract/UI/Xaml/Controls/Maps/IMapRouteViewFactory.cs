// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapRouteViewFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapRouteView))]
  [Guid(4035161567, 102, 17960, 130, 254, 234, 120, 194, 60, 236, 30)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMapRouteViewFactory
  {
    MapRouteView CreateInstanceWithMapRoute(
      MapRoute route,
      object baseInterface,
      out object innerInterface);
  }
}
