// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geopoint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Describes a geographic point.</summary>
  [Activatable(typeof (IGeopointFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Geopoint : IGeopoint, IGeoshape
  {
    /// <summary>Create a geographic point object for the given position.</summary>
    /// <param name="position">Create a geographic point object for the given position.</param>
    [MethodImpl]
    public extern Geopoint(BasicGeoposition position);

    /// <summary>Create a geographic point object for the given position and altitude reference system.</summary>
    /// <param name="position">Create a geographic point object for the given position.</param>
    /// <param name="altitudeReferenceSystem">The altitude reference system of the new point.</param>
    [MethodImpl]
    public extern Geopoint(
      BasicGeoposition position,
      AltitudeReferenceSystem altitudeReferenceSystem);

    /// <summary>Create a geographic point object for the given position, altitude reference system, and spatial reference Id.</summary>
    /// <param name="position">Create a geographic point object for the given position.</param>
    /// <param name="altitudeReferenceSystem">The altitude reference system of the new point.</param>
    /// <param name="spatialReferenceId">The spatial reference Id of the new point.</param>
    [MethodImpl]
    public extern Geopoint(
      BasicGeoposition position,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);

    /// <summary>The position of a geographic point.</summary>
    /// <returns>The position of a geographic point.</returns>
    public extern BasicGeoposition Position { [MethodImpl] get; }

    /// <summary>The type of geographic shape.</summary>
    /// <returns>The type of geographic shape.</returns>
    public extern GeoshapeType GeoshapeType { [MethodImpl] get; }

    /// <summary>The spatial reference identifier for the geographic point, corresponding to a spatial reference system based on the specific ellipsoid used for either flat-earth mapping or round-earth mapping.</summary>
    /// <returns>The spatial reference identifier for the geographic point, corresponding to a spatial reference system based on the specific ellipsoid used for either flat-earth mapping or round-earth mapping.</returns>
    public extern uint SpatialReferenceId { [MethodImpl] get; }

    /// <summary>The altitude reference system of the geographic point. GeoPoint will default to a value of unspecified when constructed without an altitude reference system. The behavior of an unspecified altitude reference system will depend on the API. A MapIcon will treat an unspecified reference system as Surface with an altitude value of 0 and the supplied value for altitude will be ignored.</summary>
    /// <returns>The altitude reference system of the geographic point.</returns>
    public extern AltitudeReferenceSystem AltitudeReferenceSystem { [MethodImpl] get; }
  }
}
