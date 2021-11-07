// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocoordinateWithPositionData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (Geocoordinate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2514891966, 56278, 16556, 184, 242, 166, 92, 3, 64, 217, 166)]
  internal interface IGeocoordinateWithPositionData : IGeocoordinate
  {
    PositionSource PositionSource { get; }

    GeocoordinateSatelliteData SatelliteData { get; }
  }
}
