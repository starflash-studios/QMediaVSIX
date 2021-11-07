// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.GeocoordinateSatelliteData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Provides additional information about a Geocoordinate. This information is only applicable to position estimates obtained using satellite signals.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GeocoordinateSatelliteData : 
    IGeocoordinateSatelliteData,
    IGeocoordinateSatelliteData2
  {
    /// <summary>Gets the position dilution of precision (PDOP) of a Geocoordinate.</summary>
    /// <returns>The position dilution of precision (PDOP).</returns>
    public extern IReference<double> PositionDilutionOfPrecision { [MethodImpl] get; }

    /// <summary>Gets the horizontal dilution of precision (HDOP) of a Geocoordinate.</summary>
    /// <returns>The horizontal dilution of precision (HDOP).</returns>
    public extern IReference<double> HorizontalDilutionOfPrecision { [MethodImpl] get; }

    /// <summary>Gets the vertical dilution of precision (VDOP) of a Geocoordinate.</summary>
    /// <returns>The vertical dilution of precision (VDOP).</returns>
    public extern IReference<double> VerticalDilutionOfPrecision { [MethodImpl] get; }

    public extern IReference<double> GeometricDilutionOfPrecision { [MethodImpl] get; }

    public extern IReference<double> TimeDilutionOfPrecision { [MethodImpl] get; }
  }
}
