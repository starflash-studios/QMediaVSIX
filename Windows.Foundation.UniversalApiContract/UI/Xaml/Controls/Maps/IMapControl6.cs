// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControl6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(2967112098, 4161, 19434, 184, 138, 18, 172, 154, 130, 224, 226)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapControl))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMapControl6
  {
    IVector<MapLayer> Layers { get; set; }

    [Overload("TryGetLocationFromOffset")]
    bool TryGetLocationFromOffset(Point offset, out Geopoint location);

    [Overload("TryGetLocationFromOffsetWithReferenceSystem")]
    bool TryGetLocationFromOffset(
      Point offset,
      AltitudeReferenceSystem desiredReferenceSystem,
      out Geopoint location);
  }
}
