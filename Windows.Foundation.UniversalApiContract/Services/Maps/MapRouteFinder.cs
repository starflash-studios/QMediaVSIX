// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteFinder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Gets a route.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMapRouteFinderStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMapRouteFinderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapRouteFinderStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public static class MapRouteFinder
  {
    [Overload("GetDrivingRouteFromEnhancedWaypointsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromEnhancedWaypointsAsync(
      IIterable<EnhancedWaypoint> waypoints);

    [Overload("GetDrivingRouteFromEnhancedWaypointsWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromEnhancedWaypointsAsync(
      IIterable<EnhancedWaypoint> waypoints,
      MapRouteDrivingOptions options);

    /// <summary>Gets a driving route for the specified start and end coordinates (using MapRouteDrivingOptions ).</summary>
    /// <param name="startPoint">The starting point of the driving route.</param>
    /// <param name="endPoint">The ending point of the driving route.</param>
    /// <param name="options">The advanced routing options to be applied to this route.</param>
    /// <returns>When this method completes successfully, it returns one or more driving routes contained in the MapRouteFinderResult.</returns>
    [Overload("GetDrivingRouteWithOptionsAsync")]
    [RemoteAsync]
    [DefaultOverload]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteDrivingOptions options);

    /// <summary>Gets a driving route for the specified start and end coordinates.</summary>
    /// <param name="startPoint">The starting point of the driving route.</param>
    /// <param name="endPoint">The ending point of the driving route.</param>
    /// <returns>When this method completes successfully, it returns a driving route contained in the MapRouteFinderResult.</returns>
    [RemoteAsync]
    [Overload("GetDrivingRouteAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint);

    /// <summary>Gets a driving route for the specified start and end coordinates (using optimizations).</summary>
    /// <param name="startPoint">The starting point of the driving route.</param>
    /// <param name="endPoint">The ending point of the driving route.</param>
    /// <param name="optimization">The optimizations to apply when calculating the driving route.</param>
    /// <returns>When this method completes successfully, it returns a driving route contained in the MapRouteFinderResult.</returns>
    [Overload("GetDrivingRouteWithOptimizationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization);

    /// <summary>Gets a driving route for the specified start and end coordinates (using optimizations and restrictions).</summary>
    /// <param name="startPoint">The starting point of the driving route.</param>
    /// <param name="endPoint">The ending point of the driving route.</param>
    /// <param name="optimization">The optimizations to apply when calculating the driving route.</param>
    /// <param name="restrictions">The restrictions to apply when calculating the driving route.</param>
    /// <returns>When this method completes successfully, it returns a driving route contained in the MapRouteFinderResult.</returns>
    [RemoteAsync]
    [Overload("GetDrivingRouteWithOptimizationAndRestrictionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions);

    /// <summary>Gets a driving route for the specified start and end coordinates (using optimizations, restrictions, and heading).</summary>
    /// <param name="startPoint">The starting point of the driving route.</param>
    /// <param name="endPoint">The ending point of the driving route.</param>
    /// <param name="optimization">The optimizations to apply when calculating the driving route.</param>
    /// <param name="restrictions">The restrictions to apply when calculating the driving route.</param>
    /// <param name="headingInDegrees">The preferred start direction from the current location for the driving route.</param>
    /// <returns>When this method completes successfully, it returns a driving route contained in the MapRouteFinderResult.</returns>
    [RemoteAsync]
    [Overload("GetDrivingRouteWithOptimizationRestrictionsAndHeadingAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions,
      double headingInDegrees);

    [Overload("GetDrivingRouteFromWaypointsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints);

    [Overload("GetDrivingRouteFromWaypointsAndOptimizationAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization);

    [Overload("GetDrivingRouteFromWaypointsOptimizationAndRestrictionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions);

    [Overload("GetDrivingRouteFromWaypointsOptimizationRestrictionsAndHeadingAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints,
      MapRouteOptimization optimization,
      MapRouteRestrictions restrictions,
      double headingInDegrees);

    /// <summary>Gets a walking route using the specified start and end coordinates.</summary>
    /// <param name="startPoint">The starting point of the walking route.</param>
    /// <param name="endPoint">The ending point of the walking route.</param>
    /// <returns>When this method completes successfully, it returns a walking route contained in the MapRouteFinderResult.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetWalkingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint);

    [MethodImpl]
    public static extern IAsyncOperation<MapRouteFinderResult> GetWalkingRouteFromWaypointsAsync(
      IIterable<Geopoint> wayPoints);
  }
}
