// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeopathFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geopath))]
  [Guid(666806728, 51175, 17241, 155, 155, 252, 163, 224, 94, 245, 147)]
  internal interface IGeopathFactory
  {
    Geopath Create(IIterable<BasicGeoposition> positions);

    Geopath CreateWithAltitudeReference(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeReferenceSystem);

    Geopath CreateWithAltitudeReferenceAndSpatialReference(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);
  }
}
