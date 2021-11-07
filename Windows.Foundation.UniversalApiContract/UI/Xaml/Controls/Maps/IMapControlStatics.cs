// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControlStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(3267762069, 8519, 20234, 148, 42, 84, 147, 168, 93, 232, 7)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapControl))]
  internal interface IMapControlStatics
  {
    DependencyProperty CenterProperty { get; }

    DependencyProperty ChildrenProperty { get; }

    DependencyProperty ColorSchemeProperty { get; }

    DependencyProperty DesiredPitchProperty { get; }

    DependencyProperty HeadingProperty { get; }

    DependencyProperty LandmarksVisibleProperty { get; }

    DependencyProperty LoadingStatusProperty { get; }

    DependencyProperty MapServiceTokenProperty { get; }

    DependencyProperty PedestrianFeaturesVisibleProperty { get; }

    DependencyProperty PitchProperty { get; }

    DependencyProperty StyleProperty { get; }

    DependencyProperty TrafficFlowVisibleProperty { get; }

    DependencyProperty TransformOriginProperty { get; }

    DependencyProperty WatermarkModeProperty { get; }

    DependencyProperty ZoomLevelProperty { get; }

    DependencyProperty MapElementsProperty { get; }

    DependencyProperty RoutesProperty { get; }

    DependencyProperty TileSourcesProperty { get; }

    DependencyProperty LocationProperty { get; }

    Geopoint GetLocation(DependencyObject element);

    void SetLocation(DependencyObject element, Geopoint value);

    DependencyProperty NormalizedAnchorPointProperty { get; }

    Point GetNormalizedAnchorPoint(DependencyObject element);

    void SetNormalizedAnchorPoint(DependencyObject element, Point value);
  }
}
