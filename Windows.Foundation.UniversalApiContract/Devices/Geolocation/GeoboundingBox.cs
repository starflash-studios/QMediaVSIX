// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.GeoboundingBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Represents a rectangle that defines a geographic area.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IGeoboundingBoxFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGeoboundingBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class GeoboundingBox : IGeoboundingBox, IGeoshape
  {
    /// <summary>Initializes a new instance of the GeoboundingBox class that has the specified corners.</summary>
    /// <param name="northwestCorner">The northwest corner to use for the new GeoboundingBox. For more info, see the NorthwestCorner property.</param>
    /// <param name="southeastCorner">The southeast corner to use for the new GeoboundingBox. For more info, see the SoutheastCorner property.</param>
    [MethodImpl]
    public extern GeoboundingBox(BasicGeoposition northwestCorner, BasicGeoposition southeastCorner);

    /// <summary>Initializes a new instance of the GeoboundingBox class that has the specified corners and uses the specified altitude reference system.</summary>
    /// <param name="northwestCorner">The northwest corner to use for the new GeoboundingBox. For more info, see the NorthwestCorner property.</param>
    /// <param name="southeastCorner">The southeast corner to use for the new GeoboundingBox. For more info, see the SoutheastCorner property.</param>
    /// <param name="altitudeReferenceSystem">The altitude reference system to use for the new GeoboundingBox. For more info, see the AltitudeReferenceSystem property.</param>
    [MethodImpl]
    public extern GeoboundingBox(
      BasicGeoposition northwestCorner,
      BasicGeoposition southeastCorner,
      AltitudeReferenceSystem altitudeReferenceSystem);

    /// <summary>Initializes a new instance of the GeoboundingBox class that has the specified corners and uses the specified altitude reference system and spatial reference ID (SRID).</summary>
    /// <param name="northwestCorner">The northwest corner to use for the new GeoboundingBox. For more info, see the NorthwestCorner property.</param>
    /// <param name="southeastCorner">The southeast corner to use for the new GeoboundingBox. For more info, see the SoutheastCorner property.</param>
    /// <param name="altitudeReferenceSystem">The altitude reference system to use for the new GeoboundingBox. For more info, see the AltitudeReferenceSystem property.</param>
    /// <param name="spatialReferenceId">The spatial reference ID (SRID) to use for the new GeoboundingBox. For more info, see the SpatialReferenceId property.</param>
    [MethodImpl]
    public extern GeoboundingBox(
      BasicGeoposition northwestCorner,
      BasicGeoposition southeastCorner,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);

    /// <summary>Gets the northwest corner of the GeoboundingBox.</summary>
    /// <returns>The northwest corner of the GeoboundingBox.</returns>
    public extern BasicGeoposition NorthwestCorner { [MethodImpl] get; }

    /// <summary>Gets the southeast corner of the GeoboundingBox.</summary>
    /// <returns>The southeast corner of the GeoboundingBox.</returns>
    public extern BasicGeoposition SoutheastCorner { [MethodImpl] get; }

    /// <summary>Gets the center of the GeoboundingBox.</summary>
    /// <returns>The center of the GeoboundingBox.</returns>
    public extern BasicGeoposition Center { [MethodImpl] get; }

    /// <summary>Gets the altitude of the lowest corner of the GeoboundingBox.</summary>
    /// <returns>The altitude of the lowest corner of the GeoboundingBox.</returns>
    public extern double MinAltitude { [MethodImpl] get; }

    /// <summary>Gets the altitude of the highest corner of the GeoboundingBox.</summary>
    /// <returns>The altitude of the highest corner of the GeoboundingBox.</returns>
    public extern double MaxAltitude { [MethodImpl] get; }

    /// <summary>Gets the type of geographic shape represented by the GeoboundingBox.</summary>
    /// <returns>The type of geographic shape represented by the GeoboundingBox.</returns>
    public extern GeoshapeType GeoshapeType { [MethodImpl] get; }

    /// <summary>Gets the spatial reference ID (SRID) used by the GeoboundingBox.</summary>
    /// <returns>The spatial reference ID (SRID) used by the GeoboundingBox.</returns>
    public extern uint SpatialReferenceId { [MethodImpl] get; }

    /// <summary>Gets the altitude reference system used by the GeoboundingBox.</summary>
    /// <returns>The altitude reference system used by the GeoboundingBox.</returns>
    public extern AltitudeReferenceSystem AltitudeReferenceSystem { [MethodImpl] get; }

    [Overload("TryCompute")]
    [MethodImpl]
    public static extern GeoboundingBox TryCompute(
      IIterable<BasicGeoposition> positions);

    [Overload("TryComputeWithAltitudeReference")]
    [MethodImpl]
    public static extern GeoboundingBox TryCompute(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeRefSystem);

    [Overload("TryComputeWithAltitudeReferenceAndSpatialReference")]
    [MethodImpl]
    public static extern GeoboundingBox TryCompute(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeRefSystem,
      uint spatialReferenceId);
  }
}
