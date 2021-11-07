// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geocoordinate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Contains the information for identifying a geographic location.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Geocoordinate : 
    IGeocoordinate,
    IGeocoordinateWithPositionData,
    IGeocoordinateWithPoint,
    IGeocoordinateWithPositionSourceTimestamp,
    IGeocoordinateWithRemoteSource
  {
    /// <summary>The latitude in degrees.</summary>
    /// <returns>The latitude in degrees. The valid range of values is from -90.0 to 90.0.</returns>
    public extern double Latitude { [Deprecated("Latitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Latitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The longitude in degrees.</summary>
    /// <returns>The longitude in degrees. The valid range of values is from -180.0 to 180.0.</returns>
    public extern double Longitude { [Deprecated("Longitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Longitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The altitude of the location, in meters.</summary>
    /// <returns>The altitude in meters.</returns>
    public extern IReference<double> Altitude { [Deprecated("Altitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Altitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The accuracy of the location in meters.</summary>
    /// <returns>The accuracy in meters.</returns>
    public extern double Accuracy { [MethodImpl] get; }

    /// <summary>The accuracy of the altitude, in meters.</summary>
    /// <returns>The accuracy of the altitude.</returns>
    public extern IReference<double> AltitudeAccuracy { [MethodImpl] get; }

    /// <summary>The current heading in degrees relative to true north.</summary>
    /// <returns>The current heading in degrees relative to true north.</returns>
    public extern IReference<double> Heading { [MethodImpl] get; }

    /// <summary>The speed in meters per second.</summary>
    /// <returns>The speed in meters per second.</returns>
    public extern IReference<double> Speed { [MethodImpl] get; }

    /// <summary>The system time at which the location was determined.</summary>
    /// <returns>The system time at which the location was determined.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the source used to obtain a Geocoordinate.</summary>
    /// <returns>Gets the source used to obtain a Geocoordinate.</returns>
    public extern PositionSource PositionSource { [MethodImpl] get; }

    /// <summary>Gets information about the satellites used to obtain a Geocoordinate.</summary>
    /// <returns>Gets information about the satellites used to obtain a Geocoordinate.</returns>
    public extern GeocoordinateSatelliteData SatelliteData { [MethodImpl] get; }

    /// <summary>The location of the Geocoordinate.</summary>
    /// <returns>The location of the Geocoordinate.</returns>
    public extern Geopoint Point { [MethodImpl] get; }

    /// <summary>Gets the time at which the associated Geocoordinate position was calculated.</summary>
    /// <returns>The time at which the associated Geocoordinate position was calculated.</returns>
    public extern IReference<DateTime> PositionSourceTimestamp { [MethodImpl] get; }

    public extern bool IsRemoteSource { [MethodImpl] get; }
  }
}
