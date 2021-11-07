// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControl5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ExclusiveTo(typeof (MapControl))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3717926909, 30755, 18082, 130, 201, 101, 221, 172, 79, 54, 95)]
  internal interface IMapControl5
  {
    MapProjection MapProjection { get; set; }

    MapStyleSheet StyleSheet { get; set; }

    Thickness ViewPadding { get; set; }

    event TypedEventHandler<MapControl, MapContextRequestedEventArgs> MapContextRequested;

    [Overload("FindMapElementsAtOffsetWithRadius")]
    IVectorView<MapElement> FindMapElementsAtOffset(
      Point offset,
      double radius);

    [Overload("GetLocationFromOffsetWithReferenceSystem")]
    void GetLocationFromOffset(
      Point offset,
      AltitudeReferenceSystem desiredReferenceSystem,
      out Geopoint location);

    void StartContinuousPan(double horizontalPixelsPerSecond, double verticalPixelsPerSecond);

    void StopContinuousPan();

    [RemoteAsync]
    IAsyncOperation<bool> TryPanAsync(double horizontalPixels, double verticalPixels);

    [RemoteAsync]
    IAsyncOperation<bool> TryPanToAsync(Geopoint location);
  }
}
