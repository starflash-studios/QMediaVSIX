// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapTileSource))]
  [Guid(2292674126, 12255, 17767, 146, 85, 17, 0, 81, 156, 141, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMapTileSource
  {
    MapTileDataSource DataSource { get; set; }

    MapTileLayer Layer { get; set; }

    MapZoomLevelRange ZoomLevelRange { get; set; }

    GeoboundingBox Bounds { get; set; }

    bool AllowOverstretch { get; set; }

    bool IsFadingEnabled { get; set; }

    bool IsTransparencyEnabled { get; set; }

    bool IsRetryEnabled { get; set; }

    int ZIndex { get; set; }

    int TilePixelSize { get; set; }

    bool Visible { get; set; }
  }
}
