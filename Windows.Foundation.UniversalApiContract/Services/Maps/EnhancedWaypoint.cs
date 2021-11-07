// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.EnhancedWaypoint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Represents a stop, start, or intermediate waypoint that a route must pass through.</summary>
  [WebHostHidden]
  [Activatable(typeof (IEnhancedWaypointFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class EnhancedWaypoint : IEnhancedWaypoint
  {
    /// <summary>Creates an instance of the EnhancedWayPoint class.</summary>
    /// <param name="point">The coordinates of a geographic location.</param>
    /// <param name="kind">The type of waypoint.</param>
    [MethodImpl]
    public extern EnhancedWaypoint(Geopoint point, WaypointKind kind);

    /// <summary>Gets the coordinates of a geographic location.</summary>
    /// <returns>The coordinates of a geographic location.</returns>
    public extern Geopoint Point { [MethodImpl] get; }

    /// <summary>Gets the type of waypoint.</summary>
    /// <returns>The type of waypoint.</returns>
    public extern WaypointKind Kind { [MethodImpl] get; }
  }
}
