// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeoboundingBoxFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GeoboundingBox))]
  [Guid(1308337545, 1041, 19132, 179, 181, 91, 188, 203, 87, 217, 140)]
  internal interface IGeoboundingBoxFactory
  {
    GeoboundingBox Create(
      BasicGeoposition northwestCorner,
      BasicGeoposition southeastCorner);

    GeoboundingBox CreateWithAltitudeReference(
      BasicGeoposition northwestCorner,
      BasicGeoposition southeastCorner,
      AltitudeReferenceSystem altitudeReferenceSystem);

    GeoboundingBox CreateWithAltitudeReferenceAndSpatialReference(
      BasicGeoposition northwestCorner,
      BasicGeoposition southeastCorner,
      AltitudeReferenceSystem altitudeReferenceSystem,
      uint spatialReferenceId);
  }
}
