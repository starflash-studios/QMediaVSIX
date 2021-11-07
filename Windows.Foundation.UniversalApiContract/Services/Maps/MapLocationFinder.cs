// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapLocationFinder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Provides methods to convert addresses to geographic locations (geocoding) and to convert geographic locations to addresses (reverse geocoding).</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMapLocationFinderStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapLocationFinderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class MapLocationFinder
  {
    /// <summary>Converts a geopoint to a collection of addresses with the desired accuracy (reverse geocoding).</summary>
    /// <param name="queryPoint">The point for which you want to get locations.</param>
    /// <param name="accuracy">The desired accuracy for which you want to get locations.</param>
    /// <returns>When this method completes successfully, it returns a list of locations contained in the MapLocationFinderResult.</returns>
    [RemoteAsync]
    [Overload("FindLocationsAtWithAccuracyAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapLocationFinderResult> FindLocationsAtAsync(
      Geopoint queryPoint,
      MapLocationDesiredAccuracy accuracy);

    /// <summary>Converts a geographic location to a collection of addresses (reverse geocoding).</summary>
    /// <param name="queryPoint">The point for which you want to get locations.</param>
    /// <returns>When this method completes successfully, it returns a list of locations contained in the MapLocationFinderResult.</returns>
    [Overload("FindLocationsAtAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapLocationFinderResult> FindLocationsAtAsync(
      Geopoint queryPoint);

    /// <summary>Converts the specified address to a collection of geographic locations (geocoding), using the specified reference point as a query hint.</summary>
    /// <param name="searchText">The query for which you want to get locations.</param>
    /// <param name="referencePoint">A reference point that provides a query hint.</param>
    /// <returns>When this method completes successfully, it returns a list of locations contained in the MapLocationFinderResult.</returns>
    [Overload("FindLocationsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapLocationFinderResult> FindLocationsAsync(
      string searchText,
      Geopoint referencePoint);

    /// <summary>Converts the specified address to a collection of geographic locations (geocoding), using the specified reference point as a query hint. The list contains no more than the specified maximum number of results.</summary>
    /// <param name="searchText">The query for which you want to get locations.</param>
    /// <param name="referencePoint">A reference point that provides a query hint.</param>
    /// <param name="maxCount">The maximum number of locations to get.</param>
    /// <returns>When this method completes successfully, it returns a list of locations contained in the MapLocationFinderResult.</returns>
    [RemoteAsync]
    [Overload("FindLocationsWithMaxCountAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapLocationFinderResult> FindLocationsAsync(
      string searchText,
      Geopoint referencePoint,
      uint maxCount);
  }
}
