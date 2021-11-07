// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteDrivingOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(1746220621, 50908, 18071, 164, 82, 177, 143, 143, 11, 103, 161)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapRouteDrivingOptions))]
  internal interface IMapRouteDrivingOptions
  {
    uint MaxAlternateRouteCount { get; set; }

    IReference<double> InitialHeading { get; set; }

    MapRouteOptimization RouteOptimization { get; set; }

    MapRouteRestrictions RouteRestrictions { get; set; }
  }
}
