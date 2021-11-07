// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRoute
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
  /// <summary>Represents a path to be traveled between two or more waypoints.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapRoute : IMapRoute, IMapRoute2, IMapRoute3, IMapRoute4
  {
    /// <summary>Gets the bounding box that contains the route.</summary>
    /// <returns>The bounding box that contains the route.</returns>
    public extern GeoboundingBox BoundingBox { [MethodImpl] get; }

    /// <summary>Gets the length of the route in meters.</summary>
    /// <returns>The length of the route in meters.</returns>
    public extern double LengthInMeters { [MethodImpl] get; }

    /// <summary>Gets the estimated time required to traverse the route.</summary>
    /// <returns>The estimated time required to traverse the route.</returns>
    public extern TimeSpan EstimatedDuration { [MethodImpl] get; }

    /// <summary>Gets the path of the route.</summary>
    /// <returns>The path of the route.</returns>
    public extern Geopath Path { [MethodImpl] get; }

    /// <summary>Gets the list of legs associated with the route.</summary>
    /// <returns>The list of legs associated with the route. This property returns a collection of MapRouteLeg objects.</returns>
    public extern IVectorView<MapRouteLeg> Legs { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the MapRoute is based on traffic.</summary>
    /// <returns>**true** if the MapRoute is based on traffic; otherwise, **false**.</returns>
    public extern bool IsTrafficBased { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if any restrictions have been violated by the route.</summary>
    /// <returns>The MapRouteRestrictions that have been violated by the route.</returns>
    public extern MapRouteRestrictions ViolatedRestrictions { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the route has been modified from the "best" route to avoid blocked roads.</summary>
    /// <returns>**true** if the route has been modified to avoid blocked roads; otherwise, **false**.</returns>
    public extern bool HasBlockedRoads { [MethodImpl] get; }

    /// <summary>Gets the estimated time required to traverse the route without traffic.</summary>
    /// <returns>The estimated time required to traverse the route without traffic.</returns>
    public extern TimeSpan DurationWithoutTraffic { [MethodImpl] get; }

    /// <summary>Gets the level of traffic congestion along a map route.</summary>
    /// <returns>The level of traffic congestion along a map route.</returns>
    public extern TrafficCongestion TrafficCongestion { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the MapRoute is based on scenic roads.</summary>
    /// <returns>**true** if the MapRoute is based on scenic roads; otherwise, **false**.</returns>
    public extern bool IsScenic { [MethodImpl] get; }
  }
}
