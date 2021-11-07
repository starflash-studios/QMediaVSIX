// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(3447685407, 30714, 18475, 157, 52, 113, 211, 29, 70, 92, 72)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapTileSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapTileSourceFactory
  {
    MapTileSource CreateInstance(object baseInterface, out object innerInterface);

    MapTileSource CreateInstanceWithDataSource(
      MapTileDataSource dataSource,
      object baseInterface,
      out object innerInterface);

    MapTileSource CreateInstanceWithDataSourceAndZoomRange(
      MapTileDataSource dataSource,
      MapZoomLevelRange zoomLevelRange,
      object baseInterface,
      out object innerInterface);

    MapTileSource CreateInstanceWithDataSourceZoomRangeAndBounds(
      MapTileDataSource dataSource,
      MapZoomLevelRange zoomLevelRange,
      GeoboundingBox bounds,
      object baseInterface,
      out object innerInterface);

    MapTileSource CreateInstanceWithDataSourceZoomRangeBoundsAndTileSize(
      MapTileDataSource dataSource,
      MapZoomLevelRange zoomLevelRange,
      GeoboundingBox bounds,
      int tileSizeInPixels,
      object baseInterface,
      out object innerInterface);
  }
}
