// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteFinderStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4127818036, 22803, 4582, 139, 119, 134, 243, 12, 168, 147, 211)]
  [ExclusiveTo(typeof (MapRouteFinder))]
  internal interface IMapRouteFinderStatics3
  {
    [Overload("GetDrivingRouteFromEnhancedWaypointsAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromEnhancedWaypointsAsync(
      IIterable<EnhancedWaypoint> waypoints);

    [Overload("GetDrivingRouteFromEnhancedWaypointsWithOptionsAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromEnhancedWaypointsAsync(
      IIterable<EnhancedWaypoint> waypoints,
      MapRouteDrivingOptions options);
  }
}
