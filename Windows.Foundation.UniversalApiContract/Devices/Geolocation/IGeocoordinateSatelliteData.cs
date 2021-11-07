// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocoordinateSatelliteData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (GeocoordinateSatelliteData))]
  [Guid(3274339545, 9736, 18252, 145, 44, 6, 221, 73, 15, 74, 247)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeocoordinateSatelliteData
  {
    IReference<double> PositionDilutionOfPrecision { get; }

    IReference<double> HorizontalDilutionOfPrecision { get; }

    IReference<double> VerticalDilutionOfPrecision { get; }
  }
}
