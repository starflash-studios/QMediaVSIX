// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geocircle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Describes a geographic circle with a center point and a radius.</summary>
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IGeocircleFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Geocircle : IGeocircle, IGeoshape
  {
    /// <summary>Create a geographic circle object for the given position and radius.</summary>
    /// <param name="position">The geographic position of the new circle.</param>
    /// <param name="radius">The radius of the new circle, in meters.</param>
    [MethodImpl]
    public extern Geocircle(BasicGeoposition position, double radius);

    /// <summary>Create a geographic circle object for the given position, radius and altitude reference system.</summary>
    /// <param name="position">The geographic position of the new circle.</param>
    /// <param name="radius">The radius of the new circle, in meters.</param>
    /// <param name="altitudeReferenceSystem">The altitude reference system of the new circle.</param>
    [MethodImpl]
    public extern Geocircle(
      BasicGeoposition position,
      double radius,
      AltitudeReferenceSystem altitudeReferenceSystem);

    /// <summary>Create a geographic circle object for the given position, radius, altitude reference system, and spatial reference id.</summary>
    /// <param name="position">The geographic position of the new circle.</param>
    /// <param name="radius">The radius of the new circle, in meters.</param>
    /// <param name="altitudeReferenceSystem">The altitude reference system of the new circle.</param>
    /// <param name="spatialReferenceId">The spatial reference Id of the new circle.</param>
    [MethodImpl]
    public extern Geocircle(
      BasicGeoposition position,
      double radius,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);

    /// <summary>The center point of a geographic circle.</summary>
    /// <returns>The center point of a geographic circle.</returns>
    public extern BasicGeoposition Center { [MethodImpl] get; }

    /// <summary>The radius of a geographic circle in meters.</summary>
    /// <returns>The radius of a geographic circle.</returns>
    public extern double Radius { [MethodImpl] get; }

    /// <summary>The type of geographic shape.</summary>
    /// <returns>The type of geographic shape.</returns>
    public extern GeoshapeType GeoshapeType { [MethodImpl] get; }

    /// <summary>The spatial reference identifier for the geographic circle, corresponding to a spatial reference system based on the specific ellipsoid used for either flat-earth mapping or round-earth mapping.</summary>
    /// <returns>The spatial reference identifier for the geographic circle, corresponding to a spatial reference system based on the specific ellipsoid used for either flat-earth mapping or round-earth mapping.</returns>
    public extern uint SpatialReferenceId { [MethodImpl] get; }

    /// <summary>The altitude reference system of the geographic circle.</summary>
    /// <returns>The altitude reference system of the geographic circle.</returns>
    public extern AltitudeReferenceSystem AltitudeReferenceSystem { [MethodImpl] get; }
  }
}
