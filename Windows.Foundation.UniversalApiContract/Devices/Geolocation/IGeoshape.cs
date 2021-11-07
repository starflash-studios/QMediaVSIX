// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeoshape
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Interface to define a geographic shape.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3382485679, 50985, 17345, 143, 171, 214, 222, 201, 20, 223, 126)]
  public interface IGeoshape
  {
    /// <summary>The type of geographic shape.</summary>
    /// <returns>The type of geographic shape.</returns>
    GeoshapeType GeoshapeType { get; }

    /// <summary>The spatial reference identifier for the geographic shape, corresponding to a spatial reference system based on the specific ellipsoid used for either flat-earth mapping or round-earth mapping.</summary>
    /// <returns>The spatial reference identifier for the geographic shape, corresponding to a spatial reference system based on the specific ellipsoid used for either flat-earth mapping or round-earth mapping.</returns>
    uint SpatialReferenceId { get; }

    /// <summary>The altitude reference system of the geographic shape.</summary>
    /// <returns>The altitude reference system of the geographic shape.</returns>
    AltitudeReferenceSystem AltitudeReferenceSystem { get; }
  }
}
