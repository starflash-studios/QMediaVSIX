// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControl2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(3791479885, 38636, 16485, 176, 240, 117, 40, 29, 163, 101, 77)]
  [ExclusiveTo(typeof (MapControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMapControl2
  {
    bool BusinessLandmarksVisible { get; set; }

    bool TransitFeaturesVisible { get; set; }

    MapPanInteractionMode PanInteractionMode { get; set; }

    MapInteractionMode RotateInteractionMode { get; set; }

    MapInteractionMode TiltInteractionMode { get; set; }

    MapInteractionMode ZoomInteractionMode { get; set; }

    bool Is3DSupported { get; }

    bool IsStreetsideSupported { get; }

    MapScene Scene { get; set; }

    MapCamera ActualCamera { get; }

    MapCamera TargetCamera { get; }

    MapCustomExperience CustomExperience { get; set; }

    event TypedEventHandler<MapControl, MapElementClickEventArgs> MapElementClick;

    event TypedEventHandler<MapControl, MapElementPointerEnteredEventArgs> MapElementPointerEntered;

    event TypedEventHandler<MapControl, MapElementPointerExitedEventArgs> MapElementPointerExited;

    event TypedEventHandler<MapControl, MapActualCameraChangedEventArgs> ActualCameraChanged;

    event TypedEventHandler<MapControl, MapActualCameraChangingEventArgs> ActualCameraChanging;

    event TypedEventHandler<MapControl, MapTargetCameraChangedEventArgs> TargetCameraChanged;

    event TypedEventHandler<MapControl, MapCustomExperienceChangedEventArgs> CustomExperienceChanged;

    void StartContinuousRotate(double rateInDegreesPerSecond);

    void StopContinuousRotate();

    void StartContinuousTilt(double rateInDegreesPerSecond);

    void StopContinuousTilt();

    void StartContinuousZoom(double rateOfChangePerSecond);

    void StopContinuousZoom();

    [RemoteAsync]
    IAsyncOperation<bool> TryRotateAsync(double degrees);

    [RemoteAsync]
    IAsyncOperation<bool> TryRotateToAsync(double angleInDegrees);

    [RemoteAsync]
    IAsyncOperation<bool> TryTiltAsync(double degrees);

    [RemoteAsync]
    IAsyncOperation<bool> TryTiltToAsync(double angleInDegrees);

    [RemoteAsync]
    IAsyncOperation<bool> TryZoomInAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryZoomOutAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryZoomToAsync(double zoomLevel);

    [RemoteAsync]
    [Overload("TrySetSceneAsync")]
    IAsyncOperation<bool> TrySetSceneAsync(MapScene scene);

    [Overload("TrySetSceneWithAnimationAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TrySetSceneAsync(
      MapScene scene,
      MapAnimationKind animationKind);
  }
}
