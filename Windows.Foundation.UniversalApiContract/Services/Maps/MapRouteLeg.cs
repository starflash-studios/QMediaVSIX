// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteLeg
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
  /// <summary>Represents the set of actions (maneuvers) required to travel between two waypoints along a route.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MapRouteLeg : IMapRouteLeg, IMapRouteLeg2
  {
    /// <summary>Gets the bounding box that contains the route leg.</summary>
    /// <returns>The bounding box that contains the route leg.</returns>
    public extern GeoboundingBox BoundingBox { [MethodImpl] get; }

    /// <summary>Gets the path of the route leg.</summary>
    /// <returns>The path of the route leg.</returns>
    public extern Geopath Path { [MethodImpl] get; }

    /// <summary>Gets the length of the route leg in meters.</summary>
    /// <returns>The length of the route leg in meters.</returns>
    public extern double LengthInMeters { [MethodImpl] get; }

    /// <summary>Gets the estimated time required to traverse the route leg.</summary>
    /// <returns>The estimated time required to traverse the route leg.</returns>
    public extern TimeSpan EstimatedDuration { [MethodImpl] get; }

    /// <summary>Gets the list of maneuvers associated with the route leg.</summary>
    /// <returns>The list of maneuvers associated with the route leg. This property returns a collection of MapRouteManeuver objects.</returns>
    public extern IVectorView<MapRouteManeuver> Maneuvers { [MethodImpl] get; }

    /// <summary>Gets the estimated time required to traverse the route without traffic.</summary>
    /// <returns>The estimated time required to traverse the route without traffic.</returns>
    public extern TimeSpan DurationWithoutTraffic { [MethodImpl] get; }

    /// <summary>Gets the level of traffic congestion along a map route leg.</summary>
    /// <returns>The level of traffic congestion along a map route leg.</returns>
    public extern TrafficCongestion TrafficCongestion { [MethodImpl] get; }
  }
}
