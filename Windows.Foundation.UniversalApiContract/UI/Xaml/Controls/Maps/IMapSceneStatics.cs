// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapSceneStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapScene))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(65318252, 34540, 17625, 149, 151, 251, 117, 183, 222, 186, 10)]
  internal interface IMapSceneStatics
  {
    [Overload("CreateFromBoundingBox")]
    MapScene CreateFromBoundingBox(GeoboundingBox bounds);

    [Overload("CreateFromBoundingBoxWithHeadingAndPitch")]
    MapScene CreateFromBoundingBox(
      GeoboundingBox bounds,
      double headingInDegrees,
      double pitchInDegrees);

    MapScene CreateFromCamera(MapCamera camera);

    [Overload("CreateFromLocation")]
    MapScene CreateFromLocation(Geopoint location);

    [Overload("CreateFromLocationWithHeadingAndPitch")]
    MapScene CreateFromLocation(
      Geopoint location,
      double headingInDegrees,
      double pitchInDegrees);

    [Overload("CreateFromLocationAndRadius")]
    MapScene CreateFromLocationAndRadius(Geopoint location, double radiusInMeters);

    [Overload("CreateFromLocationAndRadiusWithHeadingAndPitch")]
    MapScene CreateFromLocationAndRadius(
      Geopoint location,
      double radiusInMeters,
      double headingInDegrees,
      double pitchInDegrees);

    [Overload("CreateFromLocations")]
    MapScene CreateFromLocations(IIterable<Geopoint> locations);

    [Overload("CreateFromLocationsWithHeadingAndPitch")]
    MapScene CreateFromLocations(
      IIterable<Geopoint> locations,
      double headingInDegrees,
      double pitchInDegrees);
  }
}
