// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteFinderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [Guid(3097871631, 7268, 19514, 129, 235, 31, 124, 21, 42, 251, 187)]
  [ExclusiveTo(typeof (MapRouteFinder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapRouteFinderStatics
  {
    [RemoteAsync]
    [Overload("GetDrivingRouteAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint);

    [RemoteAsync]
    [Overload("GetDrivingRouteWithOptimizationAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization);

    [Overload("GetDrivingRouteWithOptimizationAndRestrictionsAsync")]
    [RemoteAsync]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions);

    [Overload("GetDrivingRouteWithOptimizationRestrictionsAndHeadingAsync")]
    [RemoteAsync]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions,
      double headingInDegrees);

    [Overload("GetDrivingRouteFromWaypointsAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints);

    [Overload("GetDrivingRouteFromWaypointsAndOptimizationAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization);

    [Overload("GetDrivingRouteFromWaypointsOptimizationAndRestrictionsAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions);

    [Overload("GetDrivingRouteFromWaypointsOptimizationRestrictionsAndHeadingAsync")]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions,
      double headingInDegrees);

    [RemoteAsync]
    IAsyncOperation<MapRouteFinderResult> GetWalkingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint);

    IAsyncOperation<MapRouteFinderResult> GetWalkingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints);
  }
}
