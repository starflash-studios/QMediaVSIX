// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeopointFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3681258803, 30397, 20016, 138, 247, 168, 68, 220, 55, 183, 160)]
  [ExclusiveTo(typeof (Geopoint))]
  internal interface IGeopointFactory
  {
    Geopoint Create(BasicGeoposition position);

    Geopoint CreateWithAltitudeReferenceSystem(
      BasicGeoposition position,
      AltitudeReferenceSystem altitudeReferenceSystem);

    Geopoint CreateWithAltitudeReferenceSystemAndSpatialReferenceId(
      BasicGeoposition position,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);
  }
}
