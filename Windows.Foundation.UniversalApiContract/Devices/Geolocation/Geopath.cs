// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geopath
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Represents an ordered series of geographic points.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IGeopathFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Geopath : IGeopath, IGeoshape
  {
    [MethodImpl]
    public extern Geopath(IIterable<BasicGeoposition> positions);

    [MethodImpl]
    public extern Geopath(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeReferenceSystem);

    [MethodImpl]
    public extern Geopath(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);

    /// <summary>Gets the collection of geographic points that define the Geopath.</summary>
    /// <returns>The collection of geographic points that define the Geopath.</returns>
    public extern IVectorView<BasicGeoposition> Positions { [MethodImpl] get; }

    /// <summary>Gets the type of geographic shape represented by the Geopath.</summary>
    /// <returns>The type of geographic shape represented by the Geopath.</returns>
    public extern GeoshapeType GeoshapeType { [MethodImpl] get; }

    /// <summary>Gets the spatial reference ID (SRID) used by the Geopath.</summary>
    /// <returns>The spatial reference ID (SRID) used by the Geopath.</returns>
    public extern uint SpatialReferenceId { [MethodImpl] get; }

    /// <summary>Gets the altitude reference system used by the Geopath.</summary>
    /// <returns>The altitude reference system used by the Geopath.</returns>
    public extern AltitudeReferenceSystem AltitudeReferenceSystem { [MethodImpl] get; }
  }
}
