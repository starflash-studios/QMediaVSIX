// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapTileSource))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2482817340, 28725, 17923, 153, 177, 230, 89, 146, 27, 96, 147)]
  internal interface IMapTileSourceStatics
  {
    DependencyProperty DataSourceProperty { get; }

    DependencyProperty LayerProperty { get; }

    DependencyProperty ZoomLevelRangeProperty { get; }

    DependencyProperty BoundsProperty { get; }

    DependencyProperty AllowOverstretchProperty { get; }

    DependencyProperty IsFadingEnabledProperty { get; }

    DependencyProperty IsTransparencyEnabledProperty { get; }

    DependencyProperty IsRetryEnabledProperty { get; }

    DependencyProperty ZIndexProperty { get; }

    DependencyProperty TilePixelSizeProperty { get; }

    DependencyProperty VisibleProperty { get; }
  }
}
